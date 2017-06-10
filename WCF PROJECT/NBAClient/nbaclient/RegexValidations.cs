
using System.Text.RegularExpressions;


namespace WcfDuplexServiceClient
{
    class RegexValidations
    {
        public static bool NameValidation(string name)
        {
            if (!Regex.IsMatch(name, @"^[A-Z][a-z]+(\s+[A-Z][a-z]+)?$")) 
                return false;
            return true;
        }
        public static bool NumericValidation(string num)
        {
            if(!Regex.IsMatch(num, @"^\d+$"))
                return false;
            return true;
        }
        public static bool HeightAndWeightValidation(string num)
        {
            if (!Regex.IsMatch(num, @"^(\d+)|(\d+.\d+)$"))
                return false;
            return true;
        }

        public static bool PositionValidation(string position)
        {
            if (!Regex.IsMatch(position, @"Shooting guard|Point guard|Center|Small forward|Power forward"))
                return false;
            return true;
        }
        

    }
}
