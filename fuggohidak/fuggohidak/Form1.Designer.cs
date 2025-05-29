namespace fuggohidak
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
            menuStrip1 = new MenuStrip();
            keresésToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            megnyitásToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox5 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { keresésToolStripMenuItem, kilépésToolStripMenuItem, fájlToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(525, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(73, 24);
            keresésToolStripMenuItem.Text = "Keresés";
            keresésToolStripMenuItem.Click += keresésToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(71, 24);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += button1_Click;
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { megnyitásToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(45, 24);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            megnyitásToolStripMenuItem.Size = new Size(169, 26);
            megnyitásToolStripMenuItem.Text = "Megnyitás...";
            megnyitásToolStripMenuItem.Click += megnyitásToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Hely";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 118);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Ország";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 171);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Hossz";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 217);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 4;
            label4.Text = "Év";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(392, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(392, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 224);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(30, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 144);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hidak száma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 114);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "darab";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 111);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(11, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(169, 24);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "2000-ben vagy utána";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(135, 24);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "2000 előtt épült";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(409, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Kilépés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 458);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem megnyitásToolStripMenuItem;
    }
}
