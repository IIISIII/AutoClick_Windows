using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeSelector.initToNow();
            //timeSelector.disable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editButtonClicked(object sender, EventArgs e)
        {
            this.Hide();

            BackgroundForm backgroundForm = new BackgroundForm(this, -1);
            backgroundForm.ShowDialog();
        }

        private void ShowPreview(object sender, EventArgs e)
        {
            //Cursor.Position = Program.point;

            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
