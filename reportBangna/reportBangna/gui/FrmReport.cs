using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reportBangna.objdb;
using Microsoft.Reporting.WinForms;


namespace reportBangna.gui
{
    public partial class FrmReport : Form
    {
        private ConnectDB conn;
        private reportDB reportdb;
        public String reportName { get; set; }
         
        private void initConfig()
        {
            //MessageBox.Show("inifConfig aaaaa");
            conn = new ConnectDB();
            //MessageBox.Show("initConfig bbbb");
            reportdb = new reportDB(conn);
            //MessageBox.Show("initConfig cccc");
        }
        public FrmReport()
        {
            InitializeComponent();
            initConfig();
        }
        public DataTable getXraySummaryView(DateTime dateStart, DateTime dateEnd)
        {
            conn = new ConnectDB("mainhis");
            reportdb.conn = conn;
            return reportdb.xraySummary(dateStart, dateEnd);
        }
        public void setRptXraySummaryView(DateTime dateStart, DateTime dateEnd)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("xraySummary", getXraySummaryView(dateStart, dateEnd));
                //MessageBox.Show("bbbb");
                rV1.LocalReport.DataSources.Add(rds);
                //rV1.LocalReport.ReportPath = "d:\\source\\reportBangna\\reportBangna\\report\\xraysummary.rdlc";
                rV1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\report\\xraysummary.rdlc";
                ReportParameter reportParaHeader1 = new ReportParameter();
                reportParaHeader1.Name = "header1";
                reportParaHeader1.Values.Add("aaaaaa");
                rV1.LocalReport.SetParameters(reportParaHeader1);
                ReportParameter reportParaHeader2 = new ReportParameter();
                reportParaHeader2.Name = "header2";
                reportParaHeader2.Values.Add("bbbbbbbb");
                rV1.LocalReport.SetParameters(reportParaHeader2);
                ReportParameter reportParaHeader3 = new ReportParameter();
                reportParaHeader3.Name = "header3";
                reportParaHeader3.Values.Add("cccccccc");
                rV1.LocalReport.SetParameters(reportParaHeader3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaa");
            

            //MessageBox.Show("cccc");
            this.rV1.RefreshReport();
            //MessageBox.Show("dddd");
            rV1.Size = new Size(this.Width - 40, this.Height - 70);
        }
    }
}
