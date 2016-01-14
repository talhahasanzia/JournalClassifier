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

            static List<string> savedDataFromACMAI = new List<string>();
            static List<string> savedDataFromACMSE = new List<string>();
            static List<string> savedDataFromACMTOCS = new List<string>();
            static List<string> savedDataFromACMCN = new List<string>();
            static List<string> savedDataFromACMCG = new List<string>();
            static List<string> savedDataFromACMCV = new List<string>();
            static List<string> savedDataFromACMCC = new List<string>();
            static List<string> savedDataFromACMDDB = new List<string>();
            static List<string> savedDataFromACMPC = new List<string>();








        public Comparator()
        {

             
           
            
        
        }

        public static float matchSpringerCS(string[] keywords)
        {
            savedDataFromSpringerCS = DataManager.GetData(TableNames.Springer.ComputerScience);
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerCS.Contains(word))
                    matched++;
            
            }

            perc = ((float)matched / (float)totalKeywords) * 100f;
            return perc;
        }
        
        public static float matchSpringerMA(string[] keywords)
        {
            savedDataFromSpringerMA = DataManager.GetData(TableNames.Springer.Mathematics);
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerMA.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;

            return perc;
        }
       
        public static float matchSpringerEN(string[] keywords)
        {
            savedDataFromSpringerEN = DataManager.GetData(TableNames.Springer.Engineering);
            float perc=0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromSpringerEN.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;
        }

        public static float matchACMArtificialIntelligence(string[] keywords) {
            savedDataFromACMAI = DataManager.GetData(TableNames.ACM.AI);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMAI.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }
        public static float matchACMSoftwareEngineering(string[] keywords)
        {
            savedDataFromACMSE = DataManager.GetData(TableNames.ACM.SoftwareEngineering);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMSE.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

        public static float matchACMComputerNetworks(string[] keywords)
        {
            savedDataFromACMCN = DataManager.GetData(TableNames.ACM.ComputerNetworks);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMCN.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

        public static float matchACMComputerVision(string[] keywords)
        {
            savedDataFromACMCV = DataManager.GetData(TableNames.ACM.ComputerVision);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMCV.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

        public static float matchACMTOCS(string[] keywords)
        {
            savedDataFromACMTOCS = DataManager.GetData(TableNames.ACM.TheoryOfComputerScience);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMTOCS.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;

            }

        public static float matchACMParallelComputing(string[] keywords)
        {
            savedDataFromACMPC = DataManager.GetData(TableNames.ACM.ParallelComputing);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMPC.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

        public static float matchACMCloudComputing(string[] keywords)
        {
            savedDataFromACMCC = DataManager.GetData(TableNames.ACM.CloudComputing);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMCC.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }
        public static float matchACMDistributedDatabase(string[] keywords)
        {
            savedDataFromACMDDB = DataManager.GetData(TableNames.ACM.DistributedDatabase);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMDDB.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

        public static float matchACMComputerGraphics(string[] keywords)
        {
            savedDataFromACMCG = DataManager.GetData(TableNames.ACM.ComputerGraphics);
            float perc = 0;

            int totalKeywords = keywords.Length;
            int matched = 0;

            foreach (string word in keywords)
            {

                if (savedDataFromACMCG.Contains(word))
                    matched++;

            }

            perc = ((float)matched / (float)totalKeywords) * 100f;


            return perc;


        }

    }
}