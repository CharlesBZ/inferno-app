namespace InfernoUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.ForeColor = Color.DarkRed;
            formHeader.Location = new Point(46, 28);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(131, 47);
            formHeader.TabIndex = 0;
            formHeader.Text = "Inferno";
            formHeader.Click += label1_Click;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.ForeColor = Color.White;
            apiLabel.Location = new Point(59, 88);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(53, 32);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            apiLabel.Click += label2_Click;
            // 
            // apiText
            // 
            apiText.BackColor = Color.FromArgb(26, 24, 21);
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.ForeColor = Color.Lime;
            apiText.Location = new Point(118, 85);
            apiText.Name = "apiText";
            apiText.Size = new Size(434, 39);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.BackColor = SystemColors.MenuHighlight;
            callApi.ForeColor = Color.White;
            callApi.Location = new Point(558, 85);
            callApi.Name = "callApi";
            callApi.Size = new Size(101, 39);
            callApi.TabIndex = 3;
            callApi.Text = "Send";
            callApi.UseVisualStyleBackColor = false;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.FromArgb(26, 24, 21);
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.ForeColor = Color.White;
            resultsText.Location = new Point(59, 211);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(600, 347);
            resultsText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(26, 24, 21);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 565);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(836, 30);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "System Status";
            statusStrip.ItemClicked += statusStrip_ItemClicked;
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.ForeColor = SystemColors.MenuHighlight;
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(62, 25);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.ForeColor = Color.White;
            resultsLabel.Location = new Point(59, 154);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(88, 32);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 24, 21);
            ClientSize = new Size(836, 595);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Inferno by CharloDev";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
