/**
 * 03. Time + 15 Minutes
 */


int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());


minutes += 15;


if (minutes > 59)
{
    hour++;
    minutes -= 60;
}

if (hour > 23)
{
    hour -= 24;
}



if (minutes < 10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}