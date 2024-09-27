using Dashboard.Employee_Section;

namespace Dashboard
{
	public class FileIO
	{
		private string fileName = "";
		private string path = AppDomain.CurrentDomain.BaseDirectory;
		private string fullPath;

		// ---------- Employee Section ---------- //
		private List<Employee> employeeData = new List<Employee>( );

		public FileIO ( string fileName = "data.txt" )
		{
			this.fileName = fileName;
			this.fullPath = path + fileName;
		}


		public void createEmployee ( Employee employee )
		{
			string data = $"{employee.Name}\t{employee.Age}\t{employee.Id}" +
			$"\t{employee.ContractHours}\t{employee.PayPerHour}\t{employee.hoursWorked}";

			using ( StreamWriter file = new StreamWriter( fullPath, true ) ) {
				file.WriteLine( data );
			}
		}

		public void getExistingEmployees ( )
		{

			using ( StreamReader sr = File.OpenText( fullPath ) ) {
				string s;

				while ( ( s = sr.ReadLine( ) ) != null ) {
					string[] temp = s.Split( "\t" );
					if ( temp.Length == 6 ) {

						this.employeeData.Add(
						new Employee(temp[0], Int32.Parse(temp[1] ), temp[2],
						float.Parse(temp[3] ), float.Parse(temp[4] ), float.Parse(temp[5])
						)); 
					}
					else {
						Console.Error.WriteLine( "Invalid line, skipping." );
					}
				}
			}

		}

		// ----- Getters & Setters ----- //
		public List<Employee> GetEmployeeData ( )
		{
			return employeeData;
		}


		// ---------- Todo Section ---------- //
		public void addToList ( string todo )
		{
			using ( StreamWriter file = new StreamWriter( fullPath, true ) ) {
				file.WriteLine( todo );
			}
		}

		public void updateList ( List<string> todo )
		{
			using ( StreamWriter file = new StreamWriter( fullPath ) ) {
				foreach ( string item in todo ) {
					file.WriteLine ( item );
				}
			}
		}

		public List<String> getExistingTodos ( )
		{
			List<String> todoList = new List<String>( );
			if ( File.Exists( fullPath ) ) {
				using ( StreamReader sr = File.OpenText( fullPath ) ) {
					string s;
					

					while ( ( s = sr.ReadLine( ) ) != null ) {
						todoList.Add( s );
					}
					return todoList;
				}
			}
			return todoList;
		}

	}
}
