using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count); //näitab elementide arvu ehk listi pikkust

            myWishList.Add("coffee machine");
            myWishList.Add("a new pair of socks");
            myWishList.Add("box of chocolates");
            myWishList.Add("new pillow"); //listi sisu

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish); //hea kuvada iga elementi, mis on listi lisatud
            }
        }
    }
}
