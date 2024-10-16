namespace SR_1000_ver._1
{
    partial class DataForm
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
            this.buttonAllDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.radioButtonXML = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.listBoxDMC = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAllDelete
            // 
            this.buttonAllDelete.Location = new System.Drawing.Point(70, 13);
            this.buttonAllDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllDelete.Name = "buttonAllDelete";
            this.buttonAllDelete.Size = new System.Drawing.Size(64, 47);
            this.buttonAllDelete.TabIndex = 0;
            this.buttonAllDelete.Text = "Delete\r\nall data";
            this.buttonAllDelete.UseVisualStyleBackColor = true;
            this.buttonAllDelete.Click += new System.EventHandler(this.buttonAllDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(266, 13);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 47);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxData.Location = new System.Drawing.Point(5, 68);
            this.richTextBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(323, 214);
            this.richTextBoxData.TabIndex = 2;
            this.richTextBoxData.Text = "";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(141, 13);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(57, 47);
            this.buttonSaveData.TabIndex = 3;
            this.buttonSaveData.Text = "Save\r\ndata";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(204, 13);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(57, 47);
            this.buttonLoadData.TabIndex = 4;
            this.buttonLoadData.Text = "Load\r\ndata";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // radioButtonXML
            // 
            this.radioButtonXML.AutoSize = true;
            this.radioButtonXML.Location = new System.Drawing.Point(5, 13);
            this.radioButtonXML.Name = "radioButtonXML";
            this.radioButtonXML.Size = new System.Drawing.Size(54, 21);
            this.radioButtonXML.TabIndex = 5;
            this.radioButtonXML.Text = "XML";
            this.radioButtonXML.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Checked = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(5, 40);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(53, 21);
            this.radioButtonTXT.TabIndex = 6;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // listBoxDMC
            // 
            this.listBoxDMC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDMC.FormattingEnabled = true;
            this.listBoxDMC.ItemHeight = 16;
            this.listBoxDMC.Location = new System.Drawing.Point(5, 302);
            this.listBoxDMC.Name = "listBoxDMC";
            this.listBoxDMC.Size = new System.Drawing.Size(324, 180);
            this.listBoxDMC.TabIndex = 7;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 490);
            this.Controls.Add(this.listBoxDMC);
            this.Controls.Add(this.radioButtonTXT);
            this.Controls.Add(this.radioButtonXML);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.richTextBoxData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAllDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAllDelete;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonLoadData;
        public System.Windows.Forms.RadioButton radioButtonXML;
        public System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.ListBox listBoxDMC;
    }
}