﻿namespace FallingObjectsBenF
{
    partial class frmFallingObjects
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
            this.components = new System.ComponentModel.Container();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtEnterTime = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuFallingObjects = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAns = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mnuFallingObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTime.ForeColor = System.Drawing.Color.Red;
            this.lblEnterTime.Location = new System.Drawing.Point(34, 161);
            this.lblEnterTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(1014, 42);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter the time (in seconds) since you released the object";
            // 
            // txtEnterTime
            // 
            this.txtEnterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTime.Location = new System.Drawing.Point(1108, 168);
            this.txtEnterTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnterTime.Name = "txtEnterTime";
            this.txtEnterTime.Size = new System.Drawing.Size(89, 34);
            this.txtEnterTime.TabIndex = 1;
            this.txtEnterTime.TextChanged += new System.EventHandler(this.txtEnterTime_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnCalculate.Location = new System.Drawing.Point(459, 297);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(499, 69);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "CALCULATE!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mnuFallingObjects
            // 
            this.mnuFallingObjects.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFallingObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFallingObjects.Location = new System.Drawing.Point(0, 0);
            this.mnuFallingObjects.Name = "mnuFallingObjects";
            this.mnuFallingObjects.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuFallingObjects.Size = new System.Drawing.Size(1485, 28);
            this.mnuFallingObjects.TabIndex = 3;
            this.mnuFallingObjects.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(44, 24);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(108, 26);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.Location = new System.Drawing.Point(33, 544);
            this.lblAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(1253, 45);
            this.lblAns.TabIndex = 4;
            this.lblAns.Text = "The object has fallen x amount of meters since you released the object";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 84);
            this.label1.TabIndex = 5;
            this.label1.Text = "You are standing on a platform holding an object.\r\nThe object is exactly 100 mete" +
    "rs above the ground.";
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterTime);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.mnuFallingObjects);
            this.MainMenuStrip = this.mnuFallingObjects;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects Ben F";
            this.mnuFallingObjects.ResumeLayout(false);
            this.mnuFallingObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.TextBox txtEnterTime;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip mnuFallingObjects;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
    }
}

