namespace z4
{
    public partial class Form1 : Form
    {
        int indexElem = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string lit = textBoxLit.Text;
                lit = lit.ToUpper();

                int x = Convert.ToInt32(textBoxX.Text);
                int y = Convert.ToInt32(textBoxY.Text);

                

                if (lit == "�")
                {
                    //����
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(x, y);
                    textBox.Name = $"textBox{indexElem}";
                    textBox.Size = new Size(120, 25);
                    textBox.Text = "����� ���� �����";
                    Controls.Add(textBox);
                }
                else if (lit == "�")
                {
                    //������
                    Button button = new Button();
                    button.Location = new Point(x, y);
                    button.Name = $"button{indexElem}";
                    button.Size = new Size(120, 25);
                    button.Text = "����� ������";
                    Controls.Add(button);
                }
                else if (lit == "�")
                {
                    //�����
                    Label label = new Label();
                    label.Location = new Point(x, y);
                    label.Name = $"label{indexElem}";
                    label.Size = new Size(120, 25);
                    label.Text = "����� �����";
                    Controls.Add(label);

                }
                else
                {
                    MessageBox.Show(
                        $"������������ ��������: {textBoxLit.Text}.\n" +
                        $"���������� ��������:\n" +
                        $"� - ���� ��� �����\n" +
                        $"� - �����\n" +
                        $"� - �����",
                        "������������ ��������.",
                        MessageBoxButtons.OK);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "�� ��������� ������ ����������.",
                    "����������",
                    MessageBoxButtons.OK);
            }
            indexElem++;
        }
    }
}