
namespace NotepadApp
{
	partial class NoteDetail
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
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.noteMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(286, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(45, 45);
            this.closeButton.TabIndex = 43;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameLabel.Location = new System.Drawing.Point(12, 9);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(138, 37);
            this.noteNameLabel.TabIndex = 44;
            this.noteNameLabel.Text = "Note Name";
            this.noteNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noteNameLabel_MouseDown);
            // 
            // noteMessageTextBox
            // 
            this.noteMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteMessageTextBox.Location = new System.Drawing.Point(12, 70);
            this.noteMessageTextBox.Multiline = true;
            this.noteMessageTextBox.Name = "noteMessageTextBox";
            this.noteMessageTextBox.Size = new System.Drawing.Size(306, 264);
            this.noteMessageTextBox.TabIndex = 45;
            this.noteMessageTextBox.Text = "This is a note";
            // 
            // NoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 349);
            this.Controls.Add(this.noteMessageTextBox);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteDetail";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteDetail_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label noteNameLabel;
		private System.Windows.Forms.TextBox noteMessageTextBox;
	}
}