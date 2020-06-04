using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace PR14_WF
{
	public partial class RequestForm : Form
	{
		public RequestForm()
		{
			InitializeComponent();
		}
		private void execute_button_Click(object sender, EventArgs e)
		{
			OleDbConnection sql_connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\User\Desktop\Students.accdb");
			sql_connection.Open();
			string str = "";
			if (full_info_radio_button.Checked) str = "SELECT * FROM students";
			if (short_info_radio_button.Checked) str = "SELECT SNP, Group, Address FROM students";
			if (group_list_radio_button.Checked) str = "SELECT DISTINCT Group FROM students";
			if (number_of_flour_radio_button.Checked) str = "SELECT * FROM rooms where Flour=3";
			if (PO_list_radio_button.Checked) str = "SELECT * FROM students where students.Group like 'ПО%'";
			OleDbDataAdapter oda = new OleDbDataAdapter(str, sql_connection);
			DataTable dt = new DataTable();
			oda.Fill(dt);
			request_table.DataSource = dt;
			sql_connection.Close();
		}
		private void clear_button_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < request_table.Columns.Count; i++)
				request_table.Columns.RemoveAt(0);
		}
	}
}
