using Business.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD -> O harfi Open closed prenciple
    //yaptığım yazılıma yeni bir özellik ekliyorsam mevcuttaki hiç bir koduna dokunamazsın
    //bizde oyle yaptık inMemory duruyor fakat entitiyframework ekleyip Plug and play(tak ve çalıştır) ile çalıştırdık
    class program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }



        }
    }
}