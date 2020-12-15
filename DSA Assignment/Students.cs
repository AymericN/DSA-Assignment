using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DSA
{
    class Students
    {
        string firstname;
        string lastname;
        string studentnumber;
        float averagescore;
        //Constructor
       public Students(string firstname, string lastname,string studentnumber,float averagescore)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.studentnumber = studentnumber;
            this.averagescore = averagescore;
        }
        public void ToString()
        {
            Console.WriteLine(firstname + " " + lastname + " " + studentnumber + " " + averagescore);
        }   
    }
}
