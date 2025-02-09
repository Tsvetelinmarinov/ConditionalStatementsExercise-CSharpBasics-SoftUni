/**
 * Sum seconds
 */


/**
 * 
 */


int firstRunnerTime = int.Parse(Console.ReadLine());
int secondRunnerTime = int.Parse(Console.ReadLine());
int thirdRunnerTime = int.Parse(Console.ReadLine());



int totalTime = firstRunnerTime + secondRunnerTime + thirdRunnerTime;


int minutes = totalTime / 60;
int seconds = totalTime % 60;


if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}