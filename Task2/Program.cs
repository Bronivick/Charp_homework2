int blyat = new Random().Next(45,1000);

Console.WriteLine(blyat);

int blyat1 = blyat % 10;

int result = blyat1;

if(blyat>100)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нету");
}
