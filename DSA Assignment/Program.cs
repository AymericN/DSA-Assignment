using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DSA
{
    class Program
    {
        static void Main(string[] args)
        {                   
            CustomDataBase mybase = new CustomDataBase();
            int stop = 0;
            string value = "";
            int index = 0;
            int answer = 0;
            mybase.PopulateWithSampleData();
            string firstname = "";
            string lastname = "";
            string studentnumber = "";
            float averagescore = 0;
            while(stop==0)
            {
                answer = 0;
                index = 0;
                value = "";
                while (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) < 1 || Convert.ToInt32(value) > 7)
                {               // traitment of different kind of missclick 
                    Console.WriteLine("What do  you want to do?");
                    Console.WriteLine("Press 1 to add student");
                    Console.WriteLine("Press 2 to get element");
                    Console.WriteLine("Press 3 to remove one element by index");
                    Console.WriteLine("Press 4 to remove the first element");
                    Console.WriteLine("Press 5 to remove the last element");
                    Console.WriteLine("Press 6 to display on the list");
                    Console.WriteLine("Press 7 to stop");
                    value = Console.ReadLine();
                }
                answer = Convert.ToInt32(value);              
                if (answer == 1)
                {
                    Console.WriteLine("Create a student");
                    Console.WriteLine("Enter the firstname");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Enter the lastname");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Enter the studentnumber");
                    studentnumber = Console.ReadLine();
                    value = "";
                    while (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) < 0 || Convert.ToInt32(value) > 100)
                    {
                        Console.WriteLine("Enter the average score between 0 and 100");
                        value = Console.ReadLine();
                    }
                    
                    averagescore = Convert.ToInt32(value);
                    Students student1 = new Students(firstname, lastname, studentnumber, averagescore);
                    mybase.Add_element(student1);
                }
                else
                {
                    if (answer == 2)
                    {
                        value = "";
                        while (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) < 1 || Convert.ToInt32(value) > mybase.Data.Count)
                        {
                            Console.WriteLine("Enter the index of the student you want between 1 and" + mybase.Data.Count);
                            value = Console.ReadLine();
                        }
                        index = Convert.ToInt32(value);
                        mybase.Data.ElementAt(index-1).ToString();                       
                    }
                    else
                    {
                        if (answer == 3)
                        {
                            value = "";            
                               while (value.All(Char.IsDigit) == false|| value== null || value==""|| Convert.ToInt32(value) < 1 || Convert.ToInt32(value) > mybase.Data.Count)
                                {
                                    Console.WriteLine("Enter the index of the student you want to remove between 1 and" + mybase.Data.Count);
                                    value = Console.ReadLine();
                                }
                                index = Convert.ToInt32(value);                          
                                mybase.RemoveByIndex(index);                            
                        }
                        else
                        {
                            if (answer == 4)
                            {
                                mybase.RemoveFirst();
                            }
                            else
                            {
                                if (answer == 5)
                                {
                                    mybase.RemoveLast();
                                }
                                else
                                {
                                    if (answer == 6)
                                    {
                                        mybase.DisplayList();
                                    }
                                    else
                                    {
                                        if (answer == 7)
                                        {
                                            stop = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if(mybase.Data.Count==0)        // if the list is empty
                {
                    Console.WriteLine("the list is empty, end of the programm");
                    Console.WriteLine("Press a button to leave");
                    Console.ReadKey();
                    stop = 1;
                }
            }
            Console.WriteLine("Press a button to leave");
            Console.ReadKey();
        }
    }
}
