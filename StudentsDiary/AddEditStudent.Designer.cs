using System.ComponentModel;

namespace StudentsDiary
{
    partial class AddEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhysics = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPolishLang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbForeignLang = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(120, 19);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(228, 20);
            this.tbId.TabIndex = 0;
            this.tbId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(120, 45);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(228, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(120, 71);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(228, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Matematyka:";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(120, 97);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(228, 20);
            this.tbMath.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Technologia:";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(120, 123);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(228, 20);
            this.tbTechnology.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fizyka:";
            // 
            // tbPhysics
            // 
            this.tbPhysics.Location = new System.Drawing.Point(120, 149);
            this.tbPhysics.Name = "tbPhysics";
            this.tbPhysics.Size = new System.Drawing.Size(228, 20);
            this.tbPhysics.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Jęz pol.:";
            // 
            // tbPolishLang
            // 
            this.tbPolishLang.Location = new System.Drawing.Point(120, 175);
            this.tbPolishLang.Name = "tbPolishLang";
            this.tbPolishLang.Size = new System.Drawing.Size(228, 20);
            this.tbPolishLang.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Jęz obc.:";
            // 
            // tbForeignLang
            // 
            this.tbForeignLang.Location = new System.Drawing.Point(120, 201);
            this.tbForeignLang.Name = "tbForeignLang";
            this.tbForeignLang.Size = new System.Drawing.Size(228, 20);
            this.tbForeignLang.TabIndex = 14;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(122, 227);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(226, 102);
            this.rtbComments.TabIndex = 16;
            this.rtbComments.Text = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Uwagi:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(265, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 24);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 24);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(370, 385);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbForeignLang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPolishLang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPhysics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AddEditStudent";
            this.Load += new System.EventHandler(this.AddEditStudent_Load);
            this.Click += new System.EventHandler(this.AddEditStudent_Click);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFirstName;

        private System.Windows.Forms.TextBox tbId;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Button btnConfirm;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox dtbId;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}