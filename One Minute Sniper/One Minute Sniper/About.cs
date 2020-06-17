/*
    Created by: Matej Cvetanovski
    * About form - Information about the application, such as what it is for, how to play. Contains the latest patch notes.
    * Last Revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Minute_Sniper
{
    public partial class About : Form
    {
        // ============= INIT ============= //

        int formWidth;
        int formHeight;

        Graphics pomGraphics;
        Pen pen;
        Point x;
        Point y;

        string version1 = String.Format("***VERSION 1.0.0***{0}- All systems designed and implemented {1}- All functionalities implemented {2}- Resources added {3}- Database created", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine);

        // ================================ //

        public About()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.MaximizeBox = false;

            pomGraphics = CreateGraphics();

            tbPatchNotes.Text += version1;
        }

        private void drawSeparator(Graphics g, int fw, int fh)
        {
            pen = new Pen(Color.Black, 2);

            x = new Point(fw / 2, 0);
            y = new Point(fw / 2, fh - 5);

            g.DrawLine(pen, x, y);

            pen.Dispose();
        }

        private void About_Paint(object sender, PaintEventArgs e)
        {
            formWidth = ClientSize.Width;
            formHeight = ClientSize.Height;

            drawSeparator(pomGraphics, formWidth, formHeight);
        }

        private void About_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
