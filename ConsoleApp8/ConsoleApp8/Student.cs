using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }


        public static bool CheckGroupNo(this string groupNo)
        {
            if (groupNo = value)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool CheckFullName(this string fullName)
        {
            if(fullName=value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
