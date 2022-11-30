Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "";

if(username.ToLower() == "alex")
{
    Console.WriteLine("Ура, это же Alex!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}