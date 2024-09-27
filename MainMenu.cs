using System.Runtime.InteropServices;

namespace Dashboard
{
	public partial class MainMenu : Form
	{
		private Color selectedColour = Color.FromArgb( 46, 51, 73 );
		private Color defaultColor = Color.FromArgb( 24, 30, 54 );

		public Panel ContentPanel { get { return contentPanel; } }

		// Create Rounded edges of the application using windows dll
		[DllImport( "Gdi32.dll", EntryPoint = "CreateRoundRectRgn" )]

		private static extern IntPtr CreateRoundRectRgn (
		int nLeft, int nTop, int nRight, int nBottom, int nWidth, int nHeight
		);

		public MainMenu ( )
		{
			InitializeComponent( );
			this.DoubleBuffered = true;

			Region = System.Drawing.Region.FromHrgn( CreateRoundRectRgn( 0, 0, Width, Height, 25, 25 ) );
			// Set the selected area on start up as main menu
			leftSidePanel.Height = btnMainMenu.Height;
			leftSidePanel.Top = btnMainMenu.Top;
			leftSidePanel.Left = btnMainMenu.Left;
			btnMainMenu.BackColor = selectedColour;
		}

		private void MainMenu_Load ( object sender, EventArgs e )
		{
		}
		
		// ----- GUI Methods ----- //
		private void setClickedColour ( Button buttonName )
		{
			contentPanel.Controls.Clear( );
			// reset other buttons to default highlight
			foreach ( Control control in leftSidePanel.Controls ) {
				if ( control is Button ) {
					( (Button) control ).BackColor = defaultColor;
				}
			}

			// set title & button highlight
			lblTitle.Text = buttonName.Text;
			buttonName.BackColor = selectedColour;
		}

		public static void openFormInPanel ( Form form, Panel panel )
		{
			panel.Controls.Clear( );

			form.TopLevel = false;

			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;

			panel.Controls.Add( form );

			form.Show( );
		}

		// ----- Button On Click Events ----- //
		private void btnMainMenu_Click ( object sender, EventArgs e )
		{ 
			setClickedColour( (Button) sender );

		}

		private void btnCalender_Click ( object sender, EventArgs e )
		{
			setClickedColour( (Button) sender );


		}

		private void btnCalculator_Click ( object sender, EventArgs e )
		{
			setClickedColour( (Button) sender );
		}

		private void btnClose_Click ( object sender, EventArgs e )
		{
			Application.Exit( );
		}

		private void btnMinimise_Click ( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnEmployeeManager_Click ( object sender, EventArgs e )
		{
			setClickedColour( (Button) sender );
			var employeeForm = new EmployeeManager(this );
			openFormInPanel(employeeForm, contentPanel );
		}
	}
}
