namespace _5
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Home3 = new TextBox();
            Home2 = new TextBox();
            Home1 = new TextBox();
            VidBox3 = new TextBox();
            VidBox2 = new TextBox();
            VidBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkedListBox3 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            NameBox3 = new TextBox();
            NameBox2 = new TextBox();
            NameBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button = new Button();
            label1 = new Label();
            ResultBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Home3);
            groupBox1.Controls.Add(Home2);
            groupBox1.Controls.Add(Home1);
            groupBox1.Controls.Add(VidBox3);
            groupBox1.Controls.Add(VidBox2);
            groupBox1.Controls.Add(VidBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkedListBox3);
            groupBox1.Controls.Add(checkedListBox2);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(NameBox3);
            groupBox1.Controls.Add(NameBox2);
            groupBox1.Controls.Add(NameBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 18);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 25;
            label6.Text = "Місце проживання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 18);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 24;
            label5.Text = "Вид";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 18);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 23;
            label4.Text = "Назва";
            // 
            // Home3
            // 
            Home3.Location = new Point(350, 215);
            Home3.Name = "Home3";
            Home3.Size = new Size(118, 27);
            Home3.TabIndex = 22;
            // 
            // Home2
            // 
            Home2.Location = new Point(350, 125);
            Home2.Name = "Home2";
            Home2.Size = new Size(118, 27);
            Home2.TabIndex = 21;
            // 
            // Home1
            // 
            Home1.Location = new Point(350, 41);
            Home1.Name = "Home1";
            Home1.Size = new Size(118, 27);
            Home1.TabIndex = 20;
            // 
            // VidBox3
            // 
            VidBox3.Location = new Point(203, 215);
            VidBox3.Name = "VidBox3";
            VidBox3.Size = new Size(114, 27);
            VidBox3.TabIndex = 19;
            // 
            // VidBox2
            // 
            VidBox2.Location = new Point(203, 125);
            VidBox2.Name = "VidBox2";
            VidBox2.Size = new Size(114, 27);
            VidBox2.TabIndex = 18;
            // 
            // VidBox1
            // 
            VidBox1.Location = new Point(203, 41);
            VidBox1.Name = "VidBox1";
            VidBox1.Size = new Size(114, 27);
            VidBox1.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(651, 214);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(37, 24);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "-";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Дика", "Домашня" });
            checkedListBox3.Location = new Point(511, 204);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(134, 48);
            checkedListBox3.TabIndex = 15;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Морська", "Прісноводна" });
            checkedListBox2.Location = new Point(511, 113);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(134, 48);
            checkedListBox2.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Травоїдний", "Хижак", "Всеїдний" });
            checkedListBox1.Location = new Point(511, 9);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(134, 70);
            checkedListBox1.TabIndex = 13;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // NameBox3
            // 
            NameBox3.Location = new Point(62, 215);
            NameBox3.Name = "NameBox3";
            NameBox3.Size = new Size(110, 27);
            NameBox3.TabIndex = 6;
            // 
            // NameBox2
            // 
            NameBox2.Location = new Point(62, 125);
            NameBox2.Name = "NameBox2";
            NameBox2.Size = new Size(110, 27);
            NameBox2.TabIndex = 5;
            // 
            // NameBox1
            // 
            NameBox1.Location = new Point(62, 41);
            NameBox1.Name = "NameBox1";
            NameBox1.Size = new Size(110, 27);
            NameBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 218);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Птиця";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 128);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Риба";
            // 
            // button
            // 
            button.Location = new Point(177, 255);
            button.Name = "button";
            button.Size = new Size(166, 58);
            button.TabIndex = 1;
            button.Text = "Додати";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Ссавці";
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(794, 21);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(456, 304);
            ResultBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 337);
            Controls.Add(ResultBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Тварини";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button;
        private Label label1;
        private TextBox ResultBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Home3;
        private TextBox Home2;
        private TextBox Home1;
        private TextBox VidBox3;
        private TextBox VidBox2;
        private TextBox VidBox1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private TextBox NameBox3;
        private TextBox NameBox2;
        private TextBox NameBox1;
        private Label label3;
        private Label label2;
    }
}