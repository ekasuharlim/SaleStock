﻿using System.Configuration;

namespace StoreWeb.Constant
{
    public static class Setting
    {
        public static string ProductServiceEndPoint = ConfigurationManager.AppSettings["ProductServiceEndPoint"];

        public static string CartServiceEndPoint = ConfigurationManager.AppSettings["CartServiceEndPoint"];

        public static string LogInstance = "StoreWeb";

    }
}
