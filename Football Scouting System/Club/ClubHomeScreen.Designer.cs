﻿namespace Football_Scouting_System.Club
{
	partial class ClubHomeScreen
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Searchnonfree = new System.Windows.Forms.Button();
			this.Postbutton = new System.Windows.Forms.Button();
			this.playerstatusbutt = new System.Windows.Forms.Button();
			this.Transfersbutton = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.LogoutButt = new System.Windows.Forms.Button();
			this.passbutton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(126, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(241, 110);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add Players";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(373, 249);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(241, 110);
			this.button3.TabIndex = 2;
			this.button3.Text = "Sign Staff\r\n";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Searchnonfree
			// 
			this.Searchnonfree.Location = new System.Drawing.Point(373, 17);
			this.Searchnonfree.Name = "Searchnonfree";
			this.Searchnonfree.Size = new System.Drawing.Size(241, 110);
			this.Searchnonfree.TabIndex = 3;
			this.Searchnonfree.Text = "Search for players";
			this.Searchnonfree.UseVisualStyleBackColor = true;
			this.Searchnonfree.Click += new System.EventHandler(this.Searchnonfree_Click);
			// 
			// Postbutton
			// 
			this.Postbutton.Location = new System.Drawing.Point(373, 133);
			this.Postbutton.Name = "Postbutton";
			this.Postbutton.Size = new System.Drawing.Size(241, 110);
			this.Postbutton.TabIndex = 4;
			this.Postbutton.Text = "Post official news";
			this.Postbutton.UseVisualStyleBackColor = true;
			this.Postbutton.Click += new System.EventHandler(this.Postbutton_Click);
			// 
			// playerstatusbutt
			// 
			this.playerstatusbutt.Location = new System.Drawing.Point(126, 133);
			this.playerstatusbutt.Name = "playerstatusbutt";
			this.playerstatusbutt.Size = new System.Drawing.Size(241, 110);
			this.playerstatusbutt.TabIndex = 5;
			this.playerstatusbutt.Text = "Post player status";
			this.playerstatusbutt.UseVisualStyleBackColor = true;
			this.playerstatusbutt.Click += new System.EventHandler(this.playerstatusbutt_Click);
			// 
			// Transfersbutton
			// 
			this.Transfersbutton.Location = new System.Drawing.Point(126, 249);
			this.Transfersbutton.Name = "Transfersbutton";
			this.Transfersbutton.Size = new System.Drawing.Size(241, 110);
			this.Transfersbutton.TabIndex = 6;
			this.Transfersbutton.Text = "Received offers";
			this.Transfersbutton.UseVisualStyleBackColor = true;
			this.Transfersbutton.Click += new System.EventHandler(this.Transfersbutton_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(126, 365);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(241, 110);
			this.button8.TabIndex = 7;
			this.button8.Text = "Endorse non-signed scouts";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// LogoutButt
			// 
			this.LogoutButt.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.LogoutButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.LogoutButt.Location = new System.Drawing.Point(509, 415);
			this.LogoutButt.Name = "LogoutButt";
			this.LogoutButt.Size = new System.Drawing.Size(241, 60);
			this.LogoutButt.TabIndex = 10;
			this.LogoutButt.Text = "Logout";
			this.LogoutButt.UseVisualStyleBackColor = false;
			this.LogoutButt.Click += new System.EventHandler(this.LogoutButt_Click);
			// 
			// passbutton
			// 
			this.passbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.passbutton.Location = new System.Drawing.Point(509, 365);
			this.passbutton.Name = "passbutton";
			this.passbutton.Size = new System.Drawing.Size(241, 44);
			this.passbutton.TabIndex = 11;
			this.passbutton.Text = "Change Password";
			this.passbutton.UseVisualStyleBackColor = false;
			this.passbutton.Click += new System.EventHandler(this.passbutton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(373, 365);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 110);
			this.button2.TabIndex = 12;
			this.button2.Text = "Release a player";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ClubHomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.CancelButton = this.LogoutButt;
			this.ClientSize = new System.Drawing.Size(762, 493);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.passbutton);
			this.Controls.Add(this.LogoutButt);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.Transfersbutton);
			this.Controls.Add(this.playerstatusbutt);
			this.Controls.Add(this.Postbutton);
			this.Controls.Add(this.Searchnonfree);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ClubHomeScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClubHomeScreen_FormClosed);
			this.Load += new System.EventHandler(this.ClubHomeScreen_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button Searchnonfree;
		private System.Windows.Forms.Button Postbutton;
		private System.Windows.Forms.Button playerstatusbutt;
		private System.Windows.Forms.Button Transfersbutton;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button LogoutButt;
		private System.Windows.Forms.Button passbutton;
		private System.Windows.Forms.Button button2;
	}
}