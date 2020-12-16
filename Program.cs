using System;
using System.Collections.Generic;
namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            CarSalesman steve = new CarSalesman("Steve", "Rogers");
            // Console.WriteLine(steve.FullName);
            steve.Sell();
        
        
         RetailSalesPerson jon = new RetailSalesPerson("jon", "bon");
         
            jon.Sell();

            //Dynamic polymorphism 
             List<Salesman> salelist = new List<Salesman>(){new CarSalesman("bon", "Rogers") , new RetailSalesPerson("kon", "saa")};

            WebDeveloper Roan = new WebDeveloper("java");
            Roan.Code();
            Roan.Code("javascript", "thirsdal");
            Roan.Develop();
            foreach (var item in salelist)
            {
                 ShowMeSell(item);
            }
           
      


           
            static void ShowMeSell(Salesman sale){
                sale.Sell();
            }
        }
    }
}
