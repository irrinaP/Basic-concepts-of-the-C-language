using System;

namespace Laboratory {
  class Program {
    static void Main(string[] args) {
      
      Console.WriteLine("Введите действительное число (x):");

      int x = int.Parse(Console.ReadLine());
      int workX = x;

      do
      {
          workX = workX / 10;

          if (workX < 100)
          {
              do
              {
                  workX = workX - 10;


              }
              while (workX > 10);
          }
      }
      while (workX > 100);

      int n = int.Parse(x.ToString().Remove(1, 1) + workX); 

      Console.WriteLine("Результат: " + n); 
    }
  }
}
  
