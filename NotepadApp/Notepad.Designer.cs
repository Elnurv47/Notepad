
namespace NotepadApp
{
	partial class Notepad
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
			this.noteLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.addNoteButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// noteLayoutPanel
			// 
			this.noteLayoutPanel.Location = new System.Drawing.Point(8, 50);
			this.noteLayoutPanel.Name = "noteLayoutPanel";
			this.noteLayoutPanel.Size = new System.Drawing.Size(628, 423);
			this.noteLayoutPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Notepad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(603, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.closeButton.Size = new System.Drawing.Size(45, 45);
			this.closeButton.TabIndex = 42;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-2, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(650, 45);
			this.panel1.TabIndex = 43;
			// 
			// addNoteButton
			// 
			this.addNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.addNoteButton.FlatAppearance.BorderSize = 0;
			this.addNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNoteButton.ForeColor = System.Drawing.Color.White;
			this.addNoteButton.Location = new System.Drawing.Point(281, 479);
			this.addNoteButton.Name = "addNoteButton";
			this.addNoteButton.Size = new System.Drawing.Size(112, 47);
			this.addNoteButton.TabIndex = 44;
			this.addNoteButton.Text = "Add";
			this.addNoteButton.UseVisualStyleBackColor = false;
			this.addNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 538);
			this.Controls.Add(this.addNoteButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.noteLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Notepad";
			this.Text = "Notepad";
			this.Load += new System.EventHandler(this.Notepad_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel noteLayoutPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button addNoteButton;
	}
}