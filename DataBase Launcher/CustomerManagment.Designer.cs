namespace DataBase_Launcher
{
	partial class CustomerManagment
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
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtEmailEdit = new System.Windows.Forms.TextBox();
			this.txtNameEdit = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLoginEdit = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(327, 423);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(169, 46);
			this.button4.TabIndex = 30;
			this.button4.Text = "Вывод в файл";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(734, 425);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(91, 41);
			this.button3.TabIndex = 29;
			this.button3.Text = "Отбор";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Есть почта",
            "Нет почты",
            "Не выбрано"});
			this.comboBox1.Location = new System.Drawing.Point(861, 435);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(139, 21);
			this.comboBox1.TabIndex = 28;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// txtEmailEdit
			// 
			this.txtEmailEdit.Location = new System.Drawing.Point(820, 252);
			this.txtEmailEdit.Multiline = true;
			this.txtEmailEdit.Name = "txtEmailEdit";
			this.txtEmailEdit.Size = new System.Drawing.Size(154, 20);
			this.txtEmailEdit.TabIndex = 26;
			// 
			// txtNameEdit
			// 
			this.txtNameEdit.Location = new System.Drawing.Point(820, 204);
			this.txtNameEdit.Multiline = true;
			this.txtNameEdit.Name = "txtNameEdit";
			this.txtNameEdit.Size = new System.Drawing.Size(154, 20);
			this.txtNameEdit.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(817, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Contact_email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(817, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Contact_person";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(817, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Company_name";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(820, 38);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(171, 44);
			this.button2.TabIndex = 17;
			this.button2.Text = "Редактировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(10, 423);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 44);
			this.button1.TabIndex = 15;
			this.button1.Text = "Добавить";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(-3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(786, 378);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Enabled = false;
			this.txtCustomerId.Location = new System.Drawing.Point(820, 122);
			this.txtCustomerId.Multiline = true;
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(154, 20);
			this.txtCustomerId.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(817, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 17);
			this.label3.TabIndex = 32;
			this.label3.Text = "Customer_id";
			// 
			// txtLoginEdit
			// 
			this.txtLoginEdit.Location = new System.Drawing.Point(820, 165);
			this.txtLoginEdit.Multiline = true;
			this.txtLoginEdit.Name = "txtLoginEdit";
			this.txtLoginEdit.Size = new System.Drawing.Size(154, 20);
			this.txtLoginEdit.TabIndex = 33;
			// 
			// CustomerManagment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(997, 494);
			this.Controls.Add(this.txtLoginEdit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtEmailEdit);
			this.Controls.Add(this.txtNameEdit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CustomerManagment";
			this.Text = "CustomerManagment";
			this.Load += new System.EventHandler(this.CustomerManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtEmailEdit;
		private System.Windows.Forms.TextBox txtNameEdit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLoginEdit;
	}
}