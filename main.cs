using System;

class Program {
  public static void Main (string[] args) {
    
    int x = 30;
    int y = 2;

    int soma = x + y;
    int sub  = x - y;
    int div = x / y;
    int mult = x * y;
    int mod = x % y;
    int incremento = x++;
    int diminuicao = y--;

    Console.WriteLine($"Os dados são X= {x} e Y= {y}");
    Console.WriteLine ("\n a soma de X e Y resulta em: " + soma);
    Console.WriteLine ("\n a subtração de X e Y resulta em : " + sub);
    Console.WriteLine ("\n a divisão de X e Y resulta em: " + div);
    Console.WriteLine ("\n a multiplicação de X e Y resulta em: " + mult);
    Console.WriteLine ("\n o módulo de X e Y resulta em: " + mod);
    Console.WriteLine ("\n O x++ é: " + incremento) ;
    Console.WriteLine ("\n O Y++ é: " + diminuicao + "\n");
    Console.WriteLine("-----------------------------------------------");

    int z = 5;
    Console.WriteLine($"\n Agora, dado Z = {z}, temos: ");
    Console.WriteLine($"\n Z += 3 -> resulta em: {z += 3}");
    Console.WriteLine($"\n Z -= 4 -> resulta em: {z -= 4}");
    Console.WriteLine($"\n Z *= 5 -> resulta em: {z *= 5}");
    Console.WriteLine($"\n Z /= 2 -> resulta em: {z /= 2}");
    Console.WriteLine($"\n z %= 3 -> resulta em: {z %= 3}");
    Console.WriteLine($"\n z &= 3 -> resulta em: {z &= 3}");
    Console.WriteLine("-----------------------------------------------");

    bool a = true;
    bool b = false;

    Console.WriteLine($"\n Agora temos A = {a} e B = {b}");
    Console.WriteLine($"\n a &= b -> resulta em: {a &= b}");
    Console.WriteLine($"\n a |= b -> resulta em: {a |= b}");
    Console.WriteLine("-----------------------------------------------");

    Console.WriteLine($"\nUsando novamente as variaveis x = {x} e y = {y}:");
    Console.WriteLine($"\n X < Y -> {x < y}");
    Console.WriteLine($"\n X > Y -> {x > y}");
    Console.WriteLine($"\n X == Y -> {x == y}");
    Console.WriteLine($"\n X >= Y -> {x >= y}");
    Console.WriteLine($"\n X <= Y -> {x <= y}");
    Console.WriteLine($"\n X != Y -> {x != y}");
    Console.WriteLine("-----------------------------------------------");


    
  
  }
}