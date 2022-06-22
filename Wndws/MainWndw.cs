using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Ares cannot be run from WinRAR Please extract to a folder and try again.", "Ares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            InitializeComponent();
            checkProcess();
        }

        private void MainWndw_Load(object sender, EventArgs e)
        {
            msgLbl.Text = "None";
            weaponPnl.Hide();
            if (Data.procOpen)
            {
                try
                {
                    var cave = CodeCave.createCodeCave("iw4x", 1048);
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

        private void mainBtn_Click(object sender, EventArgs e)
        {
            weaponPnl.Hide();
            mainPnl.Show();
        }

        private void weaponBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Hide();
            weaponPnl.Show();
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Hide();
            weaponPnl.Hide();
        }

        private void unlimitedAmmoWeaponComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Data.procOpen)
            {
                var ammotType = unlimitedAmmoWeaponComboBox.Text.ToLower();
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

                    case "none":
                        try
                        {
                            Memory.UnfreezeValue(Data.interventionAmmoPointer);
                            Memory.UnfreezeValue(Data.deagleAmmoPointer);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error unfreezing ammo, error: {ex.Message}", Application.ProductName);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("iw4x is not open, restart Ares when iw4x opens", Application.ProductName);
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
                CodeCave.releaseCave("iw4x", (IntPtr)address);
                Close();
            }
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void weaponPnl_Click(object sender, EventArgs e)
        {
            weaponPnl.Select();
        }

        void checkProcess()
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

        void writeToCave(string Data)
        {
            CodeCave.writeToCave("iw4x", (IntPtr)int.Parse(caveAddressLbl.Text, System.Globalization.NumberStyles.HexNumber), Encoding.ASCII.GetBytes(Data));
        }
    }
}
