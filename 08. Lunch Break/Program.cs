/**
 * 08. Lunch Break
 */



string serialName = Console.ReadLine();
int serialDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());



double timeForLaunch = breakDuration / 8.0;
double timeForResting = breakDuration / 4.0;



//You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
//•	Ако времето не Ви е достатъчно:
//"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
//Времето в двете изходни съобщения да се закръгли до най-близкото цяло число нагоре.


double leftTime = breakDuration - timeForLaunch - timeForResting;


if (serialDuration <= leftTime) 
{
    Console.WriteLine(value: $"You have enough time to watch {serialName} and left with {Math.Ceiling(leftTime - serialDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(serialDuration - leftTime)} more minutes."); 
}