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
	public partial class Assortiment : Form
	{
		public Assortiment ( )
		{
			InitializeComponent ( );
		}
		private void Assortiment_Load ( object sender, EventArgs e )
		{
			DBConnection.GetAssortimentList ( );
			dataGridView1.DataSource = DBConnection.dtAssortiment; //привязка набора данных к таблице
		}

		private void button2_Click ( object sender, EventArgs e )
		{
			try
			{
				//Создаем диалог выбора папки
				FolderBrowserDialog folderdialog = new FolderBrowserDialog();
				//открываем диалог папки и ждем, пока пользователь выберет папку
				DialogResult result = folderdialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					string fileName = Path.Combine(folderdialog.SelectedPath, "Assortiment.txt");
					FileStream fsOutput = new FileStream(fileName, FileMode.Create, FileAccess.Write);
					//поток для записи в файл
					StreamWriter swOutput = new StreamWriter(fsOutput, Encoding.UTF8);
					swOutput.WriteLine ( "Ассортимент" );
					//выполняем обход таблицы
					for (int i = 0; i < dataGridView1.Rows.Count; i++)
					{
						//заносим Название товара
						swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 1 ].Value.ToString ( ) );
						swOutput.Write ( " " );
						//заносим значение Количетсва
						swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 2 ].Value.ToString ( ) );
						swOutput.Write ( " " );
						swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 3 ].Value.ToString ( ) );
						swOutput.Write ( " " );
						swOutput.Write ( dataGridView1.Rows [ i ].Cells [ 4 ].Value.ToString ( ) );
						//добавляем перенос строки
						swOutput.WriteLine ( );
					}
					swOutput.WriteLine ( "Итого записей: " + (dataGridView1.Rows.Count).ToString ( ) );
					swOutput.Close ( );
					MessageBox.Show ( "Вывод в файл успешно завершён!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
				} else if (result == DialogResult.Cancel)
				{
					MessageBox.Show ( "Сохранение файла отменено.", "Информация" );
				}
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.Message, "Произошла ошибка!" );
			}
		}

		private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
		{

		}
	}
}
