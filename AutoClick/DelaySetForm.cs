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
    public partial class DelaySetForm : Form
    {
        private BackgroundForm backgroundForm;
        private Point point;
        private int childIndex = -1;
        private bool isCloseAll = true;

        public DelaySetForm(BackgroundForm background, Point point, int childIndex)
        {

            InitializeComponent();
            this.backgroundForm = background;
            this.point = point;
            this.childIndex = childIndex;
        }

        private void AddClickPoint(object sender, EventArgs e)
        {
            AutoClickInput input = new AutoClickInput(this.point, Convert.ToInt32(delayInput.Value));

            if(this.childIndex == -1)
            {
                // 추가
                Program.inputList.Add(input);
            }
            else
            {
                // 교체
                Program.inputList[this.childIndex] = input;
            }
            this.Close();
        }

        private void Reset(object sender, EventArgs e)
        {
            this.isCloseAll = false;
            this.Close();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if(this.isCloseAll)
            {
                backgroundForm.Close();
            }
        }
    }
}
