Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Ура, это же Настя!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}