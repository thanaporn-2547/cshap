// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string prefix, fname, lname;
int id;
double h, w;
Console.Write("input your prefix=");
prefix=Console.ReadLine();
Console.Write("input your firstname=");
fname= Console.ReadLine();
Console.Write("input your lastname=");
lname = Console.ReadLine();
Console.Write("input your student id=");
id = Int32.Parse( Console.ReadLine());
Console.Write("input your height=");
h = Double.Parse(Console .ReadLine());
Console.Write("input your weight=");
w = Double.Parse(Console.ReadLine());
Console.WriteLine("********************");
Console.WriteLine("student id is= "+id);
Console.WriteLine("full name is= "+prefix+fname+" "+lname);
Console.WriteLine("your height= "+h);
Console.WriteLine("your weight= " +w);
Console.WriteLine("your BMI is= "+w/((h/100)*(h/100)));
Console.WriteLine("********************");
