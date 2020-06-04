using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class PrivelegeForm : Form
	{
		public PrivelegeForm()
		{
			InitializeComponent();
		}

		private void PrivelegeForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.lgota". При необходимости она может быть перемещена или удалена.
			this.lgotaTableAdapter.Fill(this.studentsDataSet.lgota);

		}

		private void refresh_button_Click(object sender, EventArgs e)
		{
			lgotaTableAdapter.Update(studentsDataSet);
		}
	}
}
