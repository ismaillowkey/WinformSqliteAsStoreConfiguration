
namespace WinformSqliteAsStoreConf
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
            this.BtnWriteKey = new System.Windows.Forms.Button();
            this.TxtWriteKey = new System.Windows.Forms.TextBox();
            this.TxtWriteValue = new System.Windows.Forms.TextBox();
            this.TxtWriteSection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReadKey = new System.Windows.Forms.TextBox();
            this.TxtReadValue = new System.Windows.Forms.TextBox();
            this.TxtReadSection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnWriteKey
            // 
            this.BtnWriteKey.Location = new System.Drawing.Point(71, 101);
            this.BtnWriteKey.Name = "BtnWriteKey";
            this.BtnWriteKey.Size = new System.Drawing.Size(100, 23);
            this.BtnWriteKey.TabIndex = 0;
            this.BtnWriteKey.Text = "Write";
            this.BtnWriteKey.UseVisualStyleBackColor = true;
            this.BtnWriteKey.Click += new System.EventHandler(this.BtnWriteKey_Click);
            // 
            // TxtWriteKey
            // 
            this.TxtWriteKey.Location = new System.Drawing.Point(71, 49);
            this.TxtWriteKey.Name = "TxtWriteKey";
            this.TxtWriteKey.Size = new System.Drawing.Size(100, 20);
            this.TxtWriteKey.TabIndex = 1;
            this.TxtWriteKey.Text = "ip";
            // 
            // TxtWriteValue
            // 
            this.TxtWriteValue.Location = new System.Drawing.Point(71, 75);
            this.TxtWriteValue.Name = "TxtWriteValue";
            this.TxtWriteValue.Size = new System.Drawing.Size(100, 20);
            this.TxtWriteValue.TabIndex = 2;
            this.TxtWriteValue.Text = "127.0.0.1";
            // 
            // TxtWriteSection
            // 
            this.TxtWriteSection.Location = new System.Drawing.Point(71, 23);
            this.TxtWriteSection.Name = "TxtWriteSection";
            this.TxtWriteSection.Size = new System.Drawing.Size(100, 20);
            this.TxtWriteSection.TabIndex = 3;
            this.TxtWriteSection.Text = "mysql";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnWriteKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtWriteKey);
            this.groupBox1.Controls.Add(this.TxtWriteValue);
            this.groupBox1.Controls.Add(this.TxtWriteSection);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnRead);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtReadKey);
            this.groupBox3.Controls.Add(this.TxtReadValue);
            this.groupBox3.Controls.Add(this.TxtReadSection);
            this.groupBox3.Location = new System.Drawing.Point(216, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 147);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Value";
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(71, 101);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(100, 23);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Key";
            // 
            // TxtReadKey
            // 
            this.TxtReadKey.Location = new System.Drawing.Point(71, 49);
            this.TxtReadKey.Name = "TxtReadKey";
            this.TxtReadKey.Size = new System.Drawing.Size(100, 20);
            this.TxtReadKey.TabIndex = 1;
            this.TxtReadKey.Text = "ip";
            // 
            // TxtReadValue
            // 
            this.TxtReadValue.Location = new System.Drawing.Point(71, 75);
            this.TxtReadValue.Name = "TxtReadValue";
            this.TxtReadValue.ReadOnly = true;
            this.TxtReadValue.Size = new System.Drawing.Size(100, 20);
            this.TxtReadValue.TabIndex = 2;
            // 
            // TxtReadSection
            // 
            this.TxtReadSection.Location = new System.Drawing.Point(71, 23);
            this.TxtReadSection.Name = "TxtReadSection";
            this.TxtReadSection.Size = new System.Drawing.Size(100, 20);
            this.TxtReadSection.TabIndex = 3;
            this.TxtReadSection.Text = "mysql";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File configuration : dbsettings.db";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWriteKey;
        private System.Windows.Forms.TextBox TxtWriteKey;
        private System.Windows.Forms.TextBox TxtWriteValue;
        private System.Windows.Forms.TextBox TxtWriteSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReadKey;
        private System.Windows.Forms.TextBox TxtReadValue;
        private System.Windows.Forms.TextBox TxtReadSection;
        private System.Windows.Forms.Label label4;
    }
}

