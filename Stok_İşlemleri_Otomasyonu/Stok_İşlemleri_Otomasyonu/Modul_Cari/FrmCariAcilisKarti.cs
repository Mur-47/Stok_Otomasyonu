using DevExpress.XtraEditors;
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
    public partial class FrmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar= new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara(); 

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public FrmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtcarikodu.Text = Numaralar.CariKodNumarasi();

        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
           
            Edit=false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Cariler Cari = new Fonksiyonlar.TBL_Cariler();
                Cari.ADRES = txtadres.Text;
                Cari.CARIADI = txtcariadi.Text;
                Cari.CARIKODU = txtcarikodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtilce.Text;
                Cari.SEHIR = txtsehir.Text;
                Cari.MAILBILGI = txtmailbilgisi.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                Cari.TELEFON1 = txttelefon1.Text;
                Cari.TELEFON2 = txttelefon2.Text;
                Cari.ULKE = txtulke.Text;
                Cari.VERGIDAIRESI = txtvergidairesi.Text;
                Cari.VERGINO = txtvergino.Text;
                Cari.WEBADRES = txtwebadres.Text;
                Cari.YETKILI1 = txtyetkili1.Text;
                Cari.YETKILI2 = txtyetkili2.Text;
                Cari.YETKILIMAIL1 = txtyetkilimail1.Text;
                Cari.YETKILIMAIL2 = txtyetkilimail2.Text;
                DB.TBL_Carilers.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_Cariler Cari = DB.TBL_Carilers.First(s=> s.ID==CariID);
                Cari.ADRES = txtadres.Text;
                Cari.CARIADI = txtcariadi.Text;
                Cari.CARIKODU = txtcarikodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtilce.Text;
                Cari.SEHIR = txtsehir.Text;
                Cari.MAILBILGI = txtmailbilgisi.Text;
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
                Cari.TELEFON1 = txttelefon1.Text;
                Cari.TELEFON2 = txttelefon2.Text;
                Cari.ULKE = txtulke.Text;
                Cari.VERGIDAIRESI = txtvergidairesi.Text;
                Cari.VERGINO = txtvergino.Text;
                Cari.WEBADRES = txtwebadres.Text;
                Cari.YETKILI1 = txtyetkili1.Text;
                Cari.YETKILI2 = txtyetkili2.Text;
                Cari.YETKILIMAIL1 = txtyetkilimail1.Text;
                Cari.YETKILIMAIL2 = txtyetkilimail2.Text;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
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
                DB.TBL_Carilers.DeleteOnSubmit(DB.TBL_Carilers.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);

            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit=true;
                CariID = ID;
                Fonksiyonlar.TBL_Cariler Cari = DB.TBL_Carilers.First(s=> s.ID==CariID);
                txtadres.Text = Cari.ADRES;
                txtcariadi.Text= Cari.CARIADI;
                txtcarikodu.Text = Cari.CARIKODU;
                txtfax1.Text = Cari.FAX1;
                txtfax2.Text = Cari.FAX2;
                txtilce.Text= Cari.ILCE;
                txtsehir.Text = Cari.SEHIR;
                txtmailbilgisi.Text=Cari.MAILBILGI;
                txttelefon1.Text = Cari.TELEFON1;
                txttelefon2.Text = Cari.TELEFON2;
                txtulke.Text = Cari.ULKE;
                txtvergidairesi.Text = Cari.VERGIDAIRESI;
                txtvergino.Text = Cari.VERGINO;
                txtwebadres.Text = Cari.WEBADRES;
                txtyetkili1.Text = Cari.YETKILI1;
                txtyetkili2.Text = Cari.YETKILI2;
                txtyetkilimail1.Text = Cari.YETKILIMAIL1;
                txtyetkilimail2.Text = Cari.YETKILIMAIL2;
                GrupAc(Cari.GRUPID.Value);

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int  ID)
        {
            try
            {
                GrupID =ID;
                Fonksiyonlar.TBL_CariGruplari Grup = DB.TBL_CariGruplaris.First(s => s.ID == GrupID);
                txtgrupadi.Text = Grup.GRUPADI;
                txtgrupkodu.Text = Grup.GRUPKODU;

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.sil() == DialogResult.Yes) Sil();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtgrupkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);

            }
            AnaForm.Aktarma = -1;
             
        }

        private void txtcarikodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }
    }
}