namespace WaitingLineSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            NextBtn = new Button();
            ResetBtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ServingTurn = new TextBox();
            panel2 = new Panel();
            Averge = new TextBox();
            Average = new Label();
            OnWaiting = new TextBox();
            label2 = new Label();
            CounterInfo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NextBtn
            // 
            NextBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextBtn.Location = new Point(29, 30);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(229, 48);
            NextBtn.TabIndex = 0;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(29, 138);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(229, 48);
            ResetBtn.TabIndex = 1;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(29, 192);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(229, 48);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 18);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 3;
            label1.Text = "Now Serving";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(ServingTurn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(296, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 197);
            panel1.TabIndex = 4;
            // 
            // ServingTurn
            // 
            ServingTurn.BackColor = Color.AliceBlue;
            ServingTurn.BorderStyle = BorderStyle.None;
            ServingTurn.Font = new Font("Segoe UI Light", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServingTurn.Location = new Point(17, 54);
            ServingTurn.Name = "ServingTurn";
            ServingTurn.PlaceholderText = "#000";
            ServingTurn.ReadOnly = true;
            ServingTurn.Size = new Size(562, 128);
            ServingTurn.TabIndex = 4;
            ServingTurn.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(Averge);
            panel2.Controls.Add(Average);
            panel2.Controls.Add(OnWaiting);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(29, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 148);
            panel2.TabIndex = 5;
            // 
            // Averge
            // 
            Averge.BackColor = Color.AliceBlue;
            Averge.BorderStyle = BorderStyle.None;
            Averge.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Averge.Location = new Point(480, 53);
            Averge.Name = "Averge";
            Averge.Size = new Size(347, 64);
            Averge.TabIndex = 3;
            // 
            // Average
            // 
            Average.AutoSize = true;
            Average.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Average.Location = new Point(478, 14);
            Average.Name = "Average";
            Average.Size = new Size(236, 30);
            Average.TabIndex = 2;
            Average.Text = "Average Waiting Time:";
            // 
            // OnWaiting
            // 
            OnWaiting.BackColor = Color.AliceBlue;
            OnWaiting.BorderStyle = BorderStyle.None;
            OnWaiting.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OnWaiting.Location = new Point(15, 53);
            OnWaiting.Name = "OnWaiting";
            OnWaiting.Size = new Size(347, 64);
            OnWaiting.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 14);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 0;
            label2.Text = "On Waiting: ";
            // 
            // CounterInfo
            // 
            CounterInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CounterInfo.Location = new Point(29, 84);
            CounterInfo.Name = "CounterInfo";
            CounterInfo.Size = new Size(229, 48);
            CounterInfo.TabIndex = 6;
            CounterInfo.Text = "Open Counter";
            CounterInfo.UseVisualStyleBackColor = true;
            CounterInfo.Click += CounterInfo_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(925, 472);
            Controls.Add(CounterInfo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ExitBtn);
            Controls.Add(ResetBtn);
            Controls.Add(NextBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Waiting Line System - Admin Page";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button NextBtn;
        private Button ResetBtn;
        private Button ExitBtn;
        private Label label1;
        private Panel panel1;
        private TextBox ServingTurn;
        private Panel panel2;
        private Label label2;
        private TextBox Averge;
        private Label Average;
        private TextBox OnWaiting;
        private Button CounterInfo;
    }
}