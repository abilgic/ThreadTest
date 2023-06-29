namespace ThreadTest
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
            ButtonStart = new Button();
            ButtonStop = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(74, 98);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(94, 29);
            ButtonStart.TabIndex = 0;
            ButtonStart.Text = "ButtonStart";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonStop
            // 
            ButtonStop.Location = new Point(74, 284);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(94, 29);
            ButtonStop.TabIndex = 1;
            ButtonStop.Text = "ButtonStop";
            ButtonStop.UseVisualStyleBackColor = true;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(406, 89);
            listBox.Name = "listBox";
            listBox.Size = new Size(150, 104);
            listBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(ButtonStop);
            Controls.Add(ButtonStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonStart;
        private Button ButtonStop;
        private ListBox listBox;
    }
}