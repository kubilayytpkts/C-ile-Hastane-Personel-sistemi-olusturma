using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanePersonelKayıtSistemi
{
    public partial class Uygulama : Form
    {
        public Uygulama(PersonelBilgileri Data)
        {
            InitializeComponent();
            uygulamaisim.Text = Data.isim;
            uygulamasoyisim.Text = Data.soyisim;
            uygulamakullanıcıadı.Text = Data.KullanıcıAdı;
            uygulamaid.Text = Data.Personelİd;
            uygulamaşifre.Text = Data.şifre;
            uygulamagörev.Text = Data.Görev;
            uygulamahaftalıkgörev.Text = Data.HaftalıkGörevListesi;
            btngüncelleme.Tag = Data.Personelİd;

        }

        private void Uygulama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = (string)btngüncelleme.Tag;
          int index=  PersonelDatabase.PersonelBilgileriDB.FindIndex(i => i.Personelİd == id);
            PersonelDatabase.PersonelBilgileriDB[index].şifre = uygulamaşifre.Text;
            PersonelDatabase.PersonelBilgileriDB[index].KullanıcıAdı = uygulamakullanıcıadı.Text;
            PersonelDatabase.PersonelBilgileriDB[index].HaftalıkGörevListesi = uygulamahaftalıkgörev.Text;
        }
    }
}
