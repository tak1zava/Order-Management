using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase_Launcher
{
	internal class DBConnection
	{
		static string connectionString = @"Database = tac_database; Data Source = localhost; 
UserID = root; Password = 967749"
		; //строка подключения
		static MySqlConnection msConnect; //объект для установки соединения с БД
		static MySqlCommand msCommand; //объект для выполнения запросов
		static public MySqlDataAdapter msDataAdapter;
		// установка соединения с БД
		static public bool Connect ( )
		{
			try
			{
				//создание объекта соединения с заданной строкой подключения
				msConnect = new MySqlConnection ( connectionString );
				msConnect.Open ( ); //открытие подключения
									//создание объекта-запрос
				msCommand = new MySqlCommand ( );
				msCommand.Connection = msConnect;
				msDataAdapter = new MySqlDataAdapter ( msCommand );
				return true; //результат «истина»
			} catch (Exception ex) //при возникновении ошибки
			{
				//вывод сообщения
				System.Windows.Forms.MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
				return false; //результат "ложь"
			}
		}

		static public void Close ( )
		{
			msConnect.Close ( );
		}
		static public string User; //логин авторизованного пользователя
		static public string Role; //роль авторизованного пользователя
		static public void Authorization ( string login, string password )
		{
			try
			{
				//формируем запрос: выбрать поле из таблицы значения,
				//где логин и пароль равны введенным пользователем значениям
				string sql = "SELECT role FROM user WHERE username = '" + login
					+ "' AND password = '" + password + "' ;";
				//создаем запрос
				if (msCommand != null)
				{
					msCommand.CommandText = sql;
				} else
				{
					MessageBox.Show ( login + " " + password + " \nНет подключения!" );
				}
				//фиксируем результат запроса
				Object result = msCommand.ExecuteScalar();
				//если в результате выполнения запроса получено непустое значение
				if (result != null)
				{
					//заполняем информацию об авторизированном пользователе
					Role = result.ToString ( );
					User = login;
				} else
				{
					//иначе тип пользователя-неавторизированный
					Role = null;
				}
			} catch (Exception ex)
			{
				Role = User = null; //обнуляем значения полей
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}
		static public DataTable dtUsers = new DataTable();
		static public DataTable dtEmployee = new DataTable();
		static public DataTable dtCustomers = new DataTable();
		static public DataTable dtCount = new DataTable();
		static public DataTable dtDetail = new DataTable();
		static public DataTable dtWrittenOff = new DataTable();
		static public DataTable dtSales = new DataTable();
		static public DataTable dtAssortiment = new DataTable();
		static public DataTable dtOrders = new DataTable();
		static public DataTable dtOrderItems = new DataTable();
		//
		//получение данных о пользователях из таблицы User
		//
		static public void GetUserList ( string selectedRole = null )
		{
			try
			{
				//если роль не выбрана
				if (selectedRole == null)
				{
					//формируем запрос на выборку всех записей
					msCommand.CommandText = "SELECT * FROM user";
				} else
				{
					//иначе, формируем запрос с фильтрацией
					msCommand.CommandText = "SELECT * FROM user WHERE user.role='" + selectedRole + "'";
				}
				dtUsers.Clear ( ); //очистка набора данных
				msDataAdapter.Fill ( dtUsers ); //заполнение набора данных
			} catch (Exception ex)
			{
				//вывод сообщения
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}

		static public void GetEmployeeList ( string position = null )
		{
			try
			{
				if (position == null)
				{
					msCommand.CommandText = "SELECT * FROM employee";
				} else
				{
					msCommand.CommandText = "SELECT * FROM employee WHERE employee.position='" + position + "'";
				}

				dtEmployee.Clear ( ); //очистка набора данных
				msDataAdapter.Fill ( dtEmployee ); //заполнение набора данных
			} catch (Exception ex)
			{
				//вывод сообщения
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );

			}
		}
		//
		//получение данных о заказчиках из таблицы Customers
		//
		static public void GetCustomerList ( string selectedEmail )
		{
			try
			{
				if (selectedEmail == null)
				{
					msCommand.CommandText = "SELECT * FROM customer";
				} else
				{
					msCommand.CommandText = "SELECT * FROM customer" + selectedEmail;
				}
				dtCustomers.Clear ( ); //очистка набора данных
				msDataAdapter.Fill ( dtCustomers ); //заполнение набора данных
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}
		//добавление нового пользователя
		static public bool AddUser ( string login, string role )
		{

			//формирование запроса
			msCommand.CommandText = "INSERT INTO user (username, password, role) VALUES(username='" + login + "', password=19987, role='" + role + "');";
			//выполнение запроса 
			if (msCommand.ExecuteNonQuery ( ) > 0)
				return true;
			else
				return false;
		}

		//добавление заказа
		static public void AddOrder(string customer_id, string employee_id, string order_date, string total_amount, 
			string order_id, string product_id, string quantity)
		{
			//формирование запроса 
			msCommand.CommandText = "INSERT INTO order_table (customer_id, employee_id, order_date, total_amount) VALUES " +
				"('" + customer_id + "', '" + employee_id + "', '" + order_date + "', '" + total_amount + "');";
			//выполнение запроса
			msCommand.ExecuteNonQuery ( );

			msCommand.CommandText = "INSERT INTO order_item (product_id, quantity) VALUES " +
				"('" + product_id + "', '" + quantity + "');";
			msCommand.ExecuteNonQuery ( );
		}

		//добавление нового заказчика
		static public void AddCustomer ( string company_name, string contact_person, string contact_email )
		{
			//формирование запроса 
			msCommand.CommandText = "INSERT INTO customer (company_name, contact_person, contact_email) VALUES ('" + company_name + "', '" + contact_person + "', '" + contact_email + "');";
			//выполнение запроса
			msCommand.ExecuteNonQuery ( );
		}

		static public void EditCustomer (string customer_id, string company_name, string contact_person, string contact_email)
		{
			msCommand.CommandText = "UPDATE customer SET company_name = '" + company_name + "',contact_person = '" + contact_person + "',contact_email='" + contact_email + "' WHERE customer_id='" + customer_id + "';";
			//выполение запроса
			msCommand.ExecuteNonQuery ( );
		}

		static public void GetOrder ( )
		{
			try
			{
				msCommand.CommandText = "SELECT * FROM order_table";
				dtOrders.Clear ( );
				msDataAdapter.Fill ( dtOrders ); //заполнение набора данных
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}

		static public void GetOrderItems( )
		{
			try
			{
				msCommand.CommandText = "SELECT * FROM order_item";
				dtOrderItems.Clear ( );
				msDataAdapter.Fill ( dtOrderItems );
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
			
		}

		static public void GetSalesList ( )
		{
			try
			{
				msCommand.CommandText = "SELECT * FROM license";
				dtSales.Clear ( ); //очистка набора данных
				msDataAdapter.Fill ( dtSales ); //заполнение набора данных
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}

		static public void GetAssortimentList ( string selectedCategory = null )
		{
			try
			{
				
				msCommand.CommandText = "SELECT * FROM product ";
				
				dtAssortiment.Clear ( );
				msDataAdapter.Fill ( dtAssortiment );
			} catch (Exception ex)
			{
				MessageBox.Show ( ex.ToString ( ), "Ошибка!" );
			}
		}

		static public string GetOrderConnections1 ( string customer_id)
		{
			msCommand.CommandText = @"SELECT company_name FROM customer WHERE customer_id='" + customer_id + "';";
			object result = msCommand.ExecuteScalar ( );
			if ( result != null)
			{
				return result.ToString ( );
			}
			else
			{
				return null;
			}
		}

		static public void DeleteRowFromDB ( string table, string id_name, string id )
		{
			try
			{
				msCommand.CommandText = $"DELETE FROM {table} WHERE {id_name} = @ID";
				msCommand.Parameters.AddWithValue ( "@ID", id );

				msCommand.ExecuteNonQuery ( );
			} catch (Exception ex)
			{
				Console.WriteLine ( "Ошибка при удалении строки из базы данных: " + ex.Message );
			} finally
			{
				msCommand.Parameters.Clear ( ); // Очистим параметры после использования
			}
		}

		static public string GetOrderConnections2 ( string employee_id )
		{
			msCommand.CommandText = @"SELECT full_name FROM employee WHERE employee_id='" + employee_id + "';";
			object result = msCommand.ExecuteScalar ( );
			if (result != null)
			{
				return result.ToString ( );
			} else
			{
				return null;
			}
		}

		static public string GetOrderItemConnections1 (string order_id)
		{
			msCommand.CommandText = @"SELECT total_amount FROM order_table WHERE order_id='" + order_id + "';";
			object result = msCommand.ExecuteScalar ( );
			if (result != null)
			{
				return result.ToString ( );
			} else
			{
				return null;
			}
		}

		static public string GetOrderItemConnections2 ( string product_id )
		{
			msCommand.CommandText = @"SELECT product_name FROM product WHERE product_id='" + product_id + "';";
			object result = msCommand.ExecuteScalar ( );	
			if (result != null)
			{
				return result.ToString ( );
			} else
			{
				return null;
			}
		}

		static public string GetProductId ( string productName )
		{
			msCommand.CommandText = @"SELECT Product FROM Assortiment WHERE Name='" +
			productName + "';";
			object result = msCommand.ExecuteScalar();
			//если результат запроса не пустой
			if (result != null)
			{
				return result.ToString ( ); //возвращаем полученное значение
			} else
				return null; //иначе возвращаем пустое значение
		}

	}
}