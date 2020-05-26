namespace outlook_connector
{
    partial class RibbonConnector : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonConnector()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Synck = this.Factory.CreateRibbonButton();
            this.comboBox1 = this.Factory.CreateRibbonComboBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "iCount Sync";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.comboBox1);
            this.group1.Items.Add(this.Synck);
            this.group1.Label = "iCount Sync";
            this.group1.Name = "group1";
            // 
            // Synck
            // 
            this.Synck.Image = global::outlook_connector.Properties.Resources.sync_image;
            this.Synck.Label = "Sync";
            this.Synck.Name = "Synck";
            this.Synck.ShowImage = true;
            // 
            // comboBox1
            // 
            ribbonDropDownItemImpl1.Label = "Appreciation";
            ribbonDropDownItemImpl2.Label = "Others";
            this.comboBox1.Items.Add(ribbonDropDownItemImpl1);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl2);
            this.comboBox1.Label = "Type";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Text = "Appreciation";
            // 
            // RibbonConnector
            // 
            this.Name = "RibbonConnector";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonConnector_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Synck;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox1;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonConnector RibbonConnector
        {
            get { return this.GetRibbon<RibbonConnector>(); }
        }
    }
}
