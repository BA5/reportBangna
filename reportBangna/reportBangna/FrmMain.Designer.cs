namespace reportBangna
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("OPD");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("รายงานการใช้ฟิลม์ประจำวัน");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("X-Ray", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tv1
            // 
            this.tv1.Location = new System.Drawing.Point(6, 11);
            this.tv1.Name = "tv1";
            treeNode7.Name = "nOPD";
            treeNode7.Text = "OPD";
            treeNode8.Name = "nXrayDailyUseFilm";
            treeNode8.Text = "รายงานการใช้ฟิลม์ประจำวัน";
            treeNode9.Name = "nXray";
            treeNode9.Text = "X-Ray";
            this.tv1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9});
            this.tv1.Size = new System.Drawing.Size(307, 345);
            this.tv1.TabIndex = 4;
            this.tv1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv1_NodeMouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 386);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv1;
    }
}

