using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    partial class MainSettingsPage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnControls = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(316, 77);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(269, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(274, 51);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings Page";
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnControls.FlatAppearance.BorderSize = 0;
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnControls.ForeColor = System.Drawing.Color.White;
            this.btnControls.Location = new System.Drawing.Point(316, 135);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(136, 52);
            this.btnControls.TabIndex = 4;
            this.btnControls.Text = "Controls";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(220, 229);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(160, 28);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume (On/Off):";
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolume.ForeColor = System.Drawing.Color.White;
            this.btnVolume.Location = new System.Drawing.Point(386, 223);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(115, 41);
            this.btnVolume.TabIndex = 7;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // MainSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Color.Black;
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnClose);
            this.Name = "MainSettingsPage";
            this.Text = "MainSettingsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnVolume;
    }
}