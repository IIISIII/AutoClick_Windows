namespace AutoClick
{
    partial class BackgroundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            clickPoint = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)clickPoint).BeginInit();
            SuspendLayout();
            // 
            // clickPoint
            // 
            clickPoint.BackgroundImage = (Image)resources.GetObject("clickPoint.BackgroundImage");
            clickPoint.BackgroundImageLayout = ImageLayout.Zoom;
            clickPoint.Location = new Point(310, 73);
            clickPoint.Name = "clickPoint";
            clickPoint.Size = new Size(30, 30);
            clickPoint.TabIndex = 0;
            clickPoint.TabStop = false;
            clickPoint.MouseClick += SetClickPoint;
            // 
            // BackgroundForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(clickPoint);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BackgroundForm";
            Opacity = 0.5D;
            Text = "BackgroundForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += OnClosed;
            MouseClick += SetClickPoint;
            ((System.ComponentModel.ISupportInitialize)clickPoint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox clickPoint;
    }
}