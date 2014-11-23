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
	/// Summary description for ColeccionMuralla.
	/// </summary>
	public class ColeccionMuralla : System.Collections.CollectionBase
	{
		public ColeccionMuralla()
		{
			List.Clear();
		}

		public void Add(AtomicNET.Muralla muralla)
		{
			List.Add(muralla);
		}
		
		protected override void OnClear()
		{
			foreach(AtomicNET.Muralla muralla in this)
				muralla.Dispose();
		}

		public AtomicNET.Muralla this[int index] 
		{
			get 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					return (AtomicNET.Muralla) List[index];
			}
			set 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					List[index] = value;
			}
		}
	}
}
