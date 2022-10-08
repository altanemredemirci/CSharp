using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tek satır açıklama yazmaya yarar.

            /*
            Birden fazla satır açıklama yazılabilir.
            Comment(Yorum) satırlar derleyici(compiler)-Visual Studio tarafından kontrol edilmez.
            Comment yazmaktaki amacımız kendimize veya başka yazılımcılara not bırakmaktır.
            */

            /*
            Solution Explorer => Projeleri ve dosyalarını listeler.
                                 View -> Solution Explorer açabilirsiniz.

            Proje Açma => New Project => Console App(C# .Net Framework olmasına dikkat ediyoruz.)
            Solution => Birden fazla projeyi altında barındırabilen yapıdır.
                        Kapsadığı projelerin birbirlerini tanımasını ve senkronize olarak iletişim kurmasını sağlar.


            .NET FRAMEWORK NEDİR?
                .Net microsoft firmasına ait yazılımların yazılabildiği kontrol(yazım kuralları) edildiği bir yapıdır.
                .NET Framework ise Microsoft firmasına ait bütün dillerin ve yapıların birlikte geliştirilebilceği ve çalıştırılabileceği bir platformdur.
                        C#      => Console ve Masaüstü
                        MSSQL   => Veritabanı yazılımı
                        ASP.NET => Web Yazılım
                        Unity   => Oyun Programlama
                        Azure   => Bulut Tabanlı Veri Tabanı
                        Xamarin => Mobil Yazılım
                        Web Service 




            Algoritma: Bir sorunu çözmek veya belirlenmiş bir hedefe ulaşmak için gerçekleştirilen işlemin işlem adımlarıdır.
            Amaca ulaşmak için işlenecek yolları ve sıralamalarını belirli bir mantıkla takip etmemezi sağlar.

            Giriş/Çıkış Bilgisi: Program başlangıcında verilecek değerleri veya kullanıcıdan dışarıdan alınacak değerlerin  neler    olduğu ve işlemler sonucunda ne çıktısı alınacağının belirtilmiş olması gereklidir.

            Sonluluk: Her türlü olasılık bir sonuca ulaşmalıdır.Ucu açık bir durum kalmamalıdır. 

            Kesinlik: Her komutun(işlem) net bir şekilde yapacağı iş belirtilmelidir.

            Etkinlik: Yazılan algoritmalar etkin ve dolasıyla gereksiz tekrarlandan kaçınmalıdır. Algoritma genellenebilir ve modüler olmalıdır. 

            Başarı ve Performans: Amaça ulaşılmalı ve algoritma paradan,zamandan ve performanstan kazanç sağlamalıdır.
            */

            /*
             EVDE ÇAY DEMLEME
            1-Mutfağa Git
            2-Çaydanlığa Su Koy
            3-Ocağı Yak
            4-Su Kaynadı Mı? H->5 E->6
            5-Bekle ->4
            6-Demliğe Çay Koy
            7-Çay Demlendi Mi? E->9 H->8
            8-Bekle->7
            9-Servis Et
            10-Bitti


            **SU YOK
            **ÇAY YOK
            **BAKKAL KAPALI
            *
            
            1-Mutfağa Git
            2-Su ve Çay Var Mı? E->9
            3-Bakkala Git
            4-Bakkal Açık Mı? E->6
            5-Başka Bakkala Git ->4
            6-Eksikleri Al
            7-Eve Dön
            8-Mutfağa Git
            9-Çaydanlığa Su Koy
            10-Ocağı Yak
            11-Su Kaynadı Mı? E->13
            12-Bekle ->11
            13-Demliğe Çay Koy
            14-Çay Demlendi Mi? E->16
            15-Bekle ->14
            16-Servis Et
            17-Bitti

             */
            /*
            **EVDEN AKADEMİYE GELİŞ ALGORİTMASI
            1-Başla
            2-Asansör mü? Merdiven mi?(A/M) A->3 M->9 
            3-Asansör katta mı? E->5
            4-Asansör çağır ->3
            5-Asansöre bin istenilen kat tuşuna bas
            6-Asansör bin istenilen kat katta mı? E->8
            7-Bekle ->6
            8-Asansörden in ->11
            9-Bir kat hareket et
            10-bin istenilen katta mıyız? H->9
            11-Binadan Çık
            12-Akbil dolu mu? E->14
            13-Büfeye Git Akbil doldur.
            14-Durağa Git
            15-Toplu Taşıma Geldi mi? E->17
            16-Bekle -> 15
            17-Akbil Bas
            18-Boş yer varmı? H->20 
            19-Otur ->21
            20-Ayakta Git
            21-İnilecek Durağa Geldik mi? E->23
            22-Bekle ->21
            23-Toplu Taşımadan in
            24-Akademiye Yürü
            25-Bitti

            */


            Console.WriteLine("drftghjulş");
        }
    }
}
