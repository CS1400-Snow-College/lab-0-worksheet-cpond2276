string aFriend = "Bill";
Console.WriteLine($"Hello {aFriend}");

aFriend = "Maria";
Console.WriteLine($"Hello {aFriend}");

string FirstFriend = "Bill";
string SecondFriend = "Maria";
Console.WriteLine($"My friends are {FirstFriend} and {SecondFriend}");

Console.WriteLine($"The name {FirstFriend} has {FirstFriend.Length} letters.");
Console.WriteLine($"The name {SecondFriend} has {SecondFriend.Length} letters.");

string greeting = "     Hello World!     ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());


string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));


Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));


Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));