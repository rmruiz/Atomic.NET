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
using System.Data;
using System.Resources;
using System.Reflection;

namespace AtomicNET
{
	public class Flecha : System.Windows.Forms.PictureBox
	{
		/// <summary>
		///		The Flecha Constructor is used to set initial position of it and its type
		/// </summary>
		/// <param name="tipo">Type of Flecha</param>
		public Flecha(string tipo)
		{
			this.BackColor = System.Drawing.SystemColors.MenuText;
			this.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Size = new System.Drawing.Size(30, 30);

            this.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AtomicNET.Resources."+tipo+".bmp"));

			this.Location = new System.Drawing.Point(1000,1000);

			switch(tipo)
			{
				case "FlechaUp": this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up); break;
				case "FlechaDw": this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down); break;
				case "FlechaRt": this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right); break;
				case "FlechaLt": this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left); break;
			}
		}
		
		public void up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Link.THE_FORM.tablero.Celdas.CurrentCelda.Mover(1);
		}
		public void down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Link.THE_FORM.tablero.Celdas.CurrentCelda.Mover(2);
		}
		public void right(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Link.THE_FORM.tablero.Celdas.CurrentCelda.Mover(4);
		}
		public void left(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Link.THE_FORM.tablero.Celdas.CurrentCelda.Mover(3);
		}
	}
}
