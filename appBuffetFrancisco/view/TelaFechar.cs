﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.view
{
    public partial class TelaFechar : Form
    {
        public TelaFechar()
        {
            InitializeComponent();
        }
        private void TelaFehcar_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
        }
    }
}
