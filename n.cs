using System;

namespace Laboratory {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите действительное число (a):");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите степень для числа (n):");
      int n = int.Parse(Console.ReadLine());

      if (a < 1) {
        Console.WriteLine("Ошибка. Число (a) не является действительным числом.");
        Environment.Exit(0); 
      }
      double result = 1; 
      
      for (int multyplyindex = 0; multyplyindex < n; ++multyplyindex) { 
        result *= a;
      }
      
      Console.WriteLine("a^n = " + result);
      Console.ReadKey();
    }
  }
}
