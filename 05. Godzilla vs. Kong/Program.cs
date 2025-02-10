/**
 * 05. Godzilla vs. Kong
 */



/*
Ред 2.	Брой на статистите – цяло число в интервала [1 … 500]
Ред 3.	Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]
Ред 1.	Бюджет за филма – реално число в интервала [1.00 … 1000000.00]
*/




double movieBudget = double.Parse(Console.ReadLine());
int statistCount = int.Parse(Console.ReadLine());
double suitPrice = double.Parse(Console.ReadLine());




double movieDekor = movieBudget * 0.1;
double suitsTotal = statistCount * suitPrice;



if (statistCount > 150)
{
    suitsTotal -= suitsTotal * 0.1;
}




/*
•	Ако  парите за декора и дрехите са повече от бюджета:
o	"Not enough money!"
o	"Wingard needs {парите недостигащи за филма} leva more."
•	Ако парите за декора и дрехите са по малко или равни на бюджета:
o	"Action!" 
o	"Wingard starts filming with {останалите пари} leva left."
*/



if ((suitsTotal + movieDekor) <= movieBudget) 
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {movieBudget - (suitsTotal + movieDekor):F2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingars needs {Math.Abs((movieBudget - (suitsTotal + movieDekor))):F2} leva more.");
}