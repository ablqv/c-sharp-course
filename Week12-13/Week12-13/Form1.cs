using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12_13
{
    public partial class Form1 : Form
    {
        private Painter painter;
        public Form1()
        {
            InitializeComponent();
            painter = new Painter(pictureBox);
            ColorButton.BackColor = painter.color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            painter.setWidth(trackBar1.Value);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                painter.setColor(colorDialog.Color);
                Button b = sender as Button;
                b.BackColor = painter.color;
            }
        }

        private void onOperationClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            painter.CurrentOperation = painter.Operations[b.Text];
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            painter.MouseDown(e);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            painter.MouseUp(e);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            painter.MouseMove(e);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            painter.pictureBoxPaint(e);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"JPG File|*.jpg|PNG File|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                painter.bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"JPG File|*.jpg|PNG File|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                painter = new Painter(pictureBox, new Bitmap(Image.FromFile(openFileDialog.FileName), pictureBox.Size));
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painter.GP.Reset();
            painter.G.Clear(Color.White);
            pictureBox.Refresh();
        }
    }
}
