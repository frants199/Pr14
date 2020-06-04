using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PR14_WF
{
	public partial class ReportForm : Form
	{
		public ReportForm()
		{
			InitializeComponent();
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			reportViewer1.ProcessingMode = ProcessingMode.Local;
			reportViewer1.LocalReport.ReportPath = ("Report.rdlc");
			ReportDataSource datasource = new ReportDataSource("StudentsDataSet", this.studentsDataSet1.Tables["students"]);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(datasource);
			this.reportViewer1.RefreshReport();
		}
	}
}
