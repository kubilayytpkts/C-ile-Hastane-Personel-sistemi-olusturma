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
    public partial class PersonelGirişSistemi : Form
    {
        public PersonelGirişSistemi()
        {
            InitializeComponent();
        }

        private void PersonelGirişSistemi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanıcıad = girişKullanıcıadı.Text;
            string şifre = girişşifre.Text;
            string Personelİd = girişpersonelid.Text;

            PersonelBilgileri Data = PersonelDatabase.PersonelBilgileriDB.Find(i => i.KullanıcıAdı == Kullanıcıad
            && i.şifre == şifre && i.Personelİd == Personelİd);
            if(Data!=null)
            {
                Uygulama _uygulama = new Uygulama(Data);
                _uygulama.Show();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı,Bilgilerinize erişemiyorsanız lütfen hastane yönetimi ile iletişime geçiniz..", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
