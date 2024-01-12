namespace REDDIT_CREATE_COMMUNITY_TEST
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
            this.listBoxTC = new System.Windows.Forms.ListBox();
            this.buttonTC1 = new System.Windows.Forms.Button();
            this.buttonTC2 = new System.Windows.Forms.Button();
            this.buttonTC3 = new System.Windows.Forms.Button();
            this.textBoxUName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTC
            // 
            this.listBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTC.FormattingEnabled = true;
            this.listBoxTC.ItemHeight = 20;
            this.listBoxTC.Location = new System.Drawing.Point(12, 12);
            this.listBoxTC.Name = "listBoxTC";
            this.listBoxTC.Size = new System.Drawing.Size(214, 264);
            this.listBoxTC.TabIndex = 0;
            // 
            // buttonTC1
            // 
            this.buttonTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTC1.Location = new System.Drawing.Point(270, 49);
            this.buttonTC1.Name = "buttonTC1";
            this.buttonTC1.Size = new System.Drawing.Size(131, 40);
            this.buttonTC1.TabIndex = 1;
            this.buttonTC1.Text = "Chạy Test Case 1";
            this.buttonTC1.UseVisualStyleBackColor = true;
            this.buttonTC1.Click += new System.EventHandler(this.buttonTC1_Click);
            // 
            // buttonTC2
            // 
            this.buttonTC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTC2.Location = new System.Drawing.Point(270, 115);
            this.buttonTC2.Name = "buttonTC2";
            this.buttonTC2.Size = new System.Drawing.Size(131, 40);
            this.buttonTC2.TabIndex = 1;
            this.buttonTC2.Text = "Chạy Test Case 2";
            this.buttonTC2.UseVisualStyleBackColor = true;
            this.buttonTC2.Click += new System.EventHandler(this.buttonTC2_Click);
            // 
            // buttonTC3
            // 
            this.buttonTC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTC3.Location = new System.Drawing.Point(270, 181);
            this.buttonTC3.Name = "buttonTC3";
            this.buttonTC3.Size = new System.Drawing.Size(131, 40);
            this.buttonTC3.TabIndex = 1;
            this.buttonTC3.Text = "Chạy Test Case 3";
            this.buttonTC3.UseVisualStyleBackColor = true;
            this.buttonTC3.Click += new System.EventHandler(this.buttonTC3_Click);
            // 
            // textBoxUName
            // 
            this.textBoxUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUName.Location = new System.Drawing.Point(12, 316);
            this.textBoxUName.Name = "textBoxUName";
            this.textBoxUName.Size = new System.Drawing.Size(148, 26);
            this.textBoxUName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(9, 290);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(276, 23);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nhập tên subreddit chưa được tạo:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 375);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxUName);
            this.Controls.Add(this.buttonTC3);
            this.Controls.Add(this.buttonTC2);
            this.Controls.Add(this.buttonTC1);
            this.Controls.Add(this.listBoxTC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTC;
        private System.Windows.Forms.Button buttonTC1;
        private System.Windows.Forms.Button buttonTC2;
        private System.Windows.Forms.Button buttonTC3;
        private System.Windows.Forms.TextBox textBoxUName;
        private System.Windows.Forms.Label labelName;
    }
}

