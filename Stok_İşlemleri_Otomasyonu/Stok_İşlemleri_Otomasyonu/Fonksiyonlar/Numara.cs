using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_İşlemleri_Otomasyonu.Fonksiyonlar
{
    internal class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();

        public  string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_Stoklars
                                        orderby s.ID descending
                                        select s).First().Stok_Kodu);
                Numara++;
                string  Num  = Numara.ToString().PadLeft(7,'0');
                return Num;
            }
            catch (Exception )
            {
               
                return "0000001";
            }
        }

        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_Carilers
                                        orderby s.ID descending
                                        select s).First().CARIKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {

                return "0000001";
            }
        }
    }
}
