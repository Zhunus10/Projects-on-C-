// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insert user name");
string username = Console.ReadLine();

if(username.ToLower() == "tanos")
{
    Console.WriteLine("Wellcome TANOS");    
}
else
{
    Console.Write("Hello Dear ");
    Console.WriteLine(username);
}