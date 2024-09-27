
namespace Dashboard.Employee_Section
{
	public class Employee
	{
		private string name { get; set; }
		private int age { get; set; }
		private string id { get; set; }
		private float contractHours { get; set; }
		private float payPerHour { get; set; }
		public float hoursWorked { get; set; }

		public Employee ( string name, int age, string id, float contractHours,
		float payPerHour, float hoursWorked = 0 )
		{
			this.name = name;
			this.age = age;
			this.id = id;
			this.contractHours = contractHours;
			this.payPerHour = payPerHour;
		}

		// ----- Validation Methods -----//
		public static bool validateName ( string name )
		{
			if ( name == null || name.Length > 50 || name.Length < 1 || name.Trim( ).Length == 0 ) { return false; }
			return !name.Any( char.IsDigit );
		}

		public static bool validateAge ( string age )
		{
			try {
				int check = Int32.Parse( age );
				if ( check < 18 ) { return false; }
				return true;
			}
			catch ( Exception e ) {
				return false;
			}
		}

		public static bool validateId ( string id )
		{
			if ( id.Length == 3 ) {
				if ( char.IsLetter( id[0] ) ) {
					for ( int i = 1 ; i < id.Length ; i++ ) {
						if ( !char.IsDigit( id[i] ) ) { return false; }
					}
					return true;
				}
			}
			return false;
		}


		public static bool validateContractHours ( string hours )
		{
			try {
				float check = float.Parse( hours );
				if ( check < 8 || check > 50 ) { return false; }
				return true;
			}
			catch ( Exception e ) {
				return false;
			}
		}

		public static bool validateWage ( string wage )
		{
			try {
				float check = float.Parse( wage );
				if ( check < 10 || check > 100 ) { return false; }
				return true;
			}
			catch ( Exception e ) { return false; }
		}

		// ----- Custom Setters & Getters ----- //
		public void setHoursWorked ( float hours ) { hoursWorked += hours; }

		public string Name
		{
			get { return name; }
		}

		public int Age
		{
			get { return age; }
		}

		public string Id
		{
			get { return id; }
		}

		public float ContractHours
		{
			get { return contractHours; }
		}

		public float PayPerHour
		{
			get { return payPerHour; }
		}

		public float HoursWorked
		{
			get { return hoursWorked; }

		}
	}
}
