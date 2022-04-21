namespace UserApp
{
    partial class ForgotPass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.confirmnewpassbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newpassbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenumberbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnbackbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitbutton);
            this.groupBox1.Controls.Add(this.exitbutton);
            this.groupBox1.Controls.Add(this.confirmnewpassbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newpassbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phonenumberbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Change ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // submitbutton
            // 
            this.submitbutton.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitbutton.Location = new System.Drawing.Point(226, 196);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(99, 29);
            this.submitbutton.TabIndex = 11;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitbutton.Location = new System.Drawing.Point(425, 26);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(86, 29);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // confirmnewpassbox
            // 
            this.confirmnewpassbox.Location = new System.Drawing.Point(167, 142);
            this.confirmnewpassbox.Name = "confirmnewpassbox";
            this.confirmnewpassbox.Size = new System.Drawing.Size(176, 27);
            this.confirmnewpassbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password:";
            // 
            // newpassbox
            // 
            this.newpassbox.Location = new System.Drawing.Point(167, 93);
            this.newpassbox.Name = "newpassbox";
            this.newpassbox.Size = new System.Drawing.Size(176, 27);
            this.newpassbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password:";
            // 
            // phonenumberbox
            // 
            this.phonenumberbox.Location = new System.Drawing.Point(167, 46);
            this.phonenumberbox.Name = "phonenumberbox";
            this.phonenumberbox.Size = new System.Drawing.Size(176, 27);
            this.phonenumberbox.TabIndex = 5;
            this.phonenumberbox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number:";
            // 
            // returnbackbutton
            // 
            this.returnbackbutton.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnbackbutton.Location = new System.Drawing.Point(42, 288);
            this.returnbackbutton.Name = "returnbackbutton";
            this.returnbackbutton.Size = new System.Drawing.Size(141, 29);
            this.returnbackbutton.TabIndex = 3;
            this.returnbackbutton.Text = "Return Back";
            this.returnbackbutton.UseVisualStyleBackColor = true;
            this.returnbackbutton.Click += new System.EventHandler(this.returnbackbutton_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 338);
            this.Controls.Add(this.returnbackbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForgotPass";
            this.Text = "vv";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox newpassbox;
        private Label label2;
        private TextBox phonenumberbox;
        private Label label1;
        private TextBox confirmnewpassbox;
        private Label label3;
        private Button submitbutton;
        private Button exitbutton;
        private Button returnbackbutton;
    }
}