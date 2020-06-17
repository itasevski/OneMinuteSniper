/*
    Created by: Ivo Tasevski
    * Target class - the complete design of the target.
    * Last Revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Minute_Sniper
{
    class Target
    {
        public Color targetColor { get; set; }

        public float RADIUS = 40;

        Point shape_location;

        public Target(Color color)
        {
            this.targetColor = color;
            this.RADIUS = 65;
        } 

        public void drawTarget(Graphics g, int x_location, int y_location)
        {
            shape_location.X = x_location;
            shape_location.Y = y_location;

            Brush brush = new SolidBrush(targetColor); // DEFAULT COLOR - BLUE
            g.FillEllipse(brush, x_location, y_location, RADIUS * 2, RADIUS * 2);
        }

        public bool isTargetShot(Point clicked_location)
        {
            return (clicked_location.X - shape_location.X - RADIUS) * (clicked_location.X - shape_location.X - RADIUS) +
                   (clicked_location.Y - shape_location.Y - RADIUS) * (clicked_location.Y - shape_location.Y - RADIUS)
                   <= RADIUS * RADIUS;
        }
    }
}
