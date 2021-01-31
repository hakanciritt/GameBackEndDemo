using System;

namespace GameBackEndDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

            //4.Satışlarda kampanya entegrasyonunu simule ediniz.

            GamerManager manager = new GamerManager ( new UserValidationManager() );
            manager.Add(new Gamer { FirstName = "hakan", LastName = "cirit", IdentityNumber = "1234567890" });


            Console.ReadKey();
        }
    }
}
