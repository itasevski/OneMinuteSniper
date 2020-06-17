﻿/*
    Created by: Matej Cvetanovski
    * Follow us form - Information about ourselves (the developers). Contact information for bugs and improvements and credits.
    * Last Revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Minute_Sniper
{
    public partial class FollowUs : Form
    {
        public FollowUs()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailCommand = "mailto:ivo_t@live.com?subject=ONE-MINUTE-SNIPER:Bugs-And-Improvements";
            Process.Start(mailCommand);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailCommand = "mailto:matej_cvetanovski@hotmail.com?subject=ONE-MINUTE-SNIPER:Bugs-And-Improvements";
            Process.Start(mailCommand);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/itasevski/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/cvetanovskimatej/");
        }
    }
}
