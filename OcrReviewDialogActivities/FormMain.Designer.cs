namespace OcrReview
{
    partial class FormMain
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
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonUnreadble = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.pictureBoxReviewImage = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(512, 388);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 39);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonUnreadble
            // 
            this.buttonUnreadble.Location = new System.Drawing.Point(593, 388);
            this.buttonUnreadble.Name = "buttonUnreadble";
            this.buttonUnreadble.Size = new System.Drawing.Size(86, 39);
            this.buttonUnreadble.TabIndex = 1;
            this.buttonUnreadble.Text = "Unreadble";
            this.buttonUnreadble.UseVisualStyleBackColor = true;
            this.buttonUnreadble.Click += new System.EventHandler(this.buttonUnreadble_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxText.Location = new System.Drawing.Point(12, 295);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(680, 87);
            this.textBoxText.TabIndex = 2;
            // 
            // pictureBoxReviewImage
            // 
            this.pictureBoxReviewImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxReviewImage.Name = "pictureBoxReviewImage";
            this.pictureBoxReviewImage.Size = new System.Drawing.Size(680, 277);
            this.pictureBoxReviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReviewImage.TabIndex = 3;
            this.pictureBoxReviewImage.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 396);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 31);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(110, 396);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(89, 31);
            this.buttonRestore.TabIndex = 5;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxReviewImage);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonUnreadble);
            this.Controls.Add(this.buttonGo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Review Dialog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonUnreadble;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.PictureBox pictureBoxReviewImage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRestore;
    }
}