namespace Stok_İşlemleri_Otomasyonu.ModulStok
{
    partial class FrmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.txtbarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtstokadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtstokkodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Liste1 = new DevExpress.XtraGrid.GridControl();
            this.Grd1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stok_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stok_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stok_Barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1205, 508);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(234, 508);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnara);
            this.xtraTabPage1.Controls.Add(this.txtbarkod);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtstokadi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtstokkodu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(232, 483);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(122, 190);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(91, 33);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Temizle";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnara.ImageOptions.Image")));
            this.btnara.Location = new System.Drawing.Point(25, 190);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(91, 33);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "Ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(25, 155);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(188, 20);
            this.txtbarkod.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Barkod";
            // 
            // txtstokadi
            // 
            this.txtstokadi.Location = new System.Drawing.Point(25, 110);
            this.txtstokadi.Name = "txtstokadi";
            this.txtstokadi.Size = new System.Drawing.Size(188, 20);
            this.txtstokadi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtstokkodu
            // 
            this.txtstokkodu.Location = new System.Drawing.Point(25, 65);
            this.txtstokkodu.Name = "txtstokkodu";
            this.txtstokkodu.Size = new System.Drawing.Size(188, 20);
            this.txtstokkodu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // Liste1
            // 
            this.Liste1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste1.Location = new System.Drawing.Point(0, 0);
            this.Liste1.MainView = this.Grd1;
            this.Liste1.Name = "Liste1";
            this.Liste1.Size = new System.Drawing.Size(961, 508);
            this.Liste1.TabIndex = 0;
            this.Liste1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grd1});
            this.Liste1.DoubleClick += new System.EventHandler(this.Liste1_DoubleClick);
            // 
            // Grd1
            // 
            this.Grd1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Stok_Kodu,
            this.Stok_Adi,
            this.Stok_Barkod});
            this.Grd1.GridControl = this.Liste1;
            this.Grd1.Name = "Grd1";
            this.Grd1.OptionsView.ShowGroupPanel = false;
            this.Grd1.DoubleClick += new System.EventHandler(this.Grd1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Stok_Kodu
            // 
            this.Stok_Kodu.Caption = "Stok Kodu";
            this.Stok_Kodu.FieldName = "Stok_Kodu";
            this.Stok_Kodu.Name = "Stok_Kodu";
            this.Stok_Kodu.OptionsColumn.AllowEdit = false;
            this.Stok_Kodu.OptionsColumn.AllowFocus = false;
            this.Stok_Kodu.OptionsColumn.FixedWidth = true;
            this.Stok_Kodu.Visible = true;
            this.Stok_Kodu.VisibleIndex = 0;
            this.Stok_Kodu.Width = 70;
            // 
            // Stok_Adi
            // 
            this.Stok_Adi.Caption = "Stok Adı";
            this.Stok_Adi.FieldName = "Stok_Adi";
            this.Stok_Adi.Name = "Stok_Adi";
            this.Stok_Adi.OptionsColumn.AllowEdit = false;
            this.Stok_Adi.OptionsColumn.AllowFocus = false;
            this.Stok_Adi.OptionsColumn.FixedWidth = true;
            this.Stok_Adi.Visible = true;
            this.Stok_Adi.VisibleIndex = 1;
            this.Stok_Adi.Width = 70;
            // 
            // Stok_Barkod
            // 
            this.Stok_Barkod.Caption = "Barkod";
            this.Stok_Barkod.FieldName = "Stok_Barkod";
            this.Stok_Barkod.Name = "Stok_Barkod";
            this.Stok_Barkod.OptionsColumn.AllowEdit = false;
            this.Stok_Barkod.OptionsColumn.AllowFocus = false;
            this.Stok_Barkod.OptionsColumn.FixedWidth = true;
            this.Stok_Barkod.Visible = true;
            this.Stok_Barkod.VisibleIndex = 2;
            this.Stok_Barkod.Width = 70;
            // 
            // FrmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmStokListesi.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Lİstesi";
            this.Load += new System.EventHandler(this.FrmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl Liste1;
        private DevExpress.XtraGrid.Views.Grid.GridView Grd1;
        private DevExpress.XtraEditors.TextEdit txtstokkodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.TextEdit txtbarkod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtstokadi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Stok_Kodu;
        private DevExpress.XtraGrid.Columns.GridColumn Stok_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn Stok_Barkod;
    }
}