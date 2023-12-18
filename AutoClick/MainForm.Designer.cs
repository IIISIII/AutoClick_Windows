namespace AutoClick
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            timeSelector = new TimeSelector();
            button2 = new Button();
            actionListView = new ListView();
            order = new ColumnHeader();
            action = new ColumnHeader();
            delay = new ColumnHeader();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button5 = new Button();
            rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(timeSelector);
            groupBox1.Font = new Font("맑은 고딕", 12F);
            groupBox1.Location = new Point(23, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20, 20, 20, 5);
            groupBox1.Size = new Size(399, 147);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "시간 예약";
            // 
            // timeSelector
            // 
            timeSelector.AutoSize = true;
            timeSelector.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timeSelector.Location = new Point(20, 47);
            timeSelector.Margin = new Padding(0);
            timeSelector.Name = "timeSelector";
            timeSelector.Size = new Size(359, 68);
            timeSelector.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 12F);
            button2.Location = new Point(23, 23);
            button2.Name = "button2";
            button2.Size = new Size(108, 40);
            button2.TabIndex = 0;
            button2.Text = "미리보기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShowPreview;
            // 
            // actionListView
            // 
            actionListView.Columns.AddRange(new ColumnHeader[] { order, action, delay });
            actionListView.FullRowSelect = true;
            actionListView.GridLines = true;
            actionListView.ImeMode = ImeMode.NoControl;
            actionListView.Location = new Point(23, 76);
            actionListView.Margin = new Padding(3, 10, 3, 10);
            actionListView.MultiSelect = false;
            actionListView.Name = "actionListView";
            actionListView.Size = new Size(399, 179);
            actionListView.TabIndex = 8;
            actionListView.UseCompatibleStateImageBehavior = false;
            actionListView.View = View.Details;
            // 
            // order
            // 
            order.Text = "순서";
            // 
            // action
            // 
            action.Text = "동작";
            action.Width = 120;
            // 
            // delay
            // 
            delay.Text = "딜레이(ms)";
            delay.Width = 120;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 12F);
            button4.Location = new Point(23, 268);
            button4.Name = "button4";
            button4.Size = new Size(101, 40);
            button4.TabIndex = 10;
            button4.Text = "수정";
            button4.UseVisualStyleBackColor = true;
            button4.Click += UpdateInput;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 12F);
            button3.Location = new Point(287, 23);
            button3.Name = "button3";
            button3.Size = new Size(135, 40);
            button3.TabIndex = 9;
            button3.Text = "키보드 입력";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddKeyboardInput;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F);
            button1.Location = new Point(142, 23);
            button1.Name = "button1";
            button1.Size = new Size(135, 40);
            button1.TabIndex = 0;
            button1.Text = "마우스 입력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddMouseInputPoint;
            // 
            // button5
            // 
            button5.Font = new Font("맑은 고딕", 12F);
            button5.Location = new Point(321, 268);
            button5.Name = "button5";
            button5.Size = new Size(101, 40);
            button5.TabIndex = 10;
            button5.Text = "삭제";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DeleteInput;
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.Location = new Point(344, 486);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.Gray;
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(78, 36);
            rjToggleButton1.TabIndex = 11;
            rjToggleButton1.UseVisualStyleBackColor = true;
            rjToggleButton1.CheckedChanged += OnCheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F);
            label1.Location = new Point(219, 490);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 12;
            label1.Text = "매크로 실행";
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 12F);
            button6.Location = new Point(23, 541);
            button6.Name = "button6";
            button6.Size = new Size(101, 40);
            button6.TabIndex = 10;
            button6.Text = "저장";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("맑은 고딕", 12F);
            button7.Location = new Point(142, 541);
            button7.Name = "button7";
            button7.Size = new Size(101, 40);
            button7.TabIndex = 10;
            button7.Text = "불러오기";
            button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 608);
            Controls.Add(label1);
            Controls.Add(rjToggleButton1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(actionListView);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "MainForm";
            Padding = new Padding(20);
            Text = "Auto Click";
            Activated += OnFocusEnter;
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button button2;
        private ListView actionListView;
        private TimeSelector timeSelector;
        private ColumnHeader order;
        private ColumnHeader delay;
        private ColumnHeader action;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button5;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private Label label1;
        private Button button6;
        private Button button7;
    }
}
