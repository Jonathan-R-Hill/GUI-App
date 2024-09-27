namespace Dashboard
{
	partial class EmployeeManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			btnCreate = new Button( );
			btnViewExisting = new Button( );
			SuspendLayout( );
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.FromArgb(   24,   30,   54 );
			btnCreate.FlatAppearance.BorderSize = 0;
			btnCreate.FlatStyle = FlatStyle.Flat;
			btnCreate.Font = new Font( "Choco cooky", 10F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnCreate.ForeColor = Color.FromArgb(   0,   150,   250 );
			btnCreate.Location = new Point( 111, 12 );
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size( 209, 57 );
			btnCreate.TabIndex = 4;
			btnCreate.Text = "Create Employee";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click +=  btnCreate_Click ;
			// 
			// btnViewExisting
			// 
			btnViewExisting.BackColor = Color.FromArgb(   24,   30,   54 );
			btnViewExisting.FlatAppearance.BorderSize = 0;
			btnViewExisting.FlatStyle = FlatStyle.Flat;
			btnViewExisting.Font = new Font( "Choco cooky", 10F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnViewExisting.ForeColor = Color.FromArgb(   0,   150,   250 );
			btnViewExisting.Location = new Point( 485, 12 );
			btnViewExisting.Name = "btnViewExisting";
			btnViewExisting.Size = new Size( 209, 57 );
			btnViewExisting.TabIndex = 5;
			btnViewExisting.Text = "View Existing Employee's";
			btnViewExisting.UseVisualStyleBackColor = false;
			// 
			// EmployeeManager
			// 
			AutoScaleDimensions = new SizeF( 12F, 28F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(   46,   51,   73 );
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size( 836, 535 );
			Controls.Add( btnViewExisting );
			Controls.Add( btnCreate );
			Font = new Font( "Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding( 4 );
			Name = "EmployeeManager";
			Text = "EmployeeManager";
			ResumeLayout( false );
		}

		#endregion

		private Button btnCreate;
		private Button btnViewExisting;
	}
}