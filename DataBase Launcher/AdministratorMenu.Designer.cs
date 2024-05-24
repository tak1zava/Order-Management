namespace DataBase_Launcher
{
	partial class AdministratorMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.Exit_Button = new System.Windows.Forms.Button();
			this.order = new System.Windows.Forms.Button();
			this.doOrderBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(316, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 61);
			this.button1.TabIndex = 4;
			this.button1.Text = "Список пользователей";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(316, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(164, 61);
			this.button2.TabIndex = 5;
			this.button2.Text = "Управление должностями";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(316, 146);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(164, 61);
			this.button3.TabIndex = 6;
			this.button3.Text = "Управление заказчиками";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(316, 283);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(164, 59);
			this.button5.TabIndex = 8;
			this.button5.Text = "Лицензия";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(316, 348);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(164, 79);
			this.button6.TabIndex = 9;
			this.button6.Text = "Просмотр ассортимента";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Exit_Button
			// 
			this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit_Button.Location = new System.Drawing.Point(685, 391);
			this.Exit_Button.Name = "Exit_Button";
			this.Exit_Button.Size = new System.Drawing.Size(103, 47);
			this.Exit_Button.TabIndex = 10;
			this.Exit_Button.Text = "Выход";
			this.Exit_Button.UseVisualStyleBackColor = true;
			this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
			// 
			// order
			// 
			this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.order.Location = new System.Drawing.Point(316, 213);
			this.order.Name = "order";
			this.order.Size = new System.Drawing.Size(164, 59);
			this.order.TabIndex = 11;
			this.order.Text = "Заказы";
			this.order.UseVisualStyleBackColor = true;
			this.order.Click += new System.EventHandler(this.order_Click);
			// 
			// doOrderBtn
			// 
			this.doOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.doOrderBtn.Location = new System.Drawing.Point(486, 213);
			this.doOrderBtn.Name = "doOrderBtn";
			this.doOrderBtn.Size = new System.Drawing.Size(164, 59);
			this.doOrderBtn.TabIndex = 12;
			this.doOrderBtn.Text = "Добавить заказ";
			this.doOrderBtn.UseVisualStyleBackColor = true;
			this.doOrderBtn.Click += new System.EventHandler(this.doOrderBtn_Click);
			// 
			// AdministratorMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.doOrderBtn);
			this.Controls.Add(this.order);
			this.Controls.Add(this.Exit_Button);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "AdministratorMenu";
			this.Text = "AdministratorMenu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button Exit_Button;
		private System.Windows.Forms.Button order;
		private System.Windows.Forms.Button doOrderBtn;
	}
}