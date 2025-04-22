using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stok_İşlemleri_Otomasyonu.Fonksiyonlar;

namespace Stok_İşlemleri_Otomasyonu.ModulStok
{
    

    public partial class FrmStokGrupları : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesaj =new Fonksiyonlar.Mesajlar(); 
        public bool secim = false;
        int secimID = -1;
        bool Edit =false;

        public FrmStokGrupları()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokGrupları_Load(object sender, EventArgs e)
        {
          listele();
        }
        void listele() 
        {
          var lst = from s in DB.TBL_Stok_Gruplarıs
                    select s;
            Liste.DataSource = lst;
            
        }

        void Temizle() 
        {
            txtgrupkodu.Text = "";
            txtgrupadi.Text = "";  
            listele();
            Edit = false;
        }

        void YeniKaydet() 
        {
            try
            {
                Fonksiyonlar.TBL_Stok_Grupları Grup = new Fonksiyonlar.TBL_Stok_Grupları();
                Grup.Grup_Adi = txtgrupadi.Text;
                Grup.Grup_Kodu = txtgrupkodu.Text;
                Grup.Grup_Save_Date = DateTime.Now;
                Grup.Grup_Save_User = AnaForm.UserID;
                DB.TBL_Stok_Gruplarıs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesaj.YeniKayit("Yeni grup kaydı oluşturuldu");
                Temizle();
               

            }
            catch (Exception e)
            {
                Mesaj.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_Stok_Grupları Grup = DB.TBL_Stok_Gruplarıs.First(s => s.ID == secimID);
                Grup.Grup_Kodu = txtgrupkodu.Text;
                Grup.Grup_Adi = txtgrupadi.Text;
                Grup.Grup_Edit_User = AnaForm.UserID;
                Grup.Grup_Edit_Date = DateTime.Now;
                DB.SubmitChanges();
                Mesaj.Guncelle(true);
                Temizle();
                
            }
            catch (Exception e)
            {
                Mesaj.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_Stok_Gruplarıs.DeleteOnSubmit(DB.TBL_Stok_Gruplarıs.First(s => s.ID == secimID));
                DB.SubmitChanges();

                Temizle();
               Mesaj.sil(true);
                
            }
            catch (Exception e)
            {
                Mesaj.Hata(e); 
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && Mesaj.sil() == DialogResult.Yes) Sil();
            listele();
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && Mesaj.Guncelle()== DialogResult.Yes) Guncelle();
            else YeniKaydet();
            listele();
        }

        void sec()
        {
            try
            {
                Edit = true;
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtgrupadi.Text = gridView1.GetFocusedRowCellValue("Grup_Adi").ToString();
                txtgrupkodu.Text = gridView1.GetFocusedRowCellValue("Grup_Kodu").ToString();
            }
            catch (Exception )
            {
                Edit = false;
                secimID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            sec();  
            if(secim && secimID> 0)
            {
                AnaForm.Aktarma= secimID;
                this.Close();
            }
        }

        private void groupControl2_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if (secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if (secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }

        private void Liste_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtgrupadi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtgrupkodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}