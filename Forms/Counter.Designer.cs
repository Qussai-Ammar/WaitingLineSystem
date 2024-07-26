namespace WaitingLineSystem.Forms
{
    partial class Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter));
            label1 = new Label();
            CoNum = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(436, 65);
            label1.TabIndex = 0;
            label1.Text = "Counter Number: ";
            // 
            // CoNum
            // 
            CoNum.AutoSize = true;
            CoNum.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CoNum.Location = new Point(444, 20);
            CoNum.Name = "CoNum";
            CoNum.Size = new Size(41, 65);
            CoNum.TabIndex = 1;
            CoNum.Text = " ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 101);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "#000";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(482, 135);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Counter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(515, 292);
            Controls.Add(textBox1);
            Controls.Add(CoNum);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Counter";
            Text = "Counter";
            Load += Counter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CoNum;
        private TextBox textBox1;
    }
}