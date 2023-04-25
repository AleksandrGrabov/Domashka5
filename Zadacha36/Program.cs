int[] array = new int[4];
        int sum = 0;

        Random rand = new Random();

          for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 100);
            Console.WriteLine(array[i]);
        }

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine($"Сумма элементов с нечетными индексами: {sum}");

        Console.ReadLine();