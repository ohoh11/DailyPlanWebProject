using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyPlanWebApp.Models
{
    public class MyDBHelper
    {
        static public List<PeopleInfo> My_Test_ODBC_Link(string sql)
        {

            List<PeopleInfo> list = new List<PeopleInfo>();
            //try
            //{
            //    //String strdata = @"provider=microsoft.jet.oledb.4.0;Data Source=D:\\c# 项目\\WindowsForms随机点名\\Date\\Namedate.mdb";
            //    OleDbConnection oleCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\Temp_机械盘\\db\\TestDatabase.mdb");
            //    oleCon.Open();
            //    OleDbDataAdapter oleDap = new OleDbDataAdapter(sql, oleCon);
            //    DataSet ds = new DataSet();
            //    oleDap.Fill(ds, "name");
            //    //this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //    //dataview = new DataView(ds.Tables["suijiname"]);
            //    int count = ds.Tables.Count;
            //    int count2 = ds.Tables[0].Rows.Count;
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        String t = row[0].ToString();
            //        UserInfo iu = new UserInfo();
            //        iu.Username = t;
            //        list.Add(iu);
            //    }
            //    oleCon.Close();
            //    oleCon.Dispose();
            //}
            //catch (Exception e)
            //{ }
            return list;
        }

    }
}