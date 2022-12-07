// Вид 1 ничего не возвращает, и ничего не принимает
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2 ничего не возвращает, но принимает аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method2_1(string msg, int count) // именованные аргументы
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; // Инкримент(увеличение), Декримент(уменьшение)
    }
}
Method2_1("Текст", 4);
Method2_1(count: 3, msg: "Текст"); // можно не по порядку, если именованные

// Вид 3 что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 что-то принимают и что-то возвращают
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // резалт будет пустой строкой

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "Ha");
Console.WriteLine(res);