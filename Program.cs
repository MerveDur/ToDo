// See https://aka.ms/new-console-template for more information

using System.Collections;
#nullable disable // String null olabilir uyarısı engelleme

namespace HelloWorld
{
    class Menu
    {
        public void getMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Çıkış Yapmak");
        }
    }
}