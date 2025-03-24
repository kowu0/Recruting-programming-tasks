public static class Exercise1{
    public static void Exercises()
    {
        var numbers = new int[7];

        numbers[0] = 10;
        numbers[1] = 5;
        numbers[2] = 12;
        numbers[3] = 17;
        numbers[4] = 22;
        numbers[5] = 87;
        numbers[6] = 3;

        Console.WriteLine("Zadanie 2: ");
        //wypisz elementy z tablicy
        foreach (int x in numbers)
        {
            Console.Write(x + " ");
        }
        Console.Write("\n");
        Console.Write("Zadanie 3: \n");

        //wypisz co 2 element
        for (int x = 0; x < numbers.Length; x += 2)
        {
            Console.Write(numbers[x] + "   ");
        }
    }   
}