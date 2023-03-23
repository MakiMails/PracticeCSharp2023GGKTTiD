using z4.Enums;

namespace z4.Model
{
    internal class Gender
    {
        private static Dictionary<GenderType, string> allsOption = new Dictionary<GenderType, string>()
        { 
            {GenderType.Man,"Мужской"},
            {GenderType.Women,"Женский"}
        };

        private GenderType _type;

        public Gender(GenderType type)
        {
            _type = type;
        }

        public override string ToString()
        {
            return allsOption[_type];
        }
    }
}
