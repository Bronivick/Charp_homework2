int blyat = new Random().Next(1,8);

Console.WriteLine(blyat);

int blyat1 = blyat % 10;

int result = blyat1;

if(blyat>5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
