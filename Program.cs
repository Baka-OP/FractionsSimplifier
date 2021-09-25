using System;
using System.Linq;

class Program {
	
  public static void Main (string[] args) 
  {
  	//Input, you can remove this stuff because the Simplify() is important
  	Console.WriteLine("----Balls---- Enter the number: \n");
  	string tobecalculated = Console.ReadLine();
    int[] converted = tobecalculated.Split('/').Select(n => Convert.ToInt32(n)).ToArray();
    Simplify(converted);
    Console.ReadLine();
  }
  //Simplify, takes in an int array, returns simplified thru console :)
  public static void Simplify(int[] numbers)
  {
  	int x = numbers[0];
  	int y = numbers[1];
  	int gcd = 1;
   for(int i = 1; i <= x && i <= y; i++)  
   {  
     if(x%i==0 && y%i==0)   
     gcd = i; 
   }  
    int finalx = x/gcd;
    int finaly = y/gcd;    
    Console.WriteLine(finalx.ToString() + "/" + finaly.ToString());
  }


}