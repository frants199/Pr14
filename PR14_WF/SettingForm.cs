using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.roomsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.studentsDataSet);

		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.studentsDataSet.students);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.rooms". При необходимости она может быть перемещена или удалена.
			this.roomsTableAdapter.Fill(this.studentsDataSet.rooms);

		}

		private void save_changes_button_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите сохранить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				roomsBindingSource.EndEdit();
				roomsTableAdapter.Update(studentsDataSet);
				studentsTableAdapter.Update(studentsDataSet);
			}
			
		}
	}
}
