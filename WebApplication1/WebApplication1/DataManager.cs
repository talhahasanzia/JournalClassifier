using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DataManager
    {
        static DataSet SQLdset;
        static SqlDataAdapter SQLAdp;
        static SqlConnection c;
        static SqlConnection SQLCon;
            
            public DataManager()
        {
            
                        

                

     
           
        }
            public static List<string> GetData(string tableName)
            {
                SQLCon = new SqlConnection();

                string ConString = @"Data Source=" + "F:\\Github\\JournalClassifier\\WebApplication1\\WebApplication1\\App_Data\\KeywordsDB.sdf" + ";Integrated Security=True;Connect Timeout=30";
                SQLCon.ConnectionString = ConString; 

                List<string> WordList = new List<string>();
                SQLCon.Open();

                string Comm = "SELECT * FROM "+tableName;

                SQLAdp = new SqlDataAdapter(Comm, SQLCon);

                SQLAdp.SelectCommand = new SqlCommand(Comm, SQLCon);

                SQLdset = new DataSet();

                SQLAdp.Fill(SQLdset,tableName);




                SQLCon.Close();

                if (SQLdset != null)
                {
                    ;
                    int j = SQLdset.Tables[tableName].Rows.Count;
                   
                    ;

                    for (int i = 0; i < j - 1; i++)
                    {

                        string temp = SQLdset.Tables[tableName].Rows[i]["Keywords"].ToString();
                        WordList.Add(temp.ToLower());
                        
                    }
                }
                return WordList;
            }
            public static  void SetData(string tableName, List<string> keywordsList)
            {
                SQLCon = new SqlConnection();

                string ConString = @"Data Source=|DataDirectory|KeywordsDB.sdf;";
                SQLCon.ConnectionString = ConString; 
                // from db to array

                if (SQLCon != null)
                {
                  //  SQLCon.Open();


                    foreach (string word in keywordsList)
                    {
                        string sql = "insert into " + tableName + "(Keywords) values(" + word.ToLower() + ")";
                        try
                        {
                            SQLAdp.InsertCommand = new SqlCommand(sql, SQLCon);

                            SQLAdp.InsertCommand.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            
                        }
                        finally
                        {
                            SQLCon.Close();
                        
                        }
                    }
                    
                }

                
            
            }
    }
}