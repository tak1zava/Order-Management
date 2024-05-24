using System;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class EmployeeList : Form
	{
		public EmployeeList ( )
		{
			InitializeComponent ( );
		}

		private void EmployeeList_Load ( object sender, EventArgs e )
		{
			DBConnection.GetEmployeeList( ); //получения списка пользователей
			dataGridView1.DataSource = DBConnection.dtEmployee; //привязка набора данных к таблице
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			string position = null; //выбранное значение поля
										//сопоставление номера выбранного значения в списке с типами ролей
			switch (comboBox1.SelectedIndex)
			{
				case 1:
					position = "Бухгалтер";
					break;
				case 2:
					position = "Менеджер по продажам";
					break;
				case 3:
					position = "Директор";
					break;
			}
			DBConnection.GetEmployeeList ( position ); //получение списка пользователей
		}

		private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}
	}
}
