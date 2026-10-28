namespace Dangky
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
            textFullName = new TextBox();
            label2 = new Label();
            mtxtPhone = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkCSharp = new CheckBox();
            chkJava = new CheckBox();
            chkCpp = new CheckBox();
            btnRegister = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 79);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên: ";
            // 
            // textFullName
            // 
            textFullName.Location = new Point(327, 76);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(184, 27);
            textFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 112);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại: ";
            // 
            // mtxtPhone
            // 
            mtxtPhone.HidePromptOnLeave = true;
            mtxtPhone.HideSelection = false;
            mtxtPhone.Location = new Point(327, 109);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(184, 27);
            mtxtPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 147);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 178);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Khóa học:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 211);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Giới tính:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(327, 142);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(125, 27);
            dtpBirthDate.TabIndex = 7;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(327, 175);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(125, 28);
            cboCourse.TabIndex = 8;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(327, 209);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 9;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(395, 209);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 10;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(327, 239);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(49, 24);
            chkCSharp.TabIndex = 11;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(327, 269);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(59, 24);
            chkJava.TabIndex = 12;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Location = new Point(327, 299);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(60, 24);
            chkCpp.TabIndex = 13;
            chkCpp.Text = "C++";
            chkCpp.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(327, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 240);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 15;
            label6.Text = "Ngôn ngữ: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(chkCpp);
            Controls.Add(chkJava);
            Controls.Add(chkCSharp);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mtxtPhone);
            Controls.Add(label2);
            Controls.Add(textFullName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textFullName;
        private Label label2;
        private MaskedTextBox mtxtPhone;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkCSharp;
        private CheckBox chkJava;
        private CheckBox chkCpp;
        private Button btnRegister;
        private Label label6;
    }
}
