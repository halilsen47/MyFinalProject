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
            ProductTest();

            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}