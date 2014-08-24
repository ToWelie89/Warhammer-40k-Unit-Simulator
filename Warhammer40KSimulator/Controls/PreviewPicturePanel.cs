using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warhammer40KSimulator.Presentation.ArmyChoosing;

namespace Warhammer40KSimulator.Controls
{
    public partial class PreviewPicturePanel : UserControl, IPreviewPicturePanel
    {
        private ArmyChoosingPresenter presenter;

        public PreviewPicturePanel()
        {
            InitializeComponent();
        }

        public void SetPresenter(ArmyChoosingPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void UpdatePicture(Bitmap picture)
        {
            if (picture != null && (picture.Width > this.pictureBox1.Width || picture.Height > this.pictureBox1.Height))
            {
                int height;
                int width;

                if (picture.Width > picture.Height)
                {
                    width = this.pictureBox1.Width;
                    double ratio = picture.Width/picture.Height;
                    height = Convert.ToInt32(width / ratio);
                }
                else
                {
                    height = this.pictureBox1.Height;
                    double ratio = Convert.ToDouble(picture.Height) / Convert.ToDouble(picture.Width);
                    width = Convert.ToInt32(height / ratio);
                }

                picture = new Bitmap(picture, width, height);
            }

            this.pictureBox1.Image = picture;
        }
    }
}
