namespace ImageFilterProject
{
    partial class FilterScreen
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
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.buttonOpenOriginal = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BackColor = System.Drawing.Color.Silver;
            this.pictureOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(600, 600);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // picturePreview
            // 
            this.picturePreview.BackColor = System.Drawing.Color.Silver;
            this.picturePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picturePreview.Location = new System.Drawing.Point(636, 12);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(600, 600);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 1;
            this.picturePreview.TabStop = false;
            // 
            // buttonOpenOriginal
            // 
            this.buttonOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenOriginal.Location = new System.Drawing.Point(288, 618);
            this.buttonOpenOriginal.Name = "buttonOpenOriginal";
            this.buttonOpenOriginal.Size = new System.Drawing.Size(150, 46);
            this.buttonOpenOriginal.TabIndex = 15;
            this.buttonOpenOriginal.Text = "Load Image";
            this.buttonOpenOriginal.UseVisualStyleBackColor = true;
            this.buttonOpenOriginal.Click += new System.EventHandler(this.buttonOpenOriginal_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.DropDownWidth = 288;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(481, 627);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(288, 32);
            this.comboBoxFilter.TabIndex = 20;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveImage.Location = new System.Drawing.Point(815, 618);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(150, 46);
            this.buttonSaveImage.TabIndex = 21;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // FilterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 675);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonOpenOriginal);
            this.Controls.Add(this.picturePreview);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "FilterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Button buttonOpenOriginal;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonSaveImage;
    }
}