using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Daugybos lentele");
    Calculus();
  }


  public static void Calculus()
  {
    int sk1 = 0;
    string aValue;

    Console.WriteLine("Iveskite skaiciu:");

    aValue = Console.ReadLine();

    if (CheckEnteredValue(aValue))
    {
      sk1 = int.Parse(aValue);


      for (int i = 1; i < 11; i++)
      {
        Console.WriteLine(sk1 + " * " + i + " = " + sk1 * i);
      }

      Console.WriteLine("");
      Calculus();
    }
    else
    {
      Console.WriteLine("Ivedete bloga reiksme:");
      Console.WriteLine("");
      Calculus();
    }
  }

  static bool CheckEnteredValue(string aValue)
  {
    int a = 0;
    bool aBoolean;

    if (String.IsNullOrEmpty(aValue))
    {
      return false;
    }
    else
    {
      aBoolean = int.TryParse(aValue, out a);
      //Console.WriteLine(a);	
      return aBoolean;

    }

  }
}