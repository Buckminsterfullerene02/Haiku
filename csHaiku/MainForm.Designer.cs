namespace csHaiku
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNoun1 = new System.Windows.Forms.TextBox();
			this.txtNoun2 = new System.Windows.Forms.TextBox();
			this.txtVerb = new System.Windows.Forms.TextBox();
			this.txtAdjective = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnExample = new System.Windows.Forms.Button();
			this.lblOutput1 = new System.Windows.Forms.Label();
			this.lblOutput2 = new System.Windows.Forms.Label();
			this.lblOutput3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Noun";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Noun";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Verb";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Adjective";
			// 
			// txtNoun1
			// 
			this.txtNoun1.Location = new System.Drawing.Point(120, 35);
			this.txtNoun1.Name = "txtNoun1";
			this.txtNoun1.Size = new System.Drawing.Size(100, 20);
			this.txtNoun1.TabIndex = 4;
			// 
			// txtNoun2
			// 
			this.txtNoun2.Location = new System.Drawing.Point(120, 68);
			this.txtNoun2.Name = "txtNoun2";
			this.txtNoun2.Size = new System.Drawing.Size(100, 20);
			this.txtNoun2.TabIndex = 5;
			// 
			// txtVerb
			// 
			this.txtVerb.Location = new System.Drawing.Point(120, 105);
			this.txtVerb.Name = "txtVerb";
			this.txtVerb.Size = new System.Drawing.Size(100, 20);
			this.txtVerb.TabIndex = 6;
			// 
			// txtAdjective
			// 
			this.txtAdjective.Location = new System.Drawing.Point(120, 145);
			this.txtAdjective.Name = "txtAdjective";
			this.txtAdjective.Size = new System.Drawing.Size(100, 20);
			this.txtAdjective.TabIndex = 7;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(49, 186);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 8;
			this.btnSubmit.Text = "Write!";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnExample
			// 
			this.btnExample.Location = new System.Drawing.Point(145, 186);
			this.btnExample.Name = "btnExample";
			this.btnExample.Size = new System.Drawing.Size(75, 23);
			this.btnExample.TabIndex = 10;
			this.btnExample.Text = "Generate Ex";
			this.btnExample.UseVisualStyleBackColor = true;
			this.btnExample.Click += new System.EventHandler(this.BtnExampleClick);
			// 
			// lblOutput1
			// 
			this.lblOutput1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput1.Location = new System.Drawing.Point(13, 222);
			this.lblOutput1.Name = "lblOutput1";
			this.lblOutput1.Size = new System.Drawing.Size(253, 35);
			this.lblOutput1.TabIndex = 11;
			// 
			// lblOutput2
			// 
			this.lblOutput2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput2.Location = new System.Drawing.Point(13, 257);
			this.lblOutput2.Name = "lblOutput2";
			this.lblOutput2.Size = new System.Drawing.Size(253, 35);
			this.lblOutput2.TabIndex = 12;
			// 
			// lblOutput3
			// 
			this.lblOutput3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput3.Location = new System.Drawing.Point(13, 292);
			this.lblOutput3.Name = "lblOutput3";
			this.lblOutput3.Size = new System.Drawing.Size(253, 35);
			this.lblOutput3.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 379);
			this.Controls.Add(this.lblOutput3);
			this.Controls.Add(this.lblOutput2);
			this.Controls.Add(this.lblOutput1);
			this.Controls.Add(this.btnExample);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtAdjective);
			this.Controls.Add(this.txtVerb);
			this.Controls.Add(this.txtNoun2);
			this.Controls.Add(this.txtNoun1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "csHaiku";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblOutput3;
		private System.Windows.Forms.Label lblOutput2;
		private System.Windows.Forms.Label lblOutput1;
		private System.Windows.Forms.Button btnExample;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtAdjective;
		private System.Windows.Forms.TextBox txtVerb;
		private System.Windows.Forms.TextBox txtNoun2;
		private System.Windows.Forms.TextBox txtNoun1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
