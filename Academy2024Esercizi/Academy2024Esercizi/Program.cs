
//Console.WriteLine("Insert Lato 1: ");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Insert Lato 2: ");
//double b = double.Parse(Console.ReadLine());

//if(a<=0 && b<=0)
//{
//    Console.WriteLine("You have inserted un invalid value. Retry");
//        return;
//}


//double ipotenusa = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//Console.WriteLine($"L'ipotenusa misura {ipotenusa} cm");

/*creare un programma che prende input dall'utente i due lati di un triangolo rettangolo
 e che vada a calcorlare l'ipotenusa tramite il teorema di pitagora:
ipotenusa = sqrt(Lato1*lato1 +lato2*lato2)
stampare il risultato all'utente.


 
i = sqrt(a * a + b * b)
Math.Sqrt
Math.Pow(5, 2);*/

Console.WriteLine("Insert one number:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Insert a second number:");
double b = double.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Number 1 {a} is bigger than number2 {b}");
}
else if (b > a)
{
    Console.WriteLine($"Number2 {b} is bigger than number1 {a} ");
}
else
{
    Console.WriteLine($"Number 1 {a} is equal to Number 2 {b}");
}