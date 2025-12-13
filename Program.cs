
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, Haris!");

//Datatypes
//Numeric
//byte age = 12;
//short sal = 28000;
//int number = 10;
//long lnum = 213213213123232323L;

//float fnum = 0.7885F;// 7 digits
//double dnum = 0.788544554454544454554544;//15 digits
//decimal deci = 0.78854545444444446545434545444M;// 28 digits

////character
//char Alpha = 'a';
//string fullName = "Haris Naseer";
//bool isValid = true;




//Console.WriteLine("What's your First Name..?");

//string Name = Console.ReadLine();//user input and readline always returns a string



//Console.WriteLine("Welcome "+Name + ", to our console application...!");



//29 -11-25

//Operators


//unary operator  -- 1 operand
//a++

//binary operator  -- 2 operands
//ternary operator  -- 3 operands

//Arithmetic Operators 
//Console.WriteLine(40 + 20);
//Console.WriteLine(40 - 20);
//Console.WriteLine(40 * 20);
//Console.WriteLine(40 / 20);
//Console.WriteLine(50 % 20);// Modulo => Remainder

////Assignment Operators

//int number = 5;
//number += 2;// number = number + 2 //7
//number -= 2;// number = number - 2 //5
//number *= 2;// number = number * 2 //10
//number /= 2;// number = number / 2 //5

//Comparison Operators (True / False)
//int a = 45, b = 120;
//Console.WriteLine(a == b);// False
//Console.WriteLine(a != b);// True
//Console.WriteLine(a < b); // true
//Console.WriteLine(a > b);// false
//Console.WriteLine(a >= b);// false
//Console.WriteLine(a <= b);// true

//Logical Operators
//int a = 34,  b = 45;

////And T/T = T
//Console.WriteLine(a <= b && a >= b); // false
//Console.WriteLine(a >= b && a != b);// false

////Or
//Console.WriteLine(a >= b || a == b);// FAlse
//Console.WriteLine(a >= b || a != b);// True


//Not
//Console.WriteLine(!(a == b)); //True


//Conditional Statements
// if else
//Console.WriteLine("Enter salary ..");

//int salary = Convert.ToInt32(Console.ReadLine());
// int salary = Int32.Parse(Console.ReadLine());

//if else ladder
//if (salary >= 50000 && salary <= 80000)
//    {
//        Console.WriteLine("Good Salary");

//    }
//    else if (salary < 50000)
//    {
//    Console.WriteLine("Do you get Fuel Allowance ?");
//    string answer = Console.ReadLine();


//    // Nested
//    answer = answer.ToLower();//yes
//    if (answer == "yes" || answer == "y")

//    {
//        Console.WriteLine("Sounds Good");
//    }
//    else if (answer == "no" || answer == "n")
//    {
//        Console.WriteLine("Try to Switch your job");
//    }
//    else
//    {


//        Console.WriteLine("Please answer yes or no.");
//    }

//}
//else
//    {
//        Console.WriteLine("Masha Allah");
//    }







// switch
//Console.WriteLine("Enter number for days from 1 to 7 :");
//int number = Convert.ToInt32(Console.ReadLine());


//switch (number)
//{
//    case 1:
//        Console.WriteLine("Monday");

//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;

//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:

//        //Exception /error handling
//        try
//        {
//            Console.WriteLine("Today is Friday");
//            Console.WriteLine("Have u recited durood sharif?  Press 1 for yes and 2 for no");
//            int ans = Int32.Parse(Console.ReadLine());
//            switch (ans)
//            {
//                case 1:
//                    Console.WriteLine("Masha Allah");
//                    break;
//                case 2:
//                    Console.WriteLine("Barai meherbani prh lein..");
//                    break;
//                default:
//                    Console.WriteLine("Please answer in 1 or 2.");
//                    break;
//            }
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e);
//        }


//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Enjoy it's Sunday.");
//        break;
//    default:
//        Console.WriteLine("Invalid input.");
//        break;

//}

//int x = 7;
//Console.WriteLine($"This is String Interpolation. {x * 2}");// String Interpolation $"{ }"


//Loops


//for -- when we are aware of starting / ending point
//  initialization ; test condition ; increment/decrement

//using System.Runtime.InteropServices;

//for (int i = 1, j = 10; i < 11 && j > 0; i++, j--)
//{

//    Console.WriteLine(i);
//    Console.WriteLine(j);

//}




//for (int i = 10; i > 0; i--)
//{
//	Console.WriteLine(i);

//}
//even
//for (int i = 2; i < 11; i = i + 2)
//{
//    Console.WriteLine(i);
//}
////odd
//for (int i = 1; i < 10; i += 2)
//{
//    Console.WriteLine(i);
//}


//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }

//}
//while -- when we are aware of ending point we dont know  exact number of iteration
//int j = 13;

//while (j < 13)
//{
//    Console.WriteLine("J");
//    j--;
//}


//do While-- when we have to run the code at least once then condition is checked
//int j = 13;

//do

//{
//    Console.WriteLine("J");
//    j++;
//} while (j < 13);

//even / odd

//int num;
//char ans;



