namespace project_test
{
    partial class Form3
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
            contain = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)contain).BeginInit();
            SuspendLayout();
            // 
            // contain
            // 
            contain.BackgroundColor = SystemColors.ActiveCaption;
            contain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contain.Location = new Point(-1, 121);
            contain.Margin = new Padding(3, 5, 3, 5);
            contain.Name = "contain";
            contain.RowHeadersWidth = 51;
            contain.Size = new Size(1001, 458);
            contain.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 33F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(700, 62);
            label1.TabIndex = 1;
            label1.Text = "X-O Players Information";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 578);
            Controls.Add(label1);
            Controls.Add(contain);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)contain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView contain;
        private Label label1;
    }
}