namespace WaitingLineSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            VisitorBtn = new Button();
            AdminBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(VisitorBtn);
            panel1.Controls.Add(AdminBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 392);
            panel1.TabIndex = 0;
            // 
            // VisitorBtn
            // 
            VisitorBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VisitorBtn.Location = new Point(40, 306);
            VisitorBtn.Name = "VisitorBtn";
            VisitorBtn.Size = new Size(213, 44);
            VisitorBtn.TabIndex = 2;
            VisitorBtn.Text = "Visitor";
            VisitorBtn.UseVisualStyleBackColor = true;
            VisitorBtn.Click += VisitorBtn_Click;
            // 
            // AdminBtn
            // 
            AdminBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminBtn.Location = new Point(40, 256);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(213, 44);
            AdminBtn.TabIndex = 1;
            AdminBtn.Text = "Admin";
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Waiting Line System ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 473);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Waiting Line System - Main Page";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button VisitorBtn;
        private Button AdminBtn;
        private Label label1;
    }
}