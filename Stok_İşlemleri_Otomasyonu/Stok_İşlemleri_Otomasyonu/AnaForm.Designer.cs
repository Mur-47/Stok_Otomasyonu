namespace Stok_İşlemleri_Otomasyonu
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnstokkarti = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnstoklistesi = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnstokgruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barbutonstokhareketlei = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barbtncariaciliskarti = new DevExpress.XtraBars.BarButtonItem();
            this.barbtncarigruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barbtncarilistesi = new DevExpress.XtraBars.BarButtonItem();
            this.barbtncarihareketleri = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barbtnstokkarti,
            this.barbtnstoklistesi,
            this.barbtnstokgruplari,
            this.barbutonstokhareketlei,
            this.barbtncariaciliskarti,
            this.barbtncarigruplari,
            this.barbtncarilistesi,
            this.barbtncarihareketleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1289, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barbtnstokkarti
            // 
            this.barbtnstokkarti.Caption = "Stok Kartı";
            this.barbtnstokkarti.Id = 1;
            this.barbtnstokkarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnstokkarti.ImageOptions.LargeImage")));
            this.barbtnstokkarti.Name = "barbtnstokkarti";
            this.barbtnstokkarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnstokkarti_ItemClick);
            // 
            // barbtnstoklistesi
            // 
            this.barbtnstoklistesi.Caption = "Stok Listesi";
            this.barbtnstoklistesi.Id = 2;
            this.barbtnstoklistesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnstoklistesi.ImageOptions.LargeImage")));
            this.barbtnstoklistesi.Name = "barbtnstoklistesi";
            this.barbtnstoklistesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnstoklistesi_ItemClick);
            // 
            // barbtnstokgruplari
            // 
            this.barbtnstokgruplari.Caption = "Stok Grupları";
            this.barbtnstokgruplari.Id = 3;
            this.barbtnstokgruplari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnstokgruplari.ImageOptions.LargeImage")));
            this.barbtnstokgruplari.Name = "barbtnstokgruplari";
            this.barbtnstokgruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnstokgruplari_ItemClick);
            // 
            // barbutonstokhareketlei
            // 
            this.barbutonstokhareketlei.Caption = "Stok Hareketleri";
            this.barbutonstokhareketlei.Id = 4;
            this.barbutonstokhareketlei.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbutonstokhareketlei.ImageOptions.LargeImage")));
            this.barbutonstokhareketlei.Name = "barbutonstokhareketlei";
            this.barbutonstokhareketlei.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbutonstokhareketlei_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnstokkarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnstoklistesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnstokgruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbutonstokhareketlei);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 495);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1289, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cari";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtncariaciliskarti);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtncarigruplari);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtncarilistesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtncarihareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cari İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // barbtncariaciliskarti
            // 
            this.barbtncariaciliskarti.Caption = "Cari Açılış Kartı";
            this.barbtncariaciliskarti.Id = 5;
            this.barbtncariaciliskarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtncariaciliskarti.ImageOptions.LargeImage")));
            this.barbtncariaciliskarti.Name = "barbtncariaciliskarti";
            this.barbtncariaciliskarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtncariaciliskarti_ItemClick);
            // 
            // barbtncarigruplari
            // 
            this.barbtncarigruplari.Caption = "Cari Grupları";
            this.barbtncarigruplari.Id = 6;
            this.barbtncarigruplari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtncarigruplari.ImageOptions.LargeImage")));
            this.barbtncarigruplari.Name = "barbtncarigruplari";
            this.barbtncarigruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtncarigruplari_ItemClick);
            // 
            // barbtncarilistesi
            // 
            this.barbtncarilistesi.Caption = "Cari Listesi";
            this.barbtncarilistesi.Id = 7;
            this.barbtncarilistesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtncarilistesi.ImageOptions.LargeImage")));
            this.barbtncarilistesi.Name = "barbtncarilistesi";
            this.barbtncarilistesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtncarilistesi_ItemClick);
            // 
            // barbtncarihareketleri
            // 
            this.barbtncarihareketleri.Caption = "Cari Hareketleri";
            this.barbtncarihareketleri.Id = 8;
            this.barbtncarihareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtncarihareketleri.ImageOptions.LargeImage")));
            this.barbtncarihareketleri.Name = "barbtncarihareketleri";
            this.barbtncarihareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtncarihareketleri_ItemClick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 519);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barbtnstokkarti;
        private DevExpress.XtraBars.BarButtonItem barbtnstoklistesi;
        private DevExpress.XtraBars.BarButtonItem barbtnstokgruplari;
        private DevExpress.XtraBars.BarButtonItem barbutonstokhareketlei;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem barbtncariaciliskarti;
        private DevExpress.XtraBars.BarButtonItem barbtncarigruplari;
        private DevExpress.XtraBars.BarButtonItem barbtncarilistesi;
        private DevExpress.XtraBars.BarButtonItem barbtncarihareketleri;
    }
}