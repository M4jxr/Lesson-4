//static void MyMethod()
//{
//    Console.WriteLine("I just got executed!");
//}

//MyMethod();
//MyMethod();
//MyMethod();


//static void MyMethod1(string fname)
//{
//    Console.WriteLine(fname + " Refsnes");
//}

//MyMethod1("Liam");
//MyMethod1("Jenny");
//MyMethod1("Anja");


//static void MyMethod(string country = "Norway")
//{
//    Console.WriteLine(country);
//}

//MyMethod("Sweden");
//MyMethod("India");
//MyMethod();
//MyMethod("USA");


//static void MyMethod(string fname, int age)
//{
//    Console.WriteLine(fname + " is " + age);
//}


//MyMethod("Liam", 5);
//MyMethod("Jenny", 8);
//MyMethod("Anja", 31);


//static string MyMethod(string x)
//{
//    return x+x;
//}

//Console.WriteLine(MyMethod("qwerty")); ;

//static void MyMethod(string child1, string child2, string child3)
//{
//    Console.WriteLine("The youngest child is: " + child3);
//}

//MyMethod(child3: "John", child1: "Liam", child2: "Liam");

//static int PlusMethodInt(int x, int y)
//{
//    return x + y;
//}

//static double PlusMethodDouble(double x, double y)
//{
//    return x + y;
//}



//int myNum1 = PlusMethodInt(8, 5);
//double myNum2 = PlusMethodDouble(4.3, 6.26);
//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2);








//Lesson4 less = new Lesson4();
//int myNum1 = less.PlusMethod(8, 5);
//double myNum2 = less.PlusMethod(4.3, 6.26);
//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2);
//public class Lesson4
//{
//    public int PlusMethod(int x, int y)
//    {
//        return x + y;
//    }
//    public double PlusMethod(double x, double y)
//    {
//        return x + y;
//    }
//}

//void SayHello() => Console.WriteLine("Hello");

//void SayHello()
//{
//    Console.WriteLine("Hello");


//string GetMessage()
//{
//    return "hello";
//}

//string GetMessage() => "hello";


//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(number);
//Console.WriteLine($"Число после метода Increment: {number}");

//void Increment(int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}



//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(ref number);
//Console.WriteLine($"Число после метода Increment: {number}");


//void Increment(ref int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}


//void Sum(int x, int y, out int result)
//{
//    result = x + y;
//}
//int number;
//Sum(10, 15, out number);
//Console.WriteLine(number);


//void Sum(int x, int y, out int result)
//{
//    Console.WriteLine(x + y);
//    result = 0;
//}


//void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
//    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
//}
//int area;
//int perimetr;
//GetRectangleData(10, 20, out area, out perimetr);
//Console.WriteLine($"Площадь прямоугольника: {area}");
//Console.WriteLine($"Периметр прямоугольника: {perimetr}");

//n! = 1 * 2 * … *n


//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}
//int factorial4 = Factorial(4);  // 24
//int factorial5 = Factorial(5);  // 120
//int factorial6 = Factorial(6);  // 720
//Console.WriteLine($"Факториал числа 4 = {factorial4}");
//Console.WriteLine($"Факториал числа 5 = {factorial5}");
//Console.WriteLine($"Факториал числа 6 = {factorial6}");




//if (n == 1) return 1;
//return 4 * Factorial(3);
//Factorial(3);
//return 3 * Factorial(2);
//Factorial(2)
//return 2 * Factorial(1);
//if (n == 1) return 1;
//1
//4 * 3 * 2 * Factorial(1)





int sum1 = 8;
int sum2 = 10;
int sum3 = 12;
int sum4 = 13;


static int MaxValue(int sum1, int sum2)
{
    return Math.Max(sum1, sum2);
}
Console.WriteLine(MaxValue(sum1, sum2));

static int MinValue(int sum2, int sum3)
{
    return Math.Min(sum2, sum3);
}
Console.WriteLine(MinValue(sum2, sum3));



int sum = 6;

static bool TrySumIfOdd(int sum1, int sum3, out int sum) //sum4
{
    sum = sum1 + sum3;
    bool isTrue = (sum % 2 == 0);
    return isTrue;
}
Console.WriteLine(TrySumIfOdd(sum1, sum2, out sum));

   //please check