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

            keywords=JournalLinks.FromSpringer(source,1);

            foreach (string word in keywords)
            {
                OutputLabel.Text += "<br>"+word;
            
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

            setValues();

            if (source ==  Searcher.Springer.ComputerScience)
            {

                DataManager.SetData("Springer_ComputerScience", keywords);
            
            }
            if (source == Searcher.Springer.Mathematics)
            {

                DataManager.SetData("Springer_Mathematics", keywords);

            }
            if (source == Searcher.Springer.Engineering)
            {

                DataManager.SetData("Springer_Engineering", keywords);

            }
            OutputLabel.Text = "<br> Click 'Show Data' to see changes";
        
        }
        protected void ShowButton_Click(object sender, EventArgs e)
        {
            setValues();
           
            List<string> tempList=new List<string>();
            if (source == Searcher.Springer.ComputerScience)
            {

               tempList  = DataManager.GetData(TableNames.Springer.ComputerScience);


            }
            if (source == Searcher.Springer.Mathematics)
            {

                tempList = DataManager.GetData(TableNames.Springer.Mathematics);

            }
            if (source == Searcher.Springer.Engineering)
            {

                tempList = DataManager.GetData(TableNames.Springer.Engineering);

            }
            foreach (string word in tempList)
            {


                OutputLabel.Text += "<br>" + word;
            
            }
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
                if (DropDownList2.SelectedValue == "EN")
                {

                    source = Searcher.Springer.Engineering;

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