
//Earth Volume


int volume = 6371;



double earthVolume = (double)(4.0 / 3 * Math.PI * volume * volume * volume);



Console.Write(earthVolume);

// triangle C length
double triangleC = (double) Math.Round(Math.Sqrt(15 * 15 + 10 * 10),2);

Console.WriteLine(triangleC);



long sum = area + earthVolume + triangleC;
long average = sum / 3;


Console.WriteLine(sum);

Console.WriteLine(average);