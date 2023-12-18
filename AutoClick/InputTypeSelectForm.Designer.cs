namespace AutoClick
{
    partial class InputTypeSelectForm
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
            mouseButton = new Button();
            keyboardButton = new Button();
            SuspendLayout();
            // 
            // mouseButton
            // 
            mouseButton.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            mouseButton.Location = new Point(13, 13);
            mouseButton.Name = "mouseButton";
            mouseButton.Size = new Size(111, 46);
            mouseButton.TabIndex = 0;
            mouseButton.Text = "마우스";
            mouseButton.UseVisualStyleBackColor = true;
            mouseButton.Click += ShowMouseInput;
            // 
            // keyboardButton
            // 
            keyboardButton.Font = new Font("맑은 고딕", 12F);
            keyboardButton.Location = new Point(171, 13);
            keyboardButton.Name = "keyboardButton";
            keyboardButton.Size = new Size(110, 46);
            keyboardButton.TabIndex = 1;
            keyboardButton.Text = "키보드";
            keyboardButton.UseVisualStyleBackColor = true;
            keyboardButton.Click += ShowKeyboardInput;
            // 
            // InputTypeSelectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(714, 366);
            Controls.Add(keyboardButton);
            Controls.Add(mouseButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputTypeSelectForm";
            Padding = new Padding(10);
            Text = "매크로 입력 타입";
            FormClosed += OnClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button mouseButton;
        private Button keyboardButton;
    }
}