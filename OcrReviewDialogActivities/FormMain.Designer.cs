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
            this.buttonUnreadable = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.pictureBoxReviewImage = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(512, 397);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 39);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonUnreadable
            // 
            this.buttonUnreadable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonUnreadable.Location = new System.Drawing.Point(593, 397);
            this.buttonUnreadable.Name = "buttonUnreadable";
            this.buttonUnreadable.Size = new System.Drawing.Size(86, 39);
            this.buttonUnreadable.TabIndex = 1;
            this.buttonUnreadable.Text = "Unreadable";
            this.buttonUnreadable.UseVisualStyleBackColor = true;
            this.buttonUnreadable.Click += new System.EventHandler(this.buttonUnreadble_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxText.Location = new System.Drawing.Point(12, 306);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(680, 87);
            this.textBoxText.TabIndex = 2;
            // 
            // pictureBoxReviewImage
            // 
            this.pictureBoxReviewImage.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxReviewImage.Name = "pictureBoxReviewImage";
            this.pictureBoxReviewImage.Size = new System.Drawing.Size(680, 256);
            this.pictureBoxReviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReviewImage.TabIndex = 3;
            this.pictureBoxReviewImage.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 405);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 31);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(110, 405);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(89, 31);
            this.buttonRestore.TabIndex = 5;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(15, 5);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(35, 12);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Image";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(15, 288);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 12);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Text";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonUnreadable;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxReviewImage);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonUnreadable);
            this.Controls.Add(this.buttonGo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Dialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonUnreadable;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.PictureBox pictureBoxReviewImage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelText;
    }
}