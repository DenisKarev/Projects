// if_else
Console.WriteLine ("Ввведите имя пользователя:");
string userName = Console.ReadLine();

if (userName == "Маша") //.ToLower
{
    Console.WriteLine ("Урал! это же Маша!");
}
else
{
    Console.Write ("Здравствуйте, ");
    Console.WriteLine (userName);
}