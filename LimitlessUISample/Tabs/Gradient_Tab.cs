﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitlessUISample.Tabs
{
    public partial class Gradient_Tab : UserControl
    {
        private static Gradient_Tab _instance;

        public Gradient_Tab()
        {
            InitializeComponent();
        }

        public static Gradient_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Gradient_Tab();
            return _instance;
        }
    }
}