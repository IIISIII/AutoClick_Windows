using CustomControls.RJControls;
using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class MainForm : Form
    {
        private ActionThread? actionThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timeSelector.initToNow();

        }

        private void ShowPreview(object sender, EventArgs e)
        {
            //Cursor.Position = Program.point;

            //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void AddMouseInputPoint(object sender, EventArgs e)
        {
            this.Hide();

            BackgroundForm backgroundForm = new BackgroundForm(this, -1);
            backgroundForm.ShowDialog();
        }

        private void AddKeyboardInput(object sender, EventArgs e)
        {

        }

        private void UpdateInput(object sender, EventArgs e)
        {
            if (actionListView.SelectedItems.Count > 0)
            {
                this.Hide();

                InputTypeSelectForm typeSelectForm = new InputTypeSelectForm(this, actionListView.SelectedItems[0].Index);
                typeSelectForm.ShowDialog();
            }
        }

        private void DeleteInput(object sender, EventArgs e)
        {

        }

        private void OnFocusEnter(object sender, EventArgs e)
        {
            Console.WriteLine(Program.inputList.Count.ToString());
            this.refreshActionList(Program.inputList);
        }

        private void refreshActionList(List<AutoClickInput> actionList)
        {
            this.actionListView.Items.Clear();

            for (int i = 0; i < actionList.Count; i++)
            {
                AutoClickInput action = actionList[i];
                String actionName = "";
                if (action.getInputType() == AutoClickInput.TYPE_MOUSE)
                {
                    if (action.getKeyCode() == AutoClickInput.ACTION_LEFT_CLICK)
                        actionName = "Left Click";
                    else
                        actionName = "Right Click";
                }
                ListViewItem listViewItem = new ListViewItem(new string[] { i.ToString(), actionName, action.getDelay().ToString() }, -1);
                this.actionListView.Items.Add(listViewItem);
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            RJToggleButton toggle = (RJToggleButton)sender;
            
            List<AutoClickInput> actionList = Program.inputList;
            
            if(actionList.Count == 0)
            {
                toggle.Checked = false;
                return;
            }

            if(toggle.Checked)
            {
                this.actionThread = new ActionThread(actionList, this.timeToMilSec(timeSelector.getHour(), timeSelector.getMinute(), timeSelector.getSecond()));
                this.actionThread.start();
                this.timeSelector.disable();
            }
            else
            {
                if(this.actionThread != null)
                {
                    this.actionThread.stop();
                    this.actionThread = null;
                }
            }
        }

        private int timeToMilSec(int hour, int minute, int second)
        {
            int milSec = second * 1000;
            int milMin = minute * 1000 * 60;
            int milHour = hour * 1000 * 60 * 60;
            return milHour + milMin + milSec;
        }
    }
}
