using System;

public class RetailSalesPerson: Salesman,SelfDeveloping{
    public RetailSalesPerson (string firstName , string lastName) : base(firstName, lastName){


    }

public override void Sell(){
Console.WriteLine(this.FullName);
this.CloseSale();
this.Engage();
}
//Dynamic polymorphism method overriding at the class level
 public void Develop(){
        Console.WriteLine("developing salestetail");
    }
//encapsulation 
 protected override void CloseSale()
    {
         Console.WriteLine("Hello we are closing the sale retial");
    }

    protected override void Engage()
    {
         Console.WriteLine("hello we are engagining the custome retial");
}


}
