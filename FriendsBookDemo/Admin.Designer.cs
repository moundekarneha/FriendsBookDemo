
namespace FriendsBookDemo
{
    partial class Admin
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
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.DataGridShowToAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllFriends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShowToAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(638, 32);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 26;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // DataGridShowToAdmin
            // 
            this.DataGridShowToAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridShowToAdmin.Location = new System.Drawing.Point(17, 159);
            this.DataGridShowToAdmin.Name = "DataGridShowToAdmin";
            this.DataGridShowToAdmin.Size = new System.Drawing.Size(686, 153);
            this.DataGridShowToAdmin.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Friends Information";
            // 
            // btnAllFriends
            // 
            this.btnAllFriends.Location = new System.Drawing.Point(17, 125);
            this.btnAllFriends.Name = "btnAllFriends";
            this.btnAllFriends.Size = new System.Drawing.Size(157, 28);
            this.btnAllFriends.TabIndex = 27;
            this.btnAllFriends.Text = "Show All Friends";
            this.btnAllFriends.UseVisualStyleBackColor = true;
            this.btnAllFriends.Click += new System.EventHandler(this.btnAllFriends_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllFriends);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.DataGridShowToAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShowToAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.DataGridView DataGridShowToAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllFriends;
    }
}