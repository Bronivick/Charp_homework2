int blyat = new Random().Next(100,1000);

Console.WriteLine(blyat);

int blyat1 = blyat % 10;
int blyat2 = blyat % 100;
int result = (blyat2-blyat1)/10;

Console.WriteLine(result);

