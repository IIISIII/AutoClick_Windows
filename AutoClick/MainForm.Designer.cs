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
            button1 = new Button();
            groupBox1 = new GroupBox();
            timeSelector = new TimeSelector();
            button2 = new Button();
            actionListView = new ListView();
            order = new ColumnHeader();
            action = new ColumnHeader();
            delay = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F);
            button1.Location = new Point(23, 24);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 0;
            button1.Text = "편집";
            button1.UseVisualStyleBackColor = true;
            button1.Click += editButtonClicked;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(timeSelector);
            groupBox1.Font = new Font("맑은 고딕", 12F);
            groupBox1.Location = new Point(23, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20, 20, 20, 5);
            groupBox1.Size = new Size(399, 147);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "시간 예약";
            groupBox1.Enter += groupBox1_Enter;
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
            button2.Location = new Point(159, 24);
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
            actionListView.Location = new Point(23, 77);
            actionListView.Margin = new Padding(3, 10, 3, 10);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(686, 481);
            Controls.Add(actionListView);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Padding = new Padding(20);
            Text = "Auto Click";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private ListView actionListView;
        private TimeSelector timeSelector;
        private ColumnHeader order;
        private ColumnHeader delay;
        private ColumnHeader action;
    }
}
