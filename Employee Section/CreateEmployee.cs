﻿
namespace Dashboard.Employee_Section
{
	public partial class CreateEmployee : Form
	{
		public CreateEmployee ( )
		{
			InitializeComponent( );
		}

		private void btnCreate_Click ( object sender, EventArgs e )
		{
			bool checkName = Employee.validateName(txtBoxName.Text);
			bool checkAge = Employee.validateAge(txtBoxAge.Text);
			bool checkId = Employee.validateId(txtBoxId.Text);
			bool checkContract = Employee.validateContractHours(txtBoxHours.Text);
			bool checkPayPerHour = Employee.validateWage(txtBoxPayPerHour.Text);

			// ----- Error text ----- //
			if (!checkName) { nameError.Text = "Please ensure your name is less than 50 characters long\n" +
			" and does not contain any numbers"; }
			else {nameError.Text = ""; }

			if (!checkAge) { ageError.Text = "Please ensure you are entering an age over 17 and as a number"; }
			else { ageError.Text = ""; }

			if (!checkId) { 
			idError.Text = "Please ensure the ID is 3 characters long.\n" +
			" format: LetterNumberNumber.  EG d10";
			}
			else {idError.Text = ""; }

			if (!checkContract) { 
			hoursError.Text = "Please ensure you are entering a number\n" +
			"greater than 8 & less tahn 50 and as a number";
			}
			else {hoursError.Text = ""; }

			if ( !checkPayPerHour ) {
				wageError.Text = "Please ensure you are a number\n" +
				" greater than 10 & less than 100 as a number.";
			}
			else { wageError.Text = ""; }

			// Create Employee if all valid
			if ( checkName && checkAge && checkId && checkContract && checkPayPerHour ) {
				string name = txtBoxName.Text;
				int age = Int32.Parse(txtBoxAge.Text);
				string id = txtBoxId.Text;
				float contractHours = float.Parse(txtBoxHours.Text);
				float payPerHour = float.Parse(txtBoxPayPerHour.Text);

				var newEmployee = new Employee( name, age, id, contractHours, payPerHour );
			}
		}
	}
}
