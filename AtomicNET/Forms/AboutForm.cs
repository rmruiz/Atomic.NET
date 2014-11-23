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

namespace AtomicNET.Forms
{
	/// <summary>
	/// Summary description for AboutForm.
	/// </summary>
	public class AboutForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label katomicinfo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label SZreason;
		private System.Windows.Forms.Label FFreason;
		private System.Windows.Forms.Label friends;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.translate();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FFreason = new System.Windows.Forms.Label();
            this.SZreason = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.friends = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.katomicinfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(144, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atomic.NET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "m_version X.X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "m_created";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(8, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 208);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(328, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Version";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rolando Ruiz C.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FFreason);
            this.tabPage2.Controls.Add(this.SZreason);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.friends);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(328, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thanks to";
            // 
            // FFreason
            // 
            this.FFreason.Location = new System.Drawing.Point(144, 104);
            this.FFreason.Name = "FFreason";
            this.FFreason.Size = new System.Drawing.Size(152, 64);
            this.FFreason.TabIndex = 6;
            this.FFreason.Text = "put reason here";
            // 
            // SZreason
            // 
            this.SZreason.Location = new System.Drawing.Point(144, 39);
            this.SZreason.Name = "SZreason";
            this.SZreason.Size = new System.Drawing.Size(152, 32);
            this.SZreason.TabIndex = 5;
            this.SZreason.Text = "put reason here";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hermanos Zacharias :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // friends
            // 
            this.friends.Location = new System.Drawing.Point(16, 104);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(112, 64);
            this.friends.TabIndex = 3;
            this.friends.Text = "friends  :";
            this.friends.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(328, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Licence";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(8, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(312, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.katomicinfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(328, 182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Katomic ?";
            // 
            // katomicinfo
            // 
            this.katomicinfo.Location = new System.Drawing.Point(8, 8);
            this.katomicinfo.Name = "katomicinfo";
            this.katomicinfo.Size = new System.Drawing.Size(312, 168);
            this.katomicinfo.TabIndex = 0;
            this.katomicinfo.Text = "original idea, report bugs, ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(152, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Producto CHILENO :: Made in CHILE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void translate()
		{
			// VERSION ACTUAL
			string ver = "1.2";

            switch (Link.THE_FORM.Language)
			{
				case "eng":
					this.Text = "About ...";
					this.label3.Text = "Developed by : ";
					this.label2.Text = "Version "+ver;
					this.label4.Text = "This freeware is distributed under the GPL licence agreement. It was developed using Microsoft Visual Studio .NET. If you want a free copy of the source code just e-mail the author to rolando.ruiz@gmail.com";
					this.tabPage1.Text = "Version";
					this.tabPage3.Text = "License";
					this.tabPage2.Text = "Thanks To";
					this.tabPage4.Text = "Katomic?";
					this.katomicinfo.Text = "      Yes!, this game it's a copy from Katomic, KDE original game. The idea and all the graphics were taken from there, but all the code it's mine. This game was written in Visual Studio .NET using C#. If you want the source code just e-mail me to rolando.ruiz@gmail.com\r\n\r\n      Any comment, bug report, etc. will be apreciated.\r\n\r\n      Please, enjoy!\r\n\r\nMore info in:\r\nhttp://docs.kde.org/en/HEAD/kdegames/katomic/";
					this.SZreason.Text = "For the molecules tranlation, thanks!";
					this.FFreason.Text = "For debuging, testing and others... THANKS to all of you!!";
					this.friends.Text = "Martín Gutierrez, \n\r Alejandro Salinas, \n\rFelipe Zavala.";
					this.label6.Text = "Zacharias Bros. :";
					#region LICENCE
					this.textBox1.Text = "This software is distributed under the GNU Public Licence (GPL)\r\n\r\nCopyright (C) " +
						"2003 Rolando Ruiz C.\r\n----------------------------------------------------------" +
						"-----------------\r\n\r\nGNU GENERAL PUBLIC LICENSE\r\nVersion 2, June 1991\r\n\r\nCopyrig" +
						"ht (C) 1989, 1991 Free Software Foundation, Inc.\r\n59 Temple Place, Suite 330, Bo" +
						"ston, MA  02111-1307  USA\r\n \r\nEveryone is permitted to copy and distribute verba" +
						"tim copies of this license document, but changing it is not allowed.\r\n\r\n   \r\nGNU" +
						" GENERAL PUBLIC LICENSE\r\nTERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODI" +
						"FICATION\r\n\r\n0. This License applies to any program or other work which contains " +
						"a notice placed by the copyright holder saying it may be distributed under the t" +
						"erms of this General Public License.  The \"Program\", below, refers to any such p" +
						"rogram or work, and a \"work based on the Program\" means either the Program or an" +
						"y derivative work under copyright law: that is to say, a work containing the Pro" +
						"gram or a portion of it, either verbatim or with modifications and/or translated" +
						" into another language.  (Hereinafter, translation is included without limitatio" +
						"n in the term \"modification\".)  Each licensee is addressed as \"you\". \r\n  \r\nActiv" +
						"ities other than copying, distribution and modification are not covered by this " +
						"License; they are outside its scope.  The act of running the Program is not rest" +
						"ricted, and the output from the Program is covered only if its contents constitu" +
						"te a work based on the Program (independent of having been made by running the P" +
						"rogram). Whether that is true depends on what the Program does. \r\n  \r\n1. You may" +
						" copy and distribute verbatim copies of the Program\'s source code as you receive" +
						" it, in any medium, provided that you conspicuously and appropriately publish on" +
						" each copy an appropriate copyright notice and disclaimer of warranty; keep inta" +
						"ct all the notices that refer to this License and to the absence of any warranty" +
						"; and give any other recipients of the Program a copy of this License along with" +
						" the Program.\r\n\r\nYou may charge a fee for the physical act of transferring a cop" +
						"y, and you may at your option offer warranty protection in exchange for a fee.\r\n" +
						"\r\n2. You may modify your copy or copies of the Program or any portion of it, thu" +
						"s forming a work based on the Program, and copy and distribute such modification" +
						"s or work under the terms of Section 1 above, provided that you also meet all of" +
						" these conditions:\r\n\r\na) You must cause the modified files to carry prominent no" +
						"tices stating that you changed the files and the date of any change.\r\n\r\nb) You m" +
						"ust cause any work that you distribute or publish, that in whole or in part cont" +
						"ains or is derived from the Program or any part thereof, to be licensed as a who" +
						"le at no charge to all third parties under the terms of this License.\r\n\r\nc) If t" +
						"he modified program normally reads commands interactively when run, you must cau" +
						"se it, when started running for such interactive use in the most ordinary way, t" +
						"o print or display an announcement including an appropriate copyright notice and" +
						" a notice that there is no warranty (or else, saying that you provide a warranty" +
						") and that users may redistribute the program under these conditions, and tellin" +
						"g the user how to view a copy of this License.  (Exception: if the Program itsel" +
						"f is interactive but does not normally print such an announcement, your work bas" +
						"ed on the Program is not required to print an announcement.)\r\n\r\nThese requiremen" +
						"ts apply to the modified work as a whole.  If identifiable sections of that work" +
						" are not derived from the Program, and can be reasonably considered independent " +
						"and separate works in themselves, then this License, and its terms, do not apply" +
						" to those sections when you distribute them as separate works.  But when you dis" +
						"tribute the same sections as part of a whole which is a work based on the Progra" +
						"m, the distribution of the whole must be on the terms of this License, whose per" +
						"missions for other licensees extend to the entire whole, and thus to each and ev" +
						"ery part regardless of who wrote it. \r\n\r\nThus, it is not the intent of this sect" +
						"ion to claim rights or contest your rights to work written entirely by you; rath" +
						"er, the intent is to exercise the right to control the distribution of derivativ" +
						"e or collective works based on the Program.\r\nIn addition, mere aggregation of an" +
						"other work not based on the Program with the Program (or with a work based on th" +
						"e Program) on a volume of a storage or distribution medium does not bring the ot" +
						"her work under the scope of this License.\r\n\r\n3. You may copy and distribute the " +
						"Program (or a work based on it, under Section 2) in object code or executable fo" +
						"rm under the terms of Sections 1 and 2 above provided that you also do one of th" +
						"e following:\r\n\r\na) Accompany it with the complete corresponding machine-readable" +
						" source code, which must be distributed under the terms of Sections 1 and 2 abov" +
						"e on a medium customarily used for software interchange; or,\r\n\r\nb) Accompany it " +
						"with a written offer, valid for at least three years, to give any third party, f" +
						"or a charge no more than your cost of physically performing source distribution," +
						" a complete machine-readable copy of the corresponding source code, to be distri" +
						"buted under the terms of Sections 1 and 2 above on a medium customarily used for" +
						" software interchange; or,\r\n\r\nc) Accompany it with the information you received " +
						"as to the offer to distribute corresponding source code.  (This alternative is a" +
						"llowed only for noncommercial distribution and only if you received the program " +
						"in object code or executable form with such an offer, in accord with Subsection " +
						"b above.)\r\n\r\nThe source code for a work means the preferred form of the work for" +
						" making modifications to it.  For an executable work, complete source code means" +
						" all the source code for all modules it contains, plus any associated interface " +
						"definition files, plus the scripts used to control compilation and installation " +
						"of the executable.  However, as a special exception, the source code distributed" +
						" need not include anything that is normally distributed (in either source or bin" +
						"ary form) with the major components (compiler, kernel, and so on) of the operati" +
						"ng system on which the executable runs, unless that component itself accompanies" +
						" the executable.\r\n\r\nIf distribution of executable or object code is made by offe" +
						"ring access to copy from a designated place, then offering equivalent access to " +
						"copy the source code from the same place counts as distribution of the source co" +
						"de, even though third parties are not compelled to copy the source along with th" +
						"e object code.\r\n\r\n4. You may not copy, modify, sublicense, or distribute the Pro" +
						"gram except as expressly provided under this License.  Any attempt otherwise to " +
						"copy, modify, sublicense or distribute the Program is void, and will automatical" +
						"ly terminate your rights under this License. However, parties who have received " +
						"copies, or rights, from you under this License will not have their licenses term" +
						"inated so long as such parties remain in full compliance.\r\n\r\n5. You are not requ" +
						"ired to accept this License, since you have not signed it.  However, nothing els" +
						"e grants you permission to modify or distribute the Program or its derivative wo" +
						"rks.  These actions are prohibited by law if you do not accept this License.  Th" +
						"erefore, by modifying or distributing the Program (or any work based on the Prog" +
						"ram), you indicate your acceptance of this License to do so, and all its terms a" +
						"nd conditions for copying, distributing or modifying the Program or works based " +
						"on it.\r\n\r\n6. Each time you redistribute the Program (or any work based on the Pr" +
						"ogram), the recipient automatically receives a license from the original licenso" +
						"r to copy, distribute or modify the Program subject to these terms and condition" +
						"s.  You may not impose any further restrictions on the recipients\' exercise of t" +
						"he rights granted herein. You are not responsible for enforcing compliance by th" +
						"ird parties to this License.\r\n\r\n7. If, as a consequence of a court judgment or a" +
						"llegation of patent infringement or for any other reason (not limited to patent " +
						"issues), conditions are imposed on you (whether by court order, agreement or oth" +
						"erwise) that contradict the conditions of this License, they do not excuse you f" +
						"rom the conditions of this License.  If you cannot distribute so as to satisfy s" +
						"imultaneously your obligations under this License and any other pertinent obliga" +
						"tions, then as a consequence you may not distribute the Program at all.  For exa" +
						"mple, if a patent license would not permit royalty-free redistribution of the Pr" +
						"ogram by all those who receive copies directly or indirectly through you, then t" +
						"he only way you could satisfy both it and this License would be to refrain entir" +
						"ely from distribution of the Program.\r\n\r\nIf any portion of this section is held " +
						"invalid or unenforceable under any particular circumstance, the balance of the s" +
						"ection is intended to apply and the section as a whole is intended to apply in o" +
						"ther circumstances.\r\n\r\nIt is not the purpose of this section to induce you to in" +
						"fringe any patents or other property right claims or to contest validity of any " +
						"such claims; this section has the sole purpose of protecting the integrity of th" +
						"e free software distribution system, which is implemented by public license prac" +
						"tices.  Many people have made generous contributions to the wide range of softwa" +
						"re distributed through that system in reliance on consistent application of that" +
						" system; it is up to the author/donor to decide if he or she is willing to distr" +
						"ibute software through any other system and a licensee cannot impose that choice" +
						".\r\n\r\nThis section is intended to make thoroughly clear what is believed to be a " +
						"consequence of the rest of this License.\r\n\r\n8. If the distribution and/or use of" +
						" the Program is restricted in certain countries either by patents or by copyrigh" +
						"ted interfaces, the original copyright holder who places the Program under this " +
						"License may add an explicit geographical distribution limitation excluding those" +
						" countries, so that distribution is permitted only in or among countries not thu" +
						"s excluded.  In such case, this License incorporates the limitation as if writte" +
						"n in the body of this License.\r\n\r\n9. The Free Software Foundation may publish re" +
						"vised and/or new versions of the General Public License from time to time.  Such" +
						" new versions will be similar in spirit to the present version, but may differ i" +
						"n detail to address new problems or concerns.\r\n\r\nEach version is given a disting" +
						"uishing version number.  If the Program specifies a version number of this Licen" +
						"se which applies to it and \"any later version\", you have the option of following" +
						" the terms and conditions either of that version or of any later version publish" +
						"ed by the Free Software Foundation.  If the Program does not specify a version n" +
						"umber of this License, you may choose any version ever published by the Free Sof" +
						"tware Foundation.\r\n\r\n10. If you wish to incorporate parts of the Program into ot" +
						"her free programs whose distribution conditions are different, write to the auth" +
						"or to ask for permission.  For software which is copyrighted by the Free Softwar" +
						"e Foundation, write to the Free Software Foundation; we sometimes make exception" +
						"s for this.  Our decision will be guided by the two goals of preserving the free" +
						" status of all derivatives of our free software and of promoting the sharing and" +
						" reuse of software generally. \r\n  \r\nNO WARRANTY\r\n\r\n11. BECAUSE THE PROGRAM IS LI" +
						"CENSED FREE OF CHARGE, THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMI" +
						"TTED BY APPLICABLE LAW.  EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT H" +
						"OLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM \"AS IS\" WITHOUT WARRANTY OF ANY " +
						"KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WA" +
						"RRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.  THE ENTIRE RI" +
						"SK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM IS WITH YOU.  SHOULD THE PRO" +
						"GRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF ALL NECESSARY SERVICING, REPAIR OR " +
						"CORRECTION.\r\n\r\n12. IN NO EVENT UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN" +
						" WRITING WILL ANY COPYRIGHT HOLDER, OR ANY OTHER PARTY WHO MAY MODIFY AND/OR RED" +
						"ISTRIBUTE THE PROGRAM AS PERMITTED ABOVE, BE LIABLE TO YOU FOR DAMAGES, INCLUDIN" +
						"G ANY GENERAL, SPECIAL, INCIDENTAL OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE U" +
						"SE OR INABILITY TO USE THE PROGRAM (INCLUDING BUT NOT LIMITED TO LOSS OF DATA OR" +
						" DATA BEING RENDERED INACCURATE OR LOSSES SUSTAINED BY YOU OR THIRD PARTIES OR A" +
						" FAILURE OF THE PROGRAM TO OPERATE WITH ANY OTHER PROGRAMS), EVEN IF SUCH HOLDER" +
						" OR OTHER PARTY HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.";
				#endregion
					break;
				case "spa":
					this.Text = "Acerca de ...";
					this.label3.Text = "Desarrolado por : ";
					this.label2.Text = "Version "+ver;
					this.label4.Text = "Este freeware es distribuido bajo la licencia pública GNU. Fue desarrollado utilizando Microsoft Visual Studio .NET. Si desea una copia gratis del codigo fuente escriba al autor a: rolando.ruiz@gmail.com";
					this.tabPage1.Text = "Versión";
					this.tabPage3.Text = "Licencia";
					this.tabPage2.Text = "Agradecimientos";
					this.tabPage4.Text = "¿Katomic?";
					this.katomicinfo.Text = "      Si!, este juego es una copia de Katomic, un juego de KDE. La idea y los graficos fueron sacados de ahí, pero todo el codigo es mío. Este juego fue programado en Visual Studio .NET usando C#. Si quieres el codigo fuente puedes escribirme a rolando.ruiz@gmail.com\r\n\r\n      Cualquier comentario, reporte de bugs, etc. sera agradecido.\r\n\r\n      Espero que lo disfruten!\r\n\r\nMás info en\r\nhttp://docs.kde.org/es/HEAD/kdegames/katomic/";
					this.SZreason.Text = "Gracias por la traducción de las moleculas, gran ayuda!";
					this.FFreason.Text = "Por la ayuda a debugear, testear y otros.. GRACIAS a todos!!";
					this.friends.Text = "Martín Gutierrez, \n\r Alejandro Salinas, \n\rFelipe Zavala.";
					this.label6.Text = "Hermanos Zacharias :";
				#region LICENCIA
					this.textBox1.Text = "Este software se distribuye de acuerdo a la licencia GPL (GNU Licence Agreement)\r" +
						"\n\r\nCopyright (C) 2003 Rolando Ruiz C.\r\n\r\n\r\n-------------------------------------" +
						"-------------------------------------------\r\nNOTA IMPORTANTE: \r\nEsta es una trad" +
						"ucción no oficial al español de la GNU General Public License. No ha sido public" +
						"ada por la Free Software Foundation, y no establece legalmente las condiciones d" +
						"e distribución para el software que usa la GNU GPL. Estas condiciones se estable" +
						"cen solamente por el texto original, en inglés, de la GNU GPL. Sin embargo, espe" +
						"ramos que esta traducción ayude a los hispanohablantes a entender mejor la GNU G" +
						"PL. \r\nPara ver la Licencia en ingles seleccione el idioma \"English\" y vuela a Ab" +
						"out.\r\n--------------------------------------------------------------------------" +
						"------\r\n\r\nLicencia Pública GNU\r\n\r\nTérminos y condiciones para la copia, distribu" +
						"ción y modificación\r\nEsta Licencia se aplica a cualquier programa u otro tipo de" +
						" trabajo que contenga una nota colocada por el tenedor del copyright diciendo qu" +
						"e puede ser distribuido bajo los términos de esta Licencia Pública General. En a" +
						"delante, «Programa» se referirá a cualquier programa o trabajo que cumpla esa co" +
						"ndición y «trabajo basado en el Programa» se referirá bien al Programa o a cualq" +
						"uier trabajo derivado de él según la ley de copyright. Esto es, un trabajo que c" +
						"ontenga el programa o una proción de él, bien en forma literal o con modificacio" +
						"nes y/o traducido en otro lenguaje. Por lo tanto, la traducción está incluida si" +
						"n limitaciones en el término «modificación». Cada concesionario (licenciatario) " +
						"será denominado «usted». \r\nCualquier otra actividad que no sea la copia, distrib" +
						"ución o modificación no está cubierta por esta Licencia, está fuera de su ámbito" +
						". El acto de ejecutar el Programa no está restringido, y los resultados del Prog" +
						"rama están cubiertos únicamente si sus contenidos constituyen un trabajo basado " +
						"en el Programa, independientemente de haberlo producido mediante la ejecución de" +
						"l programa. El que esto se cumpla, depende de lo que haga el programa. \r\n\r\nUsted" +
						" puede copiar y distribuir copias literales del código fuente del Programa, segú" +
						"n lo has recibido, en cualquier medio, supuesto que de forma adecuada y bien vis" +
						"ible publique en cada copia un anuncio de copyright adecuado y un repudio de gar" +
						"antía, mantenga intactos todos los anuncios que se refieran a esta Licencia y a " +
						"la ausencia de garantía, y proporcione a cualquier otro receptor del programa un" +
						"a copia de esta Licencia junto con el Programa. \r\nPuede cobrar un precio por el " +
						"acto físico de transferir una copia, y puede, según su libre albedrío, ofrecer g" +
						"arantía a cambio de unos honorarios. \r\n\r\nPuede modificar su copia o copias del P" +
						"rograma o de cualquier porción de él, formando de esta manera un trabajo basado " +
						"en el Programa, y copiar y distribuir esa modificación o trabajo bajo los términ" +
						"os del apartado 1, antedicho, supuesto que además cumpla las siguientes condicio" +
						"nes: \r\nDebe hacer que los ficheros modificados lleven anuncios prominentes indic" +
						"ando que los ha cambiado y la fecha de cualquier cambio. \r\nDebe hacer que cualqu" +
						"ier trabajo que distribuya o publique y que en todo o en parte contenga o sea de" +
						"rivado del Programa o de cualquier parte de él sea licenciada como un todo, sin " +
						"carga alguna, a todas las terceras partes y bajo los términos de esta Licencia. " +
						"\r\nSi el programa modificado lee normalmente órdenes interactivamente cuando es e" +
						"jecutado, debe hacer que, cuando comience su ejecución para ese uso interactivo " +
						"de la forma más habitual, muestre o escriba un mensaje que incluya un anuncio de" +
						" copyright y un anuncio de que no se ofrece ninguna garantía (o por el contrario" +
						" que sí se ofrece garantía) y que los usuarios pueden redistribuir el programa b" +
						"ajo estas condiciones, e indicando al usuario cómo ver una copia de esta licenci" +
						"a. (Excepción: si el propio programa es interactivo pero normalmente no muestra " +
						"ese anuncio, no se requiere que su trabajo basado en el Programa muestre ningún " +
						"anuncio).\r\nEstos requisitos se aplican al trabajo modificado como un todo. Si pa" +
						"rtes identificables de ese trabajo no son derivadas del Programa, y pueden, razo" +
						"nablemente, ser consideradas trabajos independientes y separados por ellos mismo" +
						"s, entonces esta Licencia y sus términos no se aplican a esas partes cuando sean" +
						" distribuidas como trabajos separados. Pero cuando distribuya esas mismas seccio" +
						"nes como partes de un todo que es un trabajo basado en el Programa, la distribuc" +
						"ión del todo debe ser según los términos de esta licencia, cuyos permisos para o" +
						"tros licenciatarios se extienden al todo completo, y por lo tanto a todas y cada" +
						" una de sus partes, con independencia de quién la escribió. \r\nPor lo tanto, no e" +
						"s la intención de este apartado reclamar derechos o desafiar sus derechos sobre " +
						"trabajos escritos totalmente por usted mismo. El intento es ejercer el derecho a" +
						" controlar la distribución de trabajos derivados o colectivos basados en el Prog" +
						"rama. \r\n\r\nAdemás, el simple hecho de reunir un trabajo no basado en el Programa " +
						"con el Programa (o con un trabajo basado en el Programa) en un volumen de almace" +
						"namiento o en un medio de distribución no hace que dicho trabajo entre dentro de" +
						"l ámbito cubierto por esta Licencia. \r\n\r\nPuede copiar y distribuir el Programa (" +
						"o un trabajo basado en él, según se especifica en el apartado 2, como código obj" +
						"eto o en formato ejecutable según los términos de los apartados 1 y 2, supuesto " +
						"que además cumpla una de las siguientes condiciones: \r\nAcompañarlo con el código" +
						" fuente completo correspondiente, en formato electrónico, que debe ser distribui" +
						"do según se especifica en los apartados 1 y 2 de esta Licencia en un medio habit" +
						"ualmente utilizado para el intercambio de programas, o \r\nAcompañarlo con una ofe" +
						"rta por escrito, válida durante al menos tres años, de proporcionar a cualquier " +
						"tercera parte una copia completa en formato electrónico del código fuente corres" +
						"pondiente, a un coste no mayor que el de realizar físicamente la distribución de" +
						"l fuente, que será distribuido bajo las condiciones descritas en los apartados 1" +
						" y 2 anteriores, en un medio habitualmente utilizado para el intercambio de prog" +
						"ramas, o \r\nAcompañarlo con la información que recibiste ofreciendo distribuir el" +
						" código fuente correspondiente. (Esta opción se permite sólo para distribución n" +
						"o comercial y sólo si usted recibió el programa como código objeto o en formato " +
						"ejecutable con tal oferta, de acuerdo con el apartado b anterior).\r\nPor código f" +
						"uente de un trabajo se entiende la forma preferida del trabajo cuando se le hace" +
						"n modificaciones. Para un trabajo ejecutable, se entiende por código fuente comp" +
						"leto todo el código fuente para todos los módulos que contiene, más cualquier fi" +
						"chero asociado de definición de interfaces, más los guiones utilizados para cont" +
						"rolar la compilación e instalación del ejecutable. Como excepción especial el có" +
						"digo fuente distribuido no necesita incluir nada que sea distribuido normalmente" +
						" (bien como fuente, bien en forma binaria) con los componentes principales (comp" +
						"ilador, kernel y similares) del sistema operativo en el cual funciona el ejecuta" +
						"ble, a no ser que el propio componente acompañe al ejecutable. \r\nSi la distribuc" +
						"ión del ejecutable o del código objeto se hace mediante la oferta acceso para co" +
						"piarlo de un cierto lugar, entonces se considera la oferta de acceso para copiar" +
						" el código fuente del mismo lugar como distribución del código fuente, incluso a" +
						"unque terceras partes no estén forzadas a copiar el fuente junto con el código o" +
						"bjeto. \r\n\r\nNo puede copiar, modificar, sublicenciar o distribuir el Programa exc" +
						"epto como prevé expresamente esta Licencia. Cualquier intento de copiar, modific" +
						"ar sublicenciar o distribuir el Programa de otra forma es inválida, y hará que c" +
						"esen automáticamente los derechos que te proporciona esta Licencia. En cualquier" +
						" caso, las partes que hayan recibido copias o derechos de usted bajo esta Licenc" +
						"ia no cesarán en sus derechos mientras esas partes continúen cumpliéndola. \r\nNo " +
						"está obligado a aceptar esta licencia, ya que no la ha firmado. Sin embargo, no " +
						"hay hada más que le proporcione permiso para modificar o distribuir el Programa " +
						"o sus trabajos derivados. Estas acciones están prohibidas por la ley si no acept" +
						"a esta Licencia. Por lo tanto, si modifica o distribuye el Programa (o cualquier" +
						" trabajo basado en el Programa), está indicando que acepta esta Licencia para po" +
						"der hacerlo, y todos sus términos y condiciones para copiar, distribuir o modifi" +
						"car el Programa o trabajos basados en él. \r\nCada vez que redistribuya el Program" +
						"a (o cualquier trabajo basado en el Programa), el receptor recibe automáticament" +
						"e una licencia del licenciatario original para copiar, distribuir o modificar el" +
						" Programa, de forma sujeta a estos términos y condiciones. No puede imponer al r" +
						"eceptor ninguna restricción más sobre el ejercicio de los derechos aquí garantiz" +
						"ados. No es usted responsable de hacer cumplir esta licencia por terceras partes" +
						". \r\nSi como consecuencia de una resolución judicial o de una alegación de infrac" +
						"ción de patente o por cualquier otra razón (no limitada a asuntos relacionados c" +
						"on patentes) se le imponen condiciones (ya sea por mandato judicial, por acuerdo" +
						" o por cualquier otra causa) que contradigan las condiciones de esta Licencia, e" +
						"llo no le exime de cumplir las condiciones de esta Licencia. Si no puede realiza" +
						"r distribuciones de forma que se satisfagan simultáneamente sus obligaciones baj" +
						"o esta licencia y cualquier otra obligación pertinente entonces, como consecuenc" +
						"ia, no puede distribuir el Programa de ninguna forma. Por ejemplo, si una patent" +
						"e no permite la redistribución libre de derechos de autor del Programa por parte" +
						" de todos aquellos que reciban copias directa o indirectamente a través de usted" +
						", entonces la única forma en que podría satisfacer tanto esa condición como esta" +
						" Licencia sería evitar completamente la distribución del Programa. \r\nSi cualquie" +
						"r porción de este apartado se considera inválida o imposible de cumplir bajo cua" +
						"lquier circunstancia particular ha de cumplirse el resto y la sección por entero" +
						" ha de cumplirse en cualquier otra circunstancia. \r\n\r\nNo es el propósito de este" +
						" apartado inducirle a infringir ninguna reivindicación de patente ni de ningún o" +
						"tro derecho de propiedad o impugnar la validez de ninguna de dichas reivindicaci" +
						"ones. Este apartado tiene el único propósito de proteger la integridad del siste" +
						"ma de distribución de software libre, que se realiza mediante prácticas de licen" +
						"cia pública. Mucha gente ha hecho contribuciones generosas a la gran variedad de" +
						" software distribuido mediante ese sistema con la confianza de que el sistema se" +
						" aplicará consistentemente. Será el autor/donante quien decida si quiere distrib" +
						"uir software mediante cualquier otro sistema y una licencia no puede imponer esa" +
						" elección. \r\n\r\nEste apartado pretende dejar completamente claro lo que se cree q" +
						"ue es una consecuencia del resto de esta Licencia. \r\n\r\nSi la distribución y/o us" +
						"o de el Programa está restringida en ciertos países, bien por patentes o por int" +
						"erfaces bajo copyright, el tenedor del copyright que coloca este Programa bajo e" +
						"sta Licencia puede añadir una limitación explícita de distribución geográfica ex" +
						"cluyendo esos países, de forma que la distribución se permita sólo en o entre lo" +
						"s países no excluidos de esta manera. En ese caso, esta Licencia incorporará la " +
						"limitación como si estuviese escrita en el cuerpo de esta Licencia. \r\nLa Free So" +
						"ftware Foundation puede publicar versiones revisadas y/o nuevas de la Licencia P" +
						"ública General de tiempo en tiempo. Dichas nuevas versiones serán similares en e" +
						"spíritu a la presente versión, pero pueden ser diferentes en detalles para consi" +
						"derar nuevos problemas o situaciones. \r\nCada versión recibe un número de versión" +
						" que la distingue de otras. Si el Programa especifica un número de versión de es" +
						"ta Licencia que se refiere a ella y a «cualquier versión posterior», tienes la o" +
						"pción de seguir los términos y condiciones, bien de esa versión, bien de cualqui" +
						"er versión posterior publicada por la Free Software Foundation. Si el Programa n" +
						"o especifica un número de versión de esta Licencia, puedes escoger cualquier ver" +
						"sión publicada por la Free Software Foundation. \r\n\r\nSi quiere incorporar partes " +
						"del Programa en otros programas libres cuyas condiciones de distribución son dif" +
						"erentes, escribe al autor para pedirle permiso. Si el software tiene copyright d" +
						"e la Free Software Foundation, escribe a la Free Software Foundation: algunas ve" +
						"ces hacemos excepciones en estos casos. Nuestra decisión estará guiada por el do" +
						"ble objetivo de de preservar la libertad de todos los derivados de nuestro softw" +
						"are libre y promover el que se comparta y reutilice el software en general.\r\n\r\n\r" +
						"\nAUSENCIA DE GARANTÍA\r\nComo el programa se licencia libre de cargas, no se ofrec" +
						"e ninguna garantía sobre el programa, en todas la extensión permitida por la leg" +
						"islación aplicable. Excepto cuando se indique de otra forma por escrito, los ten" +
						"edores del copyright y/u otras partes proporcionan el programa «tal cual», sin g" +
						"arantía de ninguna clase, bien expresa o implícita, con inclusión, pero sin limi" +
						"tación a las garantías mercantiles implícitas o a la conveniencia para un propós" +
						"ito particular. Cualquier riesgo referente a la calidad y prestaciones del progr" +
						"ama es asumido por usted. Si se probase que el Programa es defectuoso, asume el " +
						"coste de cualquier servicio, reparación o corrección. \r\nEn ningún caso, salvo qu" +
						"e lo requiera la legislación aplicable o haya sido acordado por escrito, ningún " +
						"tenedor del copyright ni ninguna otra parte que modifique y/o redistribuya el Pr" +
						"ograma según se permite en esta Licencia será responsable ante usted por daños, " +
						"incluyendo cualquier daño general, especial, incidental o resultante producido p" +
						"or el uso o la imposibilidad de uso del Programa (con inclusión, pero sin limita" +
						"ción a la pérdida de datos o a la generación incorrecta de datos o a pérdidas su" +
						"fridas por usted o por terceras partes o a un fallo del Programa al funcionar en" +
						" combinación con cualquier otro programa), incluso si dicho tenedor u otra parte" +
						" ha sido advertido de la posibilidad de dichos daños.";
				#endregion
					break;
				case "ger":
					this.Text = " ...";
					this.label3.Text = " : ";
					this.label2.Text = "Versugen "+ver;
					this.label4.Text = "";
					this.tabPage1.Text = "Versugen";
					this.tabPage3.Text = "";
					this.tabPage2.Text = "";
					this.tabPage4.Text = "";
					this.katomicinfo.Text = " ";
					break;
			}
		}

	}
}
