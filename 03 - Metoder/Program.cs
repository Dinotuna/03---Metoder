// static void Hello32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine($"Hello, World!");
//     }
// }

// // Hello32();

// static int Kvadrat(int i)
// {
//     int result = i * i;
//     return result;
// }

// int t = Kvadrat(2);
// Console.WriteLine(t);

// static float Multi(float a, float b)
// {
//     float result = a * b;
//     return result;
// }

// float c = Multi(3, 4);

// Console.WriteLine(c);


// static float RightTriangleArea(float b, float h)
// {
//     float result = b*h/2;
//     return result;
// }


// float A = RightTriangleArea(3, 2);
// Console.WriteLine(A);

// static double CircleArea(double r)
// {
//     double result = 3.14 * r*r;
//     return result;
// }

// double A = CircleArea(3);
// Console.WriteLine(A);


// static int GetNumberImput()
// {
//     int result;
//     string svar;

//     while(true)
//     {
//         Console.WriteLine("Skriv ett tal");
//         svar = Console.ReadLine();

//         if(int.TryParse(svar, out result))
//         {
//             return result;
//         }

//         else
//         {
//             Console.WriteLine("Inte ett tal");

//         }
//     }

// }

// int tal = GetNumberImput();

// Console.WriteLine($"Ditt tal var {tal}");


static int GetChoice(string a, string b, string c)
{
    while(true)
    {
        Console.WriteLine("Välj ett av alternativen med en siffta 1-3");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        string svar = Console.ReadLine();

        if(svar == "1" || svar == "2" || svar == "3")
        {
            return int.Parse(svar);
        }

        else
        {
            Console.WriteLine("Skriv ett tal");
        }
    }
}

GetChoice("bil", "hus", "pengar");




Console.ReadLine();