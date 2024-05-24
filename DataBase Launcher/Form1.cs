using System;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class MainForm : Form
	{
		public MainForm ( )
		{
			InitializeComponent ( );
		}
		//
		//загрузка формы
		//
		private void Form1_Load ( object sender, EventArgs e )
		{
			if (!DBConnection.Connect ( )) //если соединение не установлено
			{
				this.Close ( ); //выход из программы
			}
			txtLogin.MaxLength = 40;
			txtPassword.MaxLength = 20;
		}
		//
		//действие при закрытии формы
		//
		private void Form1_FormClosing ( object sender, FormClosingEventArgs e )
		{
			DBConnection.Close ( );
			Application.Exit ( );
		}

		private void button1_Click_1 ( object sender, EventArgs e )
		{
			//вызываем метод авторизации и передаем введенные логин и пароль
			DBConnection.Authorization ( txtLogin.Text, txtPassword.Text );
			switch (DBConnection.Role)
			{
				//если роль не распознана, пользователь не авторизован
				case null:
					MessageBox.Show ( "Неверные данные!" );

					break;
				//если авторизован заказчик
				case "менеджер":

					break;
				//если авторизован администратор
				case "директор":
					this.Hide ( ); //скрываем текущую форму
					AdministratorMenu AdminFrm = new AdministratorMenu();//создаем и показываем
					AdminFrm.Show ( ); //меню администратора
					txtLogin.Text = "";
					txtPassword.Text = "";
					break;
				case "сотрудник":
					this.Hide ( ); //скрываем текущую форму
					DoOrder doOrder= new DoOrder(); //создаем и показываем
					doOrder.Show ( ); //меню заказчика
					txtLogin.Text = "";
					txtPassword.Text = "";
					break;
			}
		}

		private void txtLogin_TextChanged_1 ( object sender, EventArgs e )
		{

		}
	}
}
