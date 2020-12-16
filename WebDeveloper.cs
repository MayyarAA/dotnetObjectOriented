

using System;

public class WebDeveloper: Developer,SelfDeveloping{
    public WebDeveloper (string _mainDevLanguage) : base( _mainDevLanguage){


    }

    public void Develop(){
        Console.WriteLine("developing code");
    }



}
