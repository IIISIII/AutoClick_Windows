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
    public partial class BackgroundForm : Form
    {
        private MainForm from;
        private int childIndex = -1;

        public BackgroundForm(MainForm from, int childIndex)
        {
            InitializeComponent();
            this.from = from;
            this.childIndex = childIndex;
            clickPoint.Hide();
        }

        private void SetClickPoint(object sender, MouseEventArgs e)
        {
            clickPoint.Location = new Point(e.Location.X - 8, e.Location.Y - 8);
            clickPoint.Show();

            DelaySetForm delaySetForm = new DelaySetForm(this, e.Location, this.childIndex);
            delaySetForm.ShowDialog();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            this.from.Show();
        }

        private void OnFocusEnter(object sender, EventArgs e)
        {
            clickPoint.Hide();
        }
    }
}
