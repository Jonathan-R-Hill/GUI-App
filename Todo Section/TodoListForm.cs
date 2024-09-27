using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.Todo_Section
{
	public partial class TodoListForm : Form
	{
		private FileIO fileOps = new FileIO( "Todos.txt" );
		private List<string> todos = new List<string>( );

		public TodoListForm ( )
		{
			InitializeComponent( );
			PopulateTodosFromFile( );
			flowTodos.AutoScroll = true;
		}

		// ---------- Methods ---------- //
		private void txtBoxAdd_MouseDown ( object sender, MouseEventArgs e )
		{
			txtBoxAdd.Focus( );
		}

		private void AddTask ( string taskText, bool addToFile = true )
		{
			if ( !string.IsNullOrEmpty( taskText ) ) {
				if ( addToFile ) {
					fileOps.addToList( taskText );
				}

				// Panel to hold the data & checkbox
				Panel taskPanel = new Panel( );
				taskPanel.Width = flowTodos.Width - 20;

				// Create a CheckBox for marking the task as complete
				CheckBox chkBoxTask = new CheckBox( );
				chkBoxTask.Text = taskText;
				chkBoxTask.AutoSize = false;
				chkBoxTask.Size = new Size( taskPanel.Width - 10, 0 );
				chkBoxTask.MaximumSize = new Size( taskPanel.Width - 10, 0 );
				chkBoxTask.TextAlign = ContentAlignment.TopLeft;
				chkBoxTask.UseCompatibleTextRendering = true;

				// Measure text height based on the size of the text area
				Size textSize = TextRenderer.MeasureText(
					chkBoxTask.Text, chkBoxTask.Font, new Size( chkBoxTask.Width, 0 ), TextFormatFlags.WordBreak
				);
				chkBoxTask.Height = textSize.Height + 10;  // Adjust the height based on the text

				// Adjust font style based on checkbox
				chkBoxTask.CheckedChanged += ( s, ev ) =>   // s = sender ev = event arguments
				{
					if ( chkBoxTask.Checked ) {
						chkBoxTask.Font = new Font( chkBoxTask.Font, FontStyle.Strikeout );
					}
					else {
						chkBoxTask.Font = new Font( chkBoxTask.Font, FontStyle.Regular );
					}
				};

				taskPanel.Controls.Add( chkBoxTask );
				taskPanel.Height = chkBoxTask.Height;

				flowTodos.Controls.Add( taskPanel );
				txtBoxAdd.Clear( );
			}
			else {
				MessageBox.Show( "Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}



		private void btnAdd_Click ( object sender, EventArgs e )
		{
			string taskText = txtBoxAdd.Text.Trim( );
			AddTask( taskText );
		}

		private void btnSave_Click ( object sender, EventArgs e )
		{
			List<string> uncheckedTasks = new List<string>( );

			// Iterate through each control in the FlowLayoutPanel
			foreach ( Control panel in flowTodos.Controls ) {
				// Each task is inside a Panel, and we expect a CheckBox inside the Panel
				if ( panel is Panel taskPanel ) {
					CheckBox chkTask = taskPanel.Controls[0] as CheckBox;

					// If the checkbox is not checked, add the task to the list of unchecked tasks
					if ( !chkTask.Checked ) {
						uncheckedTasks.Add( chkTask.Text );
					}
				}
			}

			// Update the file with the unchecked tasks
			fileOps.updateList( uncheckedTasks );
		}

		// Method to populate todos from the file on form load
		private void PopulateTodosFromFile ( )
		{
			// Get existing todos from the file
			List<string> existingTodos = fileOps.getExistingTodos( );

			// Add each existing todo to the UI
			foreach ( string todo in existingTodos ) {
				AddTask( todo, addToFile: false ); // No need to add to file again, just populate
			}
		}

		private void btnUpdatePage_Click ( object sender, EventArgs e )
		{
			btnSave_Click(  sender,  e );
			flowTodos.Controls.Clear();
			PopulateTodosFromFile( );
		}
	}
}
