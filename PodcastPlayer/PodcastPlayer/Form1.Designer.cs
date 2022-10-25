namespace PodcastPlayer
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
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnNewPod = new System.Windows.Forms.Button();
            this.btnSavePod = new System.Windows.Forms.Button();
            this.btnDeletePod = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lstPodcasts = new System.Windows.Forms.ListView();
            this.colEpisodes = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colFrequency = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.lstCategory = new System.Windows.Forms.ListView();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstEpisode = new System.Windows.Forms.ListView();
            this.Avsnitt = new System.Windows.Forms.ColumnHeader();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblEnterCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.Location = new System.Drawing.Point(1116, 27);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(143, 29);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Kategorier:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.Location = new System.Drawing.Point(28, 308);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(70, 29);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateName.Location = new System.Drawing.Point(472, 308);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(158, 29);
            this.lblUpdateName.TabIndex = 2;
            this.lblUpdateName.Text = "Ändra namn:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(801, 308);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(119, 29);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCategory.ForeColor = System.Drawing.Color.Black;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(801, 351);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(252, 45);
            this.cbxCategory.TabIndex = 5;
            this.cbxCategory.Text = "Välj kategori:";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrl.ForeColor = System.Drawing.Color.Black;
            this.txtUrl.Location = new System.Drawing.Point(28, 352);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(437, 44);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "http://";
            this.txtUrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUrl_MouseClick);
            // 
            // btnNewPod
            // 
            this.btnNewPod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewPod.Location = new System.Drawing.Point(472, 431);
            this.btnNewPod.Name = "btnNewPod";
            this.btnNewPod.Size = new System.Drawing.Size(187, 54);
            this.btnNewPod.TabIndex = 7;
            this.btnNewPod.Text = "Ny...";
            this.btnNewPod.UseVisualStyleBackColor = true;
            this.btnNewPod.Click += new System.EventHandler(this.btnNewPod_Click);
            // 
            // btnSavePod
            // 
            this.btnSavePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePod.Location = new System.Drawing.Point(678, 431);
            this.btnSavePod.Name = "btnSavePod";
            this.btnSavePod.Size = new System.Drawing.Size(171, 54);
            this.btnSavePod.TabIndex = 8;
            this.btnSavePod.Text = "Spara";
            this.btnSavePod.UseVisualStyleBackColor = true;
            this.btnSavePod.Click += new System.EventHandler(this.btnSavePod_Click);
            // 
            // btnDeletePod
            // 
            this.btnDeletePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePod.Location = new System.Drawing.Point(870, 431);
            this.btnDeletePod.Name = "btnDeletePod";
            this.btnDeletePod.Size = new System.Drawing.Size(182, 54);
            this.btnDeletePod.TabIndex = 9;
            this.btnDeletePod.Text = "Ta bort...";
            this.btnDeletePod.UseVisualStyleBackColor = true;
            this.btnDeletePod.Click += new System.EventHandler(this.btnDeletePod_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewCategory.Location = new System.Drawing.Point(1116, 402);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(156, 56);
            this.btnNewCategory.TabIndex = 10;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCategory.Location = new System.Drawing.Point(1293, 402);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(156, 56);
            this.btnSaveCategory.TabIndex = 11;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCategory.Location = new System.Drawing.Point(1465, 402);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(156, 56);
            this.btnDeleteCategory.TabIndex = 12;
            this.btnDeleteCategory.Text = "Ta bort...";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lstPodcasts
            // 
            this.lstPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpisodes,
            this.colName,
            this.colFrequency,
            this.colCategory});
            this.lstPodcasts.FullRowSelect = true;
            this.lstPodcasts.Location = new System.Drawing.Point(28, 27);
            this.lstPodcasts.Name = "lstPodcasts";
            this.lstPodcasts.Size = new System.Drawing.Size(1024, 256);
            this.lstPodcasts.TabIndex = 13;
            this.lstPodcasts.UseCompatibleStateImageBehavior = false;
            this.lstPodcasts.View = System.Windows.Forms.View.Details;
            this.lstPodcasts.SelectedIndexChanged += new System.EventHandler(this.lstPodcasts_SelectedIndexChanged);
            // 
            // colEpisodes
            // 
            this.colEpisodes.Text = "Avsnitt";
            this.colEpisodes.Width = 80;
            // 
            // colName
            // 
            this.colName.Text = "Namn";
            this.colName.Width = 200;
            // 
            // colFrequency
            // 
            this.colFrequency.Text = "Frekvens";
            this.colFrequency.Width = 120;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 120;
            // 
            // lstCategory
            // 
            this.lstCategory.Location = new System.Drawing.Point(1116, 72);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(504, 211);
            this.lstCategory.TabIndex = 14;
            this.lstCategory.UseCompatibleStateImageBehavior = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(1118, 327);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(503, 56);
            this.txtCategory.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(1106, 535);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 29);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Beskrivning";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(1106, 484);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 51);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Avsnitt";
            // 
            // lstEpisode
            // 
            this.lstEpisode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt});
            this.lstEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstEpisode.FullRowSelect = true;
            this.lstEpisode.Location = new System.Drawing.Point(28, 538);
            this.lstEpisode.Name = "lstEpisode";
            this.lstEpisode.Size = new System.Drawing.Size(1024, 314);
            this.lstEpisode.TabIndex = 18;
            this.lstEpisode.UseCompatibleStateImageBehavior = false;
            this.lstEpisode.View = System.Windows.Forms.View.Details;
            this.lstEpisode.SelectedIndexChanged += new System.EventHandler(this.lstEpisode_SelectedIndexChanged);
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 1000;
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(28, 484);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(160, 51);
            this.lblEpisode.TabIndex = 19;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.Location = new System.Drawing.Point(471, 352);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(322, 44);
            this.txtChange.TabIndex = 20;
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterCategory.Location = new System.Drawing.Point(1116, 286);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(301, 29);
            this.lblEnterCategory.TabIndex = 21;
            this.lblEnterCategory.Text = "Lägg till/ändra kategori:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 870);
            this.Controls.Add(this.lblEnterCategory);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lstEpisode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.lstPodcasts);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.btnDeletePod);
            this.Controls.Add(this.btnSavePod);
            this.Controls.Add(this.btnNewPod);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCategories;
        private Label lblUrl;
        private Label lblUpdateName;
        private Label lblCategory;
        private ComboBox cbxCategory;
        private TextBox txtUrl;
        private Button btnNewPod;
        private Button btnSavePod;
        private Button btnDeletePod;
        private Button btnNewCategory;
        private Button btnSaveCategory;
        private Button btnDeleteCategory;
        private ListView lstPodcasts;
        private ColumnHeader colEpisodes;
        private ColumnHeader colName;
        private ColumnHeader colFrequency;
        private ColumnHeader colCategory;
        private ListView lstCategory;
        private TextBox txtCategory;
        private Label lblDescription;
        private Label lblTitle;
        private ListView lstEpisode;
        private Label lblEpisode;
        private ColumnHeader Avsnitt;
        private TextBox txtChange;
        private Label lblEnterCategory;
    }
}