namespace AdventOfCode2023
{
    internal static class DayOne
    {
        internal static decimal GetSum()
        {
            decimal sum = 0;
            var reader = new StreamReader(@"input\day1.txt");
            var line = reader.ReadLine();
            while (line != null)
            {
                int first = 0;
                int second = 0;

                var arr = line.ToCharArray();
                for (int i = 0; i < arr.Length; i++) 
                {
                    if (int.TryParse(arr[i].ToString(), out first))
                        break;
                }

                for (int i = arr.Length -1; i >= 0; i--)
                {
                    if (int.TryParse(arr[i].ToString(), out second))
                        break;
                }

                sum += first * 10 + second;

                line = reader.ReadLine();
            }
            reader.Close();
            Console.WriteLine(sum);

            return sum;
        }
    }
}
