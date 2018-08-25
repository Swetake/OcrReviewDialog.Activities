using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcrReview
{
    public partial class FormMain : Form
    {
        Image imgInput;
        string strText;
        OcrReviewDialog ocrReviewDialog;

        public FormMain(OcrReviewDialog ord)
        {
            InitializeComponent();
            ocrReviewDialog = ord;
            imgInput = ocrReviewDialog.ImgReview;
            strText = ocrReviewDialog.StrText;


            pictureBoxReviewImage.Image = imgInput;
            textBoxText.Text = strText;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxText.Text = "";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            ocrReviewDialog.StrText = textBoxText.Text;
            if (strText.Equals(textBoxText.Text))
            {
                ocrReviewDialog.IsModify = false;
            }
            else
            {
                ocrReviewDialog.IsModify = true;
            }
            this.Close();
        }

        private void buttonUnreadble_Click(object sender, EventArgs e)
        {
            ocrReviewDialog.IsUnRead = true;
            this.Close();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            textBoxText.Text = strText;
        }
    }
}
