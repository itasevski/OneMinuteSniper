/*
    Created by: Ivo Tasevski
    * Reticle class - the complete style and design of the reticle.
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
    class Reticle
    {
        public Color reticleColor { get; set; }
        public String reticleStyle { get; set; }

        public static readonly int RADIUS = 160;

        public bool startMoving = false;

        public Reticle(Color col, String style)
        {
            this.reticleColor = col;
            this.reticleStyle = style;
        } // ke se proveruva stringot za toa koj style da se koristi


        public void drawReticle(Graphics g, int X_COORDINATE, int Y_COORDINATE)
        {
            Pen pen = new Pen(this.reticleColor, 2.1F);

            if (this.reticleStyle == "Style 1")
            {
                if (startMoving == false)
                {
                    g.DrawEllipse(pen, X_COORDINATE / 2 - RADIUS, Y_COORDINATE / 2 - RADIUS, RADIUS * 2, RADIUS * 2);

                    g.DrawLine(pen, X_COORDINATE / 2 - RADIUS, Y_COORDINATE / 2, X_COORDINATE / 2 + RADIUS, Y_COORDINATE / 2);
                    g.DrawLine(pen, X_COORDINATE / 2, Y_COORDINATE / 2 - RADIUS, X_COORDINATE / 2 , Y_COORDINATE / 2 + RADIUS);
                    // poceten nisan da bide vo sredina
                }
                else
                {
                    g.DrawEllipse(pen, X_COORDINATE - RADIUS, Y_COORDINATE - RADIUS, RADIUS * 2, RADIUS * 2);

                    g.DrawLine(pen, X_COORDINATE - RADIUS, Y_COORDINATE, X_COORDINATE + RADIUS, Y_COORDINATE);
                    g.DrawLine(pen, X_COORDINATE, Y_COORDINATE - RADIUS, X_COORDINATE, Y_COORDINATE + RADIUS);
                }
            }
            else if (this.reticleStyle == "Style 2")
            {
                if (startMoving == false)
                {
                    g.DrawEllipse(pen, X_COORDINATE / 2 - RADIUS, Y_COORDINATE / 2 - RADIUS, RADIUS * 2, RADIUS * 2);

                    g.DrawLine(pen, X_COORDINATE / 2 - RADIUS, Y_COORDINATE / 2, X_COORDINATE / 2 + RADIUS, Y_COORDINATE / 2);
                    g.DrawLine(pen, X_COORDINATE / 2, Y_COORDINATE / 2, X_COORDINATE / 2, Y_COORDINATE / 2 + RADIUS);
                }
                else
                {
                    g.DrawEllipse(pen, X_COORDINATE - RADIUS, Y_COORDINATE - RADIUS, RADIUS * 2, RADIUS * 2);

                    g.DrawLine(pen, X_COORDINATE - RADIUS, Y_COORDINATE, X_COORDINATE + RADIUS, Y_COORDINATE);
                    g.DrawLine(pen, X_COORDINATE, Y_COORDINATE, X_COORDINATE, Y_COORDINATE + RADIUS);
                }
            }
            else if (this.reticleStyle == "Style 3")
            {
                if (startMoving == false)
                {
                    g.DrawLine(pen, X_COORDINATE / 2 - RADIUS, Y_COORDINATE / 2, X_COORDINATE / 2 + RADIUS, Y_COORDINATE / 2);
                    g.DrawLine(pen, X_COORDINATE / 2, Y_COORDINATE / 2 - RADIUS, X_COORDINATE / 2, Y_COORDINATE / 2 + RADIUS);
                }
                else
                {
                    g.DrawLine(pen, X_COORDINATE - RADIUS, Y_COORDINATE, X_COORDINATE + RADIUS, Y_COORDINATE);
                    g.DrawLine(pen, X_COORDINATE, Y_COORDINATE - RADIUS, X_COORDINATE, Y_COORDINATE + RADIUS);
                }
            }
        }
    }
}
