
namespace NotepadApp
{
	partial class AddNoteMessageBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.closeButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.addNewNoteLabel = new System.Windows.Forms.Label();
			this.noteNameLabel = new System.Windows.Forms.Label();
			this.noteNameTextBox = new System.Windows.Forms.TextBox();
			this.yourNoteLabel = new System.Windows.Forms.Label();
			this.noteMessageTextBox = new System.Windows.Forms.TextBox();
			this.saveNoteButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(349, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(45, 45);
			this.closeButton.TabIndex = 42;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.addNewNoteLabel);
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(395, 43);
			this.panel1.TabIndex = 43;
			// 
			// addNewNoteLabel
			// 
			this.addNewNoteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.addNewNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewNoteLabel.ForeColor = System.Drawing.Color.White;
			this.addNewNoteLabel.Location = new System.Drawing.Point(0, 0);
			this.addNewNoteLabel.Name = "addNewNoteLabel";
			this.addNewNoteLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.addNewNoteLabel.Size = new System.Drawing.Size(164, 43);
			this.addNewNoteLabel.TabIndex = 43;
			this.addNewNoteLabel.Text = "Add New Note";
			this.addNewNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// noteNameLabel
			// 
			this.noteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noteNameLabel.Location = new System.Drawing.Point(12, 58);
			this.noteNameLabel.Name = "noteNameLabel";
			this.noteNameLabel.Size = new System.Drawing.Size(137, 31);
			this.noteNameLabel.TabIndex = 44;
			this.noteNameLabel.Text = "Note Name:";
			// 
			// noteNameTextBox
			// 
			this.noteNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noteNameTextBox.Location = new System.Drawing.Point(17, 92);
			this.noteNameTextBox.Multiline = true;
			this.noteNameTextBox.Name = "noteNameTextBox";
			this.noteNameTextBox.Size = new System.Drawing.Size(364, 37);
			this.noteNameTextBox.TabIndex = 45;
			// 
			// yourNoteLabel
			// 
			this.yourNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yourNoteLabel.Location = new System.Drawing.Point(16, 142);
			this.yourNoteLabel.Name = "yourNoteLabel";
			this.yourNoteLabel.Size = new System.Drawing.Size(133, 31);
			this.yourNoteLabel.TabIndex = 46;
			this.yourNoteLabel.Text = "Your Note:";
			// 
			// noteMessageTextBox
			// 
			this.noteMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noteMessageTextBox.Location = new System.Drawing.Point(21, 177);
			this.noteMessageTextBox.Multiline = true;
			this.noteMessageTextBox.Name = "noteMessageTextBox";
			this.noteMessageTextBox.Size = new System.Drawing.Size(360, 192);
			this.noteMessageTextBox.TabIndex = 47;
			// 
			// saveNoteButton
			// 
			this.saveNoteButton.BackColor = System.Drawing.Color.White;
			this.saveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.saveNoteButton.Location = new System.Drawing.Point(292, 384);
			this.saveNoteButton.Name = "saveNoteButton";
			this.saveNoteButton.Size = new System.Drawing.Size(89, 38);
			this.saveNoteButton.TabIndex = 49;
			this.saveNoteButton.Text = "Save";
			this.saveNoteButton.UseVisualStyleBackColor = false;
			this.saveNoteButton.Click += new System.EventHandler(this.SaveNoteButton_Click);
			// 
			// AddNoteMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(393, 434);
			this.Controls.Add(this.saveNoteButton);
			this.Controls.Add(this.noteMessageTextBox);
			this.Controls.Add(this.yourNoteLabel);
			this.Controls.Add(this.noteNameTextBox);
			this.Controls.Add(this.noteNameLabel);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddNoteMessageBox";
			this.Text = "AddNoteMessageBox";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label addNewNoteLabel;
		private System.Windows.Forms.Label noteNameLabel;
		private System.Windows.Forms.TextBox noteNameTextBox;
		private System.Windows.Forms.Label yourNoteLabel;
		private System.Windows.Forms.TextBox noteMessageTextBox;
		private System.Windows.Forms.Button saveNoteButton;
	}
}