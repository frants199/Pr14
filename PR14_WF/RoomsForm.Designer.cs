namespace PR14_WF
{
	partial class RoomsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
			this.rooms_table = new System.Windows.Forms.DataGridView();
			this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsDataSet = new PR14_WF.StudentsDataSet();
			this.roomsTableAdapter = new PR14_WF.StudentsDataSetTableAdapters.roomsTableAdapter();
			this.rooms_navigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.refresh_button = new System.Windows.Forms.Button();
			this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valuerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.rooms_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rooms_navigator)).BeginInit();
			this.rooms_navigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// rooms_table
			// 
			this.rooms_table.AutoGenerateColumns = false;
			this.rooms_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rooms_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumberDataGridViewTextBoxColumn,
            this.valuerDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.toolsDataGridViewTextBoxColumn,
            this.flourDataGridViewTextBoxColumn});
			this.rooms_table.DataSource = this.roomsBindingSource;
			this.rooms_table.Location = new System.Drawing.Point(9, 12);
			this.rooms_table.Name = "rooms_table";
			this.rooms_table.RowTemplate.Height = 24;
			this.rooms_table.Size = new System.Drawing.Size(895, 150);
			this.rooms_table.TabIndex = 0;
			// 
			// roomsBindingSource
			// 
			this.roomsBindingSource.DataMember = "rooms";
			this.roomsBindingSource.DataSource = this.studentsDataSet;
			// 
			// studentsDataSet
			// 
			this.studentsDataSet.DataSetName = "StudentsDataSet";
			this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// roomsTableAdapter
			// 
			this.roomsTableAdapter.ClearBeforeFill = true;
			// 
			// rooms_navigator
			// 
			this.rooms_navigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.rooms_navigator.BindingSource = this.roomsBindingSource;
			this.rooms_navigator.CountItem = this.bindingNavigatorCountItem;
			this.rooms_navigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.rooms_navigator.Dock = System.Windows.Forms.DockStyle.None;
			this.rooms_navigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.rooms_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.rooms_navigator.Location = new System.Drawing.Point(9, 165);
			this.rooms_navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.rooms_navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.rooms_navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.rooms_navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.rooms_navigator.Name = "rooms_navigator";
			this.rooms_navigator.PositionItem = this.bindingNavigatorPositionItem;
			this.rooms_navigator.Size = new System.Drawing.Size(281, 27);
			this.rooms_navigator.TabIndex = 1;
			this.rooms_navigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// refresh_button
			// 
			this.refresh_button.Location = new System.Drawing.Point(806, 165);
			this.refresh_button.Name = "refresh_button";
			this.refresh_button.Size = new System.Drawing.Size(98, 27);
			this.refresh_button.TabIndex = 2;
			this.refresh_button.Text = "Обновить";
			this.refresh_button.UseVisualStyleBackColor = true;
			this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
			// 
			// roomnumberDataGridViewTextBoxColumn
			// 
			this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "Room_number";
			this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
			this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
			// 
			// valuerDataGridViewTextBoxColumn
			// 
			this.valuerDataGridViewTextBoxColumn.DataPropertyName = "Value_r";
			this.valuerDataGridViewTextBoxColumn.HeaderText = "Стоимость";
			this.valuerDataGridViewTextBoxColumn.Name = "valuerDataGridViewTextBoxColumn";
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			// 
			// toolsDataGridViewTextBoxColumn
			// 
			this.toolsDataGridViewTextBoxColumn.DataPropertyName = "Tools";
			this.toolsDataGridViewTextBoxColumn.HeaderText = "Инвентарь";
			this.toolsDataGridViewTextBoxColumn.Name = "toolsDataGridViewTextBoxColumn";
			// 
			// flourDataGridViewTextBoxColumn
			// 
			this.flourDataGridViewTextBoxColumn.DataPropertyName = "Flour";
			this.flourDataGridViewTextBoxColumn.HeaderText = "Этаж";
			this.flourDataGridViewTextBoxColumn.Name = "flourDataGridViewTextBoxColumn";
			// 
			// RoomsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 244);
			this.Controls.Add(this.refresh_button);
			this.Controls.Add(this.rooms_navigator);
			this.Controls.Add(this.rooms_table);
			this.Name = "RoomsForm";
			this.Text = "RoomsForm";
			this.Load += new System.EventHandler(this.RoomsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.rooms_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rooms_navigator)).EndInit();
			this.rooms_navigator.ResumeLayout(false);
			this.rooms_navigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView rooms_table;
		private StudentsDataSet studentsDataSet;
		private System.Windows.Forms.BindingSource roomsBindingSource;
		private StudentsDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
		private System.Windows.Forms.BindingNavigator rooms_navigator;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valuerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn toolsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn flourDataGridViewTextBoxColumn;
	}
}