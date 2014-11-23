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
	/// Summary description for ColeccionResultado.
	/// </summary>
	public class ColeccionResultado : System.Collections.CollectionBase
	{
		public ColeccionResultado()
		{
				List.Clear();
		}

		public void Add(AtomicNET.Resultado resultado)
		{
			List.Add(resultado);
		}
		
		protected override void OnClear()
		{
			foreach(AtomicNET.Resultado resultado in this)
				resultado.Dispose();
		}

		public AtomicNET.Resultado this[int index] 
		{
			get 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					return (AtomicNET.Resultado) List[index];
			}
			set 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					List[index] = value;
			}
		}

		public void Show()
		{
			foreach(AtomicNET.Resultado resultado in this)
				resultado.Show();
		}

		public void CenterIt()
		{
            //TODO: que hace esto!?
			int VentanaCentroX = Link.THE_FORM.RespuestaCenterX;
			int VentanaCentroY = Link.THE_FORM.RespuestaCenterY;

			int LargoRespuesta = 0;
			int AnchoRespuesta = 0;
			foreach(AtomicNET.Resultado resultado in this)
			{
				if(LargoRespuesta < resultado.PosX)
					LargoRespuesta = resultado.PosX;
				if(AnchoRespuesta < resultado.PosY)
					AnchoRespuesta = resultado.PosY;
			}
			LargoRespuesta=(LargoRespuesta+1)*15;
			AnchoRespuesta=(AnchoRespuesta+1)*15;

			foreach(AtomicNET.Resultado resultado in this)
			{
				int difX = resultado.PosX*30 - LargoRespuesta;
				int difY = resultado.PosY*30 - AnchoRespuesta;

				resultado.Location = new System.Drawing.Point(VentanaCentroX+difX,VentanaCentroY+difY);
			}
			Link.THE_FORM.tablero.Resultados.Show();
		}
	}
}
