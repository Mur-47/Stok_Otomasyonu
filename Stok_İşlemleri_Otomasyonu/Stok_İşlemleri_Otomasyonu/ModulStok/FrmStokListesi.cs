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
    public partial class FrmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool secim = false;
        int SecimID = -1;
        public FrmStokListesi()
        {
            InitializeComponent();
        }

        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            listele();

        }

        void listele() 
        {
            var lst = from s in DB.TBL_Stoklars
                      where s.Stok_Adi.Contains(txtstokadi.Text)&&  s.Stok_Barkod.Contains(txtbarkod.Text)&& s.Stok_Kodu.Contains(txtstokkodu.Text)
                    select s;
            Liste1.DataSource = lst;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            txtbarkod.Text = "";
            txtstokadi.Text = "";
            txtstokkodu.Text = "";
        }

        void sec()
        {
            try
            {
                SecimID = int.Parse(Grd1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }
        private void Grd1_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if (secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Liste1_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if (secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}