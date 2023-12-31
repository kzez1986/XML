﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToXmlWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtInventor.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);

            txtInventor.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
        }

        private void btnLookUpColors_Click(object sender, EventArgs e)
        {
            LinqToXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
        }
    }
}
