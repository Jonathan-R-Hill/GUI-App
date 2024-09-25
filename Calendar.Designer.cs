namespace Dashboard
{
	partial class CalenderForm
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
			SuspendLayout( );
			// 
			// CalenderForm
			// 
			AutoScaleDimensions = new SizeF( 10F, 21F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(   45,   51,   72 );
			ClientSize = new Size( 836, 535 );
			FormBorderStyle = FormBorderStyle.None;
			Name = "CalenderForm";
			Text = "Form1";
			ResumeLayout( false );
		}

		#endregion
	}
}