namespace AutoClick
{
    partial class TimeSelector
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            radioAM = new RadioButton();
            secondUpDown = new NumericUpDown();
            radioPM = new RadioButton();
            minuteUpDown = new NumericUpDown();
            label1 = new Label();
            hourUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)secondUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hourUpDown).BeginInit();
            SuspendLayout();
            // 
            // radioAM
            // 
            radioAM.AutoSize = true;
            radioAM.Checked = true;
            radioAM.Font = new Font("맑은 고딕", 12F);
            radioAM.Location = new Point(0, 0);
            radioAM.Margin = new Padding(0, 0, 10, 0);
            radioAM.Name = "radioAM";
            radioAM.Size = new Size(73, 32);
            radioAM.TabIndex = 7;
            radioAM.TabStop = true;
            radioAM.Text = "오전";
            radioAM.UseVisualStyleBackColor = true;
            radioAM.CheckedChanged += OnChangedAmPm;
            // 
            // secondUpDown
            // 
            secondUpDown.Font = new Font("맑은 고딕", 12F);
            secondUpDown.Location = new Point(277, 19);
            secondUpDown.Margin = new Padding(10, 0, 0, 0);
            secondUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondUpDown.Name = "secondUpDown";
            secondUpDown.Size = new Size(47, 34);
            secondUpDown.TabIndex = 12;
            // 
            // radioPM
            // 
            radioPM.AutoSize = true;
            radioPM.Font = new Font("맑은 고딕", 12F);
            radioPM.Location = new Point(0, 36);
            radioPM.Margin = new Padding(0, 0, 10, 0);
            radioPM.Name = "radioPM";
            radioPM.Size = new Size(73, 32);
            radioPM.TabIndex = 8;
            radioPM.TabStop = true;
            radioPM.Text = "오후";
            radioPM.UseVisualStyleBackColor = true;
            radioPM.CheckedChanged += OnChangedAmPm;
            // 
            // minuteUpDown
            // 
            minuteUpDown.Font = new Font("맑은 고딕", 12F);
            minuteUpDown.Location = new Point(185, 18);
            minuteUpDown.Margin = new Padding(10, 0, 0, 0);
            minuteUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteUpDown.Name = "minuteUpDown";
            minuteUpDown.Size = new Size(47, 34);
            minuteUpDown.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F);
            label1.Location = new Point(143, 20);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 28);
            label1.TabIndex = 9;
            label1.Text = "시";
            // 
            // hourUpDown
            // 
            hourUpDown.Font = new Font("맑은 고딕", 12F);
            hourUpDown.Location = new Point(93, 18);
            hourUpDown.Margin = new Padding(10, 0, 0, 0);
            hourUpDown.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            hourUpDown.Name = "hourUpDown";
            hourUpDown.Size = new Size(47, 34);
            hourUpDown.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F);
            label2.Location = new Point(235, 20);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 10;
            label2.Text = "분";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F);
            label3.Location = new Point(327, 20);
            label3.Margin = new Padding(3, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 11;
            label3.Text = "초";
            // 
            // TimeSelector
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(radioAM);
            Controls.Add(secondUpDown);
            Controls.Add(radioPM);
            Controls.Add(minuteUpDown);
            Controls.Add(label1);
            Controls.Add(hourUpDown);
            Controls.Add(label2);
            Controls.Add(label3);
            Margin = new Padding(0);
            Name = "TimeSelector";
            Size = new Size(359, 68);
            ((System.ComponentModel.ISupportInitialize)secondUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hourUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioAM;
        private NumericUpDown secondUpDown;
        private RadioButton radioPM;
        private NumericUpDown minuteUpDown;
        private Label label1;
        private NumericUpDown hourUpDown;
        private Label label2;
        private Label label3;
    }
}
