namespace PR14_WF
{
	partial class RequestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.request_table = new System.Windows.Forms.DataGridView();
			this.clear_button = new System.Windows.Forms.Button();
			this.execute_button = new System.Windows.Forms.Button();
			this.request_groupbox = new System.Windows.Forms.GroupBox();
			this.PO_list_radio_button = new System.Windows.Forms.RadioButton();
			this.number_of_flour_radio_button = new System.Windows.Forms.RadioButton();
			this.group_list_radio_button = new System.Windows.Forms.RadioButton();
			this.short_info_radio_button = new System.Windows.Forms.RadioButton();
			this.full_info_radio_button = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.request_table)).BeginInit();
			this.request_groupbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// request_table
			// 
			this.request_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.request_table.Location = new System.Drawing.Point(7, 171);
			this.request_table.Name = "request_table";
			this.request_table.RowTemplate.Height = 24;
			this.request_table.Size = new System.Drawing.Size(781, 269);
			this.request_table.TabIndex = 7;
			// 
			// clear_button
			// 
			this.clear_button.Location = new System.Drawing.Point(594, 16);
			this.clear_button.Name = "clear_button";
			this.clear_button.Size = new System.Drawing.Size(101, 50);
			this.clear_button.TabIndex = 6;
			this.clear_button.Text = "Очистить";
			this.clear_button.UseVisualStyleBackColor = true;
			this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(452, 16);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(136, 50);
			this.execute_button.TabIndex = 5;
			this.execute_button.Text = "Выолнить запрос";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// request_groupbox
			// 
			this.request_groupbox.Controls.Add(this.PO_list_radio_button);
			this.request_groupbox.Controls.Add(this.number_of_flour_radio_button);
			this.request_groupbox.Controls.Add(this.group_list_radio_button);
			this.request_groupbox.Controls.Add(this.short_info_radio_button);
			this.request_groupbox.Controls.Add(this.full_info_radio_button);
			this.request_groupbox.Location = new System.Drawing.Point(7, 10);
			this.request_groupbox.Name = "request_groupbox";
			this.request_groupbox.Size = new System.Drawing.Size(439, 155);
			this.request_groupbox.TabIndex = 4;
			this.request_groupbox.TabStop = false;
			this.request_groupbox.Text = "Выберете запрос:";
			// 
			// PO_list_radio_button
			// 
			this.PO_list_radio_button.AutoSize = true;
			this.PO_list_radio_button.Location = new System.Drawing.Point(6, 129);
			this.PO_list_radio_button.Name = "PO_list_radio_button";
			this.PO_list_radio_button.Size = new System.Drawing.Size(328, 21);
			this.PO_list_radio_button.TabIndex = 4;
			this.PO_list_radio_button.TabStop = true;
			this.PO_list_radio_button.Text = "Список студентов, обучающихся в группе ПО";
			this.PO_list_radio_button.UseVisualStyleBackColor = true;
			// 
			// number_of_flour_radio_button
			// 
			this.number_of_flour_radio_button.AutoSize = true;
			this.number_of_flour_radio_button.Location = new System.Drawing.Point(6, 102);
			this.number_of_flour_radio_button.Name = "number_of_flour_radio_button";
			this.number_of_flour_radio_button.Size = new System.Drawing.Size(318, 21);
			this.number_of_flour_radio_button.TabIndex = 3;
			this.number_of_flour_radio_button.TabStop = true;
			this.number_of_flour_radio_button.Text = "Номера комнат, расположенных на 3 этаже";
			this.number_of_flour_radio_button.UseVisualStyleBackColor = true;
			// 
			// group_list_radio_button
			// 
			this.group_list_radio_button.AutoSize = true;
			this.group_list_radio_button.Location = new System.Drawing.Point(6, 75);
			this.group_list_radio_button.Name = "group_list_radio_button";
			this.group_list_radio_button.Size = new System.Drawing.Size(411, 21);
			this.group_list_radio_button.TabIndex = 2;
			this.group_list_radio_button.TabStop = true;
			this.group_list_radio_button.Text = "Список групп, студенты которых проживают в общежитии";
			this.group_list_radio_button.UseVisualStyleBackColor = true;
			// 
			// short_info_radio_button
			// 
			this.short_info_radio_button.AutoSize = true;
			this.short_info_radio_button.Location = new System.Drawing.Point(6, 48);
			this.short_info_radio_button.Name = "short_info_radio_button";
			this.short_info_radio_button.Size = new System.Drawing.Size(354, 21);
			this.short_info_radio_button.TabIndex = 1;
			this.short_info_radio_button.TabStop = true;
			this.short_info_radio_button.Text = "Краткая информация о студентах (ФИО, группа)";
			this.short_info_radio_button.UseVisualStyleBackColor = true;
			// 
			// full_info_radio_button
			// 
			this.full_info_radio_button.AutoSize = true;
			this.full_info_radio_button.Location = new System.Drawing.Point(6, 21);
			this.full_info_radio_button.Name = "full_info_radio_button";
			this.full_info_radio_button.Size = new System.Drawing.Size(249, 21);
			this.full_info_radio_button.TabIndex = 0;
			this.full_info_radio_button.TabStop = true;
			this.full_info_radio_button.Text = "Полная информация о студентах";
			this.full_info_radio_button.UseVisualStyleBackColor = true;
			// 
			// RequestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.request_table);
			this.Controls.Add(this.clear_button);
			this.Controls.Add(this.execute_button);
			this.Controls.Add(this.request_groupbox);
			this.Name = "RequestForm";
			this.Text = "RequestForm";
			((System.ComponentModel.ISupportInitialize)(this.request_table)).EndInit();
			this.request_groupbox.ResumeLayout(false);
			this.request_groupbox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView request_table;
		private System.Windows.Forms.Button clear_button;
		private System.Windows.Forms.Button execute_button;
		private System.Windows.Forms.GroupBox request_groupbox;
		private System.Windows.Forms.RadioButton PO_list_radio_button;
		private System.Windows.Forms.RadioButton number_of_flour_radio_button;
		private System.Windows.Forms.RadioButton group_list_radio_button;
		private System.Windows.Forms.RadioButton short_info_radio_button;
		private System.Windows.Forms.RadioButton full_info_radio_button;
	}
}