using System;
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
	public partial class AddCustomer : Form
	{
		public AddCustomer()
        {
            InitializeComponent();
        }
        //
        //КНОПКА ЗАРЕГИСТРИРОВАТЬ
        //
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
				if (txtLogin.Text.Length == null || txtName.Text.Length == null)
					MessageBox.Show ( "Данные не удовлетворяют требованиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
				else
				{
					DBConnection.AddUser ( txtLogin.Text, "сustomer" );
					DBConnection.AddCustomer ( txtLogin.Text, txtName.Text, txtEmail.Text );
					Close ( );
				}
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        //кнопка закрытия формы
        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtLogin.MaxLength = 40;
            txtName.MaxLength = 45;
			txtEmail.MaxLength = 20;
        }

		private void txtPassword_TextChanged ( object sender, EventArgs e )
		{

		}

		private void label6_Click ( object sender, EventArgs e )
		{

		}

		private void label5_Click ( object sender, EventArgs e )
		{

		}

		private void label4_Click ( object sender, EventArgs e )
		{

		}

		private void label3_Click ( object sender, EventArgs e )
		{

		}

		private void label2_Click ( object sender, EventArgs e )
		{

		}

		private void label1_Click ( object sender, EventArgs e )
		{

		}

		private void txtEmail_TextChanged ( object sender, EventArgs e )
		{

		}

		private void txtAdress_TextChanged ( object sender, EventArgs e )
		{

		}

		private void txtTelephone_TextChanged ( object sender, EventArgs e )
		{

		}

		private void txtName_TextChanged ( object sender, EventArgs e )
		{

		}

		private void txtLogin_TextChanged ( object sender, EventArgs e )
		{

		}

		private void textBox1_TextChanged ( object sender, EventArgs e )
		{

		}
	}
}
