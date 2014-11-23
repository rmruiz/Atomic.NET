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

namespace AtomicNET
{
	/// <summary>
	/// Summary description for ColeccionFlecha.
	/// </summary>
	public class ColeccionFlecha : System.Collections.CollectionBase
	{
		public ColeccionFlecha()
		{
			//List.Clear();
            List.Add(new Flecha("FlechaUp"));
            List.Add(new Flecha("FlechaDw"));
            List.Add(new Flecha("FlechaLt"));
            List.Add(new Flecha("FlechaRt"));
		}

		protected override void OnClear()
		{
			foreach(AtomicNET.Flecha flecha in this)
				flecha.Dispose();
		}

		public AtomicNET.Flecha this[int index] 
		{
			get 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					return (AtomicNET.Flecha) List[index];
			}
			set 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					List[index] = value;
			}
		}
		
		public void Hide()
		{
			foreach(AtomicNET.Flecha flecha in this)
				flecha.Hide();
		}
		
		/// <summary>
		/// The Show Method is used to unhide all the Flechas that we can.
		/// </summary>
		/// <param name="mapa">Current Map</param>
		/// <param name="currentCelda">Currect selected Celda</param>
		public void Show(int currentCeldaPosX,int currentCeldaPosY)
		{
            if (this.Count > 0)
            {
                if (!AtomicNET.Map.Busy[currentCeldaPosX, currentCeldaPosY - 1])
                {
                    //pongo la flecha en la posición
                    this[0].Left = 20 + 30 * (currentCeldaPosX);
                    this[0].Top = 20 + 30 * (currentCeldaPosY - 1);
                    //y muestro esa flecha
                    this[0].Show();
                }
                if (!AtomicNET.Map.Busy[currentCeldaPosX, currentCeldaPosY + 1])
                {
                    this[1].Left = 20 + 30 * (currentCeldaPosX);
                    this[1].Top = 20 + 30 * (currentCeldaPosY + 1);
                    this[1].Show();
                }
                if (!AtomicNET.Map.Busy[currentCeldaPosX - 1, currentCeldaPosY])
                {
                    this[2].Left = 20 + 30 * (currentCeldaPosX - 1);
                    this[2].Top = 20 + 30 * (currentCeldaPosY);
                    this[2].Show();
                }
                if (!AtomicNET.Map.Busy[currentCeldaPosX + 1, currentCeldaPosY])
                {
                    this[3].Left = 20 + 30 * (currentCeldaPosX + 1);
                    this[3].Top = 20 + 30 * (currentCeldaPosY);
                    this[3].Show();
                }
            }
		}
	}
}
