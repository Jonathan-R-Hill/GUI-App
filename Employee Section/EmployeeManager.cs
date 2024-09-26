using Dashboard.Employee_Section;

namespace Dashboard
{
	public partial class EmployeeManager : Form
	{
		private MainMenu _mainMenu;

		public EmployeeManager ( MainMenu mainMenu )
		{
			InitializeComponent( );
			_mainMenu = mainMenu; // Store reference to MainMenu form
		}

		private void btnCreate_Click ( object sender, EventArgs e )
		{
			var createEmployee = new CreateEmployee( );

			// Use _mainMenu's ContentPanel property to open the form
			MainMenu.openFormInPanel( createEmployee, _mainMenu.ContentPanel );

		}
	}
}
