using System.Runtime.CompilerServices;
/*
string aFriend = "Bill";
Console.WriteLine (aFriend);
aFriend = "João";
Console.WriteLine (aFriend);
Console.WriteLine ($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Bianca";
Console.WriteLine ($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine ($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine ($"The name {secondFriend} has {secondFriend.Length} letters");

string greeting = "      Good Afternoon!!        ";
Console.WriteLine ($"{greeting}");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"{trimmedGreeting}");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"{trimmedGreeting}");

trimmedGreeting = greeting.Trim();
Console.WriteLine ($"{trimmedGreeting}");

string sayHello = "Hello, World!";
Console.WriteLine (sayHello);
sayHello = sayHello.Replace ("Hello","Greetings");
Console.WriteLine (sayHello);

Console.WriteLine (sayHello.ToUpper());
Console.WriteLine (sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine (songLyrics.Contains("goodbye"));
Console.WriteLine (songLyrics.Contains("greetings"));
*/
string s1 = "The quick brown fox jumps over the lazy dog";
string s2 = "fox";
bool b = s1.Contains(s2);
Console.WriteLine("'{0}' is in the string '{1}':{2}",      s2, s1, b);
if (b){
    int index = s1.IndexOf(s2);
    if (index >= 0)
        Console.WriteLine("'{0}' begins at character position {1}",      s2, index + 1);
    
}
