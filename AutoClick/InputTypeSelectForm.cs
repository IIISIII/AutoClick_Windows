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
    public partial class InputTypeSelectForm : Form
    {
        private MainForm from;
        private int childIndex = -1;
        private bool isClickedCloseButton = true;

        public InputTypeSelectForm(MainForm from, int childIndex)
        {
            InitializeComponent();
            this.from = from;
            this.childIndex = childIndex;
        }

        private void ShowMouseInput(object sender, EventArgs e)
        {
            this.Hide();

            MouseInputForm backgroundForm = new MouseInputForm(this.from, this.childIndex);
            backgroundForm.ShowDialog();

            this.isClickedCloseButton = false;
            this.Close();
        }

        private void ShowKeyboardInput(object sender, EventArgs e)
        {

        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(this.isClickedCloseButton)
            {
                this.from.Show();
            }
        }
    }
}
