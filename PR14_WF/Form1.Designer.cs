namespace PR14_WF
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Main_menu = new System.Windows.Forms.MenuStrip();
			this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Tables_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Rooms_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Privelege_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Students_MenuItems = new System.Windows.Forms.ToolStripMenuItem();
			this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Setting_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.requestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Students_data = new System.Windows.Forms.BindingSource(this.components);
			this.studentsDataSet = new PR14_WF.StudentsDataSet();
			this.report_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Main_menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Students_data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// Main_menu
			// 
			this.Main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem,
            this.Tables_MenuItem,
            this.просмотрToolStripMenuItem,
            this.requestMenuItem,
            this.report_menuItem});
			this.Main_menu.Location = new System.Drawing.Point(0, 0);
			this.Main_menu.Name = "Main_menu";
			this.Main_menu.Size = new System.Drawing.Size(494, 28);
			this.Main_menu.TabIndex = 0;
			this.Main_menu.Text = "menuStrip1";
			// 
			// File_MenuItem
			// 
			this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.File_MenuItem.Name = "File_MenuItem";
			this.File_MenuItem.Size = new System.Drawing.Size(57, 24);
			this.File_MenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// Tables_MenuItem
			// 
			this.Tables_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rooms_MenuItem,
            this.Privelege_MenuItem,
            this.Students_MenuItems});
			this.Tables_MenuItem.Name = "Tables_MenuItem";
			this.Tables_MenuItem.Size = new System.Drawing.Size(83, 24);
			this.Tables_MenuItem.Text = "Таблицы";
			// 
			// Rooms_MenuItem
			// 
			this.Rooms_MenuItem.Name = "Rooms_MenuItem";
			this.Rooms_MenuItem.Size = new System.Drawing.Size(148, 26);
			this.Rooms_MenuItem.Text = "Комнаты";
			this.Rooms_MenuItem.Click += new System.EventHandler(this.Rooms_MenuItem_Click);
			// 
			// Privelege_MenuItem
			// 
			this.Privelege_MenuItem.Name = "Privelege_MenuItem";
			this.Privelege_MenuItem.Size = new System.Drawing.Size(148, 26);
			this.Privelege_MenuItem.Text = "Льготы";
			this.Privelege_MenuItem.Click += new System.EventHandler(this.Privelege_MenuItem_Click);
			// 
			// Students_MenuItems
			// 
			this.Students_MenuItems.Name = "Students_MenuItems";
			this.Students_MenuItems.Size = new System.Drawing.Size(148, 26);
			this.Students_MenuItems.Text = "Студенты";
			this.Students_MenuItems.Click += new System.EventHandler(this.Students_MenuItems_Click);
			// 
			// просмотрToolStripMenuItem
			// 
			this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting_MenuItem});
			this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
			this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
			this.просмотрToolStripMenuItem.Text = "Просмотр";
			// 
			// Setting_MenuItem
			// 
			this.Setting_MenuItem.Name = "Setting_MenuItem";
			this.Setting_MenuItem.Size = new System.Drawing.Size(164, 26);
			this.Setting_MenuItem.Text = "Расселение";
			this.Setting_MenuItem.Click += new System.EventHandler(this.Setting_MenuItem_Click);
			// 
			// requestMenuItem
			// 
			this.requestMenuItem.Name = "requestMenuItem";
			this.requestMenuItem.Size = new System.Drawing.Size(82, 24);
			this.requestMenuItem.Text = "Запросы";
			this.requestMenuItem.Click += new System.EventHandler(this.requestMenuItem_Click);
			// 
			// Students_data
			// 
			this.Students_data.DataSource = this.studentsDataSet;
			this.Students_data.Position = 0;
			// 
			// studentsDataSet
			// 
			this.studentsDataSet.DataSetName = "StudentsDataSet";
			this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// report_menuItem
			// 
			this.report_menuItem.Name = "report_menuItem";
			this.report_menuItem.Size = new System.Drawing.Size(60, 24);
			this.report_menuItem.Text = "Отчет";
			this.report_menuItem.Click += new System.EventHandler(this.report_menuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 207);
			this.Controls.Add(this.Main_menu);
			this.MainMenuStrip = this.Main_menu;
			this.Name = "Form1";
			this.Text = "Main_form";
			this.Main_menu.ResumeLayout(false);
			this.Main_menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Students_data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource Students_data;
		private StudentsDataSet studentsDataSet;
		private System.Windows.Forms.MenuStrip Main_menu;
		private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Tables_MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Rooms_MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Privelege_MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Students_MenuItems;
		private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Setting_MenuItem;
		private System.Windows.Forms.ToolStripMenuItem requestMenuItem;
		private System.Windows.Forms.ToolStripMenuItem report_menuItem;
	}
}

