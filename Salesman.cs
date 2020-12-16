using System;
//abstract class example
public abstract class Salesman
{

    private string _firstName;
    private string _lastName;




    public Salesman(string firstName, string lastName){
        this._firstName = firstName;
        this._lastName = lastName;

    }
    public string FullName {
    get{
        return string.Format("{0} {1}", this._firstName, this._lastName);
    }
}

    public abstract void Sell();

    protected abstract void Engage();
     protected abstract void CloseSale();

    
} 