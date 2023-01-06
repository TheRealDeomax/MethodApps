//Methods



//

using Methods;
using System.ComponentModel;
/*
ConsoleMessages.SayHi();
for (int i = 0; i < 5; i++)
{
ConsoleMessages.SayHi(i);
ConsoleMessages.SayHi();
ConsoleMessages.SayHi("Have a nice Day");
}
*/

ConsoleMessages.SayHi($"Hi {ConsoleMessages.GetUsersName()}");

MathShortcuts.Add(5, 3);

double[] vals = new double[] { 5, 6, 7, 8, 10, 12 };

Console.WriteLine($" The double values are { MathShortcuts.AddIt(50.01, 25.25)}");

MathShortcuts.AddAll(vals);
ConsoleMessages.SayHi("Good-Bye");
ConsoleMessages.SayHi($"{vals.Sum().ToString()}");


