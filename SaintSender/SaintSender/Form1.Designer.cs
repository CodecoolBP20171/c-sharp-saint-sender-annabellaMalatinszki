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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mailBoxPanel = new System.Windows.Forms.Panel();
            this.messagesTabControl = new System.Windows.Forms.TabControl();
            this.inboxTabPage = new System.Windows.Forms.TabPage();
            this.messagesListView = new System.Windows.Forms.ListView();
            this.sentTabPage = new System.Windows.Forms.TabPage();
            this.sentMessagesListView = new System.Windows.Forms.ListView();
            this.draftTabPage = new System.Windows.Forms.TabPage();
            this.draftsListView = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.spamTabPage = new System.Windows.Forms.TabPage();
            this.spamListView = new System.Windows.Forms.ListView();
            this.trashTabPage = new System.Windows.Forms.TabPage();
            this.trashListView = new System.Windows.Forms.ListView();
            this.letterPicture = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.composeButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.messageBodyPanel = new System.Windows.Forms.Panel();
            this.messageWebBrowser = new System.Windows.Forms.WebBrowser();
            this.messageDetailsPanel = new System.Windows.Forms.Panel();
            this.trashControlPanel = new System.Windows.Forms.Panel();
            this.trashInboxButton = new System.Windows.Forms.Button();
            this.trashDeleteButton = new System.Windows.Forms.Button();
            this.spamControlPanel = new System.Windows.Forms.Panel();
            this.spamInboxButton = new System.Windows.Forms.Button();
            this.spamDeleteButton = new System.Windows.Forms.Button();
            this.sentControlPanel = new System.Windows.Forms.Panel();
            this.sentDeleteButton = new System.Windows.Forms.Button();
            this.draftControlPanel = new System.Windows.Forms.Panel();
            this.draftEditButton = new System.Windows.Forms.Button();
            this.draftDiscardButton = new System.Windows.Forms.Button();
            this.inboxControlPanel = new System.Windows.Forms.Panel();
            this.inboxReplyButton = new System.Windows.Forms.Button();
            this.inboxDeleteButton = new System.Windows.Forms.Button();
            this.inboxSpamButton = new System.Windows.Forms.Button();
            this.labelLabel = new System.Windows.Forms.Label();
            this.subjectContentLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.dateContentLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toContentLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fromContentLabel = new System.Windows.Forms.Label();
            this.searchResultPanel = new System.Windows.Forms.Panel();
            this.searchResultContentLabel = new System.Windows.Forms.Label();
            this.noResultPanel = new System.Windows.Forms.Panel();
            this.noResultLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.noContentPanel = new System.Windows.Forms.Panel();
            this.noContentLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.newMessagePanel = new System.Windows.Forms.Panel();
            this.newSubjectLabel = new System.Windows.Forms.Label();
            this.newToLabel = new System.Windows.Forms.Label();
            this.discardButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.saveDraftButton = new System.Windows.Forms.Button();
            this.newMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mailBoxPanel.SuspendLayout();
            this.messagesTabControl.SuspendLayout();
            this.inboxTabPage.SuspendLayout();
            this.sentTabPage.SuspendLayout();
            this.draftTabPage.SuspendLayout();
            this.spamTabPage.SuspendLayout();
            this.trashTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).BeginInit();
            this.messagePanel.SuspendLayout();
            this.messageBodyPanel.SuspendLayout();
            this.messageDetailsPanel.SuspendLayout();
            this.trashControlPanel.SuspendLayout();
            this.spamControlPanel.SuspendLayout();
            this.sentControlPanel.SuspendLayout();
            this.draftControlPanel.SuspendLayout();
            this.inboxControlPanel.SuspendLayout();
            this.searchResultPanel.SuspendLayout();
            this.noResultPanel.SuspendLayout();
            this.noContentPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.newMessagePanel.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.mailBoxPanel);
            this.splitContainer1.Panel1.Controls.Add(this.letterPicture);
            this.splitContainer1.Panel1.Controls.Add(this.logoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.composeButton);
            this.splitContainer1.Panel1.Controls.Add(this.logoPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.messagePanel);
            this.splitContainer1.Panel2.Controls.Add(this.searchResultPanel);
            this.splitContainer1.Panel2.Controls.Add(this.noContentPanel);
            this.splitContainer1.Panel2.Controls.Add(this.searchPanel);
            this.splitContainer1.Panel2.Controls.Add(this.notificationPanel);
            this.splitContainer1.Panel2.Controls.Add(this.newMessagePanel);
            this.splitContainer1.Size = new System.Drawing.Size(863, 561);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // mailBoxPanel
            // 
            this.mailBoxPanel.Controls.Add(this.messagesTabControl);
            this.mailBoxPanel.Location = new System.Drawing.Point(5, 89);
            this.mailBoxPanel.Name = "mailBoxPanel";
            this.mailBoxPanel.Size = new System.Drawing.Size(230, 477);
            this.mailBoxPanel.TabIndex = 1;
            // 
            // messagesTabControl
            // 
            this.messagesTabControl.Controls.Add(this.inboxTabPage);
            this.messagesTabControl.Controls.Add(this.sentTabPage);
            this.messagesTabControl.Controls.Add(this.draftTabPage);
            this.messagesTabControl.Controls.Add(this.spamTabPage);
            this.messagesTabControl.Controls.Add(this.trashTabPage);
            this.messagesTabControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messagesTabControl.Location = new System.Drawing.Point(0, 4);
            this.messagesTabControl.Name = "messagesTabControl";
            this.messagesTabControl.SelectedIndex = 0;
            this.messagesTabControl.Size = new System.Drawing.Size(230, 449);
            this.messagesTabControl.TabIndex = 4;
            // 
            // inboxTabPage
            // 
            this.inboxTabPage.Controls.Add(this.messagesListView);
            this.inboxTabPage.Location = new System.Drawing.Point(4, 25);
            this.inboxTabPage.Name = "inboxTabPage";
            this.inboxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inboxTabPage.Size = new System.Drawing.Size(222, 420);
            this.inboxTabPage.TabIndex = 0;
            this.inboxTabPage.Text = "Inbox";
            this.inboxTabPage.UseVisualStyleBackColor = true;
            // 
            // messagesListView
            // 
            this.messagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesListView.Location = new System.Drawing.Point(3, 3);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(216, 414);
            this.messagesListView.TabIndex = 0;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.View = System.Windows.Forms.View.SmallIcon;
            this.messagesListView.SelectedIndexChanged += new System.EventHandler(this.messagesListView_SelectedIndexChanged);
            // 
            // sentTabPage
            // 
            this.sentTabPage.Controls.Add(this.sentMessagesListView);
            this.sentTabPage.Location = new System.Drawing.Point(4, 25);
            this.sentTabPage.Name = "sentTabPage";
            this.sentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sentTabPage.Size = new System.Drawing.Size(222, 420);
            this.sentTabPage.TabIndex = 1;
            this.sentTabPage.Text = "Sent";
            this.sentTabPage.UseVisualStyleBackColor = true;
            // 
            // sentMessagesListView
            // 
            this.sentMessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentMessagesListView.Location = new System.Drawing.Point(3, 3);
            this.sentMessagesListView.Name = "sentMessagesListView";
            this.sentMessagesListView.Size = new System.Drawing.Size(216, 414);
            this.sentMessagesListView.TabIndex = 0;
            this.sentMessagesListView.UseCompatibleStateImageBehavior = false;
            this.sentMessagesListView.View = System.Windows.Forms.View.SmallIcon;
            this.sentMessagesListView.SelectedIndexChanged += new System.EventHandler(this.sentMessagesListView_SelectedIndexChanged);
            // 
            // draftTabPage
            // 
            this.draftTabPage.Controls.Add(this.draftsListView);
            this.draftTabPage.Controls.Add(this.listView2);
            this.draftTabPage.Location = new System.Drawing.Point(4, 25);
            this.draftTabPage.Name = "draftTabPage";
            this.draftTabPage.Size = new System.Drawing.Size(222, 420);
            this.draftTabPage.TabIndex = 2;
            this.draftTabPage.Text = "Draft";
            this.draftTabPage.UseVisualStyleBackColor = true;
            // 
            // draftsListView
            // 
            this.draftsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draftsListView.Location = new System.Drawing.Point(0, 0);
            this.draftsListView.Name = "draftsListView";
            this.draftsListView.Size = new System.Drawing.Size(222, 420);
            this.draftsListView.TabIndex = 1;
            this.draftsListView.UseCompatibleStateImageBehavior = false;
            this.draftsListView.View = System.Windows.Forms.View.SmallIcon;
            this.draftsListView.SelectedIndexChanged += new System.EventHandler(this.draftsListView_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(222, 420);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // spamTabPage
            // 
            this.spamTabPage.Controls.Add(this.spamListView);
            this.spamTabPage.Location = new System.Drawing.Point(4, 25);
            this.spamTabPage.Name = "spamTabPage";
            this.spamTabPage.Size = new System.Drawing.Size(222, 420);
            this.spamTabPage.TabIndex = 3;
            this.spamTabPage.Text = "Spam";
            this.spamTabPage.UseVisualStyleBackColor = true;
            // 
            // spamListView
            // 
            this.spamListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spamListView.Location = new System.Drawing.Point(0, 0);
            this.spamListView.Name = "spamListView";
            this.spamListView.Size = new System.Drawing.Size(222, 420);
            this.spamListView.TabIndex = 0;
            this.spamListView.UseCompatibleStateImageBehavior = false;
            this.spamListView.View = System.Windows.Forms.View.SmallIcon;
            this.spamListView.SelectedIndexChanged += new System.EventHandler(this.spamListView_SelectedIndexChanged);
            // 
            // trashTabPage
            // 
            this.trashTabPage.Controls.Add(this.trashListView);
            this.trashTabPage.Location = new System.Drawing.Point(4, 25);
            this.trashTabPage.Name = "trashTabPage";
            this.trashTabPage.Size = new System.Drawing.Size(222, 420);
            this.trashTabPage.TabIndex = 4;
            this.trashTabPage.Text = "Trash";
            this.trashTabPage.UseVisualStyleBackColor = true;
            // 
            // trashListView
            // 
            this.trashListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trashListView.Location = new System.Drawing.Point(0, 0);
            this.trashListView.Name = "trashListView";
            this.trashListView.Size = new System.Drawing.Size(222, 420);
            this.trashListView.TabIndex = 0;
            this.trashListView.UseCompatibleStateImageBehavior = false;
            this.trashListView.View = System.Windows.Forms.View.SmallIcon;
            this.trashListView.SelectedIndexChanged += new System.EventHandler(this.trashListView_SelectedIndexChanged);
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
            // composeButton
            // 
            this.composeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.composeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.composeButton.ForeColor = System.Drawing.Color.White;
            this.composeButton.Location = new System.Drawing.Point(11, 49);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(210, 38);
            this.composeButton.TabIndex = 1;
            this.composeButton.Text = "Compose";
            this.composeButton.UseVisualStyleBackColor = false;
            this.composeButton.Click += new System.EventHandler(this.composeButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Location = new System.Drawing.Point(9, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(212, 42);
            this.logoPanel.TabIndex = 5;
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.messageBodyPanel);
            this.messagePanel.Controls.Add(this.messageDetailsPanel);
            this.messagePanel.Location = new System.Drawing.Point(5, 50);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(600, 510);
            this.messagePanel.TabIndex = 0;
            // 
            // messageBodyPanel
            // 
            this.messageBodyPanel.Controls.Add(this.messageWebBrowser);
            this.messageBodyPanel.Location = new System.Drawing.Point(3, 114);
            this.messageBodyPanel.Name = "messageBodyPanel";
            this.messageBodyPanel.Size = new System.Drawing.Size(593, 406);
            this.messageBodyPanel.TabIndex = 16;
            // 
            // messageWebBrowser
            // 
            this.messageWebBrowser.Location = new System.Drawing.Point(4, 3);
            this.messageWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.messageWebBrowser.Name = "messageWebBrowser";
            this.messageWebBrowser.Size = new System.Drawing.Size(592, 399);
            this.messageWebBrowser.TabIndex = 4;
            // 
            // messageDetailsPanel
            // 
            this.messageDetailsPanel.Controls.Add(this.trashControlPanel);
            this.messageDetailsPanel.Controls.Add(this.spamControlPanel);
            this.messageDetailsPanel.Controls.Add(this.sentControlPanel);
            this.messageDetailsPanel.Controls.Add(this.draftControlPanel);
            this.messageDetailsPanel.Controls.Add(this.inboxControlPanel);
            this.messageDetailsPanel.Controls.Add(this.labelLabel);
            this.messageDetailsPanel.Controls.Add(this.subjectContentLabel);
            this.messageDetailsPanel.Controls.Add(this.fromLabel);
            this.messageDetailsPanel.Controls.Add(this.dateContentLabel);
            this.messageDetailsPanel.Controls.Add(this.toLabel);
            this.messageDetailsPanel.Controls.Add(this.toContentLabel);
            this.messageDetailsPanel.Controls.Add(this.dateLabel);
            this.messageDetailsPanel.Controls.Add(this.fromContentLabel);
            this.messageDetailsPanel.Location = new System.Drawing.Point(3, 4);
            this.messageDetailsPanel.Name = "messageDetailsPanel";
            this.messageDetailsPanel.Size = new System.Drawing.Size(593, 107);
            this.messageDetailsPanel.TabIndex = 14;
            // 
            // trashControlPanel
            // 
            this.trashControlPanel.Controls.Add(this.trashInboxButton);
            this.trashControlPanel.Controls.Add(this.trashDeleteButton);
            this.trashControlPanel.Location = new System.Drawing.Point(466, 26);
            this.trashControlPanel.Name = "trashControlPanel";
            this.trashControlPanel.Size = new System.Drawing.Size(118, 70);
            this.trashControlPanel.TabIndex = 21;
            // 
            // trashInboxButton
            // 
            this.trashInboxButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trashInboxButton.Location = new System.Drawing.Point(3, 2);
            this.trashInboxButton.Name = "trashInboxButton";
            this.trashInboxButton.Size = new System.Drawing.Size(75, 23);
            this.trashInboxButton.TabIndex = 16;
            this.trashInboxButton.Text = "Inbox";
            this.trashInboxButton.UseVisualStyleBackColor = true;
            this.trashInboxButton.Click += new System.EventHandler(this.trashInboxButton_Click);
            // 
            // trashDeleteButton
            // 
            this.trashDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trashDeleteButton.Location = new System.Drawing.Point(3, 27);
            this.trashDeleteButton.Name = "trashDeleteButton";
            this.trashDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.trashDeleteButton.TabIndex = 15;
            this.trashDeleteButton.Text = "Delete";
            this.trashDeleteButton.UseVisualStyleBackColor = true;
            this.trashDeleteButton.Click += new System.EventHandler(this.trashDeleteButton_Click);
            // 
            // spamControlPanel
            // 
            this.spamControlPanel.Controls.Add(this.spamInboxButton);
            this.spamControlPanel.Controls.Add(this.spamDeleteButton);
            this.spamControlPanel.Location = new System.Drawing.Point(466, 26);
            this.spamControlPanel.Name = "spamControlPanel";
            this.spamControlPanel.Size = new System.Drawing.Size(118, 70);
            this.spamControlPanel.TabIndex = 20;
            // 
            // spamInboxButton
            // 
            this.spamInboxButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spamInboxButton.Location = new System.Drawing.Point(3, 0);
            this.spamInboxButton.Name = "spamInboxButton";
            this.spamInboxButton.Size = new System.Drawing.Size(75, 23);
            this.spamInboxButton.TabIndex = 15;
            this.spamInboxButton.Text = "Inbox";
            this.spamInboxButton.UseVisualStyleBackColor = true;
            this.spamInboxButton.Click += new System.EventHandler(this.spamInboxButton_Click);
            // 
            // spamDeleteButton
            // 
            this.spamDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spamDeleteButton.Location = new System.Drawing.Point(3, 24);
            this.spamDeleteButton.Name = "spamDeleteButton";
            this.spamDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.spamDeleteButton.TabIndex = 17;
            this.spamDeleteButton.Text = "Delete";
            this.spamDeleteButton.UseVisualStyleBackColor = true;
            this.spamDeleteButton.Click += new System.EventHandler(this.spamDeleteButton_Click);
            // 
            // sentControlPanel
            // 
            this.sentControlPanel.Controls.Add(this.sentDeleteButton);
            this.sentControlPanel.Location = new System.Drawing.Point(466, 26);
            this.sentControlPanel.Name = "sentControlPanel";
            this.sentControlPanel.Size = new System.Drawing.Size(118, 70);
            this.sentControlPanel.TabIndex = 20;
            // 
            // sentDeleteButton
            // 
            this.sentDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sentDeleteButton.Location = new System.Drawing.Point(3, 0);
            this.sentDeleteButton.Name = "sentDeleteButton";
            this.sentDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.sentDeleteButton.TabIndex = 15;
            this.sentDeleteButton.Text = "Delete";
            this.sentDeleteButton.UseVisualStyleBackColor = true;
            this.sentDeleteButton.Click += new System.EventHandler(this.sentDeleteButton_Click);
            // 
            // draftControlPanel
            // 
            this.draftControlPanel.Controls.Add(this.draftEditButton);
            this.draftControlPanel.Controls.Add(this.draftDiscardButton);
            this.draftControlPanel.Location = new System.Drawing.Point(466, 26);
            this.draftControlPanel.Name = "draftControlPanel";
            this.draftControlPanel.Size = new System.Drawing.Size(118, 70);
            this.draftControlPanel.TabIndex = 19;
            // 
            // draftEditButton
            // 
            this.draftEditButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draftEditButton.Location = new System.Drawing.Point(3, 0);
            this.draftEditButton.Name = "draftEditButton";
            this.draftEditButton.Size = new System.Drawing.Size(75, 23);
            this.draftEditButton.TabIndex = 15;
            this.draftEditButton.Text = "Edit";
            this.draftEditButton.UseVisualStyleBackColor = true;
            this.draftEditButton.Click += new System.EventHandler(this.draftEditButton_Click);
            // 
            // draftDiscardButton
            // 
            this.draftDiscardButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draftDiscardButton.Location = new System.Drawing.Point(3, 24);
            this.draftDiscardButton.Name = "draftDiscardButton";
            this.draftDiscardButton.Size = new System.Drawing.Size(75, 23);
            this.draftDiscardButton.TabIndex = 17;
            this.draftDiscardButton.Text = "Discard";
            this.draftDiscardButton.UseVisualStyleBackColor = true;
            this.draftDiscardButton.Click += new System.EventHandler(this.draftDiscardButton_Click);
            // 
            // inboxControlPanel
            // 
            this.inboxControlPanel.Controls.Add(this.inboxReplyButton);
            this.inboxControlPanel.Controls.Add(this.inboxDeleteButton);
            this.inboxControlPanel.Controls.Add(this.inboxSpamButton);
            this.inboxControlPanel.Location = new System.Drawing.Point(466, 26);
            this.inboxControlPanel.Name = "inboxControlPanel";
            this.inboxControlPanel.Size = new System.Drawing.Size(118, 70);
            this.inboxControlPanel.TabIndex = 18;
            // 
            // inboxReplyButton
            // 
            this.inboxReplyButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inboxReplyButton.Location = new System.Drawing.Point(3, 0);
            this.inboxReplyButton.Name = "inboxReplyButton";
            this.inboxReplyButton.Size = new System.Drawing.Size(75, 23);
            this.inboxReplyButton.TabIndex = 15;
            this.inboxReplyButton.Text = "Reply";
            this.inboxReplyButton.UseVisualStyleBackColor = true;
            this.inboxReplyButton.Click += new System.EventHandler(this.inboxReplyButton_Click);
            // 
            // inboxDeleteButton
            // 
            this.inboxDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inboxDeleteButton.Location = new System.Drawing.Point(3, 47);
            this.inboxDeleteButton.Name = "inboxDeleteButton";
            this.inboxDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.inboxDeleteButton.TabIndex = 17;
            this.inboxDeleteButton.Text = "Delete";
            this.inboxDeleteButton.UseVisualStyleBackColor = true;
            this.inboxDeleteButton.Click += new System.EventHandler(this.inboxDeleteButton_Click);
            // 
            // inboxSpamButton
            // 
            this.inboxSpamButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inboxSpamButton.Location = new System.Drawing.Point(3, 24);
            this.inboxSpamButton.Name = "inboxSpamButton";
            this.inboxSpamButton.Size = new System.Drawing.Size(75, 23);
            this.inboxSpamButton.TabIndex = 16;
            this.inboxSpamButton.Text = "Spam";
            this.inboxSpamButton.UseVisualStyleBackColor = true;
            this.inboxSpamButton.Click += new System.EventHandler(this.inboxSpamButton_Click);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLabel.Location = new System.Drawing.Point(466, 5);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(45, 16);
            this.labelLabel.TabIndex = 14;
            this.labelLabel.Text = "label1";
            // 
            // subjectContentLabel
            // 
            this.subjectContentLabel.AutoSize = true;
            this.subjectContentLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectContentLabel.Location = new System.Drawing.Point(3, 5);
            this.subjectContentLabel.Name = "subjectContentLabel";
            this.subjectContentLabel.Size = new System.Drawing.Size(40, 15);
            this.subjectContentLabel.TabIndex = 5;
            this.subjectContentLabel.Text = "label1";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromLabel.Location = new System.Drawing.Point(20, 30);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(36, 16);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "From:";
            // 
            // dateContentLabel
            // 
            this.dateContentLabel.AutoSize = true;
            this.dateContentLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateContentLabel.Location = new System.Drawing.Point(66, 56);
            this.dateContentLabel.Name = "dateContentLabel";
            this.dateContentLabel.Size = new System.Drawing.Size(41, 16);
            this.dateContentLabel.TabIndex = 11;
            this.dateContentLabel.Text = "label2";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toLabel.Location = new System.Drawing.Point(20, 43);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 16);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "To:";
            // 
            // toContentLabel
            // 
            this.toContentLabel.AutoSize = true;
            this.toContentLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toContentLabel.Location = new System.Drawing.Point(66, 43);
            this.toContentLabel.Name = "toContentLabel";
            this.toContentLabel.Size = new System.Drawing.Size(41, 16);
            this.toContentLabel.TabIndex = 13;
            this.toContentLabel.Text = "label4";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Location = new System.Drawing.Point(20, 56);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 16);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date:";
            // 
            // fromContentLabel
            // 
            this.fromContentLabel.AutoSize = true;
            this.fromContentLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromContentLabel.Location = new System.Drawing.Point(66, 30);
            this.fromContentLabel.Name = "fromContentLabel";
            this.fromContentLabel.Size = new System.Drawing.Size(41, 16);
            this.fromContentLabel.TabIndex = 12;
            this.fromContentLabel.Text = "label3";
            // 
            // searchResultPanel
            // 
            this.searchResultPanel.Controls.Add(this.searchResultContentLabel);
            this.searchResultPanel.Controls.Add(this.noResultPanel);
            this.searchResultPanel.Controls.Add(this.resultListView);
            this.searchResultPanel.Controls.Add(this.searchResultLabel);
            this.searchResultPanel.Location = new System.Drawing.Point(5, 50);
            this.searchResultPanel.Name = "searchResultPanel";
            this.searchResultPanel.Size = new System.Drawing.Size(600, 510);
            this.searchResultPanel.TabIndex = 19;
            // 
            // searchResultContentLabel
            // 
            this.searchResultContentLabel.AutoSize = true;
            this.searchResultContentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchResultContentLabel.Location = new System.Drawing.Point(131, 4);
            this.searchResultContentLabel.Name = "searchResultContentLabel";
            this.searchResultContentLabel.Size = new System.Drawing.Size(54, 18);
            this.searchResultContentLabel.TabIndex = 5;
            this.searchResultContentLabel.Text = "label1";
            // 
            // noResultPanel
            // 
            this.noResultPanel.Controls.Add(this.noResultLabel);
            this.noResultPanel.Location = new System.Drawing.Point(76, 207);
            this.noResultPanel.Name = "noResultPanel";
            this.noResultPanel.Size = new System.Drawing.Size(460, 118);
            this.noResultPanel.TabIndex = 4;
            // 
            // noResultLabel
            // 
            this.noResultLabel.AutoSize = true;
            this.noResultLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noResultLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.noResultLabel.Location = new System.Drawing.Point(41, 48);
            this.noResultLabel.Name = "noResultLabel";
            this.noResultLabel.Size = new System.Drawing.Size(403, 25);
            this.noResultLabel.TabIndex = 3;
            this.noResultLabel.Text = "Sorry, no matching emails were found.";
            // 
            // resultListView
            // 
            this.resultListView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultListView.Location = new System.Drawing.Point(7, 32);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(587, 453);
            this.resultListView.TabIndex = 2;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.List;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListView_SelectedIndexChanged);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchResultLabel.Location = new System.Drawing.Point(4, 4);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(135, 18);
            this.searchResultLabel.TabIndex = 0;
            this.searchResultLabel.Text = "Search results for ";
            // 
            // noContentPanel
            // 
            this.noContentPanel.Controls.Add(this.noContentLabel);
            this.noContentPanel.Location = new System.Drawing.Point(76, 207);
            this.noContentPanel.Name = "noContentPanel";
            this.noContentPanel.Size = new System.Drawing.Size(460, 118);
            this.noContentPanel.TabIndex = 16;
            // 
            // noContentLabel
            // 
            this.noContentLabel.AutoSize = true;
            this.noContentLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noContentLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.noContentLabel.Location = new System.Drawing.Point(41, 48);
            this.noContentLabel.Name = "noContentLabel";
            this.noContentLabel.Size = new System.Drawing.Size(372, 25);
            this.noContentLabel.TabIndex = 0;
            this.noContentLabel.Text = "Nothing to show. Select a message.";
            this.noContentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Location = new System.Drawing.Point(3, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(599, 33);
            this.searchPanel.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(505, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(486, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // notificationPanel
            // 
            this.notificationPanel.Controls.Add(this.notificationLabel);
            this.notificationPanel.Location = new System.Drawing.Point(5, 50);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(600, 30);
            this.notificationPanel.TabIndex = 18;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.notificationLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notificationLabel.Location = new System.Drawing.Point(6, 8);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(49, 16);
            this.notificationLabel.TabIndex = 0;
            this.notificationLabel.Text = "label1";
            // 
            // newMessagePanel
            // 
            this.newMessagePanel.Controls.Add(this.newSubjectLabel);
            this.newMessagePanel.Controls.Add(this.newToLabel);
            this.newMessagePanel.Controls.Add(this.discardButton);
            this.newMessagePanel.Controls.Add(this.subjectTextBox);
            this.newMessagePanel.Controls.Add(this.toTextBox);
            this.newMessagePanel.Controls.Add(this.sendButton);
            this.newMessagePanel.Controls.Add(this.saveDraftButton);
            this.newMessagePanel.Controls.Add(this.newMessageRichTextBox);
            this.newMessagePanel.Location = new System.Drawing.Point(5, 50);
            this.newMessagePanel.Name = "newMessagePanel";
            this.newMessagePanel.Size = new System.Drawing.Size(600, 510);
            this.newMessagePanel.TabIndex = 17;
            this.newMessagePanel.Visible = false;
            // 
            // newSubjectLabel
            // 
            this.newSubjectLabel.AutoSize = true;
            this.newSubjectLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSubjectLabel.Location = new System.Drawing.Point(3, 36);
            this.newSubjectLabel.Name = "newSubjectLabel";
            this.newSubjectLabel.Size = new System.Drawing.Size(52, 16);
            this.newSubjectLabel.TabIndex = 7;
            this.newSubjectLabel.Text = "Subject:";
            // 
            // newToLabel
            // 
            this.newToLabel.AutoSize = true;
            this.newToLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newToLabel.Location = new System.Drawing.Point(3, 18);
            this.newToLabel.Name = "newToLabel";
            this.newToLabel.Size = new System.Drawing.Size(23, 16);
            this.newToLabel.TabIndex = 6;
            this.newToLabel.Text = "To:";
            // 
            // discardButton
            // 
            this.discardButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discardButton.Location = new System.Drawing.Point(98, 463);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(75, 23);
            this.discardButton.TabIndex = 5;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectTextBox.Location = new System.Drawing.Point(55, 34);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(532, 21);
            this.subjectTextBox.TabIndex = 4;
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toTextBox.ForeColor = System.Drawing.Color.Black;
            this.toTextBox.Location = new System.Drawing.Point(55, 11);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(532, 21);
            this.toTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.SteelBlue;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(496, 453);
            this.sendButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(91, 32);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // saveDraftButton
            // 
            this.saveDraftButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveDraftButton.Location = new System.Drawing.Point(3, 463);
            this.saveDraftButton.Name = "saveDraftButton";
            this.saveDraftButton.Size = new System.Drawing.Size(89, 23);
            this.saveDraftButton.TabIndex = 1;
            this.saveDraftButton.Text = "Save as Draft";
            this.saveDraftButton.UseVisualStyleBackColor = true;
            this.saveDraftButton.Click += new System.EventHandler(this.saveDraftButton_Click);
            // 
            // newMessageRichTextBox
            // 
            this.newMessageRichTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newMessageRichTextBox.Location = new System.Drawing.Point(3, 67);
            this.newMessageRichTextBox.Name = "newMessageRichTextBox";
            this.newMessageRichTextBox.Size = new System.Drawing.Size(587, 384);
            this.newMessageRichTextBox.TabIndex = 0;
            this.newMessageRichTextBox.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mailBoxPanel.ResumeLayout(false);
            this.messagesTabControl.ResumeLayout(false);
            this.inboxTabPage.ResumeLayout(false);
            this.sentTabPage.ResumeLayout(false);
            this.draftTabPage.ResumeLayout(false);
            this.spamTabPage.ResumeLayout(false);
            this.trashTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.letterPicture)).EndInit();
            this.messagePanel.ResumeLayout(false);
            this.messageBodyPanel.ResumeLayout(false);
            this.messageDetailsPanel.ResumeLayout(false);
            this.messageDetailsPanel.PerformLayout();
            this.trashControlPanel.ResumeLayout(false);
            this.spamControlPanel.ResumeLayout(false);
            this.sentControlPanel.ResumeLayout(false);
            this.draftControlPanel.ResumeLayout(false);
            this.inboxControlPanel.ResumeLayout(false);
            this.searchResultPanel.ResumeLayout(false);
            this.searchResultPanel.PerformLayout();
            this.noResultPanel.ResumeLayout(false);
            this.noResultPanel.PerformLayout();
            this.noContentPanel.ResumeLayout(false);
            this.noContentPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.newMessagePanel.ResumeLayout(false);
            this.newMessagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox letterPicture;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button composeButton;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TabControl messagesTabControl;
        private System.Windows.Forms.TabPage inboxTabPage;
        private System.Windows.Forms.TabPage sentTabPage;
        private System.Windows.Forms.ListView sentMessagesListView;
        private System.Windows.Forms.TabPage draftTabPage;
        private System.Windows.Forms.TabPage spamTabPage;
        private System.Windows.Forms.TabPage trashTabPage;
        private System.Windows.Forms.WebBrowser messageWebBrowser;
        private System.Windows.Forms.ListView draftsListView;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView spamListView;
        private System.Windows.Forms.ListView trashListView;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label subjectContentLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label toContentLabel;
        private System.Windows.Forms.Label fromContentLabel;
        private System.Windows.Forms.Label dateContentLabel;
        private System.Windows.Forms.Panel mailBoxPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel messageDetailsPanel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel messageBodyPanel;
        private System.Windows.Forms.Label noContentLabel;
        private System.Windows.Forms.Panel noContentPanel;
        private System.Windows.Forms.Panel newMessagePanel;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button saveDraftButton;
        private System.Windows.Forms.RichTextBox newMessageRichTextBox;
        private System.Windows.Forms.Label newSubjectLabel;
        private System.Windows.Forms.Label newToLabel;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel searchResultPanel;
        private System.Windows.Forms.Panel noResultPanel;
        private System.Windows.Forms.Label noResultLabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Label searchResultContentLabel;
        private System.Windows.Forms.Button inboxDeleteButton;
        private System.Windows.Forms.Button inboxSpamButton;
        private System.Windows.Forms.Button inboxReplyButton;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Panel draftControlPanel;
        private System.Windows.Forms.Button draftEditButton;
        private System.Windows.Forms.Button draftDiscardButton;
        private System.Windows.Forms.Panel inboxControlPanel;
        private System.Windows.Forms.Panel trashControlPanel;
        private System.Windows.Forms.Button trashDeleteButton;
        private System.Windows.Forms.Panel spamControlPanel;
        private System.Windows.Forms.Button spamInboxButton;
        private System.Windows.Forms.Button spamDeleteButton;
        private System.Windows.Forms.Panel sentControlPanel;
        private System.Windows.Forms.Button sentDeleteButton;
        private System.Windows.Forms.Button trashInboxButton;
    }
}

