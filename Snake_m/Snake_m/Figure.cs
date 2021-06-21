using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_m
{
    class Figure
    {
        protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
