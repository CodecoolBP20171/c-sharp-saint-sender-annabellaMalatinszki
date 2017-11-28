namespace SaintSender
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Inbox", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Sent", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Spam", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Trash", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.messageListView = new System.Windows.Forms.ListView();
            this.composeButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.letterPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.letterPicture);
            this.splitContainer1.Panel1.Controls.Add(this.logoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.composeButton);
            this.splitContainer1.Panel1.Controls.Add(this.messageListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchButton);
            this.splitContainer1.Panel2.Controls.Add(this.messageTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.searchTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(739, 495);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // messageListView
            // 
            listViewGroup1.Header = "Inbox";
            listViewGroup1.Name = "inbox";
            listViewGroup2.Header = "Sent";
            listViewGroup2.Name = "sent";
            listViewGroup3.Header = "Spam";
            listViewGroup3.Name = "spam";
            listViewGroup4.Header = "Trash";
            listViewGroup4.Name = "trash";
            this.messageListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.messageListView.Location = new System.Drawing.Point(4, 93);
            this.messageListView.Name = "messageListView";
            this.messageListView.Size = new System.Drawing.Size(239, 402);
            this.messageListView.TabIndex = 0;
            this.messageListView.UseCompatibleStateImageBehavior = false;
            this.messageListView.View = System.Windows.Forms.View.List;
            // 
            // composeButton
            // 
            this.composeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.composeButton.Location = new System.Drawing.Point(4, 49);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(239, 38);
            this.composeButton.TabIndex = 1;
            this.composeButton.Text = "Compose";
            this.composeButton.UseVisualStyleBackColor = true;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(79, 19);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(118, 22);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "SaintSender";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(4, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(376, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(4, 49);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(482, 446);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(386, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // letterPicture
            // 
            this.letterPicture.ImageLocation = "C:\\Users\\amala\\Documents\\Codecool\\C#\\TW_assignments\\c-sharp-saint-sender-annabell" +
    "aMalatinszki\\SaintSender\\letter.png";
            this.letterPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("letterPicture.InitialImage")));
            this.letterPicture.Location = new System.Drawing.Point(32, 13);
            this.letterPicture.Name = "letterPicture";
            this.letterPicture.Size = new System.Drawing.Size(41, 30);
            this.letterPicture.TabIndex = 3;
            this.letterPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox letterPicture;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button composeButton;
        private System.Windows.Forms.ListView messageListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

