﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmoTeste.Forms
{
    public partial class Digimon : Form
    {
        private int id { get; set; }
        public Digimon(int id)
        {
            InitializeComponent();
            this.id = id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
