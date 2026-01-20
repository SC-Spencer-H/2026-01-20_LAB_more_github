using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManagement.Utilities
{
    internal static class ClientValidation
    {
        public static bool IsValidEmail(string email)
        {
            if (email != null)
            {
                string[] formatCheck = email.Split('@');
                if (formatCheck.Length == 2)
                {
                    return true;
                }

                return false;
            }
            return false;
        }

        public static bool IsValidName(string name)
        {
            if (name != null)
            {
                string[] formatCheck = name.Split(' ');
                if (formatCheck.Length >= 2)
                {
                    return true;
                }

                return false;
            }
            return false;
        }
    }
}
