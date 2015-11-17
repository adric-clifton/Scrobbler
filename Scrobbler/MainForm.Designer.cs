namespace Scrobbler
{
	partial class MainForm
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lstOutput = new System.Windows.Forms.ListBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.BackColor = System.Drawing.Color.Black;
			this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
			this.txtInput.Location = new System.Drawing.Point(14, 13);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(303, 22);
			this.txtInput.TabIndex = 0;
			this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnGenerate
			// 
			this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerate.Location = new System.Drawing.Point(14, 41);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(145, 25);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Get Words";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lstOutput
			// 
			this.lstOutput.BackColor = System.Drawing.Color.Black;
			this.lstOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
			this.lstOutput.FormattingEnabled = true;
			this.lstOutput.ItemHeight = 14;
			this.lstOutput.Location = new System.Drawing.Point(14, 72);
			this.lstOutput.Name = "lstOutput";
			this.lstOutput.ScrollAlwaysVisible = true;
			this.lstOutput.Size = new System.Drawing.Size(303, 198);
			this.lstOutput.TabIndex = 2;
			this.lstOutput.TabStop = false;
			// 
			// btnRemove
			// 
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Location = new System.Drawing.Point(172, 41);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(145, 25);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove Letters";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(331, 282);
			this.Controls.Add(this.lstOutput);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtInput);
			this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Scrobbler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.ListBox lstOutput;
		private System.Windows.Forms.Button btnRemove;

	}
}

