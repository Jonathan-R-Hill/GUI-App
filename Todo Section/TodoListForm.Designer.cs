namespace Dashboard.Todo_Section
{
	partial class TodoListForm
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
			lblTodo = new Label( );
			txtBoxAdd = new TextBox( );
			btnAdd = new Button( );
			flowTodos = new FlowLayoutPanel( );
			btnSave = new Button( );
			btnUpdatePage = new Button( );
			SuspendLayout( );
			// 
			// lblTodo
			// 
			lblTodo.AutoSize = true;
			lblTodo.Font = new Font( "Choco cooky", 16F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			lblTodo.Location = new Point( 10, 8 );
			lblTodo.Name = "lblTodo";
			lblTodo.Size = new Size( 170, 38 );
			lblTodo.TabIndex = 0;
			lblTodo.Text = "Add to list";
			// 
			// txtBoxAdd
			// 
			txtBoxAdd.BackColor = Color.White;
			txtBoxAdd.BorderStyle = BorderStyle.FixedSingle;
			txtBoxAdd.Cursor = Cursors.IBeam;
			txtBoxAdd.Font = new Font( "Choco cooky", 11F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			txtBoxAdd.ForeColor = Color.Black;
			txtBoxAdd.Location = new Point( 177, 12 );
			txtBoxAdd.Name = "txtBoxAdd";
			txtBoxAdd.Size = new Size( 625, 33 );
			txtBoxAdd.TabIndex = 1;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.Gray;
			btnAdd.Font = new Font( "Choco cooky", 11F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point( 671, 51 );
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size( 131, 34 );
			btnAdd.TabIndex = 2;
			btnAdd.Text = "Add to list";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click +=  btnAdd_Click ;
			// 
			// flowTodos
			// 
			flowTodos.Location = new Point( 12, 91 );
			flowTodos.Name = "flowTodos";
			flowTodos.Size = new Size( 790, 329 );
			flowTodos.TabIndex = 3;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Gray;
			btnSave.Font = new Font( "Choco cooky", 11F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnSave.ForeColor = Color.White;
			btnSave.Location = new Point( 637, 433 );
			btnSave.Name = "btnSave";
			btnSave.Size = new Size( 165, 34 );
			btnSave.TabIndex = 4;
			btnSave.Text = "Save Changes";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click +=  btnSave_Click ;
			// 
			// btnUpdatePage
			// 
			btnUpdatePage.BackColor = Color.Gray;
			btnUpdatePage.Font = new Font( "Choco cooky", 11F, FontStyle.Bold, GraphicsUnit.Point,  0 );
			btnUpdatePage.ForeColor = Color.White;
			btnUpdatePage.Location = new Point( 15, 433 );
			btnUpdatePage.Name = "btnUpdatePage";
			btnUpdatePage.Size = new Size( 165, 34 );
			btnUpdatePage.TabIndex = 5;
			btnUpdatePage.Text = "Update List";
			btnUpdatePage.UseVisualStyleBackColor = false;
			btnUpdatePage.Click +=  btnUpdatePage_Click ;
			// 
			// TodoListForm
			// 
			AutoScaleDimensions = new SizeF( 11F, 24F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(   46,   51,   73 );
			ClientSize = new Size( 814, 479 );
			Controls.Add( btnUpdatePage );
			Controls.Add( btnSave );
			Controls.Add( flowTodos );
			Controls.Add( btnAdd );
			Controls.Add( lblTodo );
			Controls.Add( txtBoxAdd );
			Font = new Font( "Choco cooky", 10F, FontStyle.Regular, GraphicsUnit.Point,  0 );
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Name = "TodoListForm";
			Text = "TodoListForm";
			ResumeLayout( false );
			PerformLayout( );
		}

		#endregion

		private Label lblTodo;
		private TextBox txtBoxAdd;
		private Button btnAdd;
		private FlowLayoutPanel flowTodos;
		private Button btnSave;
		private Button btnUpdatePage;
	}
}