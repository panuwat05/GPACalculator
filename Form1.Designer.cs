namespace GPAx
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
            label1 = new Label();
            label2 = new Label();
            tbInputGpa = new TextBox();
            tbGpax = new TextBox();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            tbGpaMin = new TextBox();
            tbGpaMax = new TextBox();
            button1 = new Button();
            label5 = new Label();
            tbStudentCount = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Input GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "GPAx";
            // 
            // tbInputGpa
            // 
            tbInputGpa.Location = new Point(92, 29);
            tbInputGpa.Name = "tbInputGpa";
            tbInputGpa.Size = new Size(132, 23);
            tbInputGpa.TabIndex = 2;
            // 
            // tbGpax
            // 
            tbGpax.Location = new Point(92, 77);
            tbGpax.Name = "tbGpax";
            tbGpax.Size = new Size(132, 23);
            tbGpax.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(282, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(198, 213);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Data";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbStudentCount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbGpaMin);
            groupBox1.Controls.Add(tbGpaMax);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbGpax);
            groupBox1.Controls.Add(tbInputGpa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 270);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "GPAx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 162);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "GPAMin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 123);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "GPAMax";
            // 
            // tbGpaMin
            // 
            tbGpaMin.Location = new Point(92, 159);
            tbGpaMin.Name = "tbGpaMin";
            tbGpaMin.Size = new Size(132, 23);
            tbGpaMin.TabIndex = 6;
            // 
            // tbGpaMax
            // 
            tbGpaMax.Location = new Point(92, 120);
            tbGpaMax.Name = "tbGpaMax";
            tbGpaMax.Size = new Size(132, 23);
            tbGpaMax.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(44, 317);
            button1.Name = "button1";
            button1.Size = new Size(454, 60);
            button1.TabIndex = 6;
            button1.Text = "Clear Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 206);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "StudentCount";
            // 
            // tbStudentCount
            // 
            tbStudentCount.Location = new Point(110, 203);
            tbStudentCount.Name = "tbStudentCount";
            tbStudentCount.Size = new Size(114, 23);
            tbStudentCount.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 398);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbInputGpa;
        private TextBox tbGpax;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox tbGpaMin;
        private TextBox tbGpaMax;
        private Button button1;
        private TextBox tbStudentCount;
        private Label label5;
    }
}
