using z4.Enums;

namespace z4.Model
{
    internal class Resume
    {
        private string _surname; 
        private string _name; 
        private string _middleName;
        private Gender _gender;
        private DateOnly _dateBirth;
        private string _placeResidence; 
        private string _email;
        private MobOperatorType _mobOperator;
        private string _mobNum;
        private string _workExp;
        private Wages _wages;
        private OtherInfo _otherInfo;
        private string _workSchedule;

        public Resume(string surname, string name, string middleName,
            Gender gender, DateOnly dateBirth, string placeResidence,
            string email, MobOperatorType mobOperator, string mobNum,
            string workExp, Wages wages, OtherInfo otherInfo, string workSchedule)
        {
            _surname = surname;
            _name = name;
            _middleName = middleName;
            _gender = gender;
            _dateBirth = dateBirth;
            _placeResidence = placeResidence;
            _email = email;
            _mobOperator = mobOperator;
            _mobNum = mobNum;
            _workExp = workExp;
            _wages = wages;
            _otherInfo = otherInfo;
            _workSchedule = workSchedule;
        }

        public override string ToString()
        {
            return $"ФИО: {_surname} {_name} {_middleName}" + Environment.NewLine +
                $"Пол: {_gender}" + Environment.NewLine +
                $"Дата рождения: {_dateBirth}" + Environment.NewLine +
                $"Мобильный оператор: {_mobOperator}" + Environment.NewLine +
                $"Email: {_email}" + Environment.NewLine +
                $"Номер телефона: {_mobNum}" + Environment.NewLine +
                $"Опыт работы: {_workExp}" + Environment.NewLine +
                $"Место проживания: {_placeResidence}" + Environment.NewLine +
                $"Зарплата: {_wages}" + Environment.NewLine +
                $"Предпочтительный график работы: {_workSchedule}" + Environment.NewLine +
                $"Другие сведенья:" + Environment.NewLine + $"{_otherInfo}" + Environment.NewLine;
        }
    }
}
