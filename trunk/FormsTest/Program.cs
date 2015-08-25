﻿using System;
using System.Windows.Forms;
using System.Threading;
using FormsTest;
//using MonoMac.AppKit;

namespace FormsTest
{
	public static class Program
	{
        //public static Settings Settings { get; private set; }
        
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
