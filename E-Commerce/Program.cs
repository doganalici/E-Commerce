using System;

namespace E_Commerce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni bir product nesnesi oluşturuldu ve daha sonrasında class içerisindeki ürün bilgilerinin içerisine açıklamalar yapıldı
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category = "Clothes";
            product1.ProductName = "Jumper";
            product1.Price = 200;
            product1.UnitInStock = 11;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Category = "Clothes";
            product2.ProductName = "Jeans";
            product2.Price = 150;
            product2.UnitInStock = 8;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Category = "Accessory";
            product3.ProductName = "Bag";
            product3.Price = 350;
            product3.UnitInStock = 4;

            Product product4 = new Product();
            product4.Id = 4;
            product4.Category = "Accessory";
            product4.ProductName = "Slipper";
            product4.Price = 70;
            product4.UnitInStock = 18;

            Product product5 = new Product();
            product5.Id = 5;
            product5.Category = "Accessory";
            product5.ProductName = "Sunglasses";
            product5.Price = 1800;
            product5.UnitInStock = 5;

            Product product6 = new Product();
            product6.Id = 6;
            product6.Category = "Personel Care";
            product6.ProductName = "Toothbrush";
            product6.Price = 480;
            product6.UnitInStock = 2;

            //Girilen bütün product nesnelerinin tek seferde gezilebilmesi için array metodu ile tanımlandı
            Product[] products = new Product[] { product1, product2, product3, product4, product5, product6 };

            //İlk önce for döngüsü ile bütün ürün bilgileri yazdırıldı
            Console.WriteLine("***** FOR LOOPS ******\n");

            //i 0 dan başlayarak ürünlerin length'i yani uzunluğu kadar olacak şekilde döngü tanımı yapıldı
            for (int i = 0; i < products.Length; i++)
            {
                //products[i] şeklinde oluşturduğumuz array sınıfının içinde gezindik ve daha sonra ürünün hangi bilgisini yazdırmak istediğimizi seçtik
                Console.WriteLine($"Id : {products[i].Id}\n" +
                                  $"Category : {products[i].Category}\n" +
                                  $"Name : {products[i].ProductName}\n" +
                                  $"Price : {products[i].Price}\n" +
                                  $"Unit in stock : {products[i].UnitInStock}\n\n");
            }

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n***** FOREACH LOOPS ******\n");

            foreach (var product in products)
            {
                //Productsların hepsini product adı altına topladık ve bütün özelliklerini yazdırdık
                Console.WriteLine($"Id : {product.Id}\n" +
                                  $"Category : {product.Category}\n" +
                                  $"Name : {product.ProductName}\n" +
                                  $"Price : {product.Price}\n" +
                                  $"Unit in stock : {product.UnitInStock}\n\n");
            }

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n***** WHİLE LOOPS ******\n");

            //önce bir değişken tanımlaması yaparak sonsuz döngüye girmemesi için products.length kadar gezinmesini sağladık
            int j = 0;
            while (j < products.Length)
            {
                //j, dizi uzunluğundan küçük olduğu sürece ürün bilgilerini ekrana yazdırdık
                Console.WriteLine($"Id : {products[j].Id}\n" +
                                  $"Category : {products[j].Category}\n" +
                                  $"Name : {products[j].ProductName}\n" +
                                  $"Price : {products[j].Price}\n" +
                                  $"Unit in stock : {products[j].UnitInStock}\n\n");
                j++;
            }
            Console.ReadKey();
        }
    }
}
