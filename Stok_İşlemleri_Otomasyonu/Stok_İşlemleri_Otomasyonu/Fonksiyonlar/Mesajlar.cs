using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_İşlemleri_Otomasyonu.Fonksiyonlar
{
    internal class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıt kalıcı olarak GÜNCELENECEKTİR!\n Güncelleme işlemini onaylıyormusunuz?", "Güncelleme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        public DialogResult sil()
        {
            return MessageBox.Show("Seçili olan kayıt kalıcı olarak SİLİNECEKTİR.\n Seçimi onaylıyormusunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void sil(bool sil)
        {
            MessageBox.Show("Kayıt silinmiştir.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Guncelle(bool Guncelle)
        {
            MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

            
    }
}
