namespace AutoClick
{
    partial class DelaySetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            delayInput = new NumericUpDown();
            label1 = new Label();
            confirmBtn = new Button();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)delayInput).BeginInit();
            SuspendLayout();
            // 
            // delayInput
            // 
            delayInput.Location = new Point(122, 28);
            delayInput.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            delayInput.Name = "delayInput";
            delayInput.Size = new Size(150, 27);
            delayInput.TabIndex = 0;
            delayInput.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "딜레이(ms)";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(33, 87);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(94, 29);
            confirmBtn.TabIndex = 2;
            confirmBtn.Text = "확인";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += AddClickPoint;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(178, 87);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "재설정";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += Reset;
            // 
            // DelaySetForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(resetBtn);
            Controls.Add(confirmBtn);
            Controls.Add(label1);
            Controls.Add(delayInput);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DelaySetForm";
            Padding = new Padding(30);
            Text = "딜레이 설정";
            FormClosing += OnClosing;
            ((System.ComponentModel.ISupportInitialize)delayInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown delayInput;
        private Label label1;
        private Button confirmBtn;
        private Button resetBtn;
    }
}