namespace PR14_WF
{
	partial class PrivelegeForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivelegeForm));
			this.privelege_table = new System.Windows.Forms.DataGridView();
			this.studentsDataSet = new PR14_WF.StudentsDataSet();
			this.lgotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lgotaTableAdapter = new PR14_WF.StudentsDataSetTableAdapters.lgotaTableAdapter();
			this.privelege_navigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.refresh_button = new System.Windows.Forms.Button();
			this.privelegecodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.privelegetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.privelege_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lgotaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.privelege_navigator)).BeginInit();
			this.privelege_navigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// privelege_table
			// 
			this.privelege_table.AutoGenerateColumns = false;
			this.privelege_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.privelege_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.privelegecodDataGridViewTextBoxColumn,
            this.privelegetypeDataGridViewTextBoxColumn,
            this.disscountDataGridViewTextBoxColumn});
			this.privelege_table.DataSource = this.lgotaBindingSource;
			this.privelege_table.Location = new System.Drawing.Point(12, 12);
			this.privelege_table.Name = "privelege_table";
			this.privelege_table.RowTemplate.Height = 24;
			this.privelege_table.Size = new System.Drawing.Size(478, 150);
			this.privelege_table.TabIndex = 0;
			// 
			// studentsDataSet
			// 
			this.studentsDataSet.DataSetName = "StudentsDataSet";
			this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lgotaBindingSource
			// 
			this.lgotaBindingSource.DataMember = "lgota";
			this.lgotaBindingSource.DataSource = this.studentsDataSet;
			// 
			// lgotaTableAdapter
			// 
			this.lgotaTableAdapter.ClearBeforeFill = true;
			// 
			// privelege_navigator
			// 
			this.privelege_navigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.privelege_navigator.BindingSource = this.lgotaBindingSource;
			this.privelege_navigator.CountItem = this.bindingNavigatorCountItem;
			this.privelege_navigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.privelege_navigator.Dock = System.Windows.Forms.DockStyle.None;
			this.privelege_navigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.privelege_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.privelege_navigator.Location = new System.Drawing.Point(12, 165);
			this.privelege_navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.privelege_navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.privelege_navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.privelege_navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.privelege_navigator.Name = "privelege_navigator";
			this.privelege_navigator.PositionItem = this.bindingNavigatorPositionItem;
			this.privelege_navigator.Size = new System.Drawing.Size(281, 27);
			this.privelege_navigator.TabIndex = 1;
			this.privelege_navigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// refresh_button
			// 
			this.refresh_button.Location = new System.Drawing.Point(392, 165);
			this.refresh_button.Name = "refresh_button";
			this.refresh_button.Size = new System.Drawing.Size(97, 27);
			this.refresh_button.TabIndex = 2;
			this.refresh_button.Text = "Обновить";
			this.refresh_button.UseVisualStyleBackColor = true;
			this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
			// 
			// privelegecodDataGridViewTextBoxColumn
			// 
			this.privelegecodDataGridViewTextBoxColumn.DataPropertyName = "Privelege_cod";
			this.privelegecodDataGridViewTextBoxColumn.HeaderText = "Код льготы";
			this.privelegecodDataGridViewTextBoxColumn.Name = "privelegecodDataGridViewTextBoxColumn";
			// 
			// privelegetypeDataGridViewTextBoxColumn
			// 
			this.privelegetypeDataGridViewTextBoxColumn.DataPropertyName = "Privelege_type";
			this.privelegetypeDataGridViewTextBoxColumn.HeaderText = "Тип льготы";
			this.privelegetypeDataGridViewTextBoxColumn.Name = "privelegetypeDataGridViewTextBoxColumn";
			// 
			// disscountDataGridViewTextBoxColumn
			// 
			this.disscountDataGridViewTextBoxColumn.DataPropertyName = "Disscount";
			this.disscountDataGridViewTextBoxColumn.HeaderText = "Скидка";
			this.disscountDataGridViewTextBoxColumn.Name = "disscountDataGridViewTextBoxColumn";
			// 
			// PrivelegeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 212);
			this.Controls.Add(this.refresh_button);
			this.Controls.Add(this.privelege_navigator);
			this.Controls.Add(this.privelege_table);
			this.Name = "PrivelegeForm";
			this.Text = "PrivelegeForm";
			this.Load += new System.EventHandler(this.PrivelegeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.privelege_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lgotaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.privelege_navigator)).EndInit();
			this.privelege_navigator.ResumeLayout(false);
			this.privelege_navigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView privelege_table;
		private StudentsDataSet studentsDataSet;
		private System.Windows.Forms.BindingSource lgotaBindingSource;
		private StudentsDataSetTableAdapters.lgotaTableAdapter lgotaTableAdapter;
		private System.Windows.Forms.BindingNavigator privelege_navigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Button refresh_button;
		private System.Windows.Forms.DataGridViewTextBoxColumn privelegecodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn privelegetypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn disscountDataGridViewTextBoxColumn;
	}
}