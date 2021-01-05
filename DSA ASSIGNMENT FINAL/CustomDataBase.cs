using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ASSIGNMENT_FINAL
{
   public class CustomDataBase
    {
        public List<Students> Data = new List<Students>();
        public void CustomDataBaseC()
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
        public Students Get_Element(int index)
        {
            return Data.ElementAt(index - 1);
        }
        public void RemoveByIndex(int index)
        {
            Data.RemoveAt(index - 1);
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
            for (int index = 0; index < Data.Count; index++)
            {
                Data.ElementAt(index).ToString();
                Console.WriteLine();
            }
        }
        public void GetMaxElement()
        {
            Students result = null;
            float maxscore = -1;
            for (int index = 0; index < Data.Count; index++)
            {
                if (Data[index].averagescore > maxscore)
                {
                    maxscore = Data[index].averagescore;
                    result = Data[index];
                }
            }
            result.ToString();
        }
        public void GetMinElement()
        {
            Students result = null;
            float minscore = 101;
            for (int index = 0; index < Data.Count; index++)
            {
                if (Data[index].averagescore < minscore)
                {
                    minscore = Data[index].averagescore;
                    result = Data[index];
                }
            }
            Console.WriteLine(minscore);
            result.ToString();
        }
        public void InsertionSort(string field, string direction)
        {
            Students[] tab = Data.ToArray<Students>();
            if (field=="grade")
            {
                if (direction == "increase")
                {
                    for (int index = 0; index < tab.Length - 1; index++)
                    {
                        for (int index2 = index + 1; index2 > 0; index2--)
                        {
                            if (tab[index2 - 1].averagescore > tab[index2].averagescore)
                            {
                                Students temp = tab[index2 - 1];
                                tab[index2 - 1] = tab[index2];
                                tab[index2] = temp;
                            }
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < tab.Length - 1; index++)
                    {
                        for (int index2 = index + 1; index2 > 0; index2--)
                        {
                            if (tab[index2 - 1].averagescore < tab[index2].averagescore)
                            {
                                Students temp = tab[index2 - 1];
                                tab[index2 - 1] = tab[index2];
                                tab[index2] = temp;
                            }
                        }
                    }
                }
            } 
            else
            {
                if(direction=="alphabetic")
                {
                    for (int index = 0; index < tab.Length - 1; index++)
                    {
                        for (int index2 = index + 1; index2 > 0; index2--)
                        {
                         
                                if(string.Compare(tab[index2-1].lastname,tab[index2].lastname)==1)
                            {
                                Students temp = tab[index2 - 1];
                                tab[index2 - 1] = tab[index2];
                                tab[index2] = temp;
                            }                           
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < tab.Length - 1; index++)
                    {
                        for (int index2 = index + 1; index2 > 0; index2--)
                        {
                            if (string.Compare(tab[index2 - 1].lastname, tab[index2].lastname) == -1)
                            {
                                Students temp = tab[index2 - 1];
                                tab[index2 - 1] = tab[index2];
                                tab[index2] = temp;
                            }
                        }
                    }
                }
            }
            Data = tab.ToList<Students>();         
        }
    }

}

