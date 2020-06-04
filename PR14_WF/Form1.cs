using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Rooms_MenuItem_Click(object sender, EventArgs e)
		{
			RoomsForm room_form = new RoomsForm();
			room_form.Text = "Комнаты";
			room_form.ShowDialog();
		}

		private void Privelege_MenuItem_Click(object sender, EventArgs e)
		{
			PrivelegeForm privelege_form = new PrivelegeForm();
			privelege_form.Text = "Льготы";
			privelege_form.ShowDialog();
		}

		private void Students_MenuItems_Click(object sender, EventArgs e)
		{
			StudentsForm students_form = new StudentsForm();
			students_form.Text = "Студенты";
			students_form.ShowDialog();
		}

		private void Setting_MenuItem_Click(object sender, EventArgs e)
		{
			SettingForm setting_form = new SettingForm();
			setting_form.Text = "Расселение";
			setting_form.ShowDialog();
		}

		private void requestMenuItem_Click(object sender, EventArgs e)
		{
			RequestForm request_form = new RequestForm();
			request_form.Text = "Запросы";
			request_form.ShowDialog();
		}

		private void report_menuItem_Click(object sender, EventArgs e)
		{
			ReportForm report_form = new ReportForm();
			report_form.Text = "Отчет";
			report_form.ShowDialog();
		}
	}
}
