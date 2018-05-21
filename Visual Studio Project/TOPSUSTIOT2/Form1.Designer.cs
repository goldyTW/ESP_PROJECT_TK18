namespace TOPSUSTIOT2
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
            this.temperature = new AdvancedHMIControls.DigitalPanelMeter();
            this.modbusTCPCom2 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.modbusTCPCom1 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.humidity = new AdvancedHMIControls.DigitalPanelMeter();
            this.basicTrendChart1 = new AdvancedHMIControls.BasicTrendChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basicTrendChart2 = new AdvancedHMIControls.BasicTrendChart();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.White;
            this.temperature.ComComponent = this.modbusTCPCom2;
            this.temperature.DecimalPosition = 0;
            this.temperature.ForeColor = System.Drawing.Color.LightGray;
            this.temperature.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.temperature.KeypadMaxValue = 0D;
            this.temperature.KeypadMinValue = 0D;
            this.temperature.KeypadScaleFactor = 1D;
            this.temperature.KeypadText = null;
            this.temperature.KeypadWidth = 300;
            this.temperature.Location = new System.Drawing.Point(0, 24);
            this.temperature.Name = "temperature";
            this.temperature.NumberOfDigits = 5;
            this.temperature.PLCAddressKeypad = "";
            this.temperature.PLCAddressValue = "30201";
            this.temperature.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.temperature.Size = new System.Drawing.Size(189, 82);
            this.temperature.TabIndex = 1;
            this.temperature.Text = "TEMPERATURE";
            this.temperature.Value = 0D;
            this.temperature.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.temperature.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // modbusTCPCom2
            // 
            this.modbusTCPCom2.DisableSubscriptions = false;
            this.modbusTCPCom2.IniFileName = "";
            this.modbusTCPCom2.IniFileSection = null;
            this.modbusTCPCom2.IPAddress = "192.168.43.109";
            this.modbusTCPCom2.MaxReadGroupSize = 20;
            this.modbusTCPCom2.SwapBytes = true;
            this.modbusTCPCom2.SwapWords = false;
            this.modbusTCPCom2.TcpipPort = ((ushort)(502));
            this.modbusTCPCom2.TimeOut = 3000;
            this.modbusTCPCom2.UnitId = ((byte)(1));
            // 
            // modbusTCPCom1
            // 
            this.modbusTCPCom1.DisableSubscriptions = false;
            this.modbusTCPCom1.IniFileName = "";
            this.modbusTCPCom1.IniFileSection = null;
            this.modbusTCPCom1.IPAddress = "192.168.43.109";
            this.modbusTCPCom1.MaxReadGroupSize = 20;
            this.modbusTCPCom1.SwapBytes = true;
            this.modbusTCPCom1.SwapWords = false;
            this.modbusTCPCom1.TcpipPort = ((ushort)(502));
            this.modbusTCPCom1.TimeOut = 3000;
            this.modbusTCPCom1.UnitId = ((byte)(1));
            // 
            // humidity
            // 
            this.humidity.BackColor = System.Drawing.Color.White;
            this.humidity.ComComponent = this.modbusTCPCom1;
            this.humidity.DecimalPosition = 0;
            this.humidity.ForeColor = System.Drawing.Color.LightGray;
            this.humidity.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.humidity.KeypadMaxValue = 0D;
            this.humidity.KeypadMinValue = 0D;
            this.humidity.KeypadScaleFactor = 1D;
            this.humidity.KeypadText = null;
            this.humidity.KeypadWidth = 300;
            this.humidity.Location = new System.Drawing.Point(0, 112);
            this.humidity.Name = "humidity";
            this.humidity.NumberOfDigits = 5;
            this.humidity.PLCAddressKeypad = "";
            this.humidity.PLCAddressValue = "30101";
            this.humidity.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.humidity.Size = new System.Drawing.Size(189, 82);
            this.humidity.TabIndex = 0;
            this.humidity.Text = "HUMIDITY";
            this.humidity.Value = 0D;
            this.humidity.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.humidity.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // basicTrendChart1
            // 
            this.basicTrendChart1.BackColor = System.Drawing.Color.Gray;
            this.basicTrendChart1.ComComponent = this.modbusTCPCom2;
            this.basicTrendChart1.Location = new System.Drawing.Point(195, 24);
            this.basicTrendChart1.MaxPoints = 40;
            this.basicTrendChart1.Name = "basicTrendChart1";
            this.basicTrendChart1.PLCAddressValue = "30201";
            this.basicTrendChart1.PLCAddressVisible = "";
            this.basicTrendChart1.Size = new System.Drawing.Size(273, 82);
            this.basicTrendChart1.TabIndex = 2;
            this.basicTrendChart1.Text = "basicTrendChart1";
            this.basicTrendChart1.Value = "";
            this.basicTrendChart1.YMaximum = 40;
            this.basicTrendChart1.YMinimum = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "SCADA / HMI Monitoring";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MySQL Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(143, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "QUERY!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.basicTrendChart2);
            this.panel1.Controls.Add(this.temperature);
            this.panel1.Controls.Add(this.humidity);
            this.panel1.Controls.Add(this.basicTrendChart1);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 214);
            this.panel1.TabIndex = 8;
            // 
            // basicTrendChart2
            // 
            this.basicTrendChart2.BackColor = System.Drawing.Color.Gray;
            this.basicTrendChart2.ComComponent = this.modbusTCPCom1;
            this.basicTrendChart2.Location = new System.Drawing.Point(195, 112);
            this.basicTrendChart2.MaxPoints = 100;
            this.basicTrendChart2.Name = "basicTrendChart2";
            this.basicTrendChart2.PLCAddressValue = "30101";
            this.basicTrendChart2.PLCAddressVisible = "";
            this.basicTrendChart2.Size = new System.Drawing.Size(273, 82);
            this.basicTrendChart2.TabIndex = 3;
            this.basicTrendChart2.Text = "basicTrendChart2";
            this.basicTrendChart2.Value = "";
            this.basicTrendChart2.YMaximum = 100;
            this.basicTrendChart2.YMinimum = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedHMIDrivers.ModbusTCPCom modbusTCPCom1;
        private AdvancedHMIDrivers.ModbusTCPCom modbusTCPCom2;
        private AdvancedHMIControls.BasicTrendChart basicTrendChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public AdvancedHMIControls.DigitalPanelMeter temperature;
        public AdvancedHMIControls.DigitalPanelMeter humidity;
        private System.Windows.Forms.Panel panel1;
        private AdvancedHMIControls.BasicTrendChart basicTrendChart2;
    }
}

