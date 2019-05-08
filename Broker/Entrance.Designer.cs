namespace Broker
{
    partial class Entrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.indiPersonButton = new System.Windows.Forms.Button();
            this.legalEntButton = new System.Windows.Forms.Button();
            this.corpClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // indiPersonButton
            // 
            this.indiPersonButton.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.indiPersonButton, "indiPersonButton");
            this.indiPersonButton.Name = "indiPersonButton";
            this.indiPersonButton.UseVisualStyleBackColor = false;
            this.indiPersonButton.Click += new System.EventHandler(this.indiPersonButton_Click);
            // 
            // legalEntButton
            // 
            this.legalEntButton.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.legalEntButton, "legalEntButton");
            this.legalEntButton.Name = "legalEntButton";
            this.legalEntButton.UseVisualStyleBackColor = false;
            this.legalEntButton.Click += new System.EventHandler(this.legalEntButton_Click);
            // 
            // corpClientButton
            // 
            this.corpClientButton.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.corpClientButton, "corpClientButton");
            this.corpClientButton.Name = "corpClientButton";
            this.corpClientButton.UseVisualStyleBackColor = false;
            this.corpClientButton.Click += new System.EventHandler(this.corpClientButton_Click);
            // 
            // Entrance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.corpClientButton);
            this.Controls.Add(this.legalEntButton);
            this.Controls.Add(this.indiPersonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Entrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entrance_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button indiPersonButton;
        private System.Windows.Forms.Button legalEntButton;
        private System.Windows.Forms.Button corpClientButton;
    }
}

