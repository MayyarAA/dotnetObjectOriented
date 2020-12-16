using System;

public class CarSalesman : Salesman
{
   
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }

    

    //Dynamic polymorphism method overriding at the class level
    public override void Sell()
    {
      Console.WriteLine(this.FullName);
       this.CloseSale();
        this.Engage();
    }

    
//Encapsulation
    protected override void CloseSale()
    {
         Console.WriteLine("Hello we are closing the sale");
    }

    protected override void Engage()
    {
         Console.WriteLine("hello we are engagining the custome renga");
}

}