using z4.Enums;

namespace z4.Model
{
    internal class OtherInfo
    {
        private bool _isAuto;
        private bool _isDriversLicense;

        private List<RightsCategory> _rightsCategories;

        public OtherInfo(bool isAuto, bool isDriversLicense, List<RightsCategory> rightsCategories)
        {
            _isAuto = isAuto;
            _isDriversLicense = isDriversLicense;
            _rightsCategories = rightsCategories;
        }

        public override string ToString()
        {
            string isAuto = _isAuto ? "Есть" : "Нет";
            string isDriversLicense = _isDriversLicense ? "Есть" : "Нет";


            string category = "";

            foreach(RightsCategory rc in _rightsCategories)
            {
                category += rc.ToString() + " ";
            }

            return $"Наличие личного авто: {isAuto}" + Environment.NewLine + 
                $"Наличие водительско удостоверения: {isDriversLicense}" + Environment.NewLine +
                $"Категории: {category}" + Environment.NewLine;
        }
    }
}
