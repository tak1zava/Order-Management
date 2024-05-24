namespace DataBase_Launcher
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(178, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(521, 147);
			this.label1.TabIndex = 1;
			this.label1.Text = "Авторизация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtPassword);
			this.panel2.Controls.Add(this.txtLogin);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(298, 226);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(291, 115);
			this.panel2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(13, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Логин";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(13, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Пароль";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(108, 68);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(158, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(108, 21);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(158, 20);
			this.txtLogin.TabIndex = 0;
			this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(330, 400);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(218, 87);
			this.button1.TabIndex = 7;
			this.button1.Text = "Авторизоваться";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 544);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler ( this.Form1_FormClosing );
			this.Load += new System.EventHandler ( this.Form1_Load );
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Button button1;
	}
}

