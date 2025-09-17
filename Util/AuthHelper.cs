using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EnglishUp.Util
{
    public static class AuthHelper
    {
        public static bool Login(string badge_id, string password)
        {
            string query = "SELECT badge_id, role, name FROM users WHERE badge_id = @badge_id AND password = @password";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@badge_id", badge_id),
                new SqlParameter("@password", password)
            };

            DataTable dt = DbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                HttpContext.Current.Session["badge_id"] = row["badge_id"].ToString();
                HttpContext.Current.Session["role"] = row["role"].ToString();
                HttpContext.Current.Session["name"] = row["name"].ToString();

                return true;
            }

            return false;
        }

        public static void Logout()
        {
            HttpContext.Current.Session.Clear();
        }

        public static bool IsLoggedIn()
        {
            return HttpContext.Current.Session["badge_id"] != null;
        }

        public static string GetBadgeId()
        {
            return HttpContext.Current.Session["badge_id"]?.ToString();
        }

        public static string GetRole()
        {
            return HttpContext.Current.Session["role"]?.ToString();
        }

        public static string GetName()
        {
            return HttpContext.Current.Session["name"]?.ToString();
        }

        public static bool RequireRole(string role)
        {
            return IsLoggedIn() &&
                   string.Equals(GetRole(), role, StringComparison.OrdinalIgnoreCase);
        }

        public static bool RequireAnyRole(params string[] roles)
        {
            if (!IsLoggedIn()) return false;

            string currentRole = GetRole();

            foreach (var role in roles)
            {
                if (string.Equals(currentRole, role, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}