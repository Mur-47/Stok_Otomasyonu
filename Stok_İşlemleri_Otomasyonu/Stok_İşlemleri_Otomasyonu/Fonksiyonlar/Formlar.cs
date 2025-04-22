using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_İşlemleri_Otomasyonu.Fonksiyonlar
{
    internal class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool Secim = false)
        {
            ModulStok.FrmStokListesi frm = new ModulStok.FrmStokListesi();
            if (Secim)
            {
                frm.secim = Secim;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
            return AnaForm.Aktarma;


        }

        public int StokGrupları(bool Secim = false)
        {
            ModulStok.FrmStokGrupları frm = new ModulStok.FrmStokGrupları();
            if (Secim) frm.secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }

        public void StokKarti(bool Ac = false)
        {
            ModulStok.FrmStokKarti frm = new ModulStok.FrmStokKarti();


            frm.ShowDialog();

        }
        #endregion

        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.FrmCariGruplari frm = new Modul_Cari.FrmCariGruplari();
            if(Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;

        }

        public int CariListesi(bool secim = false) 
        {
            Modul_Cari.FrmCariListesi frm = new Modul_Cari.FrmCariListesi();
            if (secim)
            {
                frm.Secim = secim;  
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;

        }
       
    }
}
