using System;
//1
int num = 6;
bool tru = true;
string name = "Patrick";
double doub = 2.3;
decimal dec = 2.33m;
//2
void ComineToString(string name, int num)
{
    Console.WriteLine(
        $"{name} is {num} feet tall"
        );
}
//3
ComineToString(name, num);
//4
var friends = new[] { "Charlie", "Samantha", "Joey", "Joe"};
//5
foreach(var names in friends)
{
    Console.WriteLine($"{names} is a good friend of mine.");
}
