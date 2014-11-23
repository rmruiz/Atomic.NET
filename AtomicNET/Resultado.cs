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
	/// <summary>
	/// Summary description for Resultado.
	/// </summary>
	public class Resultado : System.Windows.Forms.PictureBox
	{
		/// <summary>
		/// Stores X cord of the answer Celda
		/// </summary>
		private int posX;
		public int PosX
		{
			get 
			{
				return this.posX; 
			}
			set 
			{
				this.posX = value; 
			}
		}

		/// <summary>
		/// Stores Y cord of the answer Celda
		/// </summary>
		private int posY;
		public int PosY
		{
			get 
			{
				return this.posY; 
			}
			set 
			{
				this.posY = value; 
			}
		}

		/// <summary>
		/// Creates a new Resultado, setting posX, posY and it's name
		/// </summary>
		/// <param name="posX">X cord of the answer Celda</param>
		/// <param name="posY">Y cord of the answer Celda</param>
		/// <param name="name">name or the answer Celda</param>
		public Resultado(int posX, int posY, string name)
		{
			this.Name = name;
			this.posX = posX;
			this.posY = posY;
			this.BackColor = SystemColors.MenuText;
			this.BorderStyle = BorderStyle.None;
			this.Size = new Size(30, 30);

            this.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AtomicNET.Resources."+name+".bmp"));
			this.Location = new System.Drawing.Point(1000,1000);
			this.Hide();
		}
	}
}
