using System;

namespace sınıf_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
        //    söz dizimi
        //    class sinifadi
        //    {
        //        [erişim belirleyici] [veri tipi] özellikadi;
        //        [erişim belirleyici][ geri dönüş tipi] Mettotadı([parametre listesi])
        //        {
        //            //metot komutları
        //        }
        //    }
        //erişim belirleyiciler
        //* public
        //* private
        //* internal-sadece olduğu proje içerisinde erişilebilir
        //* protected- sadece tanımlandıı sınıf veya sınıftan kalıtım alan diğer sınıflarda kullanılabilir
        Calisan calisan1 = new Calisan();
        calisan1.ad="ayşe";
        calisan1.soyad="yılmaz";
        calisan1.no=1;
        calisan1.departman="insan kaynakları";

        calisan1.calısanBilgileri();
        Console.WriteLine("***********");

        Calisan calisan2 = new Calisan();
        calisan2.ad= "deniz";
        calisan2.soyad="arda";
        calisan2.no=12;
        calisan2.departman="teknik ekip";

        calisan2.calısanBilgileri();

        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void calısanBilgileri()
        {
            Console.WriteLine("çalışan Adı:{0}", ad);
            Console.WriteLine("çalışan Soyadı:{0}",soyad);
            Console.WriteLine("çalışan numarası:{0}", no);
            Console.WriteLine("çalışan departmanı:{0}", departman);
        }
    }
}
