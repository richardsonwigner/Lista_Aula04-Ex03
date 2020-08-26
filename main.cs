using System;

class MainClass {

  public static string NomeV(int c1,int c2,int c3){
  string Nome;
   Nome = "José Couve" ;
    if(c2 > c1 && c2 > c3){
      Nome ="Joana Bravo" ;}
    else if(c3 > c1 && c3 > c2){
      Nome = "Roberto Nove";}
   return Nome;      
  }

  public static int Comparador(int c1,int c2,int c3){
    int maior;
    maior = c1;
    if(c2 > c1 && c2 > c3){
      maior = c2;}
    else if(c3 > c1 && c3 > c2){
      maior = c3;}
    else if(c1 == c2 || c1 == c3 || c2 == c3){
      maior = -1;}
   return maior;      
  }
  public static void Main (string[] args) {
    Console.WriteLine ("33 - José Couve");
    Console.WriteLine ("25 - Joana Bravo");
    Console.WriteLine ("10 - Roberto Nove");
    Console.WriteLine ("0 - Voto branco");
    Console.WriteLine ("4 - Voto nulo");
    int i = 0;
    int c1 = 0;
    int c2 = 0;
    int c3 = 0;
    int branco = 0;
    int nulo = 0;
    int Voto = 0;
    int Resultado = 0;
    string NomeVencedor;
    int maior = 0;
    do 
    {
      Console.WriteLine(" Escolha seu voto");
      Voto = int.Parse(Console.ReadLine());
      if(Voto == 33){
        c1 = c1 + 1;}
      else if(Voto == 25){
        c2 = c2 + 1;}
      else if(Voto == 10){
        c3 = c3 + 1;}
      else if(Voto == 0){
        branco = branco + 1;}
      else if(Voto == 4){
        nulo = nulo + 1;}
      else{
        Console.WriteLine("Código invalido ");  
      }
       i++;
    } while(i<= 5); 

    Resultado = Comparador(c1,c2,c3);
    NomeVencedor = NomeV(c1,c2,c3);
    if (Resultado != -1){
    Console.WriteLine("{0} com um total de {1}  votos",NomeVencedor,Resultado);
    Console.WriteLine("Total De Votos brancos {0}",branco);
    Console.WriteLine("Total De Votos Nulos{0}",nulo);
    }
    else{
      Console.WriteLine("Empate"); }
  }

}