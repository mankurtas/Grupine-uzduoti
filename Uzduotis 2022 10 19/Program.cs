
float area;
double radius = 6371;

area = ((float)(4 * Math.PI * radius * radius));
//Console.WriteLine($"Earth's area is: {area} km");


//Earth Volume


int volume = 6371;



double earthVolume = (double)(4.0 / 3 * Math.PI * volume * volume * volume);

//Console.Write(earthVolume);

// triangle C length
double triangleC = (double) Math.Round(Math.Sqrt(15 * 15 + 10 * 10),2);

//Console.WriteLine(triangleC);



double sum = area + earthVolume + triangleC;
double average = sum / 3;


Console.WriteLine($"Sum is: {sum}");


Console.WriteLine($"Average is: {average}");



