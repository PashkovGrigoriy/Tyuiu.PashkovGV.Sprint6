namespace Tyuiu.PashkovGV.Sprint6.Task1.V21
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
            result = new TextBox();
            buttonforresult = new Button();
            info = new TextBox();
            SuspendLayout();
            // 
            // result
            // 
            result.BackColor = SystemColors.Info;
            result.Location = new Point(568, 12);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(220, 426);
            result.TabIndex = 0;
            result.TextChanged += result_TextChanged;
            // 
            // buttonforresult
            // 
            buttonforresult.Location = new Point(12, 270);
            buttonforresult.Name = "buttonforresult";
            buttonforresult.Size = new Size(550, 168);
            buttonforresult.TabIndex = 1;
            buttonforresult.Text = "button1";
            buttonforresult.UseVisualStyleBackColor = true;
            buttonforresult.Click += buttonforresult_Click;
            // 
            // info
            // 
            info.Location = new Point(291, 152);
            info.Name = "info";
            info.Size = new Size(100, 23);
            info.TabIndex = 2;
            info.TextChanged += info_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(info);
            Controls.Add(buttonforresult);
            Controls.Add(result);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result;
        private Button buttonforresult;
        private TextBox info;
    }
}
