double[] array = { 3.21, 7.04, 22.93, -2.71, 78.24 };

        double max = array[0];
        double min = array[0];

         for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        double difference = max - min;

        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");

        Console.ReadLine();