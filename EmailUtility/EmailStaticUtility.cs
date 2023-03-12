using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUtility
{
    internal static class EmailStaticUtility
    {
        private static int Count { get; set; }
        public static int Length { get; set; }

        static EmailStaticUtility()
        {
            Count = 0;
        }

        public static void SendEmail(string name,  string email, string subject, string body)
        {
            //send mail code
            Count++;
        }
    }
}
