namespace Dashboard.Employee_Section
{
	partial class CreateEmployee
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
			txtBoxName = new TextBox( );
			lblName = new Label( );
			lblAge = new Label( );
			txtBoxAge = new TextBox( );
			lblId = new Label( );
			txtBoxId = new TextBox( );
			lblContractHours = new Label( );
			txtBoxHours = new TextBox( );
			lblWage = new Label( );
			txtBoxPayPerHour = new TextBox( );
			btnCreate = new Button( );
			nameError = new Label( );
			ageError = new Label( );
			idError = new Label( );
			wageError = new Label( );
			hoursError = new Label( );
			SuspendLayout( );
			// 
			// txtBoxName
			// 
			txtBoxName.BackColor = Color.Blue;
			txtBoxName.ForeColor = SystemColors.InactiveBorder;
			txtBoxName.Location = new Point( 60, 47 );
			txtBoxName.Name = "txtBoxName";
			txtBoxName.Size = new Size( 150, 31 );
			txtBoxName.TabIndex = 0;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.Blue;
			lblName.Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			lblName.ForeColor = Color.White;
			lblName.Location = new Point( 60, 20 );
			lblName.Name = "lblName";
			lblName.Size = new Size( 58, 24 );
			lblName.TabIndex = 1;
			lblName.Text = "Name";
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.BackColor = Color.Blue;
			lblAge.Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			lblAge.ForeColor = Color.White;
			lblAge.Location = new Point( 60, 87 );
			lblAge.Name = "lblAge";
			lblAge.Size = new Size( 42, 24 );
			lblAge.TabIndex = 3;
			lblAge.Text = "Age";
			// 
			// txtBoxAge
			// 
			txtBoxAge.BackColor = Color.Blue;
			txtBoxAge.ForeColor = SystemColors.InactiveBorder;
			txtBoxAge.Location = new Point( 60, 114 );
			txtBoxAge.Name = "txtBoxAge";
			txtBoxAge.Size = new Size( 150, 31 );
			txtBoxAge.TabIndex = 2;
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.BackColor = Color.Blue;
			lblId.Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			lblId.ForeColor = Color.White;
			lblId.Location = new Point( 60, 161 );
			lblId.Name = "lblId";
			lblId.Size = new Size( 110, 24 );
			lblId.TabIndex = 5;
			lblId.Text = "EmployeeID";
			// 
			// txtBoxId
			// 
			txtBoxId.BackColor = Color.Blue;
			txtBoxId.ForeColor = SystemColors.InactiveBorder;
			txtBoxId.Location = new Point( 60, 188 );
			txtBoxId.Name = "txtBoxId";
			txtBoxId.Size = new Size( 150, 31 );
			txtBoxId.TabIndex = 4;
			// 
			// lblContractHours
			// 
			lblContractHours.AutoSize = true;
			lblContractHours.BackColor = Color.Blue;
			lblContractHours.Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			lblContractHours.ForeColor = Color.White;
			lblContractHours.Location = new Point( 60, 236 );
			lblContractHours.Name = "lblContractHours";
			lblContractHours.Size = new Size( 146, 24 );
			lblContractHours.TabIndex = 7;
			lblContractHours.Text = "Contract Hours";
			// 
			// txtBoxHours
			// 
			txtBoxHours.BackColor = Color.Blue;
			txtBoxHours.ForeColor = SystemColors.InactiveBorder;
			txtBoxHours.Location = new Point( 60, 263 );
			txtBoxHours.Name = "txtBoxHours";
			txtBoxHours.Size = new Size( 150, 31 );
			txtBoxHours.TabIndex = 6;
			// 
			// lblWage
			// 
			lblWage.AutoSize = true;
			lblWage.BackColor = Color.Blue;
			lblWage.Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			lblWage.ForeColor = Color.White;
			lblWage.Location = new Point( 60, 310 );
			lblWage.Name = "lblWage";
			lblWage.Size = new Size( 122, 24 );
			lblWage.TabIndex = 9;
			lblWage.Text = "Pay Per Hour";
			// 
			// txtBoxPayPerHour
			// 
			txtBoxPayPerHour.BackColor = Color.Blue;
			txtBoxPayPerHour.ForeColor = SystemColors.InactiveBorder;
			txtBoxPayPerHour.Location = new Point( 60, 337 );
			txtBoxPayPerHour.Name = "txtBoxPayPerHour";
			txtBoxPayPerHour.Size = new Size( 150, 31 );
			txtBoxPayPerHour.TabIndex = 8;
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.Blue;
			btnCreate.Dock = DockStyle.Bottom;
			btnCreate.FlatAppearance.BorderSize = 0;
			btnCreate.FlatStyle = FlatStyle.Flat;
			btnCreate.Font = new Font( "Choco cooky", 10F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnCreate.ForeColor = Color.White;
			btnCreate.Location = new Point( 0, 422 );
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size( 814, 57 );
			btnCreate.TabIndex = 10;
			btnCreate.Text = "Create Employee";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click +=  btnCreate_Click ;
			// 
			// nameError
			// 
			nameError.AutoSize = true;
			nameError.ForeColor = Color.Red;
			nameError.Location = new Point( 226, 47 );
			nameError.Name = "nameError";
			nameError.Size = new Size( 0, 21 );
			nameError.TabIndex = 11;
			// 
			// ageError
			// 
			ageError.AutoSize = true;
			ageError.ForeColor = Color.Red;
			ageError.Location = new Point( 226, 117 );
			ageError.Name = "ageError";
			ageError.Size = new Size( 0, 21 );
			ageError.TabIndex = 12;
			// 
			// idError
			// 
			idError.AutoSize = true;
			idError.ForeColor = Color.Red;
			idError.Location = new Point( 226, 188 );
			idError.Name = "idError";
			idError.Size = new Size( 0, 21 );
			idError.TabIndex = 13;
			// 
			// wageError
			// 
			wageError.AutoSize = true;
			wageError.ForeColor = Color.Red;
			wageError.Location = new Point( 226, 337 );
			wageError.Name = "wageError";
			wageError.Size = new Size( 0, 21 );
			wageError.TabIndex = 16;
			// 
			// hoursError
			// 
			hoursError.AutoSize = true;
			hoursError.ForeColor = Color.Red;
			hoursError.Location = new Point( 226, 263 );
			hoursError.Name = "hoursError";
			hoursError.Size = new Size( 0, 21 );
			hoursError.TabIndex = 17;
			// 
			// CreateEmployee
			// 
			AutoScaleDimensions = new SizeF( 10F, 21F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(   46,   51,   73 );
			ClientSize = new Size( 814, 479 );
			Controls.Add( hoursError );
			Controls.Add( wageError );
			Controls.Add( idError );
			Controls.Add( ageError );
			Controls.Add( nameError );
			Controls.Add( btnCreate );
			Controls.Add( lblWage );
			Controls.Add( txtBoxPayPerHour );
			Controls.Add( lblContractHours );
			Controls.Add( txtBoxHours );
			Controls.Add( lblId );
			Controls.Add( txtBoxId );
			Controls.Add( lblAge );
			Controls.Add( txtBoxAge );
			Controls.Add( lblName );
			Controls.Add( txtBoxName );
			FormBorderStyle = FormBorderStyle.None;
			Name = "CreateEmployee";
			Text = "CreateEmployee";
			ResumeLayout( false );
			PerformLayout( );
		}

		#endregion

		private TextBox txtBoxName;
		private Label lblName;
		private Label lblAge;
		private TextBox txtBoxAge;
		private Label lblId;
		private TextBox txtBoxId;
		private Label lblContractHours;
		private TextBox txtBoxHours;
		private Label lblWage;
		private TextBox txtBoxPayPerHour;
		private Button btnCreate;
		private Label nameError;
		private Label ageError;
		private Label idError;
		private Label wageError;
		private Label hoursError;
	}
}