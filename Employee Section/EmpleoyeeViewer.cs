using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Employee_Section
{
	public partial class EmpleoyeeViewer : Form
	{
		public EmpleoyeeViewer ( )
		{
			InitializeComponent( );
			setUpDataTable();
			loadEmployeeData();
		}

		private void EmpleoyeeViewer_Load ( object sender, EventArgs e )
		{

		}

		private void setUpDataTable ( )
		{
			// Clear any existing columns if necessary
			dataGridView1.Columns.Clear( );

			// Create and add columns manually
			dataGridView1.Columns.Add( "nameColumn", "Name" );
			dataGridView1.Columns.Add( "ageColumn", "Age" );
			dataGridView1.Columns.Add( "idColumn", "ID" );
			dataGridView1.Columns.Add( "contractHoursColumn", "Contract Hours" );
			dataGridView1.Columns.Add( "payPerHourColumn", "Pay Per Hour" );
			dataGridView1.Columns.Add( "hoursWorkedColumn", "Hours Worked" );


			dataGridView1.Columns["payPerHourColumn"].DefaultCellStyle.Format = "C2";  // Currency format for pay
			dataGridView1.Columns["contractHoursColumn"].DefaultCellStyle.Format = "N2";  // Numeric format for hours
			dataGridView1.Columns["hoursWorkedColumn"].DefaultCellStyle.Format = "N2";  // Numeric format for hours

			dataGridView1.AutoResizeColumns( );

		}

		private void loadEmployeeData ( )
		{
			// Fetch data
			var file = new FileIO( "data.txt" );
			file.getExistingEmployees( );
			List<Employee> employeeList = file.GetEmployeeData( );

			foreach ( Employee emp in employeeList ) {
			Console.WriteLine( emp.Name );
				dataGridView1.Rows.Add( emp.Name, emp.Age, emp.Id, emp.ContractHours,
				emp.PayPerHour, emp.HoursWorked );
			}
		}

	}
}
