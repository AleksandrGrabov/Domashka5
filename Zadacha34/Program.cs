int[] array = new int[4]; 
        int count = 0; 

        Random rand = new Random(); 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 1000);
            Console.WriteLine(array[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++; 
            }
        }

              Console.WriteLine($"Количество четных чисел в массиве: {count}");

        Console.ReadLine();