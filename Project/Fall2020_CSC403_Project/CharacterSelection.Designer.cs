namespace Fall2020_CSC403_Project.data
{
    partial class CharacterSelection
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
            this.babynut = new System.Windows.Forms.Button();
            this.mrpeanut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // babynut
            // 
            this.babynut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.baby_nut;
            this.babynut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.babynut.Location = new System.Drawing.Point(699, 236);
            this.babynut.Name = "babynut";
            this.babynut.Size = new System.Drawing.Size(400, 400);
            this.babynut.TabIndex = 1;
            this.babynut.Text = "Baby Nut";
            this.babynut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.babynut.UseVisualStyleBackColor = true;
            this.babynut.Click += new System.EventHandler(this.babynut_Click);
            // 
            // mrpeanut
            // 
            this.mrpeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.mrpeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mrpeanut.Location = new System.Drawing.Point(144, 236);
            this.mrpeanut.Name = "mrpeanut";
            this.mrpeanut.Size = new System.Drawing.Size(400, 400);
            this.mrpeanut.TabIndex = 0;
            this.mrpeanut.Text = "Mr. Peanut";
            this.mrpeanut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mrpeanut.UseVisualStyleBackColor = true;
            this.mrpeanut.Click += new System.EventHandler(this.mrpeanut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(515, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 123);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.babynut);
            this.Controls.Add(this.mrpeanut);
            this.Name = "CharacterSelection";
            this.Text = "CharacterSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mrpeanut;
        private System.Windows.Forms.Button babynut;
        private System.Windows.Forms.Button button1;
    }
}