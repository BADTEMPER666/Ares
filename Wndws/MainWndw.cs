using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AresGUI.Handler;
using AresGUI.Handler.Memory;
using Memory;

namespace AresGUI.Wndws
{
    public partial class MainWndw : Form
    {
        public static Mem Memory = new Mem();

        public MainWndw()
        {
            InitializeComponent();
            checkProcess();
        }

        private void MainWndw_Load(object sender, EventArgs e)
        {
            if (Data.procOpen)
            {
                try
                {
                    var cave = CodeCaveUtility.createCodeCave("iw4x", 1048);
                    caveAddressLbl.Text = cave.ToString("X"); //hex
                    writeToCave("Ares Code Cave");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ares occured an error creating a Code Cave, the app will restart so it can the cave properly. error: {ex.Message}", Application.ProductName + " | PLEASE READ");
                    Environment.Exit(0);
                }
            }
            else
            {
                caveAddressLbl.Text = ("iw4x not open");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (caveAddressLbl.Text == "iw4x not open")
            {
                Close();
            }
            else
            {
                var address = int.Parse(caveAddressLbl.Text, System.Globalization.NumberStyles.HexNumber);
                CodeCaveUtility.releaseCave("iw4x", (IntPtr)address);
                Close();
            }
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void unlimitedAmmoTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Data.procOpen)
                {
                    var ammotType = unlimitedAmmoTxtBox.Text.ToLower();
                    switch (ammotType)
                    {
                        case "intervention":
                            try
                            {
                                Memory.FreezeValue(Data.interventionAmmoPointer, "int", "30");
                                msgLbl.Text = "Froze Intervention ammo";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error freezing Intervention ammo pointer, error: {ex.Message}", Application.ProductName);
                            }
                            break;

                        case "deagle":
                            try
                            {
                                Memory.FreezeValue(Data.deagleAmmoPointer, "int", "30");
                                msgLbl.Text = "Froze Deagle ammo";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error freezing Deagle ammo pointer, error: {ex.Message}", Application.ProductName);
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("iw4x is not open, restart Ares when iw4x opens", Application.ProductName);
                }
            }
        }

        static void checkProcess()
        {
            Process[] processes = Process.GetProcessesByName("iw4x");
            if (processes.Length == 0)
            {
                Data.procOpen = false;
            }
            else
            {
                Memory.OpenProcess("iw4x");
                Data.procOpen = true;
            }
        }

        private void writeToCave(string Data)
        {
            CodeCaveUtility.writeToCave("iw4x", (IntPtr)int.Parse(caveAddressLbl.Text, System.Globalization.NumberStyles.HexNumber), Encoding.ASCII.GetBytes(Data));
        }
    }
}
