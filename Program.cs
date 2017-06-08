using System;
namespace venky
{
  
  class student
  {
    public int id;
  }
 
  
  
  class venky1
  {
    static void Main()
    {
      
      student a=new student();
      Console.WriteLine(a.id);
      a.id=1522;
      Console.WriteLine(a.id);
      a=new student();
      Console.WriteLine(a.id);
      
      student y= new student();
      Console.WriteLine(y.id);
      y.id=123;
     Console.WriteLine(y.id);
      kabali x=new kabali();
      y=x.outparameter( y);
     Console.WriteLine(y.id);
      Console.ReadLine();
    }
    
    class kabali{
    public student outparameter( student b)
    {
      b=new student();
      Console.WriteLine(b.id);
      return(b);
    }
    }
    
  }
  
  
}