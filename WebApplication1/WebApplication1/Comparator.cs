using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Comparator
    {

             static List<string> savedDataFromSpringerCS=new List<string>();
             static List<string> savedDataFromSpringerMA=new List<string>();
             static List<string> savedDataFromSpringerEN = new List<string>();

        public Comparator()
        {

             savedDataFromSpringerCS = DataManager.GetData(TableNames.Springer.ComputerScience);
            savedDataFromSpringerMA = DataManager.GetData(TableNames.Springer.Mathematics);
            savedDataFromSpringerEN = DataManager.GetData(TableNames.Springer.Engineering);
        
        }

        public static float matchSpringerCS(string[] keywords)
        {
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerCS.Contains(word))
                    matched++;
            
            }

            perc = (matched / totalKeywords) * 100;
            return perc;
        }
        
        public static float matchSpringerMA(string[] keywords)
        {
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerMA.Contains(word))
                    matched++;

            }

            perc = (matched / totalKeywords) * 100;

            return perc;
        }
       
        public static float matchSpringerEN(string[] keywords)
        {
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerEN.Contains(word))
                    matched++;

            }

            perc = (matched / totalKeywords) * 100;


            return perc;
        }
    }
}