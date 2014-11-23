//Copyright (C) 2003  Rolando Ruiz C. 
//
//This program is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 2 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Contact Author at rolando.ruiz@gmail.com

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AtomicNET.Forms
{
	/// <summary>
	/// Summary description for Shortcuts.
	/// </summary>
	public class Shortcuts : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Shortcuts()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			translate();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "m_title";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "m_up";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "m_down";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "m_left";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "m_right";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "m_undo";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 184);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "m_change";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 208);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "m_speed";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(96, 240);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(120, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 16);
			this.label9.TabIndex = 1;
			this.label9.Text = ": keys_up";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(120, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 16);
			this.label10.TabIndex = 1;
			this.label10.Text = ": keys_down";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(120, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(144, 16);
			this.label11.TabIndex = 1;
			this.label11.Text = ": keys_left";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(120, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 16);
			this.label12.TabIndex = 1;
			this.label12.Text = ": keys_right";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(120, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(144, 16);
			this.label13.TabIndex = 1;
			this.label13.Text = ": keys_undo";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(120, 184);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(144, 16);
			this.label14.TabIndex = 1;
			this.label14.Text = ": keys_change";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(120, 208);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(144, 16);
			this.label15.TabIndex = 1;
			this.label15.Text = ": keys_speed";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Shortcuts
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(274, 277);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label2,
																		  this.label1,
																		  this.label3,
																		  this.label4,
																		  this.label5,
																		  this.label6,
																		  this.label7,
																		  this.label8,
																		  this.label9,
																		  this.label10,
																		  this.label11,
																		  this.label12,
																		  this.label13,
																		  this.label14,
																		  this.label15});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Shortcuts";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "m_key_shortcuts";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		private void translate()
		{
			switch(Link.THE_FORM.Language)
			{
				case "eng":
					//form title
					this.Text = "AtomicNET : Keys Shortcuts";
					//title
					this.label1.Text = "Keys Shortcuts";
					//moves
					this.label2.Text = "UP";
					this.label3.Text = "DOWN";
					this.label4.Text = "LEFT";
					this.label5.Text = "RIGHT";
					this.label6.Text = "CHANGE";
					this.label7.Text = "UNDO";
					this.label8.Text = "SPEED";
					//button
					this.button1.Text = "OK";
					//keys
					this.label9.Text = ": Arrow Up, KeyPad8";
					this.label10.Text = ": Arrow Down, KeyPad2";
					this.label11.Text = ": Arrow Left, KeyPad4";
					this.label12.Text = ": Arrow Right, KeyPad6";
					this.label13.Text = ": Tab, Mouse Clic";
					this.label14.Text = ": U";
					this.label15.Text = ": [Slow] 1 - 5 [Fast]";
					break;

				case "spa":
					//form title
					this.Text = "AtomicNET : Teclas Rápidas";
					//title
					this.label1.Text = "Teclas Rápidas";
					//moves
					this.label2.Text = "ARRIBA";
					this.label3.Text = "ABAJO";
					this.label4.Text = "DERECHA";
					this.label5.Text = "IZQUIERDA";
					this.label6.Text = "CAMBIAR";
					this.label7.Text = "DESHACER";
					this.label8.Text = "VELOCIDAD";
					//button
					this.button1.Text = "Aceptar";
					//keys
					this.label9.Text = "Flecha Arriba, KeyPad8";
					this.label10.Text = "Flecha Abajo, KeyPad2";
					this.label11.Text = "Flecha Derecha, KeyPad4";
					this.label12.Text = "Flecha Izquierda, Keypad6";
					this.label13.Text = "Tab, Clic";
					this.label14.Text = "U";
					this.label15.Text = "[Lento] 1 - 5 [Rápido]";
					break;

				case "ger":
					//form title
					this.Text = "AtomicNET : Taste schnell";
					//title
					this.label1.Text = "Taste schnell";
					//moves
					this.label2.Text = "oben";
					this.label3.Text = "unten";
					this.label4.Text = "rechte";
					this.label5.Text = "linke";
					this.label6.Text = "austauschen";
					this.label7.Text = "";
					this.label8.Text = "Geschwindigkeit";
					//button
					this.button1.Text = "annehmen";
					//keys
					this.label9.Text = "Pfeil oben, KeyPad8";
					this.label10.Text = "Pfeil unten, KeyPad2";
					this.label11.Text = "Pfeil rechte, KeyPad4";
					this.label12.Text = "Pfeil linke, KeyPad6";
					this.label13.Text = "Tab, Clic";
					this.label14.Text = "U";
					this.label15.Text = "[langsam] 1 - 5 [schnell]";
					break;
			}

		}
	}
}
