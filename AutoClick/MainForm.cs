using CustomControls.RJControls;

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
            
        }

        private void AddMouseInputPoint(object sender, EventArgs e)
        {
            this.Hide();

            MouseInputForm backgroundForm = new MouseInputForm(this, -1);
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
            if (actionListView.SelectedItems.Count > 0)
            {
                Program.inputList.RemoveAt(actionListView.SelectedItems[0].Index);
                this.refreshActionList(Program.inputList);
            }
        }

        private void OnFocusEnter(object sender, EventArgs e)
        {
            //KeyGroup keyGroup = new KeyGroup();
            //keyGroup.addKey(0x43);

            //List<KeyGroup> keyGroups = new List<KeyGroup>();
            //keyGroups.Add(keyGroup);

            //AutoClickInput input = new AutoClickInput(keyGroups, 1000);
            //Program.inputList.Add(input);
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
                    actionName = MouseEvent.toString(action.getMouseInput());
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
                this.timeSelector.enable();
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
