namespace VSTORyo
{
    partial class VSTORyoRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public VSTORyoRibbon()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.splitButtonBuatAkta = this.Factory.CreateRibbonSplitButton();
            this.buttonAktaJaminanKendaraan = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.buttonAbout = this.Factory.CreateRibbonButton();
            this.buttonBantuan = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "NOTARIS";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonAbout);
            this.group1.Items.Add(this.buttonBantuan);
            this.group1.Label = "Bantuan";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.splitButtonBuatAkta);
            this.group2.Items.Add(this.button1);
            this.group2.Items.Add(this.button3);
            this.group2.Label = "Dokumen";
            this.group2.Name = "group2";
            // 
            // splitButtonBuatAkta
            // 
            this.splitButtonBuatAkta.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.splitButtonBuatAkta.Items.Add(this.buttonAktaJaminanKendaraan);
            this.splitButtonBuatAkta.Items.Add(this.button2);
            this.splitButtonBuatAkta.Label = "Buat Akta";
            this.splitButtonBuatAkta.Name = "splitButtonBuatAkta";
            this.splitButtonBuatAkta.OfficeImageId = "SignatureInsertMenu";
            // 
            // buttonAktaJaminanKendaraan
            // 
            this.buttonAktaJaminanKendaraan.Label = "Akta Jaminan Kendaraan";
            this.buttonAktaJaminanKendaraan.Name = "buttonAktaJaminanKendaraan";
            this.buttonAktaJaminanKendaraan.ShowImage = true;
            this.buttonAktaJaminanKendaraan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAktaJaminanKendaraan_Click);
            // 
            // button2
            // 
            this.button2.Label = "dll";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAbout.Label = "About";
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.OfficeImageId = "MeetingsWorkspace";
            this.buttonAbout.ShowImage = true;
            // 
            // buttonBantuan
            // 
            this.buttonBantuan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonBantuan.Label = "Bantuan";
            this.buttonBantuan.Name = "buttonBantuan";
            this.buttonBantuan.OfficeImageId = "TentativeAcceptInvitation";
            this.buttonBantuan.ShowImage = true;
            // 
            // button1
            // 
            this.button1.Label = "Edit Dokumen";
            this.button1.Name = "button1";
            // 
            // button3
            // 
            this.button3.Label = "Finishing";
            this.button3.Name = "button3";
            // 
            // VSTORyoRibbon
            // 
            this.Name = "VSTORyoRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.VSTORyoRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButtonBuatAkta;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAktaJaminanKendaraan;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAbout;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonBantuan;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
    }

    partial class ThisRibbonCollection
    {
        internal VSTORyoRibbon VSTORyoRibbon
        {
            get { return this.GetRibbon<VSTORyoRibbon>(); }
        }
    }
}
