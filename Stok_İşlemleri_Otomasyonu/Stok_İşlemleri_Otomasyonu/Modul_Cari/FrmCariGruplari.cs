using DevExpress.XtraEditors;
using Stok_İşlemleri_Otomasyonu.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_İşlemleri_Otomasyonu.Modul_Cari
{
    public partial class FrmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB =new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public FrmCariGruplari()
        {
            InitializeComponent();
           
        }

        void Temizle()
        {
            txtgrupadi.Text = "";
            txtgrupkodu.Text = "";
            Edit=false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CariGruplaris
                      select s; 
            Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                Edit=true;
                SecimID=int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtgrupadi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtgrupkodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception )
            {
                Edit=false;
                SecimID = -1;        
            }
        }

        void YeniKaydet ()
        {
            try
            {
                Fonksiyonlar.TBL_CariGruplari Grup = new Fonksiyonlar.TBL_CariGruplari();
                Grup.GRUPADI=txtgrupadi.Text;
                Grup.GRUPKODU=txtgrupkodu.Text; 
                Grup.EDİTDATE=DateTime.Now;
                Grup.EDİTUSER=AnaForm.UserID;
                DB.TBL_CariGruplaris.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Kayıt Başarılı");
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CariGruplari Grup = DB.TBL_CariGruplaris.First(s=> s.ID==SecimID);
                Grup.GRUPADI = txtgrupadi.Text;
                Grup.GRUPKODU = txtgrupkodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;               
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Cari Grup bilgileri Güncellendi");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e); 
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CariGruplaris.DeleteOnSubmit(DB.TBL_CariGruplaris.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
                Mesajlar.sil(true);
               
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
       
        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.sil() == DialogResult.Yes) Sil();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim&&SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}