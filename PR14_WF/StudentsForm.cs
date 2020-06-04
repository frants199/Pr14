using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class StudentsForm : Form
	{
		public StudentsForm()
		{
			InitializeComponent();
		}

		private void StudentsForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.studentsDataSet.students);

		}

		private void refresh_button_Click(object sender, EventArgs e)
		{
			studentsTableAdapter.Update(studentsDataSet);
		}
	}
}
