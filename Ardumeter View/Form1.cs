/*
 * By GeoSn0w (@FCE365)
 * You can use whatever voltage sensor you wish. Just make sure your arduino sends the result from the voltage sensor as string via Serial. Baud 9600 
 * Something like Serial.println("12.2"). Of course, modifications can be made. This is just a bare-bone project. Have fun.
 * MIT License
 * Copyright (c) 2018 GeoSn0w
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;
using System.Management;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Ardumeter_View
{
    public partial class Form1 : Form
    {
        //Props to FreewareFire from CodeProject for the borderless form moving code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        string TempHold;
        string MemCopy = "0.00";
        int COM_PORT_RAILER = 99;
        public Form1()
        {
            InitializeComponent();
        }

        private void MeterShutDownRail_Click(object sender, EventArgs e)
        {
            PPV_ARDUINO_IN.Close();
            PPV_LCD_Backlight.BackColor = Color.DarkOliveGreen;
            PPV_LCD_VICON.Visible = false;
            PPV_LCD_DATA_IN.Visible = false;
            PPVLM_Rail1.Visible = false;
            lastResultRail.Visible = false;
            Thread.Sleep(500);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (COM_PORT_RAILER == 99) { 
           
                PPVLM_Rail1.Text = "Configure COM Port";

            } else {

                PPVLM_Rail1.Text = "Last Measurement: ";
                lastResultRail.Visible = true;
                lastResultRail.Text = "0.00 V";
                PPV_ARDUINO_DATA_IN.RunWorkerAsync();
            }

        }
        private void PPV_SELECTIVE_LCD()
        {
            if (PPV_LCD_Backlight.Visible == true)
            {

                PPV_LCD2_INNER.Visible = true;
                PPV_LCD_Backlight.Visible = false;
                info_pan.Visible = false;

            }
            else if (PPV_LCD_Backlight.Visible == false)
            {
                PPV_LCD_Backlight.Visible = true;
                PPV_LCD2_INNER.Visible = false;
                info_pan.Visible = false;
            }
        }
        private void IO_SETTINGS_TOGGLE_RAIL_Click(object sender, EventArgs e)
        {
            PPV_SELECTIVE_LCD();
        }

        private void EEPROM_WRITE_CHANGES_Click(object sender, EventArgs e)
        {
            COM_PORT_RAILER = int.Parse(COM_PORT_RAIL.Text);
            PPVLM_Rail1.Text = "Last Measurement: ";
            lastResultRail.Visible = true;
            lastResultRail.Text = "0.00 V";
            PPV_SELECTIVE_LCD();
            try
            {
                PPV_ARDUINO_IN.Close();
                PPV_ARDUINO_IN.PortName = "COM" + COM_PORT_RAILER;
                PPV_ARDUINO_IN.Open();
                PPV_ARDUINO_DATA_IN.RunWorkerAsync();
            } catch (Exception ex)
            {

                MessageBox.Show("Cannot open the port. It may be busy or inactive. The following error has occured: \n" + ex , "ArduMeter went berserk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string QueryTheFuckOutOfThisPCToFindTheArduino()
        {
            ManagementScope newcon = new ManagementScope();
            SelectQuery sqme = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher WatchDog = new ManagementObjectSearcher(newcon, sqme);
            try
            {
                foreach (ManagementObject Property in WatchDog.Get())
                {
                    string DevicePort = Property["DeviceID"].ToString();
                    string dev_description = Property["Description"].ToString();
                    if (dev_description.Contains("Arduino") || dev_description.Contains("arduino"))
                    {
                        return DevicePort;
                    }
                }
            }
            catch (ManagementException manex) {
                MessageBox.Show("Cannot autodetect the port. The following error has occured: \n" + manex, "ArduMeter went berserk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "COMXX";
        }
        private void COM_PORT_RAIL_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(COM_PORT_RAIL.Text, "[^0-9]"))
            {
                MessageBox.Show("COM Ports can only be numbers!", "ArduMeter has issues...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                COM_PORT_RAIL.Text = COM_PORT_RAIL.Text.Remove(COM_PORT_RAIL.Text.Length - 1);
            }
        }
        private void detectArduinoAnywhere_Click(object sender, EventArgs e)
        {
            if (QueryTheFuckOutOfThisPCToFindTheArduino() == "COMXX") {
                MessageBox.Show("Could not locate the Arduino device. You may wanna specify its port manually.", "ArduMeter has issues...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                TempHold = QueryTheFuckOutOfThisPCToFindTheArduino();
                char[] TrimStuff = {'C', 'O', 'M'}; //We get rid of the "COM" because the function returns "COM3" for example and we only need "3"
                string COMPortInNumbers = TempHold.TrimStart(TrimStuff);
                COM_PORT_RAIL.Text = COMPortInNumbers;
            }
        }

        private void PPV_LCD_DATA_IN_TextChanged(object sender, EventArgs e)
        {
            if (PPV_LCD_DATA_IN.Text != MemCopy)
            {
                lastResultRail.Text = MemCopy + " V";
            }
        }

        private void PPV_ARDUINO_DATA_IN_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(PPV_ARDUINO_IN.IsOpen)
            {
                PPV_LCD_DATA_IN.Invoke((MethodInvoker)delegate
                {
                    PPV_LCD_DATA_IN.Text = PPV_ARDUINO_IN.ReadLine();
                    MemCopy = PPV_LCD_DATA_IN.Text;
                });
            }
            PPV_ARDUINO_DATA_IN.RunWorkerAsync();
        }

        private void PPV_INFO_PANE_Click(object sender, EventArgs e)
        {
            if (info_pan.Visible == true)
            {
                info_pan.Visible = false;
                PPV_LCD2_INNER.Visible = false;
                PPV_LCD_Backlight.Visible = true;
              

            }
            else if (info_pan.Visible == false)
            {
                info_pan.Visible = true;
                PPV_LCD_Backlight.Visible = false;
                PPV_LCD2_INNER.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PPV_ARDUINO_IN.Close();
            } catch (Exception ex)
            {
                //Nil
            }
       
        }

        private void drag_me_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
