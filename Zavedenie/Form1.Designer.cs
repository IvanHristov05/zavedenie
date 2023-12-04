namespace Zavedenie
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radMasa2 = new System.Windows.Forms.RadioButton();
            this.radMasa = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radKesh = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.btnPreg = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "За колко души да е масата?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид заплащане:";
            // 
            // radMasa2
            // 
            this.radMasa2.AutoSize = true;
            this.radMasa2.Location = new System.Drawing.Point(6, 26);
            this.radMasa2.Name = "radMasa2";
            this.radMasa2.Size = new System.Drawing.Size(77, 17);
            this.radMasa2.TabIndex = 3;
            this.radMasa2.TabStop = true;
            this.radMasa2.Text = "За пушачи";
            this.radMasa2.UseVisualStyleBackColor = true;
            // 
            // radMasa
            // 
            this.radMasa.AutoSize = true;
            this.radMasa.Location = new System.Drawing.Point(6, 58);
            this.radMasa.Name = "radMasa";
            this.radMasa.Size = new System.Drawing.Size(92, 17);
            this.radMasa.TabIndex = 4;
            this.radMasa.TabStop = true;
            this.radMasa.Text = "За не пушачи";
            this.radMasa.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radKesh
            // 
            this.radKesh.AutoSize = true;
            this.radKesh.Location = new System.Drawing.Point(535, 61);
            this.radKesh.Name = "radKesh";
            this.radKesh.Size = new System.Drawing.Size(55, 17);
            this.radKesh.TabIndex = 6;
            this.radKesh.TabStop = true;
            this.radKesh.Text = "В кеш";
            this.radKesh.UseVisualStyleBackColor = true;
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(535, 93);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(64, 17);
            this.radCard.TabIndex = 6;
            this.radCard.TabStop = true;
            this.radCard.Text = "С карта";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // btnPreg
            // 
            this.btnPreg.Location = new System.Drawing.Point(36, 273);
            this.btnPreg.Name = "btnPreg";
            this.btnPreg.Size = new System.Drawing.Size(165, 70);
            this.btnPreg.TabIndex = 7;
            this.btnPreg.Text = "Преглед";
            this.btnPreg.UseVisualStyleBackColor = true;
            this.btnPreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(609, 273);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 70);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Нататък";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMasa2);
            this.groupBox1.Controls.Add(this.radMasa);
            this.groupBox1.Location = new System.Drawing.Point(36, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маса за:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreg);
            this.Controls.Add(this.radCard);
            this.Controls.Add(this.radKesh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radMasa2;
        private System.Windows.Forms.RadioButton radMasa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radKesh;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.Button btnPreg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

