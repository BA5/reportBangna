using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reportBangna.gui;

namespace reportBangna
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRptXarySummary frmRptXray = new FrmRptXarySummary();
            frmRptXray.Show();
        }

        private void tv1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String nodeSelect = "";
            nodeSelect = tv1.SelectedNode.Name.ToString();
            if (nodeSelect == "nXrayDailyUseFilm")
            {
                FrmRptXarySummary frm = new FrmRptXarySummary();
                frm.Show(this);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
