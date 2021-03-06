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
            this.labId = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labLastName = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.labTechnology = new System.Windows.Forms.Label();
            this.tbPhysics = new System.Windows.Forms.TextBox();
            this.labPhysics = new System.Windows.Forms.Label();
            this.tbPolishLang = new System.Windows.Forms.TextBox();
            this.labPolishLang = new System.Windows.Forms.Label();
            this.tbForeignLang = new System.Windows.Forms.TextBox();
            this.labForeignLang = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labComments = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.chbAdditionalClasses = new System.Windows.Forms.CheckBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lbGroupId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(89, 8);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(225, 20);
            this.tbId.TabIndex = 0;
            // 
            // labId
            // 
            this.labId.Location = new System.Drawing.Point(12, 8);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(71, 20);
            this.labId.TabIndex = 1;
            this.labId.Text = "Id";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(89, 34);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(225, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // labFirstName
            // 
            this.labFirstName.Location = new System.Drawing.Point(12, 34);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(71, 20);
            this.labFirstName.TabIndex = 1;
            this.labFirstName.Text = "Imię:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(89, 60);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(225, 20);
            this.tbLastName.TabIndex = 0;
            // 
            // labLastName
            // 
            this.labLastName.Location = new System.Drawing.Point(12, 60);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(71, 20);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Nazwisko:";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(89, 86);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(225, 20);
            this.tbMath.TabIndex = 0;
            // 
            // labMath
            // 
            this.labMath.Location = new System.Drawing.Point(12, 86);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(71, 20);
            this.labMath.TabIndex = 1;
            this.labMath.Text = "Matematyka:";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(89, 112);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(225, 20);
            this.tbTechnology.TabIndex = 0;
            // 
            // labTechnology
            // 
            this.labTechnology.Location = new System.Drawing.Point(12, 112);
            this.labTechnology.Name = "labTechnology";
            this.labTechnology.Size = new System.Drawing.Size(71, 20);
            this.labTechnology.TabIndex = 1;
            this.labTechnology.Text = "Technologia:";
            // 
            // tbPhysics
            // 
            this.tbPhysics.Location = new System.Drawing.Point(89, 138);
            this.tbPhysics.Name = "tbPhysics";
            this.tbPhysics.Size = new System.Drawing.Size(225, 20);
            this.tbPhysics.TabIndex = 0;
            // 
            // labPhysics
            // 
            this.labPhysics.Location = new System.Drawing.Point(12, 138);
            this.labPhysics.Name = "labPhysics";
            this.labPhysics.Size = new System.Drawing.Size(71, 20);
            this.labPhysics.TabIndex = 1;
            this.labPhysics.Text = "Fizyka:";
            // 
            // tbPolishLang
            // 
            this.tbPolishLang.Location = new System.Drawing.Point(89, 164);
            this.tbPolishLang.Name = "tbPolishLang";
            this.tbPolishLang.Size = new System.Drawing.Size(225, 20);
            this.tbPolishLang.TabIndex = 0;
            // 
            // labPolishLang
            // 
            this.labPolishLang.Location = new System.Drawing.Point(12, 164);
            this.labPolishLang.Name = "labPolishLang";
            this.labPolishLang.Size = new System.Drawing.Size(71, 20);
            this.labPolishLang.TabIndex = 1;
            this.labPolishLang.Text = "Jęz. pol.";
            // 
            // tbForeignLang
            // 
            this.tbForeignLang.Location = new System.Drawing.Point(89, 190);
            this.tbForeignLang.Name = "tbForeignLang";
            this.tbForeignLang.Size = new System.Drawing.Size(225, 20);
            this.tbForeignLang.TabIndex = 0;
            // 
            // labForeignLang
            // 
            this.labForeignLang.Location = new System.Drawing.Point(12, 190);
            this.labForeignLang.Name = "labForeignLang";
            this.labForeignLang.Size = new System.Drawing.Size(71, 20);
            this.labForeignLang.TabIndex = 1;
            this.labForeignLang.Text = "Jęz. obc.:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(89, 265);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(224, 128);
            this.rtbComments.TabIndex = 2;
            this.rtbComments.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labComments
            // 
            this.labComments.Location = new System.Drawing.Point(11, 268);
            this.labComments.Name = "labComments";
            this.labComments.Size = new System.Drawing.Size(71, 20);
            this.labComments.TabIndex = 3;
            this.labComments.Text = "Uwagi: ";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(89, 417);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(98, 28);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Zatwierdź";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // chbAdditionalClasses
            // 
            this.chbAdditionalClasses.AutoSize = true;
            this.chbAdditionalClasses.Location = new System.Drawing.Point(90, 242);
            this.chbAdditionalClasses.Name = "chbAdditionalClasses";
            this.chbAdditionalClasses.Size = new System.Drawing.Size(119, 17);
            this.chbAdditionalClasses.TabIndex = 6;
            this.chbAdditionalClasses.Text = "Zajęcia Dodatkowe";
            this.chbAdditionalClasses.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(90, 215);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(224, 21);
            this.cmbGroup.TabIndex = 7;
            // 
            // lbGroupId
            // 
            this.lbGroupId.Location = new System.Drawing.Point(13, 216);
            this.lbGroupId.Name = "lbGroupId";
            this.lbGroupId.Size = new System.Drawing.Size(71, 20);
            this.lbGroupId.TabIndex = 8;
            this.lbGroupId.Text = "Grupa";
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 451);
            this.Controls.Add(this.lbGroupId);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.chbAdditionalClasses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.labComments);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.labForeignLang);
            this.Controls.Add(this.labPolishLang);
            this.Controls.Add(this.labPhysics);
            this.Controls.Add(this.labTechnology);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.labFirstName);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.tbForeignLang);
            this.Controls.Add(this.tbPolishLang);
            this.Controls.Add(this.tbPhysics);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.MaximumSize = new System.Drawing.Size(341, 490);
            this.MinimumSize = new System.Drawing.Size(341, 490);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie Ucznia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Button btnAccept;

        private System.Windows.Forms.Label labComments;

        private System.Windows.Forms.Label labForeignLang;

        private System.Windows.Forms.Label labPolishLang;

        private System.Windows.Forms.Label labPhysics;

        private System.Windows.Forms.Label labTechnology;

        private System.Windows.Forms.Label labMath;

        private System.Windows.Forms.Label labLastName;

        private System.Windows.Forms.Label labFirstName;

        private System.Windows.Forms.RichTextBox rtbComments;

        private System.Windows.Forms.TextBox tbForeignLang;

        private System.Windows.Forms.TextBox tbPolishLang;

        private System.Windows.Forms.TextBox tbPhysics;

        private System.Windows.Forms.TextBox tbTechnology;

        private System.Windows.Forms.TextBox tbLastName;

        private System.Windows.Forms.TextBox tbFirstName;

        private System.Windows.Forms.TextBox tbMath;

        private System.Windows.Forms.Label labId;

        private System.Windows.Forms.TextBox tbId;

        #endregion

        private System.Windows.Forms.CheckBox chbAdditionalClasses;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lbGroupId;
    }
}