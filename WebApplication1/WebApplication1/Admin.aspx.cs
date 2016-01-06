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
        List<string> keywords=new List<string>();
        string source=Searcher.Springer.ComputerScience;
        List<string> KeywordsList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {


            // SET CATEGORIES

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

            keywords=JournalLinks.FromSpringer(source,1);

            foreach (string word in keywords)
            {
                OutputLabel.Text += "<br>"+word;
            
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

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
        
        }
        protected void ShowButton_Click(object sender, EventArgs e)
        {
            List<string> tempList=new List<string>();
            if (source == Searcher.Springer.ComputerScience)
            {

               tempList  = DataManager.GetData("Springer_ComputerScience");


            }
            if (source == Searcher.Springer.Mathematics)
            {

                tempList = DataManager.GetData("Springer_Mathematics");

            }
            if (source == Searcher.Springer.Engineering)
            {

                tempList = DataManager.GetData("Springer_Engineering");

            }
            foreach (string word in tempList)
            {


                OutputLabel.Text += "<br>" + word;
            
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