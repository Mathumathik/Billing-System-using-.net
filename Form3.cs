using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Mini_project
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Mathu\source\repos\Mini_project\Mini_project\CrystalReport2.rpt");
            rd.Refresh();
            crystalReportViewer2.ReportSource = rd;
            
        }
    }

}
