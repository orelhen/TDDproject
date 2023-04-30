﻿
namespace WindowsFormsTdd
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
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.GradesLabels = new System.Windows.Forms.Label();
            this.MathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnglishTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HebrewTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhysicsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwereTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentView1 = new System.Windows.Forms.ListView();
            this.ממוצע = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.תכנות = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.פיזיקה = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.לשון = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.אנגלית = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.מתמטיקה = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.טלפון = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.אימייל = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.תעודתזהות = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.שםמלא = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addRandomBtn = new System.Windows.Forms.Button();
            this.errorlable = new System.Windows.Forms.Label();
            this.cleanbtn = new System.Windows.Forms.Button();
            this.NameErrorLable = new System.Windows.Forms.Label();
            this.LastNameErrorLable = new System.Windows.Forms.Label();
            this.IDErrorLable = new System.Windows.Forms.Label();
            this.EmailErrorLable = new System.Windows.Forms.Label();
            this.PhoneErrorLable = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.GradesErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(1042, 906);
            this.AddStudentBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(300, 125);
            this.AddStudentBtn.TabIndex = 0;
            this.AddStudentBtn.Text = "הוספת סטודנט";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(2582, 154);
            this.StudentName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(88, 25);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "שם פרטי";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(2214, 148);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(316, 31);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(2214, 225);
            this.LastNameTxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(316, 31);
            this.LastNameTxtBox.TabIndex = 3;
            this.LastNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2582, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "שם משפחה";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(2214, 302);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(316, 31);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(2574, 308);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(116, 25);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "תעודת זהות";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(2214, 379);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(316, 31);
            this.EmailTextBox.TabIndex = 7;
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.Location = new System.Drawing.Point(2582, 385);
            this.EmailTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(112, 25);
            this.EmailTextLabel.TabIndex = 8;
            this.EmailTextLabel.Text = "כתובת מייל";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(2214, 458);
            this.PhoneNumTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(316, 31);
            this.PhoneNumTextBox.TabIndex = 9;
            this.PhoneNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(2574, 462);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(129, 25);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "מספר פלאפון";
            // 
            // GradesLabels
            // 
            this.GradesLabels.AutoSize = true;
            this.GradesLabels.Location = new System.Drawing.Point(2464, 594);
            this.GradesLabels.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GradesLabels.Name = "GradesLabels";
            this.GradesLabels.Size = new System.Drawing.Size(135, 25);
            this.GradesLabels.TabIndex = 11;
            this.GradesLabels.Text = "ציוני הסטודנט";
            this.GradesLabels.Click += new System.EventHandler(this.GradesLabels_Click);
            // 
            // MathTextBox
            // 
            this.MathTextBox.Location = new System.Drawing.Point(2200, 642);
            this.MathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MathTextBox.Name = "MathTextBox";
            this.MathTextBox.Size = new System.Drawing.Size(96, 31);
            this.MathTextBox.TabIndex = 12;
            this.MathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2346, 648);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "מתמטיקה";
            // 
            // EnglishTextBox
            // 
            this.EnglishTextBox.Location = new System.Drawing.Point(2200, 719);
            this.EnglishTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EnglishTextBox.Name = "EnglishTextBox";
            this.EnglishTextBox.Size = new System.Drawing.Size(96, 31);
            this.EnglishTextBox.TabIndex = 14;
            this.EnglishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2346, 725);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "אנגלית";
            // 
            // HebrewTextBox
            // 
            this.HebrewTextBox.Location = new System.Drawing.Point(2200, 796);
            this.HebrewTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HebrewTextBox.Name = "HebrewTextBox";
            this.HebrewTextBox.Size = new System.Drawing.Size(96, 31);
            this.HebrewTextBox.TabIndex = 16;
            this.HebrewTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2352, 802);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "לשון";
            // 
            // PhysicsTextBox
            // 
            this.PhysicsTextBox.Location = new System.Drawing.Point(2200, 873);
            this.PhysicsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PhysicsTextBox.Name = "PhysicsTextBox";
            this.PhysicsTextBox.Size = new System.Drawing.Size(96, 31);
            this.PhysicsTextBox.TabIndex = 18;
            this.PhysicsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2346, 879);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "פיזיקה";
            // 
            // SoftwereTextBox
            // 
            this.SoftwereTextBox.Location = new System.Drawing.Point(2200, 950);
            this.SoftwereTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SoftwereTextBox.Name = "SoftwereTextBox";
            this.SoftwereTextBox.Size = new System.Drawing.Size(96, 31);
            this.SoftwereTextBox.TabIndex = 20;
            this.SoftwereTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2352, 956);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "תכנות";
            // 
            // StudentView1
            // 
            this.StudentView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ממוצע,
            this.תכנות,
            this.פיזיקה,
            this.לשון,
            this.אנגלית,
            this.מתמטיקה,
            this.טלפון,
            this.אימייל,
            this.תעודתזהות,
            this.שםמלא});
            this.StudentView1.HideSelection = false;
            this.StudentView1.Location = new System.Drawing.Point(24, 38);
            this.StudentView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StudentView1.Name = "StudentView1";
            this.StudentView1.Size = new System.Drawing.Size(1824, 792);
            this.StudentView1.TabIndex = 22;
            this.StudentView1.UseCompatibleStateImageBehavior = false;
            this.StudentView1.View = System.Windows.Forms.View.Details;
            this.StudentView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ממוצע
            // 
            this.ממוצע.Text = "ממוצע";
            // 
            // תכנות
            // 
            this.תכנות.Text = "תכנות";
            this.תכנות.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // פיזיקה
            // 
            this.פיזיקה.Text = "פיזיקה";
            this.פיזיקה.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // לשון
            // 
            this.לשון.Text = "לשון";
            this.לשון.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // אנגלית
            // 
            this.אנגלית.Text = "אנגלית";
            this.אנגלית.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // מתמטיקה
            // 
            this.מתמטיקה.Text = "מתמטיקה";
            this.מתמטיקה.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // טלפון
            // 
            this.טלפון.Text = "טלפון";
            this.טלפון.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.טלפון.Width = 150;
            // 
            // אימייל
            // 
            this.אימייל.Text = "אימייל";
            this.אימייל.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.אימייל.Width = 150;
            // 
            // תעודתזהות
            // 
            this.תעודתזהות.Text = "תעודת זהות";
            this.תעודתזהות.Width = 150;
            // 
            // שםמלא
            // 
            this.שםמלא.Text = "שם מלא";
            this.שםמלא.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.שםמלא.Width = 100;
            // 
            // addRandomBtn
            // 
            this.addRandomBtn.Location = new System.Drawing.Point(730, 906);
            this.addRandomBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addRandomBtn.Name = "addRandomBtn";
            this.addRandomBtn.Size = new System.Drawing.Size(300, 125);
            this.addRandomBtn.TabIndex = 23;
            this.addRandomBtn.Text = "הוסף 10000 סטודנטים";
            this.addRandomBtn.UseVisualStyleBackColor = true;
            this.addRandomBtn.Click += new System.EventHandler(this.addRandomBtn_Click);
            // 
            // errorlable
            // 
            this.errorlable.AutoSize = true;
            this.errorlable.ForeColor = System.Drawing.Color.Red;
            this.errorlable.Location = new System.Drawing.Point(1054, 875);
            this.errorlable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorlable.Name = "errorlable";
            this.errorlable.Size = new System.Drawing.Size(220, 25);
            this.errorlable.TabIndex = 24;
            this.errorlable.Text = "אנא הכנס נתונים תקינים";
            this.errorlable.Visible = false;
            this.errorlable.Click += new System.EventHandler(this.label7_Click);
            // 
            // cleanbtn
            // 
            this.cleanbtn.Location = new System.Drawing.Point(2580, 935);
            this.cleanbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cleanbtn.Name = "cleanbtn";
            this.cleanbtn.Size = new System.Drawing.Size(184, 54);
            this.cleanbtn.TabIndex = 25;
            this.cleanbtn.Text = "נקה דף";
            this.cleanbtn.UseVisualStyleBackColor = true;
            this.cleanbtn.Click += new System.EventHandler(this.cleanbtn_Click);
            // 
            // NameErrorLable
            // 
            this.NameErrorLable.AutoSize = true;
            this.NameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLable.Location = new System.Drawing.Point(1996, 154);
            this.NameErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameErrorLable.Name = "NameErrorLable";
            this.NameErrorLable.Size = new System.Drawing.Size(173, 25);
            this.NameErrorLable.TabIndex = 26;
            this.NameErrorLable.Text = "אנא הכנס שם תקין";
            this.NameErrorLable.Visible = false;
            // 
            // LastNameErrorLable
            // 
            this.LastNameErrorLable.AutoSize = true;
            this.LastNameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.LastNameErrorLable.Location = new System.Drawing.Point(1916, 231);
            this.LastNameErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastNameErrorLable.Name = "LastNameErrorLable";
            this.LastNameErrorLable.Size = new System.Drawing.Size(244, 25);
            this.LastNameErrorLable.TabIndex = 27;
            this.LastNameErrorLable.Text = "אנא הכנס שם משפחה תקין";
            this.LastNameErrorLable.Visible = false;
            // 
            // IDErrorLable
            // 
            this.IDErrorLable.AutoSize = true;
            this.IDErrorLable.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLable.Location = new System.Drawing.Point(1944, 308);
            this.IDErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IDErrorLable.Name = "IDErrorLable";
            this.IDErrorLable.Size = new System.Drawing.Size(220, 25);
            this.IDErrorLable.TabIndex = 28;
            this.IDErrorLable.Text = "תעודת זהות אינה תקינה";
            this.IDErrorLable.Visible = false;
            // 
            // EmailErrorLable
            // 
            this.EmailErrorLable.AutoSize = true;
            this.EmailErrorLable.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLable.Location = new System.Drawing.Point(1944, 385);
            this.EmailErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmailErrorLable.Name = "EmailErrorLable";
            this.EmailErrorLable.Size = new System.Drawing.Size(216, 25);
            this.EmailErrorLable.TabIndex = 29;
            this.EmailErrorLable.Text = "כתובת מייל אינה תקינה";
            this.EmailErrorLable.Visible = false;
            // 
            // PhoneErrorLable
            // 
            this.PhoneErrorLable.AutoSize = true;
            this.PhoneErrorLable.ForeColor = System.Drawing.Color.Red;
            this.PhoneErrorLable.Location = new System.Drawing.Point(1978, 463);
            this.PhoneErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhoneErrorLable.Name = "PhoneErrorLable";
            this.PhoneErrorLable.Size = new System.Drawing.Size(184, 25);
            this.PhoneErrorLable.TabIndex = 30;
            this.PhoneErrorLable.Text = "מספר נייד אינו תקין";
            this.PhoneErrorLable.Visible = false;
            this.PhoneErrorLable.Click += new System.EventHandler(this.PhoneErrorLable_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(418, 906);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(300, 125);
            this.SortBtn.TabIndex = 31;
            this.SortBtn.Text = "מיין לפי ממוצע";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Visible = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // GradesErrorLabel
            // 
            this.GradesErrorLabel.AutoSize = true;
            this.GradesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.GradesErrorLabel.Location = new System.Drawing.Point(1944, 802);
            this.GradesErrorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GradesErrorLabel.Name = "GradesErrorLabel";
            this.GradesErrorLabel.Size = new System.Drawing.Size(176, 25);
            this.GradesErrorLabel.TabIndex = 32;
            this.GradesErrorLabel.Text = "ציונים אינם תקינים";
            this.GradesErrorLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2848, 1083);
            this.Controls.Add(this.GradesErrorLabel);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.PhoneErrorLable);
            this.Controls.Add(this.EmailErrorLable);
            this.Controls.Add(this.IDErrorLable);
            this.Controls.Add(this.LastNameErrorLable);
            this.Controls.Add(this.NameErrorLable);
            this.Controls.Add(this.cleanbtn);
            this.Controls.Add(this.errorlable);
            this.Controls.Add(this.addRandomBtn);
            this.Controls.Add(this.StudentView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoftwereTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhysicsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HebrewTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnglishTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MathTextBox);
            this.Controls.Add(this.GradesLabels);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneNumTextBox);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.AddStudentBtn);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label GradesLabels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView StudentView1;
        private System.Windows.Forms.ColumnHeader ממוצע;
        private System.Windows.Forms.ColumnHeader תכנות;
        private System.Windows.Forms.ColumnHeader פיזיקה;
        private System.Windows.Forms.ColumnHeader לשון;
        private System.Windows.Forms.Button addRandomBtn;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTxtBox;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox PhoneNumTextBox;
        public System.Windows.Forms.TextBox MathTextBox;
        public System.Windows.Forms.TextBox EnglishTextBox;
        public System.Windows.Forms.TextBox HebrewTextBox;
        public System.Windows.Forms.TextBox PhysicsTextBox;
        public System.Windows.Forms.TextBox SoftwereTextBox;
        private System.Windows.Forms.Label errorlable;
        private System.Windows.Forms.Button cleanbtn;
        private System.Windows.Forms.Label NameErrorLable;
        private System.Windows.Forms.Label LastNameErrorLable;
        private System.Windows.Forms.Label IDErrorLable;
        private System.Windows.Forms.Label EmailErrorLable;
        private System.Windows.Forms.Label PhoneErrorLable;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.ColumnHeader אנגלית;
        private System.Windows.Forms.ColumnHeader מתמטיקה;
        private System.Windows.Forms.ColumnHeader טלפון;
        private System.Windows.Forms.ColumnHeader אימייל;
        private System.Windows.Forms.ColumnHeader תעודתזהות;
        private System.Windows.Forms.ColumnHeader שםמלא;
        private System.Windows.Forms.Label GradesErrorLabel;
    }
}

