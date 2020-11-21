using System;

class MainClass {
  public static void Main (string[] args) {
    int a = int.Parse(Console.ReadLine());
    for(int j =0; j <a;j++ ){
              for(int i=0; i<a;i++ ){
        int b = (a-1)/2;
        if(i==a || j==b || j==a || i==b)
          Console.Write("#");
        else 
          Console.Write(" ");
      }
      Console.WriteLine();
    }
  }
}