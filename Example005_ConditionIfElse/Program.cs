Console.Write("Введите имя пользователя:");
String username = Console.ReadLine();

if(username.ToLower() == "маша")
{
  Console.WriteLine("Ух ты, это же Маша, привет!");
}
else
{
  Console.Write("Привет, ");
  Console.Write(username);
}