using System;
public abstract class Developer
{
    private string _mainDevLanguage;

    public Developer(string _mainDevLanguage){
        this._mainDevLanguage = _mainDevLanguage;
    }

//static polymorphism
//method overloading
public virtual void Code(){
    Console.WriteLine(this._mainDevLanguage);
}
    public virtual void Code(string mainlan, string seconlan){
    Console.WriteLine(mainlan);
     Console.WriteLine(seconlan);
}
public virtual void Code(string mainlan, string seconlan, string thrirdlan){
   Console.WriteLine(mainlan);
     Console.WriteLine(seconlan);
     Console.WriteLine(thrirdlan);
    
}

    
} 