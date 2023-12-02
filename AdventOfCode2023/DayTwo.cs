namespace AdventOfCode2023
{
    internal static class DayTwo
    {
        internal static decimal CubeConundrum()
        {
            decimal sum = 0;
            var reader = new StreamReader(@"input\day2.txt");
            var line = reader.ReadLine();
            int gameId = 1;

            while (line != null)
            {
                //Game 1: 13 red, 18 green; 5 green, 3 red, 5 blue; 5 green, 9 red, 6 blue; 3 blue, 3 green
                var games = line.Split(':')[1].Split(';');
                var possible = true;

                foreach (var game in games)
                {
                    int green = 0;
                    int blue = 0;
                    int red = 0;
                    var input = game.Split(',');
                    foreach (var item in input)
                    {
                        if (item.Contains("red"))
                        {
                            red += int.Parse(item.Trim().Split(' ')[0]);
                        }

                        if (item.Contains("green"))
                        {
                            green += int.Parse(item.Trim().Split(' ')[0]);
                        }

                        if (item.Contains("blue"))
                        {
                            blue += int.Parse(item.Trim().Split(' ')[0]);
                        }
                    }

                    // only 12 red cubes, 13 green cubes, and 14 blue cubes
                    if (red > 12 || green > 13 || blue > 14)
                    {
                        possible = false;
                        break;
                    }
                }

                if (possible) 
                {
                    sum += gameId;
                }

                gameId++;
                line = reader.ReadLine();
            }
            reader.Close();
            Console.WriteLine(sum);

            return sum;
        }
    }
}
