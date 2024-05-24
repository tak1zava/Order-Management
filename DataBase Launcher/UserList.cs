using System;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class UserList : Form
	{
		public UserList ( )
		{
			InitializeComponent ( );
		}

		private void UserList_Load ( object sender, EventArgs e )
		{
			DBConnection.GetUserList ( ); //получения списка пользователей
			dataGridView1.DataSource = DBConnection.dtUsers; //привязка набора данных к таблице
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			string selectedRole = null; //выбранное значение поля
										//сопоставление номера выбранного значения в списке с типами ролей
			switch (comboBox1.SelectedIndex)
			{
				case 1:
					selectedRole = "директор";
					break;
				case 2:
					selectedRole = "менеджер";
					break;
				case 3:
					selectedRole = "сотрудник";
					break;
			}
			DBConnection.GetUserList ( selectedRole ); //получение списка пользователей
		}
	}
}
