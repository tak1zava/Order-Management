using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Launcher
{
	public partial class Order : Form
	{
		public Order ( )
		{
			InitializeComponent ( );
		}

		private void Order_Load( object sender, EventArgs e )
		{
			DBConnection.GetOrder ( );
			dataGridView1.DataSource = DBConnection.dtOrders;
			DBConnection.GetOrderItems ( );
			dataGridView2.DataSource = DBConnection.dtOrderItems;
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			// Проверяем, что есть выбранная строка в DataGridView
			/*if (dataGridView1.SelectedRows.Count > 0)
			{
				// Получаем значение ключевого столбца (например, order_id)
				string orderIDValue = Convert.ToString(dataGridView1.SelectedRows[0].Cells["order_id"].Value);

				// Удаляем строку из DataGridView
				dataGridView1.Rows.Remove ( dataGridView1.SelectedRows [ 0 ] );

				// Удаляем строку из базы данных
				DBConnection.DeleteRowFromDB ( "order_table", "order_id", orderIDValue );
			}*/
		}

	}
}
