using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfLinerSearch
{
    public class LevelPrice
    {
        public List<(double startX, double endX, double amountOfLevel)> GetLevelPrice
            (List<(double x, double y, string extermom)> input)
        {
            List<(double startX, double endX, double amountOfLevel)> Save_level =
                new List<(double startX, double endX, double amountOfLevel)>();

            List<(double maxLevel_X, double maxLevel_Y)> maxLevel =
                                                (from item in input
                                                 where item.extermom == "maximum"
                                                 select (item.x, item.y)).ToList();
            List<(double minLevel_X, double minLevel_Y)> minLevel =
                                                (from item in input
                                                 where item.extermom == "minimum"
                                                 select (item.x, item.y)).ToList();


            for (int i = 0; i < maxLevel.Count - 1; i++)
            {
                double start_X = maxLevel[i].maxLevel_X;
                double end_X = maxLevel[i + 1].maxLevel_X;
                double amountOfLevel = (maxLevel[i + 1].maxLevel_Y - maxLevel[i].maxLevel_Y);
                Save_level.Add((start_X, end_X, amountOfLevel));
                Console.WriteLine($"start time = {start_X} and the end time = {end_X} " +
                     $"y1 = {maxLevel[i].maxLevel_Y} , y2 = {maxLevel[i+1].maxLevel_Y}");
            }
            for (int i = 0; i < minLevel.Count - 1; i++)
            {
                double start_X = minLevel[i].minLevel_X;
                double end_X = minLevel[i + 1].minLevel_X;
                double amountOfLevel = (minLevel[i + 1].minLevel_Y - minLevel[i].minLevel_Y);
                Save_level.Add((start_X, end_X, amountOfLevel));
                Console.WriteLine($"start time = {start_X} and the end time = {end_X} " +
                    $"y1 = {minLevel[i].minLevel_Y} , y2 = {minLevel[i + 1].minLevel_Y}");
            }

            return Save_level;
        }
    }
}
