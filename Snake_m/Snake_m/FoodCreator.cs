using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_m
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(3, mapWidht - 3);
            int y = random.Next(3, mapHeight - 3);
            return new Point(x, y, sym);
        }
    }
}
