            Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine()!);

        if (IsPalindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }