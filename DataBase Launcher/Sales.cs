﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class Sales : Form
	{
		public Sales ( )
		{
			InitializeComponent ( );
		}

		private void Sales_Load ( object sender, EventArgs e )
		{
			DBConnection.GetSalesList ( );
			dataGridView1.DataSource = DBConnection.dtSales;
		}

		private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
		{

		}
	}
}
