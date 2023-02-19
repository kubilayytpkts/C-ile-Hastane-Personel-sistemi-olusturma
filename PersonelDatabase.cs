using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastanePersonelKayıtSistemi
{
    public class PersonelDatabase
    {
       public static List<PersonelBilgileri> PersonelBilgileriDB = new List<PersonelBilgileri>();

         static PersonelDatabase()
        {
            PersonelBilgileriDB.Add(new PersonelBilgileri() 
            { 
                Personelİd="3334455",
                isim="Kubilay",
                soyisim="Topaktaş",
                KullanıcıAdı= "kubilay",
                şifre="3334455",
                Görev="Bilgiİşlemleri",
                HaftalıkGörevListesi= "DatabaseTemizliği,kullanıcı Kontrolleri, Sisteme yeni katılan kişilere IP numarası vermek,kayıt yapmak",

            });

            PersonelBilgileriDB.Add(new PersonelBilgileri()
            {
                Personelİd = "5556545",
                isim = "Ahmet",
                soyisim = "Topaktaş",
                KullanıcıAdı = "Ahmet",
                şifre = "*",
                Görev = "Hemşir",
                HaftalıkGörevListesi = "tedavi planını uygular, tedavinin gidişatını değerlendirir, hastayı fizik muayeneden geçirir, hastayı takip eder, acil durumlara müdahale eder ve hastanın tıbbi bakımı",

            });
            PersonelBilgileriDB.Add(new PersonelBilgileri()
            {
                Personelİd = "2558795",
                isim = "Kürşat",
                soyisim = "Topaktaş",
                KullanıcıAdı = "_Kürşattpktss",
                şifre = "2558795",
                Görev = "Aile Hekimi",
                HaftalıkGörevListesi = " kişilerin sağlık durumlarını inceleyen, tedavi eden ve hastalıkların gelişmesini önlemek için düzenli sağlık taramaları",

            });
        }

    }
}
