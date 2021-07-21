using System;

namespace AppPatronesDiseño.Patrones_estructurales._7.Proxy
{
    public class Access
    {
        public static bool GetPermission(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                Enum.TryParse<EnumTypeRole>(token, out EnumTypeRole typeRole);

                if (typeRole == EnumTypeRole.Admin)
                    return true;
            }

            return false;   
        }

        public static string GetAccessByTypeRole(EnumTypeRole typeRole)
        {
            return nameof(typeRole);
        }
    }
}