namespace ProjectUARTControl
{
    partial class TemperatureScreen
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.txtReadValues = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(110, 10);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(105, 13);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "История температур:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(424, 170);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(424, 199);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(126, 21);
            this.comboPorts.TabIndex = 7;
            // 
            // txtReadValues
            // 
            this.txtReadValues.Location = new System.Drawing.Point(12, 25);
            this.txtReadValues.Name = "txtReadValues";
            this.txtReadValues.Size = new System.Drawing.Size(390, 200);
            this.txtReadValues.TabIndex = 8;
            this.txtReadValues.Text = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(424, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистить историю";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TemperatureScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 303);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtReadValues);
            this.Controls.Add(this.comboPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblHistory);
            this.Name = "TemperatureScreen";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.RichTextBox txtReadValues;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSystem;
    }
}

