
namespace tataetos
{
    partial class signinFrom
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
            System.Windows.Forms.Label userNameL;
            System.Windows.Forms.Label ServerL;
            System.Windows.Forms.Label databaseL;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signinFrom));
            this.userNameTB = new System.Windows.Forms.RichTextBox();
            this.passwordTB = new System.Windows.Forms.RichTextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.serverTB = new System.Windows.Forms.RichTextBox();
            this.signInB = new System.Windows.Forms.Button();
            this.databaseTB = new System.Windows.Forms.RichTextBox();
            userNameL = new System.Windows.Forms.Label();
            ServerL = new System.Windows.Forms.Label();
            databaseL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameL
            // 
            userNameL.Anchor = System.Windows.Forms.AnchorStyles.None;
            userNameL.AutoSize = true;
            userNameL.BackColor = System.Drawing.Color.Transparent;
            userNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameL.ForeColor = System.Drawing.Color.Gold;
            userNameL.Location = new System.Drawing.Point(21, 117);
            userNameL.Name = "userNameL";
            userNameL.Size = new System.Drawing.Size(105, 24);
            userNameL.TabIndex = 2;
            userNameL.Text = "User Name";
            // 
            // ServerL
            // 
            ServerL.Anchor = System.Windows.Forms.AnchorStyles.None;
            ServerL.AutoSize = true;
            ServerL.BackColor = System.Drawing.Color.Transparent;
            ServerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ServerL.ForeColor = System.Drawing.Color.Gold;
            ServerL.Location = new System.Drawing.Point(21, 56);
            ServerL.Name = "ServerL";
            ServerL.Size = new System.Drawing.Size(65, 24);
            ServerL.TabIndex = 5;
            ServerL.Text = "Server";
            // 
            // userNameTB
            // 
            this.userNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTB.BackColor = System.Drawing.Color.Cornsilk;
            this.userNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.Location = new System.Drawing.Point(132, 117);
            this.userNameTB.Multiline = false;
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(206, 31);
            this.userNameTB.TabIndex = 0;
            this.userNameTB.Text = "yoyo";
            this.userNameTB.MultilineChanged += new System.EventHandler(this.signInB_Click);
            this.userNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverTB_KeyDown);
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTB.BackColor = System.Drawing.Color.Cornsilk;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(132, 178);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(206, 33);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Text = "123456";
            this.passwordTB.MultilineChanged += new System.EventHandler(this.signInB_Click);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverTB_KeyDown);
            // 
            // passwordL
            // 
            this.passwordL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordL.AutoSize = true;
            this.passwordL.BackColor = System.Drawing.Color.Transparent;
            this.passwordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordL.ForeColor = System.Drawing.Color.Gold;
            this.passwordL.Location = new System.Drawing.Point(21, 178);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(92, 24);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password";
            // 
            // serverTB
            // 
            this.serverTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverTB.BackColor = System.Drawing.Color.Cornsilk;
            this.serverTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTB.Location = new System.Drawing.Point(132, 56);
            this.serverTB.Multiline = false;
            this.serverTB.Name = "serverTB";
            this.serverTB.Size = new System.Drawing.Size(206, 31);
            this.serverTB.TabIndex = 4;
            this.serverTB.Text = "DESKTOP-BL4GHI2";
            this.serverTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverTB_KeyDown);
            // 
            // signInB
            // 
            this.signInB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInB.BackColor = System.Drawing.Color.Gold;
            this.signInB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInB.Location = new System.Drawing.Point(132, 298);
            this.signInB.Name = "signInB";
            this.signInB.Size = new System.Drawing.Size(108, 37);
            this.signInB.TabIndex = 7;
            this.signInB.Text = "Sign in";
            this.signInB.UseVisualStyleBackColor = false;
            this.signInB.Click += new System.EventHandler(this.signInB_Click);
            // 
            // databaseL
            // 
            databaseL.Anchor = System.Windows.Forms.AnchorStyles.None;
            databaseL.AutoSize = true;
            databaseL.BackColor = System.Drawing.Color.Transparent;
            databaseL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            databaseL.ForeColor = System.Drawing.Color.Gold;
            databaseL.Location = new System.Drawing.Point(21, 240);
            databaseL.Name = "databaseL";
            databaseL.Size = new System.Drawing.Size(88, 24);
            databaseL.TabIndex = 9;
            databaseL.Text = "Database";
            // 
            // databaseTB
            // 
            this.databaseTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.databaseTB.BackColor = System.Drawing.Color.Cornsilk;
            this.databaseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTB.Location = new System.Drawing.Point(132, 237);
            this.databaseTB.Multiline = false;
            this.databaseTB.Name = "databaseTB";
            this.databaseTB.Size = new System.Drawing.Size(206, 31);
            this.databaseTB.TabIndex = 8;
            this.databaseTB.Text = "Traffic";
            // 
            // signinFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 367);
            this.Controls.Add(databaseL);
            this.Controls.Add(this.databaseTB);
            this.Controls.Add(this.signInB);
            this.Controls.Add(ServerL);
            this.Controls.Add(this.serverTB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(userNameL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signinFrom";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userNameTB;
        private System.Windows.Forms.RichTextBox passwordTB;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.RichTextBox serverTB;
        private System.Windows.Forms.Button signInB;
        private System.Windows.Forms.RichTextBox databaseTB;
    }
}

