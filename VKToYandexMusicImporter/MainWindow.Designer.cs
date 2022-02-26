
namespace VKToYandexMusicImporter
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
            this.launchBrowserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchBrowserButton
            // 
            this.launchBrowserButton.Location = new System.Drawing.Point(229, 260);
            this.launchBrowserButton.Name = "launchBrowserButton";
            this.launchBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.launchBrowserButton.TabIndex = 0;
            this.launchBrowserButton.Text = "button1";
            this.launchBrowserButton.UseVisualStyleBackColor = true;
            this.launchBrowserButton.Click += new System.EventHandler(this.launchBrowserButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 338);
            this.Controls.Add(this.launchBrowserButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchBrowserButton;
    }
}

