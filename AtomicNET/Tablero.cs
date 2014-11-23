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
	/// Summary description for Tablero.
	/// </summary>
	public class Tablero
	{
		public ColeccionCelda Celdas;
		public ColeccionMuralla Murallas;	
		public ColeccionFlecha Flechas;
		public ColeccionResultado Resultados;

		/// <summary>
		/// Creates a Tablero with Colections of Flechas, Celdas, Murallas, Resultados and a Map.
		/// </summary>
		public Tablero()
		{
			this.Flechas = new ColeccionFlecha();
			this.Celdas = new ColeccionCelda();
			this.Murallas = new ColeccionMuralla();
			this.Resultados = new ColeccionResultado();
		}

		/// <summary>
		/// Create a new celda puting it into the Map and creating its corresponding Respuesta.
		/// </summary>
		/// <param name="posX">Starting X-Cord of the Celda</param>
		/// <param name="posY">Starting Y-Cord of the Celda</param>
		/// <param name="name">The name of the Celda</param>
		/// <param name="solPosX">Final (relative) X-Cord of the Celda</param>
		/// <param name="solPosY">Final (relative) Y-Cord of the Celda</param>
		public void CreateCelda(int posX, int posY, string name, int solPosX,int solPosY)
		{
			this.Celdas.Add(new Celda(posX,posY,name));
            AtomicNET.Map.Busy[posX, posY] = true;
			this.Resultados.Add(new Resultado(solPosX,solPosY,name));
		}

		/// <summary>
		/// Creates a new Muralla and put it into the Map.
		/// </summary>
		/// <param name="posX">X-cord of the Muralla</param>
		/// <param name="posY">Y-cord of the Muralla</param>
		public void CreateMuralla(int posX, int posY)
		{
			this.Murallas.Add(new Muralla(posX,posY));
            AtomicNET.Map.Busy[posX, posY] = true;
		}

		/// <summary>
		/// Clears the Tablero, eliminates Celdas, Murallas and Resultados form the Map.
		/// </summary>
		public void Clear()
		{
            //TODO: necesitare resetear esto (ahora que es estatico?) AtomicNET.Map.reset();
			this.Celdas.Clear();
			this.Murallas.Clear();
			this.Resultados.Clear();
            this.Flechas.Hide();
		}
	}
}
