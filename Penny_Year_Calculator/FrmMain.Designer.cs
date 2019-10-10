namespace Penny_Year_Calculator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnAddPenny = new System.Windows.Forms.Button();
            this.btnRemovePenny = new System.Windows.Forms.Button();
            this.lboxPennies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddPennyAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPennyModify = new System.Windows.Forms.Button();
            this.txtModifyYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.txtNumberTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveNClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPenny
            // 
            this.btnAddPenny.Location = new System.Drawing.Point(19, 209);
            this.btnAddPenny.Name = "btnAddPenny";
            this.btnAddPenny.Size = new System.Drawing.Size(161, 40);
            this.btnAddPenny.TabIndex = 0;
            this.btnAddPenny.Text = "Add Penny";
            this.btnAddPenny.UseVisualStyleBackColor = true;
            this.btnAddPenny.Click += new System.EventHandler(this.btnAddPenny_Click);
            // 
            // btnRemovePenny
            // 
            this.btnRemovePenny.Location = new System.Drawing.Point(393, 249);
            this.btnRemovePenny.Name = "btnRemovePenny";
            this.btnRemovePenny.Size = new System.Drawing.Size(161, 40);
            this.btnRemovePenny.TabIndex = 1;
            this.btnRemovePenny.Text = "Remove Penny";
            this.btnRemovePenny.UseVisualStyleBackColor = true;
            this.btnRemovePenny.Click += new System.EventHandler(this.btnRemovePenny_Click);
            // 
            // lboxPennies
            // 
            this.lboxPennies.FormattingEnabled = true;
            this.lboxPennies.ItemHeight = 16;
            this.lboxPennies.Location = new System.Drawing.Point(212, 31);
            this.lboxPennies.Name = "lboxPennies";
            this.lboxPennies.Size = new System.Drawing.Size(145, 420);
            this.lboxPennies.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = ">>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = ">>";
            // 
            // txtAddPennyAmount
            // 
            this.txtAddPennyAmount.Location = new System.Drawing.Point(50, 181);
            this.txtAddPennyAmount.Name = "txtAddPennyAmount";
            this.txtAddPennyAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAddPennyAmount.TabIndex = 6;
            this.txtAddPennyAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdditionKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Value Before Deletion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type Value Before Addition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Value Before Modification";
            // 
            // btnPennyModify
            // 
            this.btnPennyModify.Location = new System.Drawing.Point(393, 129);
            this.btnPennyModify.Name = "btnPennyModify";
            this.btnPennyModify.Size = new System.Drawing.Size(161, 40);
            this.btnPennyModify.TabIndex = 9;
            this.btnPennyModify.Text = "Modify Penny";
            this.btnPennyModify.UseVisualStyleBackColor = true;
            this.btnPennyModify.Click += new System.EventHandler(this.btnPennyModify_Click);
            // 
            // txtModifyYear
            // 
            this.txtModifyYear.Location = new System.Drawing.Point(424, 101);
            this.txtModifyYear.Name = "txtModifyYear";
            this.txtModifyYear.Size = new System.Drawing.Size(100, 22);
            this.txtModifyYear.TabIndex = 12;
            this.txtModifyYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModifyKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type Value Before Modification";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Average:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "P-hat:";
            // 
            // txtAverage
            // 
            this.txtAverage.Enabled = false;
            this.txtAverage.Location = new System.Drawing.Point(462, 332);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 22);
            this.txtAverage.TabIndex = 16;
            // 
            // txtPhat
            // 
            this.txtPhat.Enabled = false;
            this.txtPhat.Location = new System.Drawing.Point(462, 363);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(100, 22);
            this.txtPhat.TabIndex = 17;
            // 
            // txtNumberTotal
            // 
            this.txtNumberTotal.Enabled = false;
            this.txtNumberTotal.Location = new System.Drawing.Point(462, 391);
            this.txtNumberTotal.Name = "txtNumberTotal";
            this.txtNumberTotal.Size = new System.Drawing.Size(100, 22);
            this.txtNumberTotal.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "N:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "<<";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveNClear
            // 
            this.btnSaveNClear.Location = new System.Drawing.Point(12, 368);
            this.btnSaveNClear.Name = "btnSaveNClear";
            this.btnSaveNClear.Size = new System.Drawing.Size(194, 40);
            this.btnSaveNClear.TabIndex = 23;
            this.btnSaveNClear.Text = "Save and Clear";
            this.btnSaveNClear.UseVisualStyleBackColor = true;
            this.btnSaveNClear.Click += new System.EventHandler(this.btnSaveNClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(25, 342);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(168, 23);
            this.btnBrowseFiles.TabIndex = 24;
            this.btnBrowseFiles.Text = "Browse Files";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 469);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.btnSaveNClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNumberTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhat);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModifyYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPennyModify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddPennyAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxPennies);
            this.Controls.Add(this.btnRemovePenny);
            this.Controls.Add(this.btnAddPenny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Penny Year Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPenny;
        private System.Windows.Forms.Button btnRemovePenny;
        private System.Windows.Forms.ListBox lboxPennies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPennyAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPennyModify;
        private System.Windows.Forms.TextBox txtModifyYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumberTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveNClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseFiles;
    }
}

