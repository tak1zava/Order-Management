using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase_Launcher
{
	public partial class DoOrder : Form
	{
		public DoOrder ( )
		{
			InitializeComponent ( );
		}

		private void AddOrder_Load ( object sender, EventArgs e )
		{
			customerTxt.MaxLength = 40;
			employeeTxt.MaxLength = 45;
			orderDateTxt.MaxLength = 20;
			totalAmountTxt.MaxLength = 40;

			orderIdTxt.MaxLength = 45;
			productTxt.MaxLength = 20;
			quantityTxt.MaxLength = 40;
		}

		private void doOrderBtn_Click ( object sender, EventArgs e )
		{
			try
			{
				if (customerTxt.Text.Length == null || employeeTxt.Text.Length == null)
					MessageBox.Show ( "Данные не удовлетворяют требованиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
				else
				{
					DBConnection.AddOrder ( customerTxt.Text, employeeTxt.Text, orderDateTxt.Text, totalAmountTxt.Text,
						orderIdTxt.Text, productTxt.Text, quantityTxt.Text);
					Close ( );
				}
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.Message );
			}
		}
	}
}
