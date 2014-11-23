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
	/// Summary description for Celda
	/// </summary>
	public class Celda : System.Windows.Forms.PictureBox
	{
		private int posX;
		private int posY;
		/// <summary>
		///		The Celda constructor sets the inicial XY-cords of the Celda
		///		in the Map, and gets the picture from the assembly resources.
		/// </summary>
		/// <param name="posX">Starting X-cord</param>
		/// <param name="posY">Starting Y-cord</param>
		/// <param name="name">Name of the Celda</param>
		public Celda(int posX, int posY, string name)
		{
			this.posX = posX;
			this.posY = posY;
			this.Name = name;
			this.BackColor = System.Drawing.SystemColors.MenuText;
			this.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Size = new System.Drawing.Size(30, 30);
					
			this.Location = new System.Drawing.Point(20+30*posX, 20+30*posY);

            this.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AtomicNET.Resources."+name+".bmp"));
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectCelda);
		}

		/// <summary>
		///		The SelectCelda Method is used to set the CurrentCelda to 'this'
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">MouseEventArgs</param>
		private void SelectCelda(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Link.THE_FORM.clock.Start();
            Link.THE_FORM.tablero.Flechas.Hide();
            Link.THE_FORM.Movidas.Push(Link.THE_FORM.tablero.Celdas.CurrentCeldaIndex);
            Link.THE_FORM.Movidas.Push(0);
            Link.THE_FORM.tablero.Celdas.CurrentCelda = this;
            Link.THE_FORM.tablero.Flechas.Show(Link.THE_FORM.tablero.Celdas.CurrentCelda.PosX, Link.THE_FORM.tablero.Celdas.CurrentCelda.PosY);
		}

		/// <summary>
		///		The Property PosX is used to store the X-cord 
		///		of the Celda (X-cord -> [0..24])
		/// </summary>
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
		///		The Property PosY is used to store the Y-cord 
		///		of the Celda (Y-cord -> [0..24])
		/// </summary>
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

		public void Mover(int direccion, int dx, int dy)
		{
			int n = 0;
            Link.THE_FORM.clock.Start();
			Link.THE_FORM.tablero.Flechas.Hide();
			int px=Link.THE_FORM.tablero.Celdas.CurrentCelda.PosX;
			int py=Link.THE_FORM.tablero.Celdas.CurrentCelda.PosY;
            AtomicNET.Map.Busy[px, py] = false;
			switch(direccion)
			{
				case 1: n=dy-py; direccion = 2; break;
				case 2: n=py-dy; direccion = 1; break;
				case 3: n=dx-px; direccion = 4; break;
				case 4: n=px-dx; direccion = 3; break;				
			}
			while(n>0)
			{
				Link.THE_FORM.tablero.Celdas.CurrentCelda.MoveIt(direccion);
				n--;
			}
            AtomicNET.Map.Busy[dx, dy]=true;
            Link.THE_FORM.tablero.Flechas.Show(Link.THE_FORM.tablero.Celdas.CurrentCelda.PosX, Link.THE_FORM.tablero.Celdas.CurrentCelda.PosY);
		}

		public bool Mover(int direccion)
		{
            Link.THE_FORM.clock.Start();
			Link.THE_FORM.tablero.Flechas.Hide();
			
			int px=Link.THE_FORM.tablero.Celdas.CurrentCelda.PosX;
			int py=Link.THE_FORM.tablero.Celdas.CurrentCelda.PosY;
            AtomicNET.Map.Busy[px, py] = false;
			int n=1;
            while (direccion == 1 && !AtomicNET.Map.Busy[px, py - n] ||
                    direccion == 2 && !AtomicNET.Map.Busy[px, py + n] ||
                    direccion == 3 && !AtomicNET.Map.Busy[px - n, py] ||
                    direccion == 4 && !AtomicNET.Map.Busy[px + n, py])
			{
				Link.THE_FORM.tablero.Celdas.CurrentCelda.MoveIt(direccion);
				n++;
			}
			switch(direccion)
			{
                case 1: AtomicNET.Map.Busy[px, py - n + 1] = true; break;
                case 2: AtomicNET.Map.Busy[px, py + n - 1] = true; break;
                case 3: AtomicNET.Map.Busy[px - n + 1, py] = true; break;
                case 4: AtomicNET.Map.Busy[px + n - 1, py] = true; break;
			}
			if(n!=1)
			{
				//puntaje
				Link.THE_FORM.CurrentMoves++;
				//undo info
				Link.THE_FORM.Movidas.Push(direccion);
				Link.THE_FORM.Movidas.Push(px);
				Link.THE_FORM.Movidas.Push(py);
				Link.THE_FORM.Movidas.Push(1);
			
				if(Link.THE_FORM.checkRespuesta())
				{
					Link.THE_FORM.ganar();
                    //TODO:fix me
                    /*
                    if (this.hScrollBarLevel.Value == AtomicNET.Levels.MAX_LEVELS + 1)
                    {
                        this.hScrollBarLevel.Value = 0;
                    }
                    else
                    {
                        this.hScrollBarLevel.Value++;
                    }*/
                    Link.THE_FORM.JumpToLevel(-1);
				}
			}
            Link.THE_FORM.tablero.Flechas.Show(Link.THE_FORM.tablero.Celdas.CurrentCelda.PosX, Link.THE_FORM.tablero.Celdas.CurrentCelda.PosY);

			if(n==1) return false;
			else return true;
		}

		public void MoveIt(int direccion)
		{
			AtomicNET.Celda dest = Link.THE_FORM.tablero.Celdas.CurrentCelda;
			int Start = 0;
			double j = 0;
			System.Drawing.Rectangle rc = new System.Drawing.Rectangle();

            //TODO:mover a la velocidad adecuada segun reloj (speed=5 = 0seg, ...speed=1 = 1/5seg)
            double factor = 0;
            switch (Link.THE_FORM.Speed)
            {
                case 1: factor = 0.00005; break;
                case 2: factor = 0.0001; break;
                case 3: factor = 0.001; break;
                case 4: factor = 0.01; break;
                case 5: factor = 30.0; break;
            }
            
			switch (direccion)
			{

				case 1:
					Start = dest.Top;

					rc.X = dest.Top+30-1;
					rc.Y = dest.Left;
					rc.Width = 30;
					rc.Height = 1;
					Link.THE_FORM.Invalidate(rc);
					for(double i=0.0;i<30.0;i+=factor)
					{
						dest.Top = Start-(int)i;
						if(j>1.0){Link.THE_FORM.Update(); j=0;}
						else j+=factor;
					}
			
					dest.Top = Start - 30;
					dest.PosY = dest.PosY-1;	
					break;

				case 2:		
					Start = dest.Top;
					
					rc.X = dest.Top;
					rc.Y = dest.Left;
					rc.Width = 30;
					rc.Height = 1;
					Link.THE_FORM.Invalidate(rc);
					for(double i=0.0;i<30.0;i+=factor)
					{
						dest.Top = Start+(int)i;
						if(j>1.0){Link.THE_FORM.Update(); j=0;}
						else j+=factor;
					}
				
					dest.Top = Start + 30;
					dest.PosY = dest.PosY+1;	
					break;

				case 3:
					Start = dest.Left;

					rc.X = dest.Top;
					rc.Y = dest.Left+30-1;
					rc.Width = 1;
					rc.Height = 30;
					Link.THE_FORM.Invalidate(rc);
					for(double i=0.0;i<30.0;i+=factor)
					{
						dest.Left = Start-(int)i;
						if(j>1.0){Link.THE_FORM.Update(); j=0;}
						else j+=factor;
					}
					
					dest.Left = Start - 30;
					dest.PosX = dest.PosX-1;
					break;
					
				case 4:	
					Start = dest.Left;

					rc.X = dest.Top;
					rc.Y = dest.Left;
					rc.Width = 1;
					rc.Height = 30;
					Link.THE_FORM.Invalidate(rc);
					for(double i=0.0;i<30.0;i+=factor)
					{
						dest.Left = Start+(int)i;
						if(j>1.0){Link.THE_FORM.Update(); j=0;}
						else j+=factor;
					}
					
					dest.Left = Start + 30;
					dest.PosX = dest.PosX+1;	
					break;
			}
		}
	}
}
