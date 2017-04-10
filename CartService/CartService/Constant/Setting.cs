using System.Configuration;

namespace CartService.Constant
{
    public static class Setting
    {
        public static string ProductServiceEndPoint = ConfigurationManager.AppSettings["ProductServiceEndPoint"];

        public static string LogInstance = "CardService";

    }
}
