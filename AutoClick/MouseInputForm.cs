using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class MouseInputForm : Form
    {
        private MainForm from;
        private int keyCode = AutoClickInput.ACTION_LEFT_CLICK;
        private int childIndex = -1;

        public MouseInputForm(MainForm from, int childIndex)
        {
            InitializeComponent();
            this.from = from;
            this.childIndex = childIndex;

            if(this.childIndex == -1)
            {
                clickPoint.Hide();
            }
            else
            {
                Point location = Program.inputList[this.childIndex].getInputPoint();
                clickPoint.Location = new Point(location.X - 8, location.Y - 8);
            }
        }

        private void SetClickPoint(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                this.keyCode = e.Button == MouseButtons.Left ? AutoClickInput.ACTION_LEFT_CLICK : AutoClickInput.ACTION_RIGHT_CLICK;

                Point location = Cursor.Position;

                clickPoint.Location = new Point(location.X - 8, location.Y - 8);
                clickPoint.Show();

                DelaySetForm delaySetForm = new DelaySetForm(this, location, this.keyCode, this.childIndex);
                delaySetForm.ShowDialog();
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            this.from.Show();
        }
    }
}
