
namespace GTATools
{
    partial class MainWindow
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
            this.antiAfkCheckbox = new System.Windows.Forms.CheckBox();
            this.privateSessionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // antiAfkCheckbox
            // 
            this.antiAfkCheckbox.AutoSize = true;
            this.antiAfkCheckbox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiAfkCheckbox.Location = new System.Drawing.Point(12, 12);
            this.antiAfkCheckbox.Name = "antiAfkCheckbox";
            this.antiAfkCheckbox.Size = new System.Drawing.Size(125, 28);
            this.antiAfkCheckbox.TabIndex = 0;
            this.antiAfkCheckbox.Text = "Anti-AFK";
            this.antiAfkCheckbox.UseVisualStyleBackColor = true;
            this.antiAfkCheckbox.CheckedChanged += new System.EventHandler(this.antiAfkCheckbox_CheckedChanged);
            // 
            // privateSessionBtn
            // 
            this.privateSessionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateSessionBtn.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.privateSessionBtn.Location = new System.Drawing.Point(12, 46);
            this.privateSessionBtn.Name = "privateSessionBtn";
            this.privateSessionBtn.Size = new System.Drawing.Size(330, 35);
            this.privateSessionBtn.TabIndex = 1;
            this.privateSessionBtn.Text = "Make Public-Solo Session";
            this.privateSessionBtn.UseVisualStyleBackColor = true;
            this.privateSessionBtn.Click += new System.EventHandler(this.privateSessionBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 98);
            this.Controls.Add(this.privateSessionBtn);
            this.Controls.Add(this.antiAfkCheckbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GTA Tools by Mahjestic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox antiAfkCheckbox;
        private System.Windows.Forms.Button privateSessionBtn;
    }
}

