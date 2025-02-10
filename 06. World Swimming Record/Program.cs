/**
 * 06. World Swimming Record
 */




  //Иван решава да подобри Световния рекорд по плуване на дълги разстояния. 
  //На конзолата се въвежда рекордът в секунди, който Иван трябва да подобри,  разстоянието в метри, 
  //което трябва да преплува и времето в секунди, за което плува разстояние от 1 м. Да се напише програма, 
  //която изчислява дали се е справил със задачата, като се има предвид, че: съпротивлението на водата го забавя 
  //на всеки 15 м. с 12.5 секунди. Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата,
  //резултатът трябва да се закръгли надолу до най-близкото цяло число.
 




double currentWorldRecord = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double secondsForOneMeter = double.Parse(Console.ReadLine());



double waterResistence = Math.Floor(distanceInMeters / 15) * 12.5;
double totalTime = distanceInMeters * secondsForOneMeter + waterResistence;


//•	Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
//o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
//•	Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
//o   "No, he failed! He was {недостигащите секунди} seconds slower."
//Резултатът трябва да се форматира до втория знак след десетичната запетая.


if (totalTime < currentWorldRecord)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(totalTime - currentWorldRecord):F2} seconds slower.");
}