//do
//{
//    Console.WriteLine("Enter a Number");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Even Number");
//    }
//    else
//    {
//        Console.WriteLine("Odd Number");
//    }
//    Console.WriteLine("Do you want to continue Press y for yes and any key to exit.");


//    ans = Convert.ToChar(Console.ReadLine());

//} while (ans == 'Y' || ans == 'y');




// Create a program which takes user input from 1 to 3 for favorite subject. which are eng, urdu, maths.
// if user selects 3 ask user to multiply 5 by 7 and give result. if user give right answer then congratulate him
// otherwise say u re bad at maths.



//Arrays fixed size

//int[] numbers = new int[4];// 4 element will come in this array
//numbers[0] = 2;
//numbers[1] = 12;
//numbers[2] = 22;
//numbers[3] = 24;
////numbers[4] = 24;

//Console.WriteLine(numbers);

//int[] numbers = new int[4]{ 2, 14, 15, 23 };
//Console.WriteLine(numbers[2]);
//int[] myNumbers = { 2, 14, 15, 23 };

//Console.WriteLine(myNumbers[2]);
////myNumbers[4] = 6;  error

////foreach
//foreach (var num in myNumbers)
//{
//    Console.WriteLine(num * 2);
//}

//var name =55.8979 ;



//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(Math.Pow(2, 2));



//int[] numbers = new int[4];// C# give default values to uninitialized variables int=0, string = null, bool= true

//Console.WriteLine(numbers);

//string[] cities = { "Karachi", "Lahore", "Rawalpindi", "Sialkot", "Multan", "Sialkot", "Sialkot", "Sialkot", "Sialkot" };


//Console.WriteLine(cities.Length);
////Array.Sort(cities);

////Array.Reverse(cities);


//Console.WriteLine(Array.IndexOf(cities, "Sialkot"));//
//Console.WriteLine(Array.LastIndexOf(cities, "Sialkot"));//1


//Console.WriteLine(cities);




//for (int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}




//Multidimensional Arrays (Array inside an array) 2D, 3D etc...
//
//int[,] TopMarks =
//{
//    { 88, 89},
//    { 92, 98},
//    { 78, 87},
//    { 99, 100}

//};

//4 x 2

//0 0
//1 1
//2 2
//3 3


//Console.WriteLine(TopMarks[3,0]);


//for (int i = 0; i < TopMarks.GetLength(0); i++)
//{
//    Console.WriteLine("row started");
//    for (int j = 0; j < TopMarks.GetLength(1); j++)
//    {
//        Console.WriteLine(TopMarks[i, j]);


//    }
//    Console.WriteLine("row ended");
//}















//for (int i = 0; i < TopMarks.GetLength(0); i++)
//{
//    Console.WriteLine($"Printing {i + 1} array");
//    //Console.WriteLine();
//    for (int j = 0; j < TopMarks.GetLength(1); j++)
//    {
//        Console.WriteLine(TopMarks[i, j]);
//    }
//    Console.WriteLine();

//}


//Jagged Array (Sizes of subarrays is not fixed) 2D:
//string[,] skillSet  Multidimensional



//string[][] skillSet =
//{
//    new string[4]{"C#","Sql","Php","Html"},
//    new string[1]{"php"},
//    new string[2]{"Css","Java"},
//    new string[3]{"Javascript","Sql","Php"}
//};

////bool[] numbers = { true,false };

//Console.WriteLine(skillSet[3][1]);

////var dexides the dataype of variable on runtime

//foreach (var skills in skillSet)
//{
//    foreach (var skill in skills)
//    {

//    Console.WriteLine(skill);
//    }
//}


//Functions  


//Functions
//1. User Defined
//add();


//1.No Return no Parameters
//return type function name () { body }



//void Greet()
//{
//    Console.WriteLine("Hi Haris, Welcome to Our Console.");
//}

//Greet();


//2. No Return with Parameters
//void Greet(string name)//Parameter
//{
//    Console.WriteLine($"Hi {name}, Welcome to Our Console.");
//}


//Greet("Javed");

//Greet("Talha");//Arguement
//Greet("Adnan");//Arguement
//Greet("Haseeb");//Arguement


//3. Return no Parameters

//string Greet()
//{
//    return ("Hi User, Welcome to Our Console.");
//}

////Console.WriteLine(Greet());

//string msg = Greet();
//Console.WriteLine(msg.ToUpper());


//float Greet()
//{
//    return (0.234f);
//}

//Console.WriteLine(Greet());

//float msg = Greet();
//Console.WriteLine(msg);



//4. Return with Parameters

//string Greet(string name, byte age) // -127 to 128   or  0  to 256
//{
//    return ($"Hi {name}, Welcome to Our Console.\n Your age is: {age}");
//}

//string msg = Greet("Jalal", 78);
//Console.WriteLine(msg.ToUpper());



//2. Pre Defined

//Math.Sqrt(49);
Console.WriteLine("hi");


double Power(int number, int power){
    double result = 1;

    for (int i =1; i<= power; i++)
    {
    
     result =  number *result ;
    }
    return (result);

}

Console.WriteLine(Power(7,5));
Console.WriteLine(Math.Pow(7,5));


//1.Make 2 jagged arrays.

//2.Create a function to print them.
