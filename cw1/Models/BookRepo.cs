using System;

namespace cw1.Models;

public class BookRepo
{
        public static List<Book>GetBooks(){
        return new List<Book>{
            new Book{Id=1,Autor="Tomasz",Title="Problem",PricePl=56.24f},
            new Book{Id=2,Autor="Andrzej",Title="Depresja",PricePl=56.24f},
            new Book{Id=3,Autor="Kamil",Title="Zabawa",PricePl=56.24f},
            new Book{Id=4,Autor="Justyna",Title="Smiech",PricePl=45.23f},

        };
    }
}


