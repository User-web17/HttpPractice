namespace Client
{
    partial class Form1
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
            txtUrl = new TextBox();
            label1 = new Label();
            btnSendRequest = new Button();
            panel = new Panel();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(553, 156);
            txtUrl.Multiline = true;
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(217, 30);
            txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 122);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter URL:";
            // 
            // btnSendRequest
            // 
            btnSendRequest.Location = new Point(617, 206);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(94, 29);
            btnSendRequest.TabIndex = 3;
            btnSendRequest.Text = "Send";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // panel
            // 
            panel.Location = new Point(60, 23);
            panel.Name = "panel";
            panel.Size = new Size(466, 369);
            panel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(btnSendRequest);
            Controls.Add(label1);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Label label1;
        private Button btnSendRequest;
        private Panel panel;
    }
}
