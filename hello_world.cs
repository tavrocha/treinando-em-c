using System.Runtime.CompilerServices;

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