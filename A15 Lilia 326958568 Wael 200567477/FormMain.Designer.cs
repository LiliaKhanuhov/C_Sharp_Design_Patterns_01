namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    partial class Form1
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
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionsComboBox = new System.Windows.Forms.ComboBox();
            this.optionButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.logoutbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.Location = new System.Drawing.Point(12, 12);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(86, 96);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_smallPictureBox.TabIndex = 41;
            this.picture_smallPictureBox.TabStop = false;
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(12, 132);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(109, 173);
            this.dataListBox.TabIndex = 37;
            this.dataListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 447);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(153, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // optionsComboBox
            // 
            this.optionsComboBox.FormattingEnabled = true;
            this.optionsComboBox.Location = new System.Drawing.Point(153, 132);
            this.optionsComboBox.Name = "optionsComboBox";
            this.optionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.optionsComboBox.TabIndex = 61;
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(178, 329);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(75, 23);
            this.optionButton.TabIndex = 62;
            this.optionButton.Text = "ok";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.SearchOkButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(178, 415);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 63;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckOkButton_Click);
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Location = new System.Drawing.Point(127, 378);
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.Size = new System.Drawing.Size(332, 20);
            this.resultMessageTextBox.TabIndex = 66;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(361, 447);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 67;
            this.logoutbutton.Text = "logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 492);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.optionButton);
            this.Controls.Add(this.optionsComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox optionsComboBox;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.Button logoutbutton;
    }
}

