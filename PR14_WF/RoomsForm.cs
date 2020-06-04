using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class RoomsForm : Form
	{
		public RoomsForm()
		{
			InitializeComponent();
		}

		private void RoomsForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.rooms". При необходимости она может быть перемещена или удалена.
			this.roomsTableAdapter.Fill(this.studentsDataSet.rooms);

		}

		private void refresh_button_Click(object sender, EventArgs e)
		{
			roomsTableAdapter.Update(studentsDataSet);
		}
	}
}
