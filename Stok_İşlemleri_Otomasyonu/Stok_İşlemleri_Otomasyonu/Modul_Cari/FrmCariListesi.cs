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
    
    public partial class FrmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        int SecimID = -1;

        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {

        }
    }
}