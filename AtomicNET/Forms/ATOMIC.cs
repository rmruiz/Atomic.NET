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
using AtomicNET;
using Microsoft.Win32;

namespace AtomicNET.Forms
{
	/// <summary>
	/// This is the main Game Form.
	/// </summary>
	public class ATOMIC : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.HScrollBar hScrollBarLevel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItemSelectLanguage;
		private System.Windows.Forms.MenuItem menuItemSelectLanguageEnglish;
		private System.Windows.Forms.MenuItem menuItemSelectLanguageSpanish;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar ProgressBarSpeed;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItemSelectSpeed1;
		private System.Windows.Forms.MenuItem menuItemSelectSpeed2;
		private System.Windows.Forms.MenuItem menuItemSelectSpeed3;
		private System.Windows.Forms.MenuItem menuItemSelectSpeed4;
		private System.Windows.Forms.MenuItem menuItemSelectSpeed5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.Panel panel1;
        
        public AtomicNET.Timer clock;
        public AtomicNET.Tablero tablero;
        public System.Collections.Stack Movidas;
        public AtomicNET.Levels niveles;
        public AtomicNET.Scores Puntajes;

		public ATOMIC()
		{   
			InitializeComponent();
            this.tablero = new Tablero();
            this.Movidas = new Stack();
            this.niveles = new Levels();
            this.Puntajes = new Scores();
		}
        public void InitAtomicNET()
        {
            this.clock.Stop();
            //TODO: donde ingreso el speed?
            this.CurrentLevel = 0;
            this.StartLevel(this.CurrentLevel);
            this.Speed = Settings.Speed;
            this.Language = Settings.Language;
        }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{   
            //TODO: todo esto en una linea
            AtomicNET.Forms.SplashScreen SS = new SplashScreen();
            SS.ShowDialog();
            Link.THE_FORM = SS.ReturnAtomic(); //TODO: sacar Link
            //SS.Dispose();
            Application.Run(Link.THE_FORM);
		}
	    /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATOMIC));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectLanguage = new System.Windows.Forms.MenuItem();
            this.menuItemSelectLanguageEnglish = new System.Windows.Forms.MenuItem();
            this.menuItemSelectLanguageSpanish = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectSpeed1 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectSpeed2 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectSpeed3 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectSpeed4 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectSpeed5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hScrollBarLevel = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressBarSpeed = new System.Windows.Forms.ProgressBar();
            this.clock = new AtomicNET.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem13,
            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem11,
            this.menuItem10,
            this.menuItem18,
            this.menuItem6,
            this.menuItem3});
            this.menuItem1.Text = "m_game";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "m_new";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.Text = "m_goto";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click_1);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Text = "m_scores";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click_1);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 3;
            this.menuItem18.Text = "m_undo";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.RadioCheck = true;
            this.menuItem3.Text = "m_quit";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSelectLanguage,
            this.menuItem19});
            this.menuItem13.Text = "m_config";
            // 
            // menuItemSelectLanguage
            // 
            this.menuItemSelectLanguage.Index = 0;
            this.menuItemSelectLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSelectLanguageEnglish,
            this.menuItemSelectLanguageSpanish});
            this.menuItemSelectLanguage.Text = "m_language";
            // 
            // menuItemSelectLanguageEnglish
            // 
            this.menuItemSelectLanguageEnglish.Index = 0;
            this.menuItemSelectLanguageEnglish.Text = "m_eng";
            this.menuItemSelectLanguageEnglish.Click += new System.EventHandler(this.menuItemSelectLanguageEnglish_Click);
            // 
            // menuItemSelectLanguageSpanish
            // 
            this.menuItemSelectLanguageSpanish.Index = 1;
            this.menuItemSelectLanguageSpanish.Text = "m_spa";
            this.menuItemSelectLanguageSpanish.Click += new System.EventHandler(this.menuItemSelectLanguageSpanish_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 1;
            this.menuItem19.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSelectSpeed1,
            this.menuItemSelectSpeed2,
            this.menuItemSelectSpeed3,
            this.menuItemSelectSpeed4,
            this.menuItemSelectSpeed5});
            this.menuItem19.Text = "m_speed";
            // 
            // menuItemSelectSpeed1
            // 
            this.menuItemSelectSpeed1.Index = 0;
            this.menuItemSelectSpeed1.Text = "1 Slow";
            this.menuItemSelectSpeed1.Click += new System.EventHandler(this.SelectSpeed1_Click);
            // 
            // menuItemSelectSpeed2
            // 
            this.menuItemSelectSpeed2.Index = 1;
            this.menuItemSelectSpeed2.Text = "2";
            this.menuItemSelectSpeed2.Click += new System.EventHandler(this.SelectSpeed2_Click);
            // 
            // menuItemSelectSpeed3
            // 
            this.menuItemSelectSpeed3.Index = 2;
            this.menuItemSelectSpeed3.Text = "3 Normal";
            this.menuItemSelectSpeed3.Click += new System.EventHandler(this.SelectSpeed3_Click);
            // 
            // menuItemSelectSpeed4
            // 
            this.menuItemSelectSpeed4.Index = 3;
            this.menuItemSelectSpeed4.Text = "4";
            this.menuItemSelectSpeed4.Click += new System.EventHandler(this.SelectSpeed4_Click);
            // 
            // menuItemSelectSpeed5
            // 
            this.menuItemSelectSpeed5.Index = 4;
            this.menuItemSelectSpeed5.Text = "5 Fast";
            this.menuItemSelectSpeed5.Click += new System.EventHandler(this.SelectSpeed5_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem8,
            this.menuItem9});
            this.menuItem4.Text = "m_help";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "m_about";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "m_howtoplay";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click_1);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "m_shortcuts";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click_1);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = -1;
            this.menuItem7.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 470);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hScrollBarLevel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "m_level";
            // 
            // hScrollBarLevel
            // 
            this.hScrollBarLevel.LargeChange = 1;
            this.hScrollBarLevel.Location = new System.Drawing.Point(15, 294);
            this.hScrollBarLevel.Maximum = 81;
            this.hScrollBarLevel.Name = "hScrollBarLevel";
            this.hScrollBarLevel.Size = new System.Drawing.Size(247, 19);
            this.hScrollBarLevel.TabIndex = 0;
            this.hScrollBarLevel.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Water";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox2.Location = new System.Drawing.Point(16, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 251);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(500, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(276, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(171, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(89, 19);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "m_score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "m_hscore";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(171, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(89, 19);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 484);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "m_speed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarSpeed
            // 
            this.ProgressBarSpeed.Location = new System.Drawing.Point(686, 373);
            this.ProgressBarSpeed.Maximum = 5;
            this.ProgressBarSpeed.Name = "ProgressBarSpeed";
            this.ProgressBarSpeed.Size = new System.Drawing.Size(53, 16);
            this.ProgressBarSpeed.Step = 1;
            this.ProgressBarSpeed.TabIndex = 0;
            this.ProgressBarSpeed.Value = 3;
            // 
            // clock
            // 
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clock.Enabled = false;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.HideSelection = false;
            this.clock.Location = new System.Drawing.Point(534, 355);
            this.clock.Name = "clock";
            this.clock.ReadOnly = true;
            this.clock.Size = new System.Drawing.Size(88, 37);
            this.clock.TabIndex = 0;
            this.clock.TabStop = false;
            this.clock.Text = "00:00";
            // 
            // ATOMIC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(785, 503);
            this.Controls.Add(this.ProgressBarSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 548);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(791, 548);
            this.Name = "ATOMIC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtomicNET";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        public string Language
        {
            get
            {
                return Settings.Language;
            }
            set
            {
                if ("eng".CompareTo(value) == 0)
                {
                    this.menuItemSelectLanguageEnglish.Checked = true;
                    this.menuItemSelectLanguageSpanish.Checked = false;
                }
                else //("spa".CompareTo(value) == 0)
                {
                    this.menuItemSelectLanguageEnglish.Checked = false;
                    this.menuItemSelectLanguageSpanish.Checked = true;
                }
                Settings.Language = value;
                this.translate(value);
            }
        }
        public void JumpToLevel(int level)
        {
            if (level == -1) level = this.hScrollBarLevel.Value + 1; //TODO: verificar condicion de borde
            this.StopLevel();     
            this.StartLevel(level);
        }
        public void StopLevel()
        {
            this.clock.Stop();
            this.tablero.Clear();
            this.Movidas.Clear();
            AtomicNET.Map.Clear();
            this.CurrentMoves = 0;
        }
        private void deshacerMovida()
        {
            //TODO: this.Movidas.Undo();
            //boton undo
            if (this.Movidas.Count != 0)
            {
                bool finished = false;
                int tipo;

                while (!finished && this.Movidas.Count != 0)
                {
                    tipo = (int)this.Movidas.Pop();

                    if (tipo == 1)
                    {
                        int y = (int)this.Movidas.Pop();
                        int x = (int)this.Movidas.Pop();
                        int mov = (int)this.Movidas.Pop();

                        this.tablero.Celdas.CurrentCelda.Mover(mov, x, y);
                        this.CurrentMoves--;
                        finished = true;
                    }
                    else if (tipo == 0)
                    {
                        this.tablero.Flechas.Hide();
                        this.tablero.Celdas.CurrentCeldaIndex = (int)this.Movidas.Pop();
                        this.tablero.Flechas.Show(this.tablero.Celdas.CurrentCelda.PosX, this.tablero.Celdas.CurrentCelda.PosY);
                        finished = false;
                    }
                }
            }
        }
        public void StartLevel(int level)
        {
            this.CurrentLevel = level;

            this.niveles.Start(level);
            this.tablero.Resultados.CenterIt();
            this.tablero.Flechas.Show(this.tablero.Celdas.CurrentCelda.PosX, this.tablero.Celdas.CurrentCelda.PosY);
            this.initMap();
            //refresh clock
            //TODO:clock debería ser una clase?
            this.clock.Reset();
            //this.Clock = this.clock.ToString();
            this.HighScore = this.Puntajes.GetScore(level, 0);
            this.updatestrings();
        }
        private bool testCelda(int posCel, int posRes, int difX, int difY)
        {
            if (this.tablero.Celdas[posCel].Name.CompareTo(this.tablero.Resultados[posRes].Name) != 0)
                return false;
            if (this.tablero.Celdas[posCel].PosX != this.tablero.Resultados[posRes].PosX + difX)
                return false;
            if (this.tablero.Celdas[posCel].PosY != this.tablero.Resultados[posRes].PosY + difY)
                return false;
            return true;
        }
        public bool checkRespuesta()
        {
            bool[] marcas = new bool[64];
            for (int i = 0; i < this.tablero.Celdas.Count; i++)
                marcas[i] = false;
            int difX = 0;
            int difY = 0;
            return deepSearch(marcas, 0, difX, difY);
        }
        private bool deepSearch(bool[] marcas, int n, int difX, int difY)
        {
            //si ya revisamos todas las celdas
            if (n == this.tablero.Celdas.Count)
                return true;

            //faltan algunas celdas
            for (int i = 0; i < this.tablero.Resultados.Count; i++)
            {
                if (n == 0)
                {
                    //calcular diferencia
                    difX = this.tablero.Celdas[0].PosX - this.tablero.Resultados[i].PosX;
                    difY = this.tablero.Celdas[0].PosY - this.tablero.Resultados[i].PosY;
                }
                //si no es la primera ya tenemos la diferencia

                //si no la hemos encontrado y coincide
                if (!marcas[i] && testCelda(n, i, difX, difY))
                {
                    //la encontramos
                    marcas[i] = true;
                    //seguimos adelante
                    if (deepSearch(marcas, n + 1, difX, difY))
                        return true;
                    //no nos sirvio (no la encontramos)
                    marcas[i] = false;
                }
            }
            //si no la encontramos en ninguna iteracion... DIE
            return false;
        }
        public void ganar()
        {
            this.clock.Stop();

            string player = "";
            int newscore = this.CurrentMoves; //TODO:acediendo a propiedades desde la clase?
            if (this.Puntajes.IsHiScore(this.currentLevel, newscore))
            {
                AtomicNET.Forms.doneHi A = new doneHi(this.clock.ToString(), this.CurrentMoves.ToString());
                A.ShowDialog();
                player = A.player;
                A.Dispose();
            }
            else
            {
                (new AtomicNET.Forms.done(this.clock.ToString(), this.CurrentMoves.ToString())).ShowDialog();
            }
            //save score
            this.Puntajes.InsertScore(this.currentLevel, newscore, player);
        }
     
        public int Speed
        {
            get
            {
                return Settings.Speed;
            }
            set
            {
                Settings.Speed = value;
                this.ProgressBarSpeed.Value = value;

                this.menuItemSelectSpeed1.Checked = false;
                this.menuItemSelectSpeed2.Checked = false;
                this.menuItemSelectSpeed3.Checked = false;
                this.menuItemSelectSpeed4.Checked = false;
                this.menuItemSelectSpeed5.Checked = false;
                switch (value)
                {
                    case 1: this.menuItemSelectSpeed1.Checked = true; break;
                    case 2: this.menuItemSelectSpeed2.Checked = true; break;
                    case 3: this.menuItemSelectSpeed3.Checked = true; break;
                    case 4: this.menuItemSelectSpeed4.Checked = true; break;
                    case 5: this.menuItemSelectSpeed5.Checked = true; break;
                }
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
		{
            this.clock.Step(); 
		}
		public void initMap()
		{			
			foreach(AtomicNET.Celda celda in this.tablero.Celdas)
				this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {celda});
			
			foreach(AtomicNET.Muralla muralla in this.tablero.Murallas)
				this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {muralla});

			foreach(AtomicNET.Flecha flecha in this.tablero.Flechas)
				this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {flecha});
			
			foreach(AtomicNET.Resultado resultado in this.tablero.Resultados)
				this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {resultado});

			this.pictureBox1.SendToBack();
			this.pictureBox2.SendToBack();
		}
		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyValue)
			{
                case 49: //Key = 1 : speed 1
                case 50: //Key = 2 : speed 2
                case 51: //Key = 3 : speed 3
                case 52: //Key = 4 : speed 4
                case 53: //Key = 5 : speed 5
                    this.Speed = e.KeyValue - 48; break;

				case 85: // Key = U : deshacer movida
					this.deshacerMovida(); break;

				case 9: // Key = TAB :cambiar molecula actual
                    this.clock.Start();
					this.tablero.Flechas.Hide();
					this.Movidas.Push(this.tablero.Celdas.CurrentCeldaIndex);
                    this.Movidas.Push(0);
                    this.tablero.Celdas.SelectNextCelda();
                    this.tablero.Flechas.Show(this.tablero.Celdas.CurrentCelda.PosX, this.tablero.Celdas.CurrentCelda.PosY);
					break;
					
				case 104:
				case 38:
					this.tablero.Celdas.CurrentCelda.Mover(1);
					break;

				case 98:
				case 40:
					this.tablero.Celdas.CurrentCelda.Mover(2);
					break;

				case 100:
				case 37:
					this.tablero.Celdas.CurrentCelda.Mover(3);
					break;

				case 102:
				case 39:
					this.tablero.Celdas.CurrentCelda.Mover(4);
					break;
			}
		}
		public void translate(string language)
		{
			switch(language)
			{
				case "eng":
					this.menuItem1.Text = "&Game";
					this.menuItem2.Text = "&Restart";
					this.menuItem3.Text = "&Quit";
					this.menuItem4.Text = "&Help";
					this.menuItem5.Text = "&About ...";
					this.menuItem8.Text = "How to Play?";
					this.menuItem9.Text = "Key Shortcuts";
					this.menuItem10.Text = "High &Scores";
					this.menuItem11.Text = "&Goto Level ...";
					this.menuItem19.Text = "&Select Speed";
					this.menuItemSelectSpeed1.Text = "&1 Slow";
					this.menuItemSelectSpeed2.Text = "&2";
					this.menuItemSelectSpeed3.Text= "&3 Normal";
					this.menuItemSelectSpeed4.Text= "&4";
					this.menuItemSelectSpeed5.Text= "&5 Fast";
					this.menuItem13.Text="&Config";
					this.menuItemSelectLanguage.Text="&Language";
					this.menuItemSelectLanguageEnglish.Text="English";
					this.menuItemSelectLanguageSpanish.Text="Spanish";
					this.menuItem18.Text ="Undo";
                    this.groupBox1.Text = "Level " + Convert.ToString(this.CurrentLevel + 1);
					
					this.label2.Text = "Score : ";
					this.label3.Text = "High Score : ";
					this.label4.Text = "Speed : ";
					break;
				case "spa":
					this.menuItem1.Text = "&Juego";
					this.menuItem2.Text = "&Reiniciar";
					this.menuItem3.Text = "&Salir";
					this.menuItem4.Text = "&Ayuda";
					this.menuItem5.Text = "&Acerca de ...";
					this.menuItem8.Text = "¿Cómo jugar?";
					this.menuItem9.Text = "Teclas Rapidas";
					this.menuItem10.Text = "&Puntajes";
					this.menuItem11.Text = "&Ir a nivel ...";
					this.menuItem19.Text = "&Velocidad";
					this.menuItemSelectSpeed1.Text = "&1 Lento";
					this.menuItemSelectSpeed2.Text = "&2";
					this.menuItemSelectSpeed3.Text= "&3 Normal";
					this.menuItemSelectSpeed4.Text= "&4";
					this.menuItemSelectSpeed5.Text= "&5 Rapido";
					this.menuItem13.Text="&Configuración";
					this.menuItemSelectLanguage.Text="&Lenguaje";
					this.menuItemSelectLanguageEnglish.Text="Ingles";
					this.menuItemSelectLanguageSpanish.Text="Español";
					this.menuItem18.Text ="Atrás";
                    this.groupBox1.Text = "Nivel " + Convert.ToString(this.CurrentLevel + 1);
					this.label2.Text = "Puntaje : ";
					this.label3.Text = "Máximo : ";
					this.label4.Text = "Velocidad :";
					break;
				case "ger":
					this.menuItem1.Text = "&Spiel";
					this.menuItem2.Text = "";
					this.menuItem3.Text = "";
					this.menuItem4.Text = "helft";
					this.menuItem5.Text = "";
					this.menuItem8.Text = "";
					this.menuItem9.Text = "";
					this.menuItem10.Text = "";
					this.menuItem19.Text = "";
					this.menuItemSelectSpeed1.Text = "&1 langsam";
					this.menuItemSelectSpeed2.Text = "&2";
					this.menuItemSelectSpeed3.Text= "&3";
					this.menuItemSelectSpeed4.Text= "&4";
					this.menuItemSelectSpeed5.Text= "&5 schnell";
					this.menuItem13.Text="";
					this.menuItemSelectLanguage.Text="";
					this.menuItemSelectLanguageEnglish.Text="English";
					this.menuItemSelectLanguageSpanish.Text="Spanish";
					this.menuItem18.Text ="hunter";
                    this.groupBox1.Text = "" + Convert.ToString(this.CurrentLevel + 1);
					this.label2.Text = "";
					this.label3.Text = "";
					this.label4.Text = "";
					break;
			}

            this.label1.Text = this.niveles.Name(this.CurrentLevel, this.Language);
		
		}
        public void updatestrings()
        {
            switch (this.Language)
            {
                case "eng":

                    this.groupBox1.Text = "Level " + Convert.ToString(this.CurrentLevel + 1);
                    break;
                case "spa":
                    this.groupBox1.Text = "Nivel " + Convert.ToString(this.CurrentLevel + 1);
                    break;
                case "ger":
                    this.groupBox1.Text = "" + Convert.ToString(this.CurrentLevel + 1);
                    break;
            }
            this.label1.Text = this.niveles.Name(this.CurrentLevel, this.Language);
        }
        private void menuItemSelectLanguageEnglish_Click(object sender, System.EventArgs e)
		{
            this.Language = "eng";
		}
        private void menuItemSelectLanguageSpanish_Click(object sender, System.EventArgs e)
		{
            this.Language = "spa";
		}
		private void menuItem17_Click(object sender, System.EventArgs e)
		{
            this.Language = "ger";
		}
		public void setLanguageMenu(string language)
		{
			this.menuItemSelectLanguageEnglish.Checked = false;
			this.menuItemSelectLanguageSpanish.Checked = false;
			
			switch(language)
			{
				case "eng": this.menuItemSelectLanguageEnglish.Checked = true; break;
				case "spa": this.menuItemSelectLanguageSpanish.Checked = true; break;
					
			}
		}
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Form A = new AboutForm();
			A.ShowDialog();
			A.Dispose();
		}
        private void SelectSpeed1_Click(object sender, System.EventArgs e)
		{
            this.Speed = 1;			
		}
        private void SelectSpeed2_Click(object sender, System.EventArgs e)
		{
            this.Speed = 2;
		}
        private void SelectSpeed3_Click(object sender, System.EventArgs e)
		{
            this.Speed = 3;
		}
        private void SelectSpeed4_Click(object sender, System.EventArgs e)
		{
            this.Speed = 4;
		}
		private void SelectSpeed5_Click(object sender, System.EventArgs e)
		{
            this.Speed = 5;
		}
		private void menuItem11_Click_1(object sender, System.EventArgs e)
		{
            int gotoLevel = this.CurrentLevel + 1;
			AtomicNET.Forms.gotoLevelForm A = new Forms.gotoLevelForm(gotoLevel);
			gotoLevel = -5;
			while (gotoLevel <= -1 || gotoLevel >= AtomicNET.Levels.MAX_LEVELS+1)
			{
				A.ShowDialog();
				gotoLevel = A.Level - 1;
			}
			A.Dispose();

			this.tablero.Clear();
            this.CurrentLevel = gotoLevel;
            this.hScrollBarLevel.Value = this.CurrentLevel;
            this.StartLevel(this.CurrentLevel);
		}
		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			this.JumpToLevel(this.hScrollBarLevel.Value);
		}
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            this.JumpToLevel(this.CurrentLevel);
		}
		public void menuItem18_Click(object sender, System.EventArgs e)
		{
			this.deshacerMovida();
		}
		private void menuItem9_Click_1(object sender, System.EventArgs e)
		{
			AtomicNET.Forms.Shortcuts A = new Shortcuts();
			A.ShowDialog();
			A.Dispose();
		}
		private void menuItem8_Click_1(object sender, System.EventArgs e)
		{
            AtomicNET.Forms.howto A = new howto(this.Language);
			A.ShowDialog();
			A.Dispose();
		}
		private void menuItem10_Click_1(object sender, System.EventArgs e)
		{
		//TODO:agregar menu de putajes altos
        }
        private int currentLevel;
        /// <summary>
        /// The Current level property stores the number of current running level.
        /// </summary>
        public int CurrentLevel
        {
            get
            {
                return this.currentLevel;
            }
            set
            {
                if (value < 0)
                    this.currentLevel = 0;
                else if (value > 81)
                    this.currentLevel = 81;
                else
                    this.currentLevel = value;
            }
        }
		public int CurrentMoves
		{
			get
			{
				return Convert.ToInt32(this.textBox2.Text);
			}
			set
			{
				if(value<=9)
					this.textBox2.Text = " " + value.ToString();
				else
					this.textBox2.Text = value.ToString();
			}
		}
		public int HighScore
		{
			get
			{
				return Convert.ToInt32(this.textBox3.Text);
			}
			set
			{
				if(value<=9)
					this.textBox3.Text = " " + value.ToString();
				else
					this.textBox3.Text = value.ToString();
			}
		}
		public int RespuestaCenterX
		{
			get
			{
				return (int) this.groupBox1.Width/2;
			}
		}
		public int RespuestaCenterY
		{
			get
			{
				return (int) this.groupBox1.Height/2;
			}
		}

	}
}
