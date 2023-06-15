
namespace PracticalNo1
{
    partial class FrmFriendInfo
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
            this.lblMarkSheet = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblPhysics = new System.Windows.Forms.Label();
            this.lblChemestry = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtPhys = new System.Windows.Forms.TextBox();
            this.txtChem = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarkSheet
            // 
            this.lblMarkSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.lblMarkSheet.AutoSize = true;
            this.lblMarkSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkSheet.Location = new System.Drawing.Point(294, 27);
            this.lblMarkSheet.Name = "lblMarkSheet";
            this.lblMarkSheet.Size = new System.Drawing.Size(229, 29);
            this.lblMarkSheet.TabIndex = 0;
            this.lblMarkSheet.Text = "Student MarkSheet";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(149, 90);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(58, 17);
            this.lblRollNo.TabIndex = 1;
            this.lblRollNo.Text = "Roll No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(149, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(116, 201);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(95, 17);
            this.lblMaths.TabIndex = 3;
            this.lblMaths.Text = "Mathematics :";
            // 
            // lblPhysics
            // 
            this.lblPhysics.AutoSize = true;
            this.lblPhysics.Location = new System.Drawing.Point(366, 204);
            this.lblPhysics.Name = "lblPhysics";
            this.lblPhysics.Size = new System.Drawing.Size(60, 17);
            this.lblPhysics.TabIndex = 4;
            this.lblPhysics.Text = "Physics:";
            // 
            // lblChemestry
            // 
            this.lblChemestry.AutoSize = true;
            this.lblChemestry.Location = new System.Drawing.Point(574, 204);
            this.lblChemestry.Name = "lblChemestry";
            this.lblChemestry.Size = new System.Drawing.Size(75, 17);
            this.lblChemestry.TabIndex = 5;
            this.lblChemestry.Text = "Chemestry";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(255, 268);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 6;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(255, 316);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 17);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(299, 90);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtRollNo.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(299, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(236, 204);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 22);
            this.txtMaths.TabIndex = 10;
            // 
            // txtPhys
            // 
            this.txtPhys.Location = new System.Drawing.Point(444, 198);
            this.txtPhys.Name = "txtPhys";
            this.txtPhys.Size = new System.Drawing.Size(100, 22);
            this.txtPhys.TabIndex = 11;
            // 
            // txtChem
            // 
            this.txtChem.Location = new System.Drawing.Point(656, 204);
            this.txtChem.Name = "txtChem";
            this.txtChem.Size = new System.Drawing.Size(100, 22);
            this.txtChem.TabIndex = 12;
            this.txtChem.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(186, 378);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(106, 23);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(378, 378);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(541, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmFriendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.txtChem);
            this.Controls.Add(this.txtPhys);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblChemestry);
            this.Controls.Add(this.lblPhysics);
            this.Controls.Add(this.lblMaths);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblMarkSheet);
            this.Name = "FrmFriendInfo";
            this.Text = "FrmFriendInfo";
            this.Load += new System.EventHandler(this.FrmFriendInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkSheet;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblPhysics;
        private System.Windows.Forms.Label lblChemestry;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtPhys;
        private System.Windows.Forms.TextBox txtChem;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
    }
}