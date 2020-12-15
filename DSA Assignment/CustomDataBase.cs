using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DSA
{
    class CustomDataBase
    {
       public List<Students> Data= new List<Students>();
        public void customDataBase()
        {
                    
        }
        public void PopulateWithSampleData()
        {
            Students Aymeric = new Students("Aymeric", "Nativel", "01", 78);
            Students Charles = new Students("Charles", "Magloire", "02", 56);
            Students Tobi = new Students("Tobi", "Teub", "03", 43);
            Students Gad = new Students("Gad", "Shaun", "04", 67);
            Students Shino = new Students("Shino", "Taf", "05", 84);
            Students Baul = new Students("Baul", "Mot", "06", 90);
            Students Arthur = new Students("Arthur", "Percifleur", "07", 79);
            Data.Add(Aymeric);
            Data.Add(Charles);
            Data.Add(Tobi);
            Data.Add(Gad);
            Data.Add(Shino);
            Data.Add(Baul);
            Data.Add(Arthur);
        }
        public void Add_element(Students student)
        {
            Data.Add(student);
        }
        public  Students Get_Element(int index)
        {
            return Data.ElementAt(index-1);
        }
        public void RemoveByIndex(int index)
        {
            Data.RemoveAt(index-1);
        }
        public void RemoveFirst()
        {
            Data.RemoveAt(0);
        }
        public void RemoveLast()
        {
            Data.RemoveAt(Data.Count - 1);
        }
        public void DisplayList()
        {
            for(int index=0; index<Data.Count; index++)
            {
                Data.ElementAt(index).ToString();
                Console.WriteLine();
            }
        }
    }
}
