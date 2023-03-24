using System;
using System.Globalization;
using z4.Enums;
using z4.Model;
using Bogus;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

using System.Threading;

namespace z4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeDate();
            InitializePlaceResidence();
            InitializeMobOperator();
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        }

        private void InitializeDate()
        {
            for (int i = 1950; i < 2023; i++)
            {
                comboBoxYear.Items.Add(i);
            }
            comboBoxYear.SelectedIndex = 0;

            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;
            for (int i = 0; i < 12; i++)
            {
                comboBoxMonth.Items.Add(dtfi.MonthGenitiveNames[i]);
            }
            comboBoxMonth.SelectedIndex = 0;

            comboBoxYear.SelectedIndexChanged += new System.EventHandler(UpdateCountDay_Click);
            comboBoxMonth.SelectedIndexChanged += new System.EventHandler(UpdateCountDay_Click);
            UpdateCountDay();
        }

        private void InitializePlaceResidence()
        {
            Faker faker;
            if (Thread.CurrentThread.CurrentCulture.Name == "ru-Ru")
            {
                faker = new Faker("ru");
            }
            else
            {
                faker = new Faker();
            }
            for (int i = 0; i < 50; i++)
            {
                comboBoxPlaceResidence.Items.Add(faker.Address.City());
            }
        }

        private void InitializeMobOperator()
        {
            foreach (var t in Enum.GetNames(typeof(MobOperatorType)))
            {
                comboBoxMobOperator.Items.Add(t);
            }
            comboBoxMobOperator.SelectedIndex = 0;
        }

        private void UpdateCountDay_Click(object sender, EventArgs e)
        {
            UpdateCountDay();
        }

        private void numericUpDownWagesMin_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownWagesMin.Value > numericUpDownWagesMax.Value)
            {
                numericUpDownWagesMax.Value = numericUpDownWagesMin.Value;
            }
        }

        private void numericUpDownWagesMax_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownWagesMin.Value > numericUpDownWagesMax.Value)
            {
                numericUpDownWagesMin.Value = numericUpDownWagesMax.Value;
            }
        }

        private void checkBoxDriversLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDriversLicense.Checked)
            {
                groupBoxRights�ategory.Enabled = true;
            }
            else
            {
                groupBoxRights�ategory.Enabled = false;
            }
            checkBox�ategoryA.Checked = false;
            checkBox�ategoryB.Checked = false;
            checkBox�ategoryC.Checked = false;
            checkBox�ategoryD.Checked = false;
        }
        
        private void UpdateCountDay()
        {
            try
            {
                comboBoxDateDay.Items.Clear();
                int countDay = DateTime.DaysInMonth(Convert.ToInt32(comboBoxYear.Items[comboBoxYear.SelectedIndex].ToString()),
                    comboBoxMonth.SelectedIndex + 1);
                for (int i = 1; i < countDay + 1; i++)
                {
                    comboBoxDateDay.Items.Add(i);
                }
                comboBoxDateDay.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(
                "���� ����� �� ��������� ��������.",
                "������: ArgumentOutOfRangeException",
                MessageBoxButtons.OK);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckAllsField())
            {
                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string midlleName = textBoxMiddleName.Text;
                Gender gender = new Gender(GetGenderType());
                DateOnly dateBirth = new DateOnly(Convert.ToInt32(comboBoxYear.Items[comboBoxYear.SelectedIndex].ToString()),
                    comboBoxMonth.SelectedIndex + 1,
                    Convert.ToInt32(comboBoxDateDay.Items[comboBoxDateDay.SelectedIndex].ToString()));
                string placeResidence = comboBoxPlaceResidence.Text;
                string email = textBoxEmail.Text;
                MobOperatorType mobOperatorType = (MobOperatorType)Enum.Parse(typeof(MobOperatorType), comboBoxMobOperator.Text);
                string mobNum = textBoxModNum.Text;
                string workExp = GetWorkEpx();
                Wages wages = new Wages(numericUpDownWagesMin.Value, numericUpDownWagesMax.Value);
                OtherInfo otherInfo = new OtherInfo(checkBoxAuto.Checked, checkBoxDriversLicense.Checked,
                    GetRightsCategorys());
                string workSchedule = GetWorkSchedule();

                Resume resume = new Resume(surname, name, midlleName, gender, dateBirth, placeResidence,
                    email, mobOperatorType, mobNum, workExp, wages, otherInfo, workSchedule);
                textBoxResume.Clear();
                textBoxResume.Text += resume;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";


                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = saveFileDialog.FileName;
                Task.Run(() => Save(path,resume.ToString()));
            }

        }

        private async void Save(string path, string text)
        {
            string[] lines = text.Split("\n");
            
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string line in lines)
                {
                    writer.Write(line);
                }
            }
            MessageBox.Show(
                "������ ����������.",
                "",
                MessageBoxButtons.OK);
        }

        private bool CheckAllsField()
        {
            try
            {
                if (CheckIsNullField(textBoxSurname.Text))
                {
                    throw new Exception("�� ������� �������");
                }
                if (CheckIsNullField(textBoxName.Text))
                {
                    throw new Exception("�� ������� ���");
                }
                if (CheckIsNullField(textBoxMiddleName.Text))
                {
                    throw new Exception("�� ������� ��������");
                }
                if (CheckIsNullField(comboBoxPlaceResidence.Text))
                {
                    throw new Exception("�� ������ ��� �� ������ �����");
                }
                if (!IsAccuracyEmail())
                {
                    throw new Exception("Email ������ ���� �������� � �������:\n" +
                    "youraddress@email.by");
                }
                if (!IsAccuracyMobNum())
                {
                    throw new Exception("����� ������ ���� �������� � �������:\n" +
                    "+375(11)1234567");
                }
                if (CheckIsNullField(textBoxEmail.Text))
                {
                    throw new Exception("�� ������� �����");
                }
                if (CheckIsNullField(textBoxModNum.Text))
                {
                    throw new Exception("�� ������ �����");
                }
                if (numericUpDownWagesMax.Value == 0)
                {
                    throw new Exception("������������ �������� �� ������ �������� ����");
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                $"{ex.Message}",
                "������",
                MessageBoxButtons.OK);
                return false;
            }
        }

        private bool CheckIsNullField(string value)
        {
            if(value == "")
            {
                return true;
            }
            return false;
        }

        private bool IsAccuracyEmail()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            return Regex.IsMatch(textBoxEmail.Text, pattern, RegexOptions.IgnoreCase);
        }

        private bool IsAccuracyMobNum()
        {
            string pattern = @"[+]\d+[(]+\d+[)]+\d{7}";
            return Regex.IsMatch(textBoxModNum.Text, pattern, RegexOptions.IgnoreCase);
        }

        private GenderType GetGenderType()
        {
            if (radioButtonGenderMan.Checked)
            {
                return GenderType.Man;
            }
            else
            {
                return GenderType.Women;
            }
        }

        private string GetWorkEpx()
        {
            if (radioButtonWorkExp0.Checked)
            {
                return "������ �� �������";
            }
            else if (radioButtonWorkExpLess1.Checked)
            {
                return "������ 1 ����";
            }
            else if (radioButtonWorkExp1_5.Checked)
            {
                return "�� 1 ���� �� 5 ���";
            }
            else if (radioButtonWorkExp5_9.Checked)
            {
                return "�� 5 �� 9 ���";
            }
            else
            {
                return "�� 10 � �����";
            }
        }

        private List<RightsCategory> GetRightsCategorys()
        {
            List<RightsCategory> rightsCategories = new List<RightsCategory>();
            if (checkBoxDriversLicense.Checked)
            {
                if (checkBox�ategoryA.Checked)
                {
                    rightsCategories.Add(RightsCategory.A);
                }
                if (checkBox�ategoryB.Checked)
                {
                    rightsCategories.Add(RightsCategory.B);
                }
                if (checkBox�ategoryC.Checked)
                {
                    rightsCategories.Add(RightsCategory.C);
                }
                if (checkBox�ategoryD.Checked)
                {
                    rightsCategories.Add(RightsCategory.D);
                }
            }
            return rightsCategories;
        }

        private string GetWorkSchedule()
        {
            if (radioButtonWorkFull.Checked)
            {
                return "������ ���������";
            }
            else if (radioButtonWorkHome.Checked)
            {
                return "������ �� ����";
            }
            else if (radioButtonWorkPartial.Checked)
            {
                return "��������� ��������";
            }
            else
            {
                return "�������� ������";
            }
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxSurname.Clear();
            textBoxName.Clear();
            textBoxModNum.Clear();
            textBoxEmail.Clear();
            textBoxModNum.Clear();
            checkBoxAuto.Checked = false;
            checkBoxDriversLicense.Checked = false;
            groupBoxRights�ategory.Enabled = false;
            checkBox�ategoryA.Checked = false;
            checkBox�ategoryB.Checked = false;
            checkBox�ategoryC.Checked = false;
            checkBox�ategoryD.Checked = false;
            numericUpDownWagesMin.Value = 0;
            numericUpDownWagesMax.Value = 0;
            textBoxResume.Clear();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProviderMain.HelpNamespace);
        }
    }
}