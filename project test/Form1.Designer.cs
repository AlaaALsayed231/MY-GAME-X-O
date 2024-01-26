namespace project_test
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
            groupBox3 = new GroupBox();
            rduAo = new RadioButton();
            rduserAX = new RadioButton();
            groupBox2 = new GroupBox();
            rdubx = new RadioButton();
            rdubO = new RadioButton();
            btnstart = new Button();
            txtuser1 = new TextBox();
            txtuser2 = new TextBox();
            li2user = new Label();
            li1user = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnstart);
            groupBox1.Controls.Add(txtuser1);
            groupBox1.Controls.Add(txtuser2);
            groupBox1.Controls.Add(li2user);
            groupBox1.Controls.Add(li1user);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(851, 454);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = ".";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rduAo);
            groupBox3.Controls.Add(rduserAX);
            groupBox3.Location = new Point(57, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(177, 56);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = ".";
            // 
            // rduAo
            // 
            rduAo.AutoSize = true;
            rduAo.Font = new Font("Lucida Bright", 16.2F);
            rduAo.Location = new Point(101, 17);
            rduAo.Name = "rduAo";
            rduAo.Size = new Size(58, 36);
            rduAo.TabIndex = 0;
            rduAo.Text = "O";
            rduAo.UseVisualStyleBackColor = true;
            // 
            // rduserAX
            // 
            rduserAX.AutoSize = true;
            rduserAX.Font = new Font("Lucida Bright", 16.2F);
            rduserAX.Location = new Point(21, 17);
            rduserAX.Name = "rduserAX";
            rduserAX.Size = new Size(53, 36);
            rduserAX.TabIndex = 0;
            rduserAX.Text = "X";
            rduserAX.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdubx);
            groupBox2.Controls.Add(rdubO);
            groupBox2.Location = new Point(606, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 55);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = ".";
            // 
            // rdubx
            // 
            rdubx.AutoSize = true;
            rdubx.Font = new Font("Lucida Bright", 16.2F);
            rdubx.Location = new Point(11, 17);
            rdubx.Name = "rdubx";
            rdubx.Size = new Size(53, 36);
            rdubx.TabIndex = 0;
            rdubx.Text = "X";
            rdubx.UseVisualStyleBackColor = true;
            // 
            // rdubO
            // 
            rdubO.AutoSize = true;
            rdubO.Font = new Font("Lucida Bright", 16.2F);
            rdubO.Location = new Point(102, 17);
            rdubO.Name = "rdubO";
            rdubO.Size = new Size(58, 36);
            rdubO.TabIndex = 0;
            rdubO.Text = "O";
            rdubO.UseVisualStyleBackColor = true;
            // 
            // btnstart
            // 
            btnstart.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstart.Location = new Point(317, 361);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(222, 57);
            btnstart.TabIndex = 5;
            btnstart.Text = "Start Game";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // txtuser1
            // 
            txtuser1.Font = new Font("Segoe MDL2 Assets", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtuser1.Location = new Point(47, 281);
            txtuser1.Name = "txtuser1";
            txtuser1.Size = new Size(204, 40);
            txtuser1.TabIndex = 4;
            // 
            // txtuser2
            // 
            txtuser2.Font = new Font("Segoe MDL2 Assets", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtuser2.Location = new Point(592, 281);
            txtuser2.Name = "txtuser2";
            txtuser2.Size = new Size(200, 40);
            txtuser2.TabIndex = 4;
            // 
            // li2user
            // 
            li2user.AutoSize = true;
            li2user.Font = new Font("Segoe UI", 15F);
            li2user.Location = new Point(93, 167);
            li2user.Name = "li2user";
            li2user.Size = new Size(102, 35);
            li2user.TabIndex = 2;
            li2user.Text = "Player 1";
            // 
            // li1user
            // 
            li1user.AutoSize = true;
            li1user.Font = new Font("Segoe UI", 15F);
            li1user.Location = new Point(644, 167);
            li1user.Name = "li1user";
            li1user.Size = new Size(102, 35);
            li1user.TabIndex = 2;
            li1user.Text = "Player 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 114);
            label1.Name = "label1";
            label1.Size = new Size(114, 50);
            label1.TabIndex = 1;
            label1.Text = "V/S";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2436818;
            pictureBox2.Location = new Point(617, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._186036;
            pictureBox1.Location = new Point(68, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 26);
            label2.Name = "label2";
            label2.Size = new Size(346, 74);
            label2.TabIndex = 4;
            label2.Text = "X O Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(912, 569);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton rduAo;
        private RadioButton rduserAX;
        private GroupBox groupBox2;
        private RadioButton rdubx;
        private RadioButton rdubO;
        private Button btnstart;
        private TextBox txtuser1;
        private TextBox txtuser2;
        private Label li2user;
        private Label li1user;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
