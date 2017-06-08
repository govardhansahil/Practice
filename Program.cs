using System;
using System.Text;
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
Program.Sumofn();
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
class Program
    {
        public static void Sumofn()
        {
            Console.WriteLine("Enter the first number:");


            string term1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string term2 = Console.ReadLine();



            StringBuilder sum = new StringBuilder();

            int n1 = term1.Length;

            int n2 = term2.Length;

            int carry = 0;

            if (term1[0] != 45 && term2[0] != 45)
            {
                //BOTH POSITIVE
                Console.WriteLine("Length of First number:" + term1.Length);
                Console.WriteLine("Length of Second number:" + term2.Length);

                int n = (n1 > n2) ? n1 : n2;

                if (n1 > n2)

                    term2 = term2.PadLeft(n1, '0');

                else

                    term1 = term1.PadLeft(n2, '0');

                for (int i = n - 1; i >= 0; i--)

                {

                    int value = (carry + term1[i] - 48 + term2[i] - 48) % 10;

                    sum.Append(value);

                    carry = (carry + term1[i] - 48 + term2[i] - 48) / 10;

                }if(carry == 1) sum.Append(carry);

            }


            else if (term1[0] == 45 && term2[0] == 45)
            {
                //BOTH NEGATIVE
                string num1 = "";
                string num2 = "";

                for (int i = term1.Length - 1; i >= 1; i--)
                {
                    num1 = term1[i] + num1;
                }
                for (int i = term2.Length - 1; i >= 1; i--)
                {
                    num2 = term2[i] + num2;
                }
                n1 = num1.Length;
                n2 = num2.Length;
                Console.WriteLine("Length of First NEGATIVE number:" + num1.Length);
                Console.WriteLine("Length of Second NEGATIVE number:" + num2.Length);

                int n = (n1 > n2) ? n1 : n2;

                if (n1 > n2)

                    num2 = num2.PadLeft(n1, '0');

                else

                    num1 = num1.PadLeft(n2, '0');

                for (int i = n - 1; i >= 0; i--)

                {

                    int value = (carry + num1[i] - 48 + num2[i] - 48) % 10;

                    sum.Append(value);

                    carry = (carry + num1[i] - 48 + num2[i] - 48) / 10;

                }if(carry ==1) sum.Append(carry);
                sum.Append("-");
            }
            
            
            
            //final adding to result
            char[] c = sum.ToString().ToCharArray();

            Array.Reverse(c);

            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
  
  
}