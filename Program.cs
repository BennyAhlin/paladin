Console.WriteLine("Hello, please enter");
    string paladin = Console.ReadLine();
string reverse = string.Empty;
Console.Clear();
for (int i = (paladin.Length - 1); i >= 0; i--) 
{

    reverse += paladin[i].ToString();
    //Måste ha + och = för att lägga ihop index igen!
}

if ( reverse == paladin)
{
   Console.WriteLine("this is a paladin");
}
else
{
    Console.WriteLine("this is a warlock");
}

Console.WriteLine(); 
Console.WriteLine(paladin);
Console.WriteLine(reverse);