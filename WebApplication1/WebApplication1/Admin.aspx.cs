using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {
        static List<string> keywords=new List<string>();
       static string source=Searcher.Springer.ComputerScience;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {
            keywords = new List<string>();

            // SET CATEGORIES

            setValues();

            keywords=JournalLinks.FromSpringer(source,GetDepth());

            foreach (string word in keywords)
            {
                OutputLabel.Text += "<br>"+word;
            
            }
        }

       

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

            setValues();

            UpdateData();

            OutputLabel.Text = "<br> Click 'Show Data' to see changes";
        
        }

       
        protected void ShowButton_Click(object sender, EventArgs e)
        {
            setValues();
           
            List<string> tempList=GetData();
            
            foreach (string word in tempList)
            {


                OutputLabel.Text += "<br>" + word;
            
            }
        }

        int GetDepth()
        {
            int d = 1;


            if (DropDownList3.SelectedValue == "x1")
            {

                d = 1;

            }
            else if (DropDownList3.SelectedValue == "x2")
            {

                d = 2;

            }
            else if (DropDownList3.SelectedValue == "x3")
            {

                d = 3;

            }
            else
            {

                d = 1; ;
            }

            return d;
        }


        void UpdateData()
        {

            if (source == Searcher.Springer.ComputerScience)
            {

                DataManager.SetData(TableNames.Springer.ComputerScience, keywords);

            }
            if (source == Searcher.Springer.Mathematics)
            {

                DataManager.SetData(TableNames.Springer.Mathematics, keywords);

            }
            if (source == Searcher.Springer.Engineering)
            {

                DataManager.SetData(TableNames.Springer.Engineering, keywords);

            }
            if (source == Searcher.Springer.AI)
            {

                DataManager.SetData(TableNames.Springer.AI, keywords);

            }
            if (source == Searcher.Springer.Algebra)
            {

                DataManager.SetData(TableNames.Springer.Algebra, keywords);

            }
            if (source == Searcher.Springer.ComputerNetworks)
            {

                DataManager.SetData(TableNames.Springer.ComputerNetworks, keywords);

            }
            if (source == Searcher.Springer.InformationSystemsAndApplications)
            {

                DataManager.SetData(TableNames.Springer.InformationSystems, keywords);

            }
            if (source == Searcher.Springer.MathematicalAndComputationalPhysics)
            {

                DataManager.SetData(TableNames.Springer.MathematicalAndComputationalPhysics, keywords);

            }
            if (source == Searcher.Springer.TheoreticalComputerScience)
            {

                DataManager.SetData(TableNames.Springer.TheoriticalComputerScience, keywords);

            }


        }

        List<string> GetData()
        {

            List<string> tempList = new List<string>();
            if (source == Searcher.Springer.ComputerScience)
            {

                tempList = DataManager.GetData(TableNames.Springer.ComputerScience);


            }
            if (source == Searcher.Springer.Mathematics)
            {

                tempList = DataManager.GetData(TableNames.Springer.Mathematics);

            }
            if (source == Searcher.Springer.Engineering)
            {

                tempList = DataManager.GetData(TableNames.Springer.Engineering);

            }
            if (source == Searcher.Springer.AI)
            {

                tempList = DataManager.GetData(TableNames.Springer.AI);

            }
            if (source == Searcher.Springer.Algebra)
            {

                tempList = DataManager.GetData(TableNames.Springer.Algebra);

            }
            if (source == Searcher.Springer.ComputerNetworks)
            {

                tempList = DataManager.GetData(TableNames.Springer.ComputerNetworks);

            }
            if (source == Searcher.Springer.InformationSystemsAndApplications)
            {

                tempList = DataManager.GetData(TableNames.Springer.InformationSystems);

            }
            if (source == Searcher.Springer.MathematicalAndComputationalPhysics)
            {

                tempList = DataManager.GetData(TableNames.Springer.MathematicalAndComputationalPhysics);

            }
            if (source == Searcher.Springer.TheoreticalComputerScience)
            {

                tempList = DataManager.GetData(TableNames.Springer.TheoriticalComputerScience);

            }
            return tempList;
        
        }


        void setValues()
        {

            if (DropDownList1.SelectedValue == "Springer")
            {
                if (DropDownList2.SelectedValue == "CS")
                {

                    source = Searcher.Springer.ComputerScience;

                }
                if (DropDownList2.SelectedValue == "MA")
                {

                    source = Searcher.Springer.Mathematics;

                }
                if (DropDownList2.SelectedValue == "AI")
                {

                    source = Searcher.Springer.AI;

                }
                if (DropDownList2.SelectedValue == "TC")
                {

                    source = Searcher.Springer.TheoreticalComputerScience;

                }
                if (DropDownList2.SelectedValue == "CN")
                {

                    source = Searcher.Springer.ComputerNetworks;

                }
                if (DropDownList2.SelectedValue == "AL")
                {

                    source = Searcher.Springer.Algebra;

                }
                if (DropDownList2.SelectedValue == "IS")
                {

                    source = Searcher.Springer.InformationSystemsAndApplications;

                }
                if (DropDownList2.SelectedValue == "CP")
                {

                    source = Searcher.Springer.MathematicalAndComputationalPhysics;

                }

            }
            if (DropDownList1.SelectedValue == "IEEE")
            {
                if (DropDownList2.SelectedValue == "CS")
                {

                    source = Searcher.IEEE.ComputerScience;

                }
                if (DropDownList2.SelectedValue == "MA")
                {

                    source = Searcher.IEEE.Mathematics;

                }
                if (DropDownList2.SelectedValue == "EN")
                {

                    source = Searcher.IEEE.Engineering;

                }

            }
            if (DropDownList1.SelectedValue == "ACM")
            {
                if (DropDownList2.SelectedValue == "CS")
                {

                    source = Searcher.ACM.ComputerScience;

                }
                if (DropDownList2.SelectedValue == "MA")
                {

                    source = Searcher.ACM.Mathematics;

                }
                if (DropDownList2.SelectedValue == "EN")
                {

                    source = Searcher.ACM.Engineering;

                }

            }

        
        
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        
        }
    }
}