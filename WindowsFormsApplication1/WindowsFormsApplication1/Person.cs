using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string fullName;


        public string GetFullName()
        {
           fullName = firstName + " " +middleName+ " " + lastName;
            return fullName;
        }

        public string GetReverseFullName()
        {
            char[] reverseName = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = reverseName.Length - 1; i > -1; i--)
            {
                reverse += reverseName[i];
            }
            return reverse;
            return reverse;
        }
    }

}
