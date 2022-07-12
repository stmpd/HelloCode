Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "георгий")
{
    Console.WriteLine("Здарова дядь!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
