namespace WinFormsApp3
{
    partial class Form1
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
            StopPlayback = new Button();
            StartPlayback = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // StopPlayback
            // 
            StopPlayback.Location = new Point(653, 428);
            StopPlayback.Name = "StopPlayback";
            StopPlayback.Size = new Size(145, 23);
            StopPlayback.TabIndex = 0;
            StopPlayback.Text = "Stop Playback";
            StopPlayback.UseVisualStyleBackColor = true;
            StopPlayback.Click += StopPlayback_Click;
            // 
            // StartPlayback
            // 
            StartPlayback.Location = new Point(12, 428);
            StartPlayback.Name = "StartPlayback";
            StartPlayback.Size = new Size(118, 23);
            StartPlayback.TabIndex = 1;
            StartPlayback.Text = "Start Playback";
            StartPlayback.UseVisualStyleBackColor = true;
            StartPlayback.Click += StartPlayback_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 311);
            button1.Name = "button1";
            button1.Size = new Size(368, 23);
            button1.TabIndex = 2;
            button1.Text = "Selected File:";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 266);
            panel1.TabIndex = 4;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(StartPlayback);
            Controls.Add(StopPlayback);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button StopPlayback;
        private Button StartPlayback;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
    }
}