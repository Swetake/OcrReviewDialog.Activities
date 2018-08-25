using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OcrReview
{
    public class OcrReviewDialog : CodeActivity
    {
        [Category("Input")]
        [Description("Image for review.")]
        [RequiredArgument]
        public InArgument<Image> InputImage { get; set; }

        [Category("Input")]
        [Description("Text for review.")]
        public InArgument<String> InputText { get; set; }

        [Category("Output")]
        [Description("Reviewed Text")]
        [RequiredArgument]
        public OutArgument<string> ReviewedText { get; set; }

        [Category("Output")]
        [Description("IsModified")]
        public OutArgument<bool>IsModified  { get; set; }

        [Category("Output")]
        [Description("IsUnreadable")]
        public OutArgument<bool> IsUnreadable { get; set; }


        protected internal Image ImgReview { get; set; }

        protected internal string StrText { get; set; }

        protected internal Boolean IsUnRead { get; set; }

        protected internal Boolean IsModify { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            this.ImgReview = InputImage.Get(context);
            this.StrText = InputText.Get(context);

            IsUnRead = false;
            IsModify = false;
            FormMain fm = new FormMain(this);
            fm.ShowDialog();

            IsModified.Set(context, this.IsModify);
            IsUnreadable.Set(context, this.IsUnRead);
            ReviewedText.Set(context, this.StrText);
        }
    }
}
