/**
 * 07. Shopping
 */



//•	Видеокарта – 250 лв./бр.
//•	Процесор – 35% от цената на закупените видеокарти/бр.
//•	Рам памет – 10% от цената на закупените видеокарти/бр.




//Цена на видеокарта
double videoCardPrice = 250.0;



//1.	Бюджетът на Петър - реално число в интервала [0.0…100000.0]
//2.	Броят видеокарти - цяло число в интервала [0…100]
//3.	Броят процесори - цяло число в интервала [0…100]
//4.	Броят рам памет - цяло число в интервала [0…100]



//Бюджет
double budget = double.Parse(Console.ReadLine());

//Брой видео карти
int videoCardsCount = int.Parse(Console.ReadLine());

//брой процесори
int processorsCount = int.Parse(Console.ReadLine());

//Брой ПСД
int ramMemoriesCount = int.Parse(Console.ReadLine());


//Общо за видео карти
double videoCardsTotal = videoCardsCount * videoCardPrice;

//Цена на процесор
double processorPrice = videoCardsTotal * 0.35;


//Цена на рам памет
double ramMemoryPrice = videoCardsTotal * 0.1;



//•	Ако бюджета е достатъчен:
//"You have {остатъчен бюджет} leva left!"
//•	Ако сумата надхвърля бюджета:
//"Not enough money! You need {нужна сума} leva more!"
//Резултатът да се форматира до втория знак след десетичната запетая.



//Крайна сума
double total = (processorsCount * processorPrice) + (ramMemoriesCount * ramMemoryPrice) + videoCardsTotal;



if (videoCardsCount > processorsCount)
{
    total -= total * 0.15;
}



if (total <= budget)
{
    Console.WriteLine($"You have {Math.Abs(total - budget):F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(total - budget):F2} leva more!");
}