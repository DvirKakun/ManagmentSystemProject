using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Managment_System_Ptoject
{
    public partial class imageValidation : Form
    {
        PictureBox grabbed;
        PopupNotifier popup;
        public imageValidation()
        {
            InitializeComponent();
            firstPictureBox.AllowDrop = true;
            secondPictureBox.AllowDrop = true;
            thirdPictureBox.AllowDrop = true;
            fourthPictureBox.AllowDrop = true;
            firstResult.AllowDrop = true;
            secondResult.AllowDrop = true;
            popup = new PopupNotifier();
            popup.ImageSize = new Size(100, 100);
            popup.TitleText = "Image Validation";
            popup.TitleFont = new Font("Imprint MT Shadow", 14);
            popup.ContentFont = new Font("Arial Rounded MT", 10);
            grabbed = null;
        }

        private void firstPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ((PictureBox)(sender)).Image != null)
            {
                grabbed = ((PictureBox)(sender));
                grabbed.Tag = ((PictureBox)(sender)).Tag;
                ((PictureBox)(sender)).DoDragDrop(((PictureBox)(sender)).Image, DragDropEffects.Move);
            }
        }

        private void firstPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            object Tag = grabbed.Tag;
            grabbed.Image = ((PictureBox)(sender)).Image;
            grabbed.Tag = ((PictureBox)(sender)).Tag;
            ((PictureBox)(sender)).Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            ((PictureBox)(sender)).Tag = Tag;
        }

        private void firstPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstResult.Tag == null || secondResult.Tag == null)
            {
                popup.Image = Properties.Resources.X;
                popup.ContentText = "You must choose images !";
                popup.Popup();
            }
            else if (firstResult.Tag.ToString().Equals("true") && secondResult.Tag.ToString().Equals("true"))
            {
                popup.Image = Properties.Resources.V;
                popup.ContentText = "Verification Succeeded !";
                popup.Popup();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                popup.Image = Properties.Resources.X;
                popup.ContentText = "Try again !";
                popup.Popup();
            }
        }
    }
}
