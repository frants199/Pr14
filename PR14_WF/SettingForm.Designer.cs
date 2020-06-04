namespace PR14_WF
{
	partial class SettingForm
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
			System.Windows.Forms.Label room_numberLabel;
			System.Windows.Forms.Label value_rLabel;
			System.Windows.Forms.Label amountLabel;
			System.Windows.Forms.Label toolsLabel;
			System.Windows.Forms.Label flourLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
			this.studentsDataSet = new PR14_WF.StudentsDataSet();
			this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.roomsTableAdapter = new PR14_WF.StudentsDataSetTableAdapters.roomsTableAdapter();
			this.tableAdapterManager = new PR14_WF.StudentsDataSetTableAdapters.TableAdapterManager();
			this.room_numberTextBox = new System.Windows.Forms.TextBox();
			this.value_rTextBox = new System.Windows.Forms.TextBox();
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.toolsTextBox = new System.Windows.Forms.TextBox();
			this.flourTextBox = new System.Windows.Forms.TextBox();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new PR14_WF.StudentsDataSetTableAdapters.studentsTableAdapter();
			this.studentsDataGridView = new System.Windows.Forms.DataGridView();
			this.save_changes_button = new System.Windows.Forms.Button();
			this.rooms_navigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			room_numberLabel = new System.Windows.Forms.Label();
			value_rLabel = new System.Windows.Forms.Label();
			amountLabel = new System.Windows.Forms.Label();
			toolsLabel = new System.Windows.Forms.Label();
			flourLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rooms_navigator)).BeginInit();
			this.rooms_navigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// studentsDataSet
			// 
			this.studentsDataSet.DataSetName = "StudentsDataSet";
			this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// roomsBindingSource
			// 
			this.roomsBindingSource.DataMember = "rooms";
			this.roomsBindingSource.DataSource = this.studentsDataSet;
			// 
			// roomsTableAdapter
			// 
			this.roomsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.lgotaTableAdapter = null;
			this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
			this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
			this.tableAdapterManager.UpdateOrder = PR14_WF.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// room_numberLabel
			// 
			room_numberLabel.AutoSize = true;
			room_numberLabel.Location = new System.Drawing.Point(12, 46);
			room_numberLabel.Name = "room_numberLabel";
			room_numberLabel.Size = new System.Drawing.Size(116, 17);
			room_numberLabel.TabIndex = 1;
			room_numberLabel.Text = "Номер комнаты:";
			// 
			// room_numberTextBox
			// 
			this.room_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Room_number", true));
			this.room_numberTextBox.Location = new System.Drawing.Point(145, 43);
			this.room_numberTextBox.Name = "room_numberTextBox";
			this.room_numberTextBox.Size = new System.Drawing.Size(100, 22);
			this.room_numberTextBox.TabIndex = 2;
			// 
			// value_rLabel
			// 
			value_rLabel.AutoSize = true;
			value_rLabel.Location = new System.Drawing.Point(12, 74);
			value_rLabel.Name = "value_rLabel";
			value_rLabel.Size = new System.Drawing.Size(82, 17);
			value_rLabel.TabIndex = 3;
			value_rLabel.Text = "Стоимость:";
			// 
			// value_rTextBox
			// 
			this.value_rTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Value_r", true));
			this.value_rTextBox.Location = new System.Drawing.Point(145, 71);
			this.value_rTextBox.Name = "value_rTextBox";
			this.value_rTextBox.Size = new System.Drawing.Size(100, 22);
			this.value_rTextBox.TabIndex = 4;
			// 
			// amountLabel
			// 
			amountLabel.AutoSize = true;
			amountLabel.Location = new System.Drawing.Point(12, 102);
			amountLabel.Name = "amountLabel";
			amountLabel.Size = new System.Drawing.Size(90, 17);
			amountLabel.TabIndex = 5;
			amountLabel.Text = "Количество:";
			// 
			// amountTextBox
			// 
			this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Amount", true));
			this.amountTextBox.Location = new System.Drawing.Point(145, 99);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(100, 22);
			this.amountTextBox.TabIndex = 6;
			// 
			// toolsLabel
			// 
			toolsLabel.AutoSize = true;
			toolsLabel.Location = new System.Drawing.Point(12, 130);
			toolsLabel.Name = "toolsLabel";
			toolsLabel.Size = new System.Drawing.Size(83, 17);
			toolsLabel.TabIndex = 7;
			toolsLabel.Text = "Инвентарь:";
			// 
			// toolsTextBox
			// 
			this.toolsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Tools", true));
			this.toolsTextBox.Location = new System.Drawing.Point(145, 127);
			this.toolsTextBox.Name = "toolsTextBox";
			this.toolsTextBox.Size = new System.Drawing.Size(100, 22);
			this.toolsTextBox.TabIndex = 8;
			// 
			// flourLabel
			// 
			flourLabel.AutoSize = true;
			flourLabel.Location = new System.Drawing.Point(12, 158);
			flourLabel.Name = "flourLabel";
			flourLabel.Size = new System.Drawing.Size(45, 17);
			flourLabel.TabIndex = 9;
			flourLabel.Text = "Этаж:";
			// 
			// flourTextBox
			// 
			this.flourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Flour", true));
			this.flourTextBox.Location = new System.Drawing.Point(145, 155);
			this.flourTextBox.Name = "flourTextBox";
			this.flourTextBox.Size = new System.Drawing.Size(100, 22);
			this.flourTextBox.TabIndex = 10;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "roomsstudents";
			this.studentsBindingSource.DataSource = this.roomsBindingSource;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// studentsDataGridView
			// 
			this.studentsDataGridView.AutoGenerateColumns = false;
			this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.studentsDataGridView.DataSource = this.studentsBindingSource;
			this.studentsDataGridView.Location = new System.Drawing.Point(15, 190);
			this.studentsDataGridView.Name = "studentsDataGridView";
			this.studentsDataGridView.RowTemplate.Height = 24;
			this.studentsDataGridView.Size = new System.Drawing.Size(1138, 220);
			this.studentsDataGridView.TabIndex = 11;
			// 
			// save_changes_button
			// 
			this.save_changes_button.Location = new System.Drawing.Point(955, 416);
			this.save_changes_button.Name = "save_changes_button";
			this.save_changes_button.Size = new System.Drawing.Size(198, 42);
			this.save_changes_button.TabIndex = 12;
			this.save_changes_button.Text = "Сохранить изменения";
			this.save_changes_button.UseVisualStyleBackColor = true;
			this.save_changes_button.Click += new System.EventHandler(this.save_changes_button_Click);
			// 
			// rooms_navigator
			// 
			this.rooms_navigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.rooms_navigator.BindingSource = this.roomsBindingSource;
			this.rooms_navigator.CountItem = this.bindingNavigatorCountItem;
			this.rooms_navigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
			this.rooms_navigator.Location = new System.Drawing.Point(0, 0);
			this.rooms_navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.rooms_navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.rooms_navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.rooms_navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.rooms_navigator.Name = "rooms_navigator";
			this.rooms_navigator.PositionItem = this.bindingNavigatorPositionItem;
			this.rooms_navigator.Size = new System.Drawing.Size(1167, 27);
			this.rooms_navigator.TabIndex = 13;
			this.rooms_navigator.Text = "bindingNavigator1";
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "stubent_kod";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код студента";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "SNP";
			this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Birth_day";
			this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
			this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Group";
			this.dataGridViewTextBoxColumn6.HeaderText = "Группа";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Privelege_cod";
			this.dataGridViewTextBoxColumn7.HeaderText = "Льготы";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Passport";
			this.dataGridViewTextBoxColumn8.HeaderText = "Паспорт";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Room";
			this.dataGridViewTextBoxColumn9.HeaderText = "Комната";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Colonize_date";
			this.dataGridViewTextBoxColumn10.HeaderText = "Дата заселения";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 470);
			this.Controls.Add(this.rooms_navigator);
			this.Controls.Add(this.save_changes_button);
			this.Controls.Add(this.studentsDataGridView);
			this.Controls.Add(room_numberLabel);
			this.Controls.Add(this.room_numberTextBox);
			this.Controls.Add(value_rLabel);
			this.Controls.Add(this.value_rTextBox);
			this.Controls.Add(amountLabel);
			this.Controls.Add(this.amountTextBox);
			this.Controls.Add(toolsLabel);
			this.Controls.Add(this.toolsTextBox);
			this.Controls.Add(flourLabel);
			this.Controls.Add(this.flourTextBox);
			this.Name = "SettingForm";
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rooms_navigator)).EndInit();
			this.rooms_navigator.ResumeLayout(false);
			this.rooms_navigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private StudentsDataSet studentsDataSet;
		private System.Windows.Forms.BindingSource roomsBindingSource;
		private StudentsDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
		private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private StudentsDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
		private System.Windows.Forms.TextBox room_numberTextBox;
		private System.Windows.Forms.TextBox value_rTextBox;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.Windows.Forms.TextBox toolsTextBox;
		private System.Windows.Forms.TextBox flourTextBox;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private System.Windows.Forms.DataGridView studentsDataGridView;
		private System.Windows.Forms.Button save_changes_button;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
	}
}