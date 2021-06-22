using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a C# program to manage a photo book using object-oriented programming.

//To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

//The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

//There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

//Finally create a PhotoBookTest class to perform the following actions:

//Create a default photo book and show the number of pages
//Create a photo book with 24 pages and show the number of pages
//Create a large photo book and show the number of pages

namespace C_sharp_oefenen_console
{
    class Photobook
    {
        protected int NumPages;
        public Photobook()
        {
            NumPages = 16;
        }
        public void GetNumberPages(int numpages)
        {
            NumPages = numpages;
        }

        public void PrintPages()
        {
            Console.WriteLine(NumPages);
        }
    }
    class BigPhotobook : Photobook
    {
        public BigPhotobook()
        {
            NumPages = 64;
        }
    }
}
