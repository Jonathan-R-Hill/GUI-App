namespace Dashboard.Employee_Section
{
	partial class EmpleoyeeViewer
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
			dataGridView1 = new DataGridView( );
			( (System.ComponentModel.ISupportInitialize) dataGridView1 ).BeginInit( );
			SuspendLayout( );
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = Color.FromArgb(   24,   30,   54 );
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point( 12, 12 );
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size( 847, 459 );
			dataGridView1.TabIndex = 0;
			// 
			// EmpleoyeeViewer
			// 
			AutoScaleDimensions = new SizeF( 11F, 24F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(   46,   51,   73 );
			ClientSize = new Size( 871, 483 );
			Controls.Add( dataGridView1 );
			Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			FormBorderStyle = FormBorderStyle.None;
			Name = "EmpleoyeeViewer";
			Text = "EmpleoyeeViewer";
			Load +=  EmpleoyeeViewer_Load ;
			( (System.ComponentModel.ISupportInitialize) dataGridView1 ).EndInit( );
			ResumeLayout( false );
		}

		#endregion

		private DataGridView dataGridView1;
	}
}