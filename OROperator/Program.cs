
int math, bio, chem;


Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your bio result:");
bio = Int32.Parse(Console.ReadLine());



Console.WriteLine("Enter your chem result:");
chem = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chem >= 90) || (math >= 90 && bio>= 90) || (chem >= 90 && bio >=90))
{
    Console.WriteLine("Congrats, you are accepted!");
}
else
{

    Console.WriteLine("your applicated cannot b approved");
}
