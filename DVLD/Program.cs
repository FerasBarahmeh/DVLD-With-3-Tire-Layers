﻿using DVLD.Applications.Local_Driving_License;
using System;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmListsLocalDrivingLicenseApplications());
            //Application.Run(new frmListTestAppointments(50, Business.clsTestTypes.enTestType.VisionTest));
        }
    }
}
