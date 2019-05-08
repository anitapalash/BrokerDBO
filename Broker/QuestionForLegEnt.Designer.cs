namespace Broker
{
    partial class QuestionForLegEnt
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
            this.heading = new System.Windows.Forms.Label();
            this.feature1 = new System.Windows.Forms.Label();
            this.feature2 = new System.Windows.Forms.Label();
            this.feature3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading.Location = new System.Drawing.Point(181, 27);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(217, 20);
            this.heading.TabIndex = 0;
            this.heading.Text = "Отметьте важные для Вас услуги";
            // 
            // feature1
            // 
            this.feature1.AutoSize = true;
            this.feature1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature1.Location = new System.Drawing.Point(46, 114);
            this.feature1.Name = "feature1";
            this.feature1.Size = new System.Drawing.Size(303, 20);
            this.feature1.TabIndex = 1;
            this.feature1.Text = "Возможность импорта/экспорта документов 1С";
            // 
            // feature2
            // 
            this.feature2.AutoSize = true;
            this.feature2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature2.Location = new System.Drawing.Point(46, 176);
            this.feature2.Name = "feature2";
            this.feature2.Size = new System.Drawing.Size(303, 20);
            this.feature2.TabIndex = 2;
            this.feature2.Text = "Возможность электронного документооборота";
            // 
            // feature3
            // 
            this.feature3.AutoSize = true;
            this.feature3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feature3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feature3.Location = new System.Drawing.Point(46, 239);
            this.feature3.Name = "feature3";
            this.feature3.Size = new System.Drawing.Size(215, 20);
            this.feature3.TabIndex = 3;
            this.feature3.Text = "Доступность корпоративных карт";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(466, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(466, 244);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(258, 314);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Далее";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // QuestionForLegEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.feature3);
            this.Controls.Add(this.feature2);
            this.Controls.Add(this.feature1);
            this.Controls.Add(this.heading);
            this.Name = "QuestionForLegEnt";
            this.Text = "BrokerDBO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label feature1;
        private System.Windows.Forms.Label feature2;
        private System.Windows.Forms.Label feature3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button submitButton;
    }
}