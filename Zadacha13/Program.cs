void Zadacha13()
{

    Console.WriteLine("Введите число");
    int numb = Convert.ToInt32(Console.ReadLine());

    if (numb > 99)
    {
        while (numb > 999)
        {
            numb = numb / 10;
        }
        int numb3 = numb % 10;
        Console.WriteLine( numb3);
    }
    else Console.WriteLine("Третьей цифры нет!!!");
}
Zadacha13 ();