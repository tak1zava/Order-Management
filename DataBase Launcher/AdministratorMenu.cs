using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class AdministratorMenu : Form
	{
		public AdministratorMenu ( )
		{
			InitializeComponent ( );
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			UserList UserListFrm=new UserList();
			UserListFrm.ShowDialog ( );
		}



		private void Exit_Button_Click ( object sender, EventArgs e )
		{
			this.Close ( );
			Application.OpenForms [ 0 ].Show ( );
		}

		private void button2_Click ( object sender, EventArgs e )
		{
			EmployeeList EmployeeListFrm = new EmployeeList();
			EmployeeListFrm.ShowDialog ( );
		}

		private void button3_Click ( object sender, EventArgs e )
		{
			CustomerManagment CustomerManagmentFrm = new CustomerManagment();
			CustomerManagmentFrm.ShowDialog ( );
		}

		private void button5_Click ( object sender, EventArgs e )
		{
			Sales salesFrm = new Sales();
			salesFrm.ShowDialog ( );
		}

		private void button6_Click ( object sender, EventArgs e )
		{
			Assortiment assortimentFrm=new Assortiment();
			assortimentFrm.ShowDialog ( );
		}

		private void order_Click ( object sender, EventArgs e )
		{
			Order orderFrm = new Order();
			orderFrm.ShowDialog ( );
		}

		private void doOrderBtn_Click ( object sender, EventArgs e )
		{
			DoOrder doOrderFrm = new DoOrder();
			doOrderFrm.ShowDialog ( );
		}
	}
}
