namespace SR_1000_ver._1
{
    // verze 10
    partial class Keyence_SR_1000
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.liveviewForm = new Keyence.AutoID.SDK.LiveviewForm();
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.labelDMC = new System.Windows.Forms.Label();
            this.labelDMC1 = new System.Windows.Forms.Label();
            this.labelDMC2 = new System.Windows.Forms.Label();
            this.labelDMC3 = new System.Windows.Forms.Label();
            this.labelDMC4 = new System.Windows.Forms.Label();
            this.labelDMC5 = new System.Windows.Forms.Label();
            this.labelDMC6 = new System.Windows.Forms.Label();
            this.labelDMC7 = new System.Windows.Forms.Label();
            this.labelDMC8 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadAllData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDmcDelete = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liveviewForm1
            // 
            this.liveviewForm.BackColor = System.Drawing.Color.Black;
            this.liveviewForm.BinningType = Keyence.AutoID.SDK.LiveviewForm.ImageBinningType.OneQuarter;
            this.liveviewForm.ImageFormat = Keyence.AutoID.SDK.LiveviewForm.ImageFormatType.Jpeg;
            this.liveviewForm.ImageQuality = 5;
            this.liveviewForm.IpAddress = "192.168.100.100";
            this.liveviewForm.Location = new System.Drawing.Point(20, 100);
            this.liveviewForm.Name = "liveviewForm1";
            this.liveviewForm.PullTimeSpan = 100;
            this.liveviewForm.Size = new System.Drawing.Size(300, 300);
            this.liveviewForm.TabIndex = 0;
            this.liveviewForm.TimeoutMs = 2000;
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.Location = new System.Drawing.Point(16, 15);
            this.buttonTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(128, 62);
            this.buttonTrigger.TabIndex = 0;
            this.buttonTrigger.Text = "Trigger";
            this.buttonTrigger.UseVisualStyleBackColor = true;
            this.buttonTrigger.Click += new System.EventHandler(this.buttonTrigger_Click);
            // 
            // labelDMC
            // 
            this.labelDMC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC.Location = new System.Drawing.Point(193, 47);
            this.labelDMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC.Name = "labelDMC";
            this.labelDMC.Size = new System.Drawing.Size(200, 30);
            this.labelDMC.TabIndex = 1;
            this.labelDMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC1
            // 
            this.labelDMC1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC1.Location = new System.Drawing.Point(524, 72);
            this.labelDMC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC1.Name = "labelDMC1";
            this.labelDMC1.Size = new System.Drawing.Size(200, 30);
            this.labelDMC1.TabIndex = 2;
            this.labelDMC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC2
            // 
            this.labelDMC2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC2.Location = new System.Drawing.Point(524, 118);
            this.labelDMC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC2.Name = "labelDMC2";
            this.labelDMC2.Size = new System.Drawing.Size(200, 30);
            this.labelDMC2.TabIndex = 3;
            this.labelDMC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC3
            // 
            this.labelDMC3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC3.Location = new System.Drawing.Point(524, 165);
            this.labelDMC3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC3.Name = "labelDMC3";
            this.labelDMC3.Size = new System.Drawing.Size(200, 30);
            this.labelDMC3.TabIndex = 4;
            this.labelDMC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC4
            // 
            this.labelDMC4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC4.Location = new System.Drawing.Point(524, 212);
            this.labelDMC4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC4.Name = "labelDMC4";
            this.labelDMC4.Size = new System.Drawing.Size(200, 30);
            this.labelDMC4.TabIndex = 5;
            this.labelDMC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC5
            // 
            this.labelDMC5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC5.Location = new System.Drawing.Point(524, 259);
            this.labelDMC5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC5.Name = "labelDMC5";
            this.labelDMC5.Size = new System.Drawing.Size(200, 30);
            this.labelDMC5.TabIndex = 6;
            this.labelDMC5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC6
            // 
            this.labelDMC6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC6.Location = new System.Drawing.Point(524, 305);
            this.labelDMC6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC6.Name = "labelDMC6";
            this.labelDMC6.Size = new System.Drawing.Size(200, 30);
            this.labelDMC6.TabIndex = 7;
            this.labelDMC6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC7
            // 
            this.labelDMC7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC7.Location = new System.Drawing.Point(524, 352);
            this.labelDMC7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC7.Name = "labelDMC7";
            this.labelDMC7.Size = new System.Drawing.Size(200, 30);
            this.labelDMC7.TabIndex = 8;
            this.labelDMC7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDMC8
            // 
            this.labelDMC8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDMC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDMC8.Location = new System.Drawing.Point(524, 399);
            this.labelDMC8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDMC8.Name = "labelDMC8";
            this.labelDMC8.Size = new System.Drawing.Size(200, 30);
            this.labelDMC8.TabIndex = 9;
            this.labelDMC8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(652, 450);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 49);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReadAllData
            // 
            this.buttonReadAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReadAllData.Location = new System.Drawing.Point(522, 450);
            this.buttonReadAllData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadAllData.Name = "buttonReadAllData";
            this.buttonReadAllData.Size = new System.Drawing.Size(100, 48);
            this.buttonReadAllData.TabIndex = 11;
            this.buttonReadAllData.Text = "Read all data";
            this.buttonReadAllData.UseVisualStyleBackColor = true;
            this.buttonReadAllData.Click += new System.EventHandler(this.buttonReadAllData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "DMC 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "DMC 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "DMC 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "DMC 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "DMC 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "DMC 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "DMC 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "DMC 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Actual read value";
            // 
            // buttonDmcDelete
            // 
            this.buttonDmcDelete.Location = new System.Drawing.Point(569, 15);
            this.buttonDmcDelete.Name = "buttonDmcDelete";
            this.buttonDmcDelete.Size = new System.Drawing.Size(106, 42);
            this.buttonDmcDelete.TabIndex = 23;
            this.buttonDmcDelete.Text = "Delete\r\nDMC data";
            this.buttonDmcDelete.UseVisualStyleBackColor = true;
            this.buttonDmcDelete.Click += new System.EventHandler(this.buttonDmcDelete_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.ForeColor = System.Drawing.Color.Red;
            this.labelConnect.Location = new System.Drawing.Point(429, 15);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(78, 17);
            this.labelConnect.TabIndex = 24;
            this.labelConnect.Text = "Disconnect";
            // 
            // Keyence_SR_1000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 517);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonDmcDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReadAllData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDMC8);
            this.Controls.Add(this.labelDMC);
            this.Controls.Add(this.buttonTrigger);
            this.Controls.Add(this.labelDMC7);
            this.Controls.Add(this.labelDMC6);
            this.Controls.Add(this.labelDMC5);
            this.Controls.Add(this.labelDMC4);
            this.Controls.Add(this.labelDMC3);
            this.Controls.Add(this.labelDMC2);
            this.Controls.Add(this.labelDMC1);
            this.Controls.Add(this.liveviewForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Keyence_SR_1000";
            this.Text = "Keyence SR-1000 read DMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyence.AutoID.SDK.LiveviewForm liveviewForm;
        private System.Windows.Forms.Button buttonTrigger;
        public System.Windows.Forms.Label labelDMC;
        public System.Windows.Forms.Label labelDMC1;
        public System.Windows.Forms.Label labelDMC2;
        public System.Windows.Forms.Label labelDMC3;
        public System.Windows.Forms.Label labelDMC4;
        public System.Windows.Forms.Label labelDMC5;
        public System.Windows.Forms.Label labelDMC6;
        public System.Windows.Forms.Label labelDMC7;
        public System.Windows.Forms.Label labelDMC8;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReadAllData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDmcDelete;
        private System.Windows.Forms.Label labelConnect;
    }
}

