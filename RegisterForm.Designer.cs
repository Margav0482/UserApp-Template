namespace UserApp
{
    partial class RegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.registercountrycombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.registeremailbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registercontactbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerdobbox = new System.Windows.Forms.DateTimePicker();
            this.registerlastnamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerfirstnamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerconfirmpasswordbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerpasswordbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerusernamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createaccbutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.registerconfirmpasswordbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.registerpasswordbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.registerusernamebox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Info ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(619, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.registercountrycombobox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.registeremailbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.registercontactbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.registerdobbox);
            this.groupBox2.Controls.Add(this.registerlastnamebox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.registerfirstnamebox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details ";
            // 
            // registercountrycombobox
            // 
            this.registercountrycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registercountrycombobox.FormattingEnabled = true;
            this.registercountrycombobox.Location = new System.Drawing.Point(453, 113);
            this.registercountrycombobox.Name = "registercountrycombobox";
            this.registercountrycombobox.Size = new System.Drawing.Size(176, 29);
            this.registercountrycombobox.TabIndex = 15;
            this.registercountrycombobox.SelectedIndexChanged += new System.EventHandler(this.registercountrycombobox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(354, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Country:";
            // 
            // registeremailbox
            // 
            this.registeremailbox.Location = new System.Drawing.Point(453, 75);
            this.registeremailbox.Name = "registeremailbox";
            this.registeremailbox.Size = new System.Drawing.Size(176, 26);
            this.registeremailbox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(354, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email:";
            // 
            // registercontactbox
            // 
            this.registercontactbox.Location = new System.Drawing.Point(453, 39);
            this.registercontactbox.Name = "registercontactbox";
            this.registercontactbox.Size = new System.Drawing.Size(176, 26);
            this.registercontactbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(354, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contact No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "DOB:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // registerdobbox
            // 
            this.registerdobbox.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerdobbox.Location = new System.Drawing.Point(113, 116);
            this.registerdobbox.Name = "registerdobbox";
            this.registerdobbox.Size = new System.Drawing.Size(176, 23);
            this.registerdobbox.TabIndex = 8;
            // 
            // registerlastnamebox
            // 
            this.registerlastnamebox.Location = new System.Drawing.Point(113, 77);
            this.registerlastnamebox.Name = "registerlastnamebox";
            this.registerlastnamebox.Size = new System.Drawing.Size(176, 26);
            this.registerlastnamebox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name:";
            // 
            // registerfirstnamebox
            // 
            this.registerfirstnamebox.Location = new System.Drawing.Point(113, 39);
            this.registerfirstnamebox.Name = "registerfirstnamebox";
            this.registerfirstnamebox.Size = new System.Drawing.Size(176, 26);
            this.registerfirstnamebox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // registerconfirmpasswordbox
            // 
            this.registerconfirmpasswordbox.Location = new System.Drawing.Point(172, 141);
            this.registerconfirmpasswordbox.Name = "registerconfirmpasswordbox";
            this.registerconfirmpasswordbox.Size = new System.Drawing.Size(176, 26);
            this.registerconfirmpasswordbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password:";
            // 
            // registerpasswordbox
            // 
            this.registerpasswordbox.Location = new System.Drawing.Point(172, 94);
            this.registerpasswordbox.Name = "registerpasswordbox";
            this.registerpasswordbox.Size = new System.Drawing.Size(176, 26);
            this.registerpasswordbox.TabIndex = 5;
            this.registerpasswordbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // registerusernamebox
            // 
            this.registerusernamebox.Location = new System.Drawing.Point(172, 52);
            this.registerusernamebox.Name = "registerusernamebox";
            this.registerusernamebox.Size = new System.Drawing.Size(176, 26);
            this.registerusernamebox.TabIndex = 3;
            this.registerusernamebox.TextChanged += new System.EventHandler(this.registerusernamebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // createaccbutton
            // 
            this.createaccbutton.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createaccbutton.Location = new System.Drawing.Point(570, 424);
            this.createaccbutton.Name = "createaccbutton";
            this.createaccbutton.Size = new System.Drawing.Size(141, 29);
            this.createaccbutton.TabIndex = 1;
            this.createaccbutton.Text = "Create Account";
            this.createaccbutton.UseVisualStyleBackColor = true;
            this.createaccbutton.Click += new System.EventHandler(this.createaccbutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnbutton.Location = new System.Drawing.Point(61, 424);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(141, 29);
            this.returnbutton.TabIndex = 2;
            this.returnbutton.Text = "Return Back";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 474);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.createaccbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registraton";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox registerconfirmpasswordbox;
        private Label label3;
        private TextBox registerpasswordbox;
        private Label label2;
        private TextBox registerusernamebox;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox registerfirstnamebox;
        private Label label4;
        private TextBox registerlastnamebox;
        private Label label5;
        private Label label6;
        private DateTimePicker registerdobbox;
        private Label label9;
        private TextBox registeremailbox;
        private Label label8;
        private TextBox registercontactbox;
        private Label label7;
        private ComboBox registercountrycombobox;
        private Button createaccbutton;
        private Button button1;
        private Button returnbutton;
    }
}