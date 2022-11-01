//Random Array
// static int[] PopulateArray()
// {   
//     int[] array = new int[10];
//     Random rand = new Random();

//     int min = 26;
//     int max = array[0];
//     int sum = 0;
//     for (int idx = 0; idx < array.Length; idx++)
//     {
//         array[idx] = rand.Next(5,25);
//         sum += array[idx];
//         Console.WriteLine(array[idx]);
//         if(array[idx] > max){
//             max = array[idx];
//         }
//         else if(array[idx] < min){
//             min = array [idx];
//         }
//     }
//     Console.WriteLine($"Max is: {max}");
//     Console.WriteLine($"Min is: {min}");
//     Console.WriteLine($"Sum is: {sum}");
//     return array;
// }
// PopulateArray();

//Coin Toss
// static Double CoinToss(int num)
// {
//     System.Console.WriteLine("Tossing a Coin");

//     Random flip = new Random();
//     double countHeads = 0;
//     double countTails = 0;
//     double ratio = 0;
//     double headsPercent = 0;
//     double tailsPercent = 0;

//     while(num > 0)
//     {
//         if (flip.Next(0,2) == 0)
//         {
//             System.Console.WriteLine("Heads");
//             countHeads += 1;
//         }
//         else
//         {
//             System.Console.WriteLine("Tails");
//             countTails += 1;
//         }
//         num --;
//     }
//     headsPercent = (countHeads / 10) * 100;
//     tailsPercent = (countTails / 10) * 100;
//     ratio = countHeads / countTails;

//     Console.WriteLine($"Heads Count is: {countHeads}  Percent is: {headsPercent}");
//     Console.WriteLine($"Tails Count is: {countTails}  Percent is: {tailsPercent}");
//     Console.WriteLine($"Heads/Tails ratio is {ratio}");
//     return ratio;
// }
// CoinToss(10);

//Names
// static List<string> Names(){
//     List<string> list = new List<string> {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
//     List<string> newList = new List<string>();
//     foreach (var person in list)
//     {
//         if(person.Length > 5){
//             newList.Add(person);
//             Console.WriteLine(person);
//         }
//     }
//     return newList;
// }
// Names();
