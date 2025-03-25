
    public static class Exercise2
    {
        public static void Exercises()
        {
        Console.Write("\nNowa tablica do kolejnych zadań: \n");
        var tab = new int[15];

            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(0,11);
            Console.Write(tab[i] + " ");
            
        }
        Console.WriteLine();
        //sprawdz czy element znajduje sie w tablicy
        Console.Write("Zadanie 4: \n");

        int lookingFor = 10;
        int nmb = 0;
        /*if (tab.Contains(lookingFor))
        {
            Console.Write("Szukany element znajduje sie w tablicy");
        }
        else {
            Console.Write("Brak elementu w tablicy");
        }*/
        foreach (int element in tab)
        {
            if (element == lookingFor)
            {
                nmb++;
            } 
        }
        Console.Write("Element wystepuje " + nmb + " razy.");

        //znajdz indeks pod ktorym znajduje sie element


        //znajdz max i min z tablicy


    }
    }
