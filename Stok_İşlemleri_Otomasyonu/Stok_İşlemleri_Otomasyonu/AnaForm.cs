using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_İşlemleri_Otomasyonu
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static int UserID = -1;  
        public static int Aktarma = -1;  
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void barbtnstokkarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barbtnstoklistesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barbtnstokgruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGrupları();
        }

        private void barbutonstokhareketlei_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barbtncariaciliskarti_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barbtncarigruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void barbtncarilistesi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barbtncarihareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}