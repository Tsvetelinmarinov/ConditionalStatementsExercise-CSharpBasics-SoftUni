/**
 * Toy Shop
 */




/**
 * •	Пъзел - 2.60 лв.
 * •	Говореща кукла - 3 лв.
 * •	Плюшено мече - 4.10 лв.
 * •	Миньон - 8.20 лв.
 * •	Камионче - 2 лв.
 */



double sawPrice = 2.6;
double puppetPrice = 3.0;
double bearPrice = 4.1;
double minionPrice = 8.2;
double truckPrice = 2.0;



/**
 * 1.	Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
 * 2.	Брой пъзели - цяло число в интервала [0… 1000]
 * 3.	Брой говорещи кукли - цяло число в интервала [0 … 1000]
 * 4.	Брой плюшени мечета - цяло число в интервала [0 … 1000]
 * 5.	Брой миньони - цяло число в интервала [0 … 1000]
 * 6.	Брой камиончета - цяло число в интервала [0 … 1000]
 */



double tripPrice = double.Parse(Console.ReadLine());
int sawsCount = int.Parse(Console.ReadLine());
int puppetsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());



double total = (sawsCount * sawPrice) + (puppetsCount * puppetPrice) + (bearsCount * bearPrice)
+ (minionsCount * minionPrice) + (trucksCount * truckPrice);



double toysCount = sawsCount + puppetsCount + bearsCount + minionsCount + trucksCount;



if (toysCount >= 50)
{
    total -= total * 0.25;
}



//Наем
double rent = total * 0.1;
total -= rent;



if (total >= tripPrice)
{
    Console.WriteLine($"Yes! {Math.Abs(tripPrice - total):F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {Math.Abs(tripPrice - total):F2} lv needed.");
}