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
	///		The Timer class provides a Seconds:Minutes timer.
	/// </summary>
	public class Timer : System.Windows.Forms.TextBox
	{
		/// <summary>
		/// Gets or sets the seconds of this Timer.
		/// </summary>
		private int seconds;

		/// <summary>
		/// Gets or sets the minutes of this Timer.
		/// </summary>
		private int minutes;

        /// <summary>
        /// Stores the Timer condition (true = running, false = stoped)
        /// </summary>
        private bool isRunning;
		
		/// <summary>
		///		The Timer constructor returns a 00:00 timer.
		/// </summary>
		public Timer()
		{
			this.Reset();
		}
        /// <summary>
        /// Return true if Timer is tiking, false otherwise.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsRunning()
        {
            return this.isRunning;
        }
        /// <summary>
        /// Starts current timer.
        /// </summary>
        public void Start()
        {
            this.isRunning = true;
        }
        /// <summary>
        /// Stops current timer.
        /// </summary>
        public void Stop()
        {
            this.isRunning = false;
        }

		/// <summary>
		///		The Step() increments a timer in one second.
		/// </summary>
		/// <returns>The increased Timer</returns>
		//public static Timer operator ++(Timer t) 
        public void Step()
		{
            if (this.isRunning)
            {
                this.seconds++;
                if (this.seconds >= 60)
                {
                    this.seconds = 0;
                    this.minutes++;
                }
                if (this.minutes >= 60)
                {
                    this.minutes = 0;
                    this.seconds = 0;
                }
                this.refreshText();
            }
		}

		/// <summary>
		///		The Reset Method sets the timer to 00:00
		/// </summary>
		public void Reset()
		{
			this.minutes=0;
			this.seconds=0;
            this.refreshText();
		}
        /// <summary>
        /// Refresh the textBox with the actual time, in the parent form.
        /// </summary>
        private void refreshText()
        {
            this.Text = this.ToString();
            this.Refresh();
        }

		/// <summary>
		///		The overriden ToString Methos is used to get a string 
		///		with Minutes & Seconds like ##:##
		/// </summary>
		/// <returns>Time elapsed in ##:## format</returns>
		public override string ToString()
		{
			return (
                this.minutes<10)?"0"+
                this.minutes.ToString()+":"+((this.seconds<10)?"0"+this.seconds.ToString():this.seconds.ToString()):this.minutes.ToString()+":"+((this.seconds<10)?"0"+this.seconds.ToString():this.seconds.ToString());
		}
	}
}
