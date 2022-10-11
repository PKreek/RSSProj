﻿namespace PodcastPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUpdateFreq = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxUpdateFreq = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnNewPod = new System.Windows.Forms.Button();
            this.btnSavePod = new System.Windows.Forms.Button();
            this.btnDeletePod = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.Location = new System.Drawing.Point(1073, 56);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(143, 29);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Kategorier:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.Location = new System.Drawing.Point(27, 308);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(70, 29);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            // 
            // lblUpdateFreq
            // 
            this.lblUpdateFreq.AutoSize = true;
            this.lblUpdateFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateFreq.Location = new System.Drawing.Point(471, 308);
            this.lblUpdateFreq.Name = "lblUpdateFreq";
            this.lblUpdateFreq.Size = new System.Drawing.Size(275, 29);
            this.lblUpdateFreq.TabIndex = 2;
            this.lblUpdateFreq.Text = "Uppdateringsfrekvens:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(770, 308);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(119, 29);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori:";
            // 
            // cbxUpdateFreq
            // 
            this.cbxUpdateFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxUpdateFreq.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxUpdateFreq.FormattingEnabled = true;
            this.cbxUpdateFreq.Location = new System.Drawing.Point(471, 352);
            this.cbxUpdateFreq.Name = "cbxUpdateFreq";
            this.cbxUpdateFreq.Size = new System.Drawing.Size(275, 45);
            this.cbxUpdateFreq.TabIndex = 4;
            this.cbxUpdateFreq.Text = "Var 10:e minut";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCategory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(770, 351);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 45);
            this.cbxCategory.TabIndex = 5;
            this.cbxCategory.Text = "Historia";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUrl.Location = new System.Drawing.Point(27, 352);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(420, 44);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "http://";
            // 
            // btnNewPod
            // 
            this.btnNewPod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewPod.Location = new System.Drawing.Point(454, 431);
            this.btnNewPod.Name = "btnNewPod";
            this.btnNewPod.Size = new System.Drawing.Size(180, 54);
            this.btnNewPod.TabIndex = 7;
            this.btnNewPod.Text = "Ny...";
            this.btnNewPod.UseVisualStyleBackColor = true;
            // 
            // btnSavePod
            // 
            this.btnSavePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePod.Location = new System.Drawing.Point(652, 431);
            this.btnSavePod.Name = "btnSavePod";
            this.btnSavePod.Size = new System.Drawing.Size(164, 54);
            this.btnSavePod.TabIndex = 8;
            this.btnSavePod.Text = "Spara";
            this.btnSavePod.UseVisualStyleBackColor = true;
            // 
            // btnDeletePod
            // 
            this.btnDeletePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePod.Location = new System.Drawing.Point(837, 431);
            this.btnDeletePod.Name = "btnDeletePod";
            this.btnDeletePod.Size = new System.Drawing.Size(175, 54);
            this.btnDeletePod.TabIndex = 9;
            this.btnDeletePod.Text = "Ta bort...";
            this.btnDeletePod.UseVisualStyleBackColor = true;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewCategory.Location = new System.Drawing.Point(1073, 351);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(150, 56);
            this.btnNewCategory.TabIndex = 10;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCategory.Location = new System.Drawing.Point(1242, 352);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(150, 56);
            this.btnSaveCategory.TabIndex = 11;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCategory.Location = new System.Drawing.Point(1407, 352);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(150, 56);
            this.btnDeleteCategory.TabIndex = 12;
            this.btnDeleteCategory.Text = "Ta bort...";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 870);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.btnDeletePod);
            this.Controls.Add(this.btnSavePod);
            this.Controls.Add(this.btnNewPod);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.cbxUpdateFreq);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdateFreq);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCategories;
        private Label lblUrl;
        private Label lblUpdateFreq;
        private Label lblCategory;
        private ComboBox cbxUpdateFreq;
        private ComboBox cbxCategory;
        private TextBox txtUrl;
        private Button btnNewPod;
        private Button btnSavePod;
        private Button btnDeletePod;
        private Button btnNewCategory;
        private Button btnSaveCategory;
        private Button btnDeleteCategory;
    }
}