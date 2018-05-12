namespace Ardumeter_View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PPV_LCD_DATA_IN = new System.Windows.Forms.Label();
            this.PPV_LCD_Backlight = new System.Windows.Forms.Panel();
            this.lastResultRail = new System.Windows.Forms.Label();
            this.PPVLM_Rail1 = new System.Windows.Forms.Label();
            this.PPV_LCD_VICON = new System.Windows.Forms.Label();
            this.PRODUCT_ID = new System.Windows.Forms.Label();
            this.MODEL_NO = new System.Windows.Forms.Label();
            this.BUILDER_RAIL_ID = new System.Windows.Forms.Label();
            this.PPV_LCD2_INNER = new System.Windows.Forms.Panel();
            this.detectArduinoAnywhere = new System.Windows.Forms.Button();
            this.COM_PORT_RAIL = new System.Windows.Forms.TextBox();
            this.ARDUINO_TEXT_INIT = new System.Windows.Forms.Label();
            this.EEPROM_WRITE_CHANGES = new System.Windows.Forms.Button();
            this.COM_PORT_DESC_TXT = new System.Windows.Forms.Label();
            this.PPV_ARDUINO_IN = new System.IO.Ports.SerialPort(this.components);
            this.PPV_ARDUINO_DATA_IN = new System.ComponentModel.BackgroundWorker();
            this.PPV_INFO_PANE = new System.Windows.Forms.PictureBox();
            this.IO_SETTINGS_TOGGLE_RAIL = new System.Windows.Forms.PictureBox();
            this.MeterShutDownRail = new System.Windows.Forms.PictureBox();
            this.info_pan = new System.Windows.Forms.Panel();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.drag_me = new System.Windows.Forms.Label();
            this.PPV_LCD_Backlight.SuspendLayout();
            this.PPV_LCD2_INNER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPV_INFO_PANE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IO_SETTINGS_TOGGLE_RAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeterShutDownRail)).BeginInit();
            this.info_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPV_LCD_DATA_IN
            // 
            this.PPV_LCD_DATA_IN.AutoSize = true;
            this.PPV_LCD_DATA_IN.Font = new System.Drawing.Font("Consolas", 100F);
            this.PPV_LCD_DATA_IN.Location = new System.Drawing.Point(70, -2);
            this.PPV_LCD_DATA_IN.Name = "PPV_LCD_DATA_IN";
            this.PPV_LCD_DATA_IN.Size = new System.Drawing.Size(363, 157);
            this.PPV_LCD_DATA_IN.TabIndex = 0;
            this.PPV_LCD_DATA_IN.Text = "0.00";
            this.PPV_LCD_DATA_IN.TextChanged += new System.EventHandler(this.PPV_LCD_DATA_IN_TextChanged);
            // 
            // PPV_LCD_Backlight
            // 
            this.PPV_LCD_Backlight.BackColor = System.Drawing.Color.OliveDrab;
            this.PPV_LCD_Backlight.Controls.Add(this.lastResultRail);
            this.PPV_LCD_Backlight.Controls.Add(this.PPVLM_Rail1);
            this.PPV_LCD_Backlight.Controls.Add(this.PPV_LCD_VICON);
            this.PPV_LCD_Backlight.Controls.Add(this.PPV_LCD_DATA_IN);
            this.PPV_LCD_Backlight.Location = new System.Drawing.Point(12, 52);
            this.PPV_LCD_Backlight.Name = "PPV_LCD_Backlight";
            this.PPV_LCD_Backlight.Size = new System.Drawing.Size(404, 195);
            this.PPV_LCD_Backlight.TabIndex = 1;
            // 
            // lastResultRail
            // 
            this.lastResultRail.AutoSize = true;
            this.lastResultRail.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastResultRail.Location = new System.Drawing.Point(290, 155);
            this.lastResultRail.Name = "lastResultRail";
            this.lastResultRail.Size = new System.Drawing.Size(111, 34);
            this.lastResultRail.TabIndex = 4;
            this.lastResultRail.Text = "0.00 V";
            this.lastResultRail.Visible = false;
            // 
            // PPVLM_Rail1
            // 
            this.PPVLM_Rail1.AutoSize = true;
            this.PPVLM_Rail1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPVLM_Rail1.Location = new System.Drawing.Point(4, 155);
            this.PPVLM_Rail1.Name = "PPVLM_Rail1";
            this.PPVLM_Rail1.Size = new System.Drawing.Size(287, 34);
            this.PPVLM_Rail1.TabIndex = 3;
            this.PPVLM_Rail1.Text = "Last measurement:";
            // 
            // PPV_LCD_VICON
            // 
            this.PPV_LCD_VICON.AutoSize = true;
            this.PPV_LCD_VICON.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPV_LCD_VICON.Location = new System.Drawing.Point(0, 0);
            this.PPV_LCD_VICON.Name = "PPV_LCD_VICON";
            this.PPV_LCD_VICON.Size = new System.Drawing.Size(37, 41);
            this.PPV_LCD_VICON.TabIndex = 2;
            this.PPV_LCD_VICON.Text = "V";
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.AutoSize = true;
            this.PRODUCT_ID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCT_ID.ForeColor = System.Drawing.Color.White;
            this.PRODUCT_ID.Location = new System.Drawing.Point(8, 9);
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Size = new System.Drawing.Size(118, 24);
            this.PRODUCT_ID.TabIndex = 2;
            this.PRODUCT_ID.Text = "ArduMeter";
            // 
            // MODEL_NO
            // 
            this.MODEL_NO.AutoSize = true;
            this.MODEL_NO.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODEL_NO.ForeColor = System.Drawing.Color.White;
            this.MODEL_NO.Location = new System.Drawing.Point(367, 9);
            this.MODEL_NO.Name = "MODEL_NO";
            this.MODEL_NO.Size = new System.Drawing.Size(54, 24);
            this.MODEL_NO.TabIndex = 3;
            this.MODEL_NO.Text = "UNO";
            // 
            // BUILDER_RAIL_ID
            // 
            this.BUILDER_RAIL_ID.AutoSize = true;
            this.BUILDER_RAIL_ID.Font = new System.Drawing.Font("Consolas", 13.75F);
            this.BUILDER_RAIL_ID.ForeColor = System.Drawing.Color.White;
            this.BUILDER_RAIL_ID.Location = new System.Drawing.Point(4, 306);
            this.BUILDER_RAIL_ID.Name = "BUILDER_RAIL_ID";
            this.BUILDER_RAIL_ID.Size = new System.Drawing.Size(210, 22);
            this.BUILDER_RAIL_ID.TabIndex = 7;
            this.BUILDER_RAIL_ID.Text = "by GeoSn0w (@FCE365)";
            // 
            // PPV_LCD2_INNER
            // 
            this.PPV_LCD2_INNER.BackColor = System.Drawing.Color.OliveDrab;
            this.PPV_LCD2_INNER.Controls.Add(this.detectArduinoAnywhere);
            this.PPV_LCD2_INNER.Controls.Add(this.COM_PORT_RAIL);
            this.PPV_LCD2_INNER.Controls.Add(this.ARDUINO_TEXT_INIT);
            this.PPV_LCD2_INNER.Controls.Add(this.EEPROM_WRITE_CHANGES);
            this.PPV_LCD2_INNER.Controls.Add(this.COM_PORT_DESC_TXT);
            this.PPV_LCD2_INNER.Location = new System.Drawing.Point(12, 50);
            this.PPV_LCD2_INNER.Name = "PPV_LCD2_INNER";
            this.PPV_LCD2_INNER.Size = new System.Drawing.Size(404, 195);
            this.PPV_LCD2_INNER.TabIndex = 5;
            this.PPV_LCD2_INNER.Visible = false;
            // 
            // detectArduinoAnywhere
            // 
            this.detectArduinoAnywhere.FlatAppearance.BorderSize = 2;
            this.detectArduinoAnywhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectArduinoAnywhere.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectArduinoAnywhere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.detectArduinoAnywhere.Location = new System.Drawing.Point(73, 101);
            this.detectArduinoAnywhere.Name = "detectArduinoAnywhere";
            this.detectArduinoAnywhere.Size = new System.Drawing.Size(252, 35);
            this.detectArduinoAnywhere.TabIndex = 7;
            this.detectArduinoAnywhere.Text = "Autodetect";
            this.detectArduinoAnywhere.UseVisualStyleBackColor = true;
            this.detectArduinoAnywhere.Click += new System.EventHandler(this.detectArduinoAnywhere_Click);
            // 
            // COM_PORT_RAIL
            // 
            this.COM_PORT_RAIL.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.COM_PORT_RAIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COM_PORT_RAIL.Font = new System.Drawing.Font("Consolas", 22.25F);
            this.COM_PORT_RAIL.Location = new System.Drawing.Point(315, 52);
            this.COM_PORT_RAIL.Name = "COM_PORT_RAIL";
            this.COM_PORT_RAIL.Size = new System.Drawing.Size(79, 35);
            this.COM_PORT_RAIL.TabIndex = 6;
            this.COM_PORT_RAIL.Text = "99";
            this.COM_PORT_RAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.COM_PORT_RAIL.TextChanged += new System.EventHandler(this.COM_PORT_RAIL_TextChanged);
            // 
            // ARDUINO_TEXT_INIT
            // 
            this.ARDUINO_TEXT_INIT.AutoSize = true;
            this.ARDUINO_TEXT_INIT.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARDUINO_TEXT_INIT.Location = new System.Drawing.Point(3, 50);
            this.ARDUINO_TEXT_INIT.Name = "ARDUINO_TEXT_INIT";
            this.ARDUINO_TEXT_INIT.Size = new System.Drawing.Size(322, 41);
            this.ARDUINO_TEXT_INIT.TabIndex = 5;
            this.ARDUINO_TEXT_INIT.Text = "Arduino VIA COM:";
            // 
            // EEPROM_WRITE_CHANGES
            // 
            this.EEPROM_WRITE_CHANGES.FlatAppearance.BorderSize = 2;
            this.EEPROM_WRITE_CHANGES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EEPROM_WRITE_CHANGES.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EEPROM_WRITE_CHANGES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EEPROM_WRITE_CHANGES.Location = new System.Drawing.Point(106, 147);
            this.EEPROM_WRITE_CHANGES.Name = "EEPROM_WRITE_CHANGES";
            this.EEPROM_WRITE_CHANGES.Size = new System.Drawing.Size(192, 35);
            this.EEPROM_WRITE_CHANGES.TabIndex = 3;
            this.EEPROM_WRITE_CHANGES.Text = "Save Changes";
            this.EEPROM_WRITE_CHANGES.UseVisualStyleBackColor = true;
            this.EEPROM_WRITE_CHANGES.Click += new System.EventHandler(this.EEPROM_WRITE_CHANGES_Click);
            // 
            // COM_PORT_DESC_TXT
            // 
            this.COM_PORT_DESC_TXT.AutoSize = true;
            this.COM_PORT_DESC_TXT.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_PORT_DESC_TXT.Location = new System.Drawing.Point(3, 0);
            this.COM_PORT_DESC_TXT.Name = "COM_PORT_DESC_TXT";
            this.COM_PORT_DESC_TXT.Size = new System.Drawing.Size(379, 41);
            this.COM_PORT_DESC_TXT.TabIndex = 2;
            this.COM_PORT_DESC_TXT.Text = "COM Port Selection:";
            // 
            // PPV_ARDUINO_IN
            // 
            this.PPV_ARDUINO_IN.PortName = "COM3";
            this.PPV_ARDUINO_IN.ReadBufferSize = 8096;
            // 
            // PPV_ARDUINO_DATA_IN
            // 
            this.PPV_ARDUINO_DATA_IN.WorkerReportsProgress = true;
            this.PPV_ARDUINO_DATA_IN.WorkerSupportsCancellation = true;
            this.PPV_ARDUINO_DATA_IN.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PPV_ARDUINO_DATA_IN_RunWorkerCompleted);
            // 
            // PPV_INFO_PANE
            // 
            this.PPV_INFO_PANE.Image = global::Ardumeter_View.Properties.Resources.information;
            this.PPV_INFO_PANE.Location = new System.Drawing.Point(278, 278);
            this.PPV_INFO_PANE.Name = "PPV_INFO_PANE";
            this.PPV_INFO_PANE.Size = new System.Drawing.Size(43, 50);
            this.PPV_INFO_PANE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PPV_INFO_PANE.TabIndex = 8;
            this.PPV_INFO_PANE.TabStop = false;
            this.PPV_INFO_PANE.Click += new System.EventHandler(this.PPV_INFO_PANE_Click);
            // 
            // IO_SETTINGS_TOGGLE_RAIL
            // 
            this.IO_SETTINGS_TOGGLE_RAIL.Image = global::Ardumeter_View.Properties.Resources.gear;
            this.IO_SETTINGS_TOGGLE_RAIL.Location = new System.Drawing.Point(330, 278);
            this.IO_SETTINGS_TOGGLE_RAIL.Name = "IO_SETTINGS_TOGGLE_RAIL";
            this.IO_SETTINGS_TOGGLE_RAIL.Size = new System.Drawing.Size(41, 50);
            this.IO_SETTINGS_TOGGLE_RAIL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IO_SETTINGS_TOGGLE_RAIL.TabIndex = 6;
            this.IO_SETTINGS_TOGGLE_RAIL.TabStop = false;
            this.IO_SETTINGS_TOGGLE_RAIL.Click += new System.EventHandler(this.IO_SETTINGS_TOGGLE_RAIL_Click);
            // 
            // MeterShutDownRail
            // 
            this.MeterShutDownRail.Image = global::Ardumeter_View.Properties.Resources.power;
            this.MeterShutDownRail.Location = new System.Drawing.Point(380, 278);
            this.MeterShutDownRail.Name = "MeterShutDownRail";
            this.MeterShutDownRail.Size = new System.Drawing.Size(41, 50);
            this.MeterShutDownRail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MeterShutDownRail.TabIndex = 5;
            this.MeterShutDownRail.TabStop = false;
            this.MeterShutDownRail.Click += new System.EventHandler(this.MeterShutDownRail_Click);
            // 
            // info_pan
            // 
            this.info_pan.BackColor = System.Drawing.Color.OliveDrab;
            this.info_pan.Controls.Add(this.infoBox);
            this.info_pan.Location = new System.Drawing.Point(10, 49);
            this.info_pan.Name = "info_pan";
            this.info_pan.Size = new System.Drawing.Size(406, 195);
            this.info_pan.TabIndex = 5;
            this.info_pan.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.OliveDrab;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.White;
            this.infoBox.Location = new System.Drawing.Point(10, 5);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(393, 185);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = resources.GetString("infoBox.Text");
            // 
            // drag_me
            // 
            this.drag_me.AutoSize = true;
            this.drag_me.Font = new System.Drawing.Font("Consolas", 13.75F);
            this.drag_me.ForeColor = System.Drawing.Color.Gray;
            this.drag_me.Location = new System.Drawing.Point(180, 5);
            this.drag_me.Name = "drag_me";
            this.drag_me.Size = new System.Drawing.Size(80, 22);
            this.drag_me.TabIndex = 9;
            this.drag_me.Text = ". . . .";
            this.drag_me.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_me_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(428, 334);
            this.Controls.Add(this.drag_me);
            this.Controls.Add(this.PPV_INFO_PANE);
            this.Controls.Add(this.BUILDER_RAIL_ID);
            this.Controls.Add(this.IO_SETTINGS_TOGGLE_RAIL);
            this.Controls.Add(this.MeterShutDownRail);
            this.Controls.Add(this.MODEL_NO);
            this.Controls.Add(this.PRODUCT_ID);
            this.Controls.Add(this.PPV_LCD_Backlight);
            this.Controls.Add(this.PPV_LCD2_INNER);
            this.Controls.Add(this.info_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArduMeter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.PPV_LCD_Backlight.ResumeLayout(false);
            this.PPV_LCD_Backlight.PerformLayout();
            this.PPV_LCD2_INNER.ResumeLayout(false);
            this.PPV_LCD2_INNER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPV_INFO_PANE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IO_SETTINGS_TOGGLE_RAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeterShutDownRail)).EndInit();
            this.info_pan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PPV_LCD_DATA_IN;
        private System.Windows.Forms.Panel PPV_LCD_Backlight;
        private System.Windows.Forms.Label PPV_LCD_VICON;
        private System.Windows.Forms.Label lastResultRail;
        private System.Windows.Forms.Label PPVLM_Rail1;
        private System.Windows.Forms.Label PRODUCT_ID;
        private System.Windows.Forms.Label MODEL_NO;
        private System.Windows.Forms.PictureBox MeterShutDownRail;
        private System.Windows.Forms.PictureBox IO_SETTINGS_TOGGLE_RAIL;
        private System.Windows.Forms.Panel PPV_LCD2_INNER;
        private System.Windows.Forms.TextBox COM_PORT_RAIL;
        private System.Windows.Forms.Label ARDUINO_TEXT_INIT;
        private System.Windows.Forms.Button EEPROM_WRITE_CHANGES;
        private System.Windows.Forms.Label COM_PORT_DESC_TXT;
        private System.Windows.Forms.Label BUILDER_RAIL_ID;
        private System.IO.Ports.SerialPort PPV_ARDUINO_IN;
        private System.ComponentModel.BackgroundWorker PPV_ARDUINO_DATA_IN;
        private System.Windows.Forms.Button detectArduinoAnywhere;
        private System.Windows.Forms.PictureBox PPV_INFO_PANE;
        private System.Windows.Forms.Panel info_pan;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label drag_me;
    }
}

