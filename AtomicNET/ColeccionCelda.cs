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
	/// Summary description for ColeccionCelda.
	/// </summary>
	public class ColeccionCelda : System.Collections.CollectionBase
	{
		public ColeccionCelda()
		{
			List.Clear();
			this.currentCeldaIndex = -1;
		}

		public void Add(AtomicNET.Celda celda)
		{
			List.Add(celda);
		}
		
		protected override void OnClear()
		{
			foreach(AtomicNET.Celda celda in this)
				celda.Dispose();
		}

		public AtomicNET.Celda this[int index] 
		{
			get 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					return (AtomicNET.Celda) List[index];
			}
			set 
			{
				if (index < 0 || index > List.Count)
					throw new Exception("Index out of range.");
				else
					List[index] = value;
			}
		}

		#region CURRENT CELDA
		private int currentCeldaIndex;
		public int CurrentCeldaIndex
		{
			get
			{
                if (this.Count == 0)
                    return -1;
				return this.currentCeldaIndex;
			}
			set
			{
                if (value < 0 || value > this.Count - 1)
                    throw new Exception("currentCeldaIndex out of range");

				this.currentCeldaIndex = value;
			}
		}

		public AtomicNET.Celda CurrentCelda
		{
			get
			{
				return (AtomicNET.Celda) List[this.currentCeldaIndex];
			}
			set
			{
				for(int cci = 0; cci < this.Count ; cci++ )
					if(List[cci].Equals(value))
					{
						this.currentCeldaIndex = cci;
						break;
					}
			}
		}

        public void SelectNextCelda()
        {
            if (this.currentCeldaIndex == this.Count - 1)
                this.currentCeldaIndex = 0;
            else 
                this.currentCeldaIndex++;
        }
		#endregion
	}
}
