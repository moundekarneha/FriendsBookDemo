
namespace FriendsBookDemo
{
    partial class FriendsInformation
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
            this.dataGridFriendsInformation = new System.Windows.Forms.DataGridView();
            this.btnAddFriendInformation = new System.Windows.Forms.Button();
            this.txtMobileNum = new System.Windows.Forms.TextBox();
            this.txtEmilId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendsInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(635, 18);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 36;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // dataGridFriendsInformation
            // 
            this.dataGridFriendsInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFriendsInformation.Location = new System.Drawing.Point(17, 289);
            this.dataGridFriendsInformation.Name = "dataGridFriendsInformation";
            this.dataGridFriendsInformation.Size = new System.Drawing.Size(686, 153);
            this.dataGridFriendsInformation.TabIndex = 35;
            // 
            // btnAddFriendInformation
            // 
            this.btnAddFriendInformation.Location = new System.Drawing.Point(17, 234);
            this.btnAddFriendInformation.Name = "btnAddFriendInformation";
            this.btnAddFriendInformation.Size = new System.Drawing.Size(168, 23);
            this.btnAddFriendInformation.TabIndex = 34;
            this.btnAddFriendInformation.Text = "Add ";
            this.btnAddFriendInformation.UseVisualStyleBackColor = true;
            this.btnAddFriendInformation.Click += new System.EventHandler(this.btnAddFriendInformation_Click);
            // 
            // txtMobileNum
            // 
            this.txtMobileNum.Location = new System.Drawing.Point(189, 161);
            this.txtMobileNum.Name = "txtMobileNum";
            this.txtMobileNum.Size = new System.Drawing.Size(158, 20);
            this.txtMobileNum.TabIndex = 3;
            // 
            // txtEmilId
            // 
            this.txtEmilId.Location = new System.Drawing.Point(189, 133);
            this.txtEmilId.Name = "txtEmilId";
            this.txtEmilId.Size = new System.Drawing.Size(158, 20);
            this.txtEmilId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email Id";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(189, 102);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(158, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(189, 74);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(158, 20);
            this.txtFname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Friends Information";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDOB.Location = new System.Drawing.Point(189, 187);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(158, 20);
            this.dateTimeDOB.TabIndex = 37;
            this.dateTimeDOB.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // FriendsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.dataGridFriendsInformation);
            this.Controls.Add(this.btnAddFriendInformation);
            this.Controls.Add(this.txtMobileNum);
            this.Controls.Add(this.txtEmilId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FriendsInformation";
            this.Text = "FriendsInformation";
            this.Load += new System.EventHandler(this.FriendsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendsInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.DataGridView dataGridFriendsInformation;
        private System.Windows.Forms.Button btnAddFriendInformation;
        private System.Windows.Forms.TextBox txtMobileNum;
        private System.Windows.Forms.TextBox txtEmilId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
    }
}