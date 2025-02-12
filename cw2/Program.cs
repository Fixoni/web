// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*
void cw1() {
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());   
    Console.WriteLine($"Liczba {a} do kwadratu: {a*a}");
}
cw1();
*/

/*
void cw2() {
    try {
        Console.Write("Podaj a: ");
        double a = Convert.ToDouble(Console.ReadLine());   
        Console.Write("Podaj b: ");
        double b = Convert.ToDouble(Console.ReadLine());   
    if(a==0 || b==0) {
        Console.WriteLine($"Liczba {a}-{b}: {a-b}");
        Console.WriteLine($"Liczba {a}+{b}: {a+b}");
        Console.WriteLine($"Liczba {a}*{b}: {a*b}");
        Console.WriteLine("Nie można dzielić przez zero");
    } else {
        Console.WriteLine($"Liczba {a}-{b}: {a-b}");
        Console.WriteLine($"Liczba {a}+{b}: {a+b}");
        Console.WriteLine($"Liczba {a}*{b}: {a*b}");
        Console.WriteLine($"Liczba {a}/{b}: {((double)a/b)}");
    }
    }  catch(FormatException ex) {
        Console.WriteLine(ex.Message);
    }
}
cw2();
*/

/*
void cw3() {
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a>0) {
        Console.WriteLine($"Liczba {a} i jej pierwiastek: {(Math.Sqrt(a))}");
    } else {
        Console.WriteLine("Nie ma pierwiastka z liczb ujemnych w zbiorze liczb rzeczywistych");
    }
}
cw3();
*/

void cw4() {
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj c: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int delta = (b*b-4*a*c)/2*a;

    if(delta >0) {
    Console.WriteLine($"1 miejsce zerowe {a},{b},{c} {(-b-delta)/2*a}");
    Console.WriteLine($"2 miejsce zerowe {a},{b},{c} {(-b+delta)/2*a}");
    }
    if(delta ==0) {
    Console.WriteLine($"1 miejsce zerowe {a},{b},{c} {(-b)/2*a}");
    } else {
        Console.WriteLine("Nie ma miejsc zerowych");
    }
}
cw4();