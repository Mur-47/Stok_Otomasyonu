using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_İşlemleri_Otomasyonu.ModulStok
{
    public partial class FrmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim=false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int StokID = -1;   

        public FrmStokKarti()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokKarti_Load(object sender, EventArgs e)
        {
           txtstokkodu.Text= Numaralar.StokKodNumarasi();
        }

        void Temizle()
        {
            txtstokkodu.Text=Numaralar.StokKodNumarasi();
            txtstokadi.Text="";
            txtsatiskdv.Text="0";
            txtsatisfiyat.Text="0";
            txtgrupkodu.Text="";
            txtgrupadi.Text="";
            txtbirim.SelectedIndex=0;
            txtbarkod.Text = "";
            txtaliskdv.Text="0";    
            txtalisfiyat.Text="0";
            pictureBox1.Image=null;
            Resim = false;   
            Edit=false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim=true;
              
            }
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID=ID;
            Fonksiyonlar.TBL_Stoklar Stok= DB.TBL_Stoklars.First(s=> s.ID==StokID);
            GrupAc(Stok.Stok_Grup_ID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.Stok_Resim.ToArray());
            txtalisfiyat.Text=Stok.Stok_Alis_Fiyat.ToString();
            txtaliskdv.Text=Stok.Stok_Alis_KDV.ToString();
            txtbarkod.Text=Stok.Stok_Barkod;
            txtbirim.Text=Stok.Stok_Birim;
            txtsatisfiyat.Text=Stok.Stok_Satis_Fiyat.ToString() ;
            txtsatiskdv.Text= Stok.Stok_Satis_KDV.ToString();
            txtstokadi.Text=Stok.Stok_Adi;
            txtstokkodu.Text=Stok.Stok_Kodu;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Stoklar Stok = new Fonksiyonlar.TBL_Stoklar();
                Stok.Stok_Adi = txtstokadi.Text;
                Stok.Stok_Alis_Fiyat = decimal.Parse(txtalisfiyat.Text);
                Stok.Stok_Alis_KDV = decimal.Parse(txtaliskdv.Text);
                Stok.Stok_Barkod = txtbarkod.Text;
                Stok.Stok_Birim = txtbirim.Text;
                Stok.Stok_Grup_ID = GrupID;
                Stok.Stok_Kodu = txtstokkodu.Text;
                Stok.Stok_Resim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.Stok_Satis_Fiyat = decimal.Parse(txtsatisfiyat.Text);
                Stok.Stok_Satis_KDV = decimal.Parse(txtsatiskdv.Text);
                Stok.Stok_Save_Date = DateTime.Now;
                Stok.Stok_Save_User = AnaForm.UserID;
                DB.TBL_Stoklars.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni kayıt oluşturuldu.");
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
                Fonksiyonlar.TBL_Stoklar Stok = DB.TBL_Stoklars. First(s=> s.ID==StokID);
                Stok.Stok_Adi = txtstokadi.Text;
                Stok.Stok_Alis_Fiyat = decimal.Parse(txtalisfiyat.Text);
                Stok.Stok_Alis_KDV = decimal.Parse(txtaliskdv.Text);
                Stok.Stok_Barkod = txtbarkod.Text;
                Stok.Stok_Birim = txtbirim.Text;
                Stok.Stok_Grup_ID = GrupID;
                Stok.Stok_Kodu = txtstokkodu.Text;
                if(Resim)Stok.Stok_Resim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.Stok_Satis_Fiyat = decimal.Parse(txtsatisfiyat.Text);
                Stok.Stok_Satis_KDV = decimal.Parse(txtsatiskdv.Text);
                Stok.Stok_Edit_Date = DateTime.Now;
                Stok.Stok_Edit_User = AnaForm.UserID;
       
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void sil()
        {
            try
            {
               DB.TBL_Stoklars.DeleteOnSubmit (DB.TBL_Stoklars.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtgrupadi.Text = DB.TBL_Stok_Gruplarıs.First(s => s.ID == GrupID).Grup_Adi;
            txtgrupkodu.Text= DB.TBL_Stok_Gruplarıs.First(s => s.ID == GrupID).Grup_Kodu;

        }

        private void txtstokkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);              
            }
            AnaForm.Aktarma = -1;
        }

        private void txtgrupkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.StokGrupları(true);
            if(Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.sil() == DialogResult.Yes) sil();           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(Edit && StokID > 0 && Mesajlar.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();   
            }
        }
    }
}