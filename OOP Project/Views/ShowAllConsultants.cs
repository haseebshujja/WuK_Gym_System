﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project.Views
{
    public partial class ShowAllConsultants : Form
    {
        public ShowAllConsultants()
        {
            InitializeComponent();
            FileManager fm = new FileManager();
            dataGridView1.DataSource = fm.ReadAll<Consultant>(Constants.Constants.consultantFileName);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
