void Zadacha15 ()
{
    Console.WriteLine("Введите код дня недели");
    int numb = Convert.ToInt32(Console.ReadLine());

    if (numb < 8)
    {
        if (numb > 5 && numb <=7)
        {
            Console.WriteLine("Выходной день");
        }
        else Console.WriteLine("Будний день");
    
    }
    else Console.WriteLine("Не корректный код");
}
Zadacha15 ();