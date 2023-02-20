using System;

public class countVowels
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter String");
      string x=Console.ReadLine();
      int i=0,c=0;
       for(i=0;i<x.Length;i++)
       {
           if(x[i]=='a' ||x[i]=='e' || x[i]=='i' ||x[i]=='o' ||x[i]=='u' ||x[i]=='A' ||x[i]=='E' ||x[i]=='I' ||x[i]=='O' ||x[i]=='U')
           {
               c++;
           }
       }
        Console.WriteLine("No Of Vowels = "+c);
    }
}
