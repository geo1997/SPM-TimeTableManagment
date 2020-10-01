using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagment.Forms
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            GetData();
        }

         
         

    private void GetData()
    {
        DataTable dt = new DataTable("TimeTable");



        DataColumn cltime = new DataColumn("Time");
        dt.Columns.Add(cltime);

        DataColumn cl1 = new DataColumn("Monday");
        dt.Columns.Add(cl1);

        DataColumn cl2 = new DataColumn("Tuesday");
        dt.Columns.Add(cl2);

        DataColumn cl3 = new DataColumn("Wednesday");
        dt.Columns.Add(cl3);



        DataRow dr1 = dt.NewRow();
        dr1["Time"] = "08.30";
        dr1["Monday"] = retrieveData("08.30", "Monday");
        dr1["Tuesday"] = "XXXXXXXX";
        dr1["Wednesday"] = "XXXXXXXX";
        dt.Rows.Add(dr1);

        DataRow dr2 = dt.NewRow();
        dr2["Time"] = "9.30 am";
        dr2["Monday"] = "XXXXXXXX";
        dr2["Tuesday"] = "XXXXXXXX";
        dr2["Wednesday"] = "XXXXXXXX";
        dt.Rows.Add(dr2);

        this.dataGridView7.DataSource = dt;
    }

    private string FormatData(string one, string two)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(one);
            
      
        sb.AppendLine(two);

        return sb.ToString();
    }

    private string retrieveData(string time, string date)
    {
        //Data reading query
        var x = "X1000";
        var s = "LXXX100";
        return this.FormatData(x, s); ;
    }
        
    }

   }

