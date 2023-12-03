namespace ccc
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
            Firstnumber = new Label();
            Secondnumber = new Label();
            txtst2 = new TextBox();
            txtst1 = new TextBox();
            btnresult = new Button();
            txtbscnn = new TextBox();
            txtuscln = new TextBox();
            usclnlabel = new Label();
            bscnnlabel = new Label();
            resultlabel = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 21);
            label1.Name = "label1";
            label1.Size = new Size(485, 37);
            label1.TabIndex = 0;
            label1.Text = "Tìm BSCNN và USCLN của 2 số bất kì";
            // 
            // Firstnumber
            // 
            Firstnumber.AutoSize = true;
            Firstnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Firstnumber.Location = new Point(102, 100);
            Firstnumber.Name = "Firstnumber";
            Firstnumber.Size = new Size(75, 17);
            Firstnumber.TabIndex = 1;
            Firstnumber.Text = "Số thứ nhất";
            // 
            // Secondnumber
            // 
            Secondnumber.AutoSize = true;
            Secondnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Secondnumber.Location = new Point(102, 175);
            Secondnumber.Name = "Secondnumber";
            Secondnumber.Size = new Size(67, 17);
            Secondnumber.TabIndex = 1;
            Secondnumber.Text = "Số thứ hai";
            // 
            // txtst2
            // 
            txtst2.Location = new Point(232, 169);
            txtst2.Name = "txtst2";
            txtst2.Size = new Size(200, 23);
            txtst2.TabIndex = 2;
            // 
            // txtst1
            // 
            txtst1.Location = new Point(232, 99);
            txtst1.Name = "txtst1";
            txtst1.Size = new Size(200, 23);
            txtst1.TabIndex = 2;
            // 
            // btnresult
            // 
            btnresult.Location = new Point(368, 216);
            btnresult.Name = "btnresult";
            btnresult.Size = new Size(100, 40);
            btnresult.TabIndex = 3;
            btnresult.Text = "Tìm Kết Quả";
            btnresult.UseVisualStyleBackColor = true;
            btnresult.Click += btnresult_Click;
            // 
            // txtbscnn
            // 
            txtbscnn.Location = new Point(232, 281);
            txtbscnn.Name = "txtbscnn";
            txtbscnn.Size = new Size(200, 23);
            txtbscnn.TabIndex = 6;
            // 
            // txtuscln
            // 
            txtuscln.Location = new Point(232, 351);
            txtuscln.Name = "txtuscln";
            txtuscln.Size = new Size(200, 23);
            txtuscln.TabIndex = 7;
            // 
            // usclnlabel
            // 
            usclnlabel.AutoSize = true;
            usclnlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usclnlabel.Location = new Point(102, 357);
            usclnlabel.Name = "usclnlabel";
            usclnlabel.Size = new Size(48, 17);
            usclnlabel.TabIndex = 4;
            usclnlabel.Text = "USCLN";
            // 
            // bscnnlabel
            // 
            bscnnlabel.AutoSize = true;
            bscnnlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bscnnlabel.Location = new Point(102, 282);
            bscnnlabel.Name = "bscnnlabel";
            bscnnlabel.Size = new Size(50, 17);
            bscnnlabel.TabIndex = 5;
            bscnnlabel.Text = "BSCNN";
            // 
            // resultlabel
            // 
            resultlabel.AutoSize = true;
            resultlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            resultlabel.Location = new Point(25, 320);
            resultlabel.Name = "resultlabel";
            resultlabel.Size = new Size(53, 17);
            resultlabel.TabIndex = 5;
            resultlabel.Text = "Kết quả";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(544, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 39);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(txtbscnn);
            Controls.Add(txtuscln);
            Controls.Add(usclnlabel);
            Controls.Add(resultlabel);
            Controls.Add(bscnnlabel);
            Controls.Add(btnresult);
            Controls.Add(txtst1);
            Controls.Add(txtst2);
            Controls.Add(Secondnumber);
            Controls.Add(Firstnumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Firstnumber;
        private Label Secondnumber;
        private TextBox txtst2;
        private TextBox txtst1;
        private Button btnresult;
        private TextBox txtbscnn;
        private TextBox txtuscln;
        private Label usclnlabel;
        private Label bscnnlabel;
        private Label resultlabel;
        private Button btnExit;
    }
}