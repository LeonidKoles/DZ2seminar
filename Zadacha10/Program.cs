void Zadacha10()
{
Console.WriteLine("Введите трехзначное число");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb >= 100 && numb < 1000) 
{
    int numb2 = numb / 10 % 10;
    Console.WriteLine(numb2);
}
else Console.WriteLine("Число не трехзначное!!!");
}
Zadacha10 ();