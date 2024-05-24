using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class CustomerManagment : Form
	{
		public CustomerManagment ( )
		{
			InitializeComponent ( );
		}
		//
		//При загрузке формы
		//
		private void CustomerManagement_Load ( object sender, EventArgs e )
		{
			DBConnection.GetCustomerList ( null);
			dataGridView1.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
			button2.Enabled = false;
		}
		//
		//кнопка добавления
		//
		private void button1_Click ( object sender, EventArgs e )
		{
			if (ActiveForm is AddCustomer)
			{
			} else
			{
				AddCustomer addCustFrm = new AddCustomer();
				addCustFrm.ShowDialog ( );
				DBConnection.GetCustomerList (null );
				dataGridView1.DataSource = DBConnection.dtCustomers; //привязка набора данных к таблице
			}
		}
		//
		//кнопка редактирования
		//
		private void button2_Click ( object sender, EventArgs e )
		{
			if ((txtLoginEdit.TextLength != 0) && (txtNameEdit.TextLength != 0))
			{
				try
				{
					DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						DBConnection.EditCustomer ( txtCustomerId.Text, txtLoginEdit.Text, txtNameEdit.Text, txtEmailEdit.Text );
						DBConnection.GetCustomerList (null );
						MessageBox.Show ( "Изменения успешно сохранены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
					} else
					{ }
				} catch (Exception ex)
				{
					MessageBox.Show ( ex.Message );
				}
			} else
			{
				MessageBox.Show ( "Данные не удовлетворяют требованиям полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}
		//
		//изменение полей ввода при выборе строки
		//
		private void dataGridView1_CellClick ( object sender, DataGridViewCellEventArgs e )
		{
			//очищение полей старой строки перед выбором новой
			txtCustomerId.Text = "";
			txtLoginEdit.Text = "";
			txtNameEdit.Text = "";
			txtEmailEdit.Text = "";

			txtCustomerId.Text = dataGridView1.CurrentRow.Cells [ 0 ].Value.ToString ( );
			txtLoginEdit.Text = dataGridView1.CurrentRow.Cells [ 1 ].Value.ToString ( );
			txtNameEdit.Text = dataGridView1.CurrentRow.Cells [ 2 ].Value.ToString ( );
			if (dataGridView1.CurrentRow.Cells [ 3 ].Value.ToString ( ) != "")
			{
				txtEmailEdit.Text = dataGridView1.CurrentRow.Cells [ 3 ].Value.ToString ( );
			}
			button2.Enabled = true;
		}

		private void button3_Click ( object sender, EventArgs e )
		{
			string selectedEmail = null; // Выбранное значение поля

			// Сопоставление номера выбранного значения в списке с типами ролей
			switch (comboBox1.SelectedIndex)
			{
				case 0:
				selectedEmail = " WHERE contact_email IS NOT NULL AND contact_email <> '' ";
				break;
				case 1:
				selectedEmail = " WHERE contact_email IS NULL OR contact_email = '' ";
				break;
			}

			DBConnection.GetCustomerList ( selectedEmail ); // Получение списка пользователей
		}

		private void button4_Click ( object sender, EventArgs e )
		{
			try
			{
				string fileName = "customers.txt"; //имя файла
												   //файловый поток создается для записи
				FileStream fsOutput = new FileStream(fileName, FileMode.Create,
				FileAccess.Write);
				//объект для записи в файл
				StreamWriter swOutput = new StreamWriter(fsOutput);
				//вывод строки в файл
				swOutput.WriteLine ( "Список заказчиков" );
				//выполняем обход таблицы
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					//заносим значение ФИО из 1го столбца таблицы
					swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 2 ].Value.ToString ( ) );
					swOutput.Write ( " " );
					//заносим значение email из 3го столбца таблицы
					swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 3 ].Value.ToString ( ) );
					//добавляем перенос строки
					swOutput.WriteLine ( );
				}
				swOutput.WriteLine ( "Итого записей: " + (dataGridView1.Rows.Count).ToString ( ) );
				swOutput.Close ( ); //закрытие потока
				MessageBox.Show ( "Вывод в файл произошёл успешно!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.Message, "Произошла ошибка!" );
			}

		}

		private void button4_Click_1 ( object sender, EventArgs e )
		{

		}

		private void txtLoginEdit_TextChanged ( object sender, EventArgs e )
		{

		}

		private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
		{

		}

		private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}
	}
}
