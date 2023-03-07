Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "максим")
{
    Console.WriteLine("Ура, это же Максим");
}
else
if (username.ToLower() == "ольга")
{
    Console.WriteLine("Ура, это же наша любимая Оленька!:");
}
else
if (username.ToLower() == "дима")
{
    Console.WriteLine("Привет, бука");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}