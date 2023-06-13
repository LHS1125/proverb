namespace proverb
{
    partial class Form2
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
            button1 = new Button();
            Quiz = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(356, 191);
            button1.Name = "button1";
            button1.Size = new Size(48, 40);
            button1.TabIndex = 0;
            button1.Text = "입력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Quiz
            // 
            Quiz.AutoSize = true;
            Quiz.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Quiz.ForeColor = SystemColors.Control;
            Quiz.Image = Properties.Resources.board;
            Quiz.Location = new Point(54, 9);
            Quiz.Margin = new Padding(0, 3, 0, 3);
            Quiz.MaximumSize = new Size(330, 170);
            Quiz.MinimumSize = new Size(330, 170);
            Quiz.Name = "Quiz";
            Quiz.Padding = new Padding(15, 10, 15, 15);
            Quiz.Size = new Size(330, 170);
            Quiz.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(35, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 35);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 248);
            Controls.Add(textBox1);
            Controls.Add(Quiz);
            Controls.Add(button1);
            Name = "Form2";
            Text = "레벨";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Quiz;
        private TextBox textBox1;
    }
}