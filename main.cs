using System;
/*Construa um programa que leia a quantidade (QT) e o preço (PR) de 45 produtos diferentes, comprados por uma empresa, e apresente o total gasto por ela. */
class Program {
  public static void Main (string[] args) {
    string op, op1;
    double  qt=0, pr=0,vp=0;
    do 
    {
      vp=0;
     do
      {
        
        Console.WriteLine("╔══════════════════════════════╗ ");
        Console.WriteLine("║Iniciar compra de 45 produtos?║");
        Console.WriteLine("║      digite: S ou N          ║");
        Console.WriteLine("╚══════════════════════════════╝ ");
       op = Console.ReadLine().ToUpper(); 
  
        switch(op)
        {
          case "S":
            for(int i=1; i<=5; i++)
      {
        do{
           Console.Write ("quantidade do {0}º produto: ",i);
           qt=double.Parse(Console.ReadLine());
        }while(qt<=0);
        
        do{
          Console.Write("preço do {0}º produto: R$ ",i); 
         pr=double.Parse(Console.ReadLine());
        }while(pr<=0);
        
        vp=vp+(qt*pr);
            }
   
    Console.WriteLine("valor total da compra : R$ {0}",vp);
           
          break;
          case "N":
           break;
          default:
            Console.WriteLine("Opção Inválida!!!");
          break;
        }
      }while(op!="S" && op!="N");
        Console.WriteLine("╔══════════════════════════════╗ ");
        Console.WriteLine("║  Deseja iniciar nova compra ?║");
        Console.WriteLine("║      digite: S ou N          ║");
        Console.WriteLine("╚══════════════════════════════╝ ");
       op1 = Console.ReadLine().ToUpper(); 
    }while(op1=="S");
    if (op1!="S")
      Console.Write("FIM");
   }
  }

        
