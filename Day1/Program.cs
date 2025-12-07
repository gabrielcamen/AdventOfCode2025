using Day1;

var secretEntrance = new SecretEntrance();
Console.WriteLine("First challenge:");
var password = secretEntrance.GetPassword("TestInput.txt", true); // correct answer 3
Console.WriteLine(password);
password = secretEntrance.GetPassword("RealInput.txt", true); // correct answer 1052
Console.WriteLine(password);
Console.WriteLine("Second challenge:");
password = secretEntrance.GetPassword("TestInput.txt", false); // correct answer 6
Console.WriteLine(password);
password = secretEntrance.GetPassword("RealInput.txt", false); // correct answer 6295
Console.WriteLine(password);