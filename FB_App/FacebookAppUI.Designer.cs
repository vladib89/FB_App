namespace FB_App
{
    public partial class FacebookAppUI
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.ListBoxLikedPages = new System.Windows.Forms.ListBox();
            this.LinkLikedPages = new System.Windows.Forms.LinkLabel();
            this.ListBoxCheckins = new System.Windows.Forms.ListBox();
            this.LinkCheckins = new System.Windows.Forms.LinkLabel();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.LinkEvents = new System.Windows.Forms.LinkLabel();
            this.LinkFriends = new System.Windows.Forms.LinkLabel();
            this.ListBoxPosts = new System.Windows.Forms.ListBox();
            this.LinkPosts = new System.Windows.Forms.LinkLabel();
            this.LabelPostStatus = new System.Windows.Forms.Label();
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.ButtonPostStatus = new System.Windows.Forms.Button();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.PaneUpper = new System.Windows.Forms.Panel();
            this.ComboBoxAppID = new System.Windows.Forms.ComboBox();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelFacebook = new System.Windows.Forms.Label();
            this.LabelExplanationAboutDeleteAndAddButton = new System.Windows.Forms.Label();
            this.ButtonCheckPlace = new System.Windows.Forms.Button();
            this.TextBoxPlace = new System.Windows.Forms.TextBox();
            this.LabelPickPlace = new System.Windows.Forms.Label();
            this.ButtonGetRecommendation = new System.Windows.Forms.Button();
            this.ListBoxFriendsToAsk = new System.Windows.Forms.ListBox();
            this.ButtonAddFriensToList = new System.Windows.Forms.Button();
            this.ButtonDeleteFriensFromList = new System.Windows.Forms.Button();
            this.PictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.PictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.ListBoxEventsByMinimumNumberOfParticipants = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelMinimumAttendersNumber = new System.Windows.Forms.Label();
            this.TextBoxMinimumNumber = new System.Windows.Forms.TextBox();
            this.ButtonFindEventsByMinimumAtendees = new System.Windows.Forms.Button();
            this.ListBoxParticipantsOfEvent = new System.Windows.Forms.ListBox();
            this.PictureBoxEventChosenByParticipantsNumber = new System.Windows.Forms.PictureBox();
            this.LabelListOfParticipants = new System.Windows.Forms.Label();
            this.LabelListOfEvents = new System.Windows.Forms.Label();
            this.LabelNumberOfParticipants = new System.Windows.Forms.Label();
            this.TextBoxNumberOfParticipants = new System.Windows.Forms.TextBox();
            this.ButtonClickToAttend = new System.Windows.Forms.Button();
            this.PanelPlaceRecommandations = new System.Windows.Forms.Panel();
            this.LabelAdditionalCheckins = new System.Windows.Forms.Label();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.ListBoxFriendsThatHaveBeenInChosenPlace = new System.Windows.Forms.ListBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelEventsFinderByMinimumAttendees = new System.Windows.Forms.Panel();
            this.ButtonFindEventsByMaximumAtendees = new System.Windows.Forms.Button();
            this.EventInfoTitle = new System.Windows.Forms.Label();
            this.PanelEventInformation = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ListBoxFriends = new System.Windows.Forms.ListBox();
            this.PictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.TextBoxNickname = new System.Windows.Forms.TextBox();
            this.LabelNickname = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.PaneUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLikedPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEventChosenByParticipantsNumber)).BeginInit();
            this.PanelPlaceRecommandations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
            this.PanelEventsFinderByMinimumAttendees.SuspendLayout();
            this.PanelEventInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 20);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(3, 47);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(3, 72);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(3, 125);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // ListBoxLikedPages
            // 
            this.ListBoxLikedPages.FormattingEnabled = true;
            this.ListBoxLikedPages.Location = new System.Drawing.Point(210, 268);
            this.ListBoxLikedPages.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxLikedPages.Name = "ListBoxLikedPages";
            this.ListBoxLikedPages.Size = new System.Drawing.Size(126, 134);
            this.ListBoxLikedPages.TabIndex = 52;
            this.ListBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.ListBoxLikedPages_SelectedIndexChanged);
            // 
            // LinkLikedPages
            // 
            this.LinkLikedPages.AutoSize = true;
            this.LinkLikedPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.LinkLikedPages.Location = new System.Drawing.Point(210, 254);
            this.LinkLikedPages.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LinkLikedPages.Name = "LinkLikedPages";
            this.LinkLikedPages.Size = new System.Drawing.Size(101, 17);
            this.LinkLikedPages.TabIndex = 51;
            this.LinkLikedPages.TabStop = true;
            this.LinkLikedPages.Text = "Fetch Liked Pages ";
            this.LinkLikedPages.UseCompatibleTextRendering = true;
            this.LinkLikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLikedPages_LinkClicked_1);
            // 
            // ListBoxCheckins
            // 
            this.ListBoxCheckins.FormattingEnabled = true;
            this.ListBoxCheckins.Location = new System.Drawing.Point(9, 268);
            this.ListBoxCheckins.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxCheckins.Name = "ListBoxCheckins";
            this.ListBoxCheckins.Size = new System.Drawing.Size(126, 134);
            this.ListBoxCheckins.TabIndex = 50;
            // 
            // LinkCheckins
            // 
            this.LinkCheckins.AutoSize = true;
            this.LinkCheckins.Location = new System.Drawing.Point(4, 254);
            this.LinkCheckins.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LinkCheckins.Name = "LinkCheckins";
            this.LinkCheckins.Size = new System.Drawing.Size(84, 13);
            this.LinkCheckins.TabIndex = 49;
            this.LinkCheckins.TabStop = true;
            this.LinkCheckins.Text = "Fetch Checkins ";
            this.LinkCheckins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCheckins_LinkClicked);
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.Location = new System.Drawing.Point(9, 430);
            this.ListBoxEvents.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(126, 134);
            this.ListBoxEvents.TabIndex = 47;
            this.ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.ListBoxEvents_SelectedIndexChanged);
            // 
            // LinkEvents
            // 
            this.LinkEvents.AutoSize = true;
            this.LinkEvents.Location = new System.Drawing.Point(6, 415);
            this.LinkEvents.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LinkEvents.Name = "LinkEvents";
            this.LinkEvents.Size = new System.Drawing.Size(73, 13);
            this.LinkEvents.TabIndex = 46;
            this.LinkEvents.TabStop = true;
            this.LinkEvents.Text = "Fetch Events ";
            this.LinkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEvents_LinkClicked);
            // 
            // LinkFriends
            // 
            this.LinkFriends.AutoSize = true;
            this.LinkFriends.Location = new System.Drawing.Point(208, 415);
            this.LinkFriends.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LinkFriends.Name = "LinkFriends";
            this.LinkFriends.Size = new System.Drawing.Size(71, 13);
            this.LinkFriends.TabIndex = 43;
            this.LinkFriends.TabStop = true;
            this.LinkFriends.Tag = string.Empty;
            this.LinkFriends.Text = "Fetch Friends";
            this.LinkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFriends_LinkClicked_1);
            // 
            // ListBoxPosts
            // 
            this.ListBoxPosts.FormattingEnabled = true;
            this.ListBoxPosts.Location = new System.Drawing.Point(193, 115);
            this.ListBoxPosts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxPosts.Name = "ListBoxPosts";
            this.ListBoxPosts.Size = new System.Drawing.Size(237, 121);
            this.ListBoxPosts.TabIndex = 42;
            // 
            // LinkPosts
            // 
            this.LinkPosts.AutoSize = true;
            this.LinkPosts.Location = new System.Drawing.Point(191, 100);
            this.LinkPosts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LinkPosts.Name = "LinkPosts";
            this.LinkPosts.Size = new System.Drawing.Size(63, 13);
            this.LinkPosts.TabIndex = 41;
            this.LinkPosts.TabStop = true;
            this.LinkPosts.Text = "Fetch Posts";
            this.LinkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPosts_LinkClicked_1);
            // 
            // LabelPostStatus
            // 
            this.LabelPostStatus.AutoSize = true;
            this.LabelPostStatus.Location = new System.Drawing.Point(191, 72);
            this.LabelPostStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelPostStatus.Name = "LabelPostStatus";
            this.LabelPostStatus.Size = new System.Drawing.Size(64, 13);
            this.LabelPostStatus.TabIndex = 40;
            this.LabelPostStatus.Text = "Post Status:";
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxUser.Location = new System.Drawing.Point(9, 87);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(160, 140);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUser.TabIndex = 39;
            this.PictureBoxUser.TabStop = false;
            // 
            // ButtonPostStatus
            // 
            this.ButtonPostStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonPostStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPostStatus.Location = new System.Drawing.Point(434, 66);
            this.ButtonPostStatus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonPostStatus.Name = "ButtonPostStatus";
            this.ButtonPostStatus.Size = new System.Drawing.Size(64, 27);
            this.ButtonPostStatus.TabIndex = 38;
            this.ButtonPostStatus.Text = "Post";
            this.ButtonPostStatus.UseVisualStyleBackColor = false;
            this.ButtonPostStatus.Click += new System.EventHandler(this.ButtonPostStatus_Click_1);
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(256, 72);
            this.TextBoxStatus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(170, 20);
            this.TextBoxStatus.TabIndex = 37;
            // 
            // PaneUpper
            // 
            this.PaneUpper.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PaneUpper.Controls.Add(this.ComboBoxAppID);
            this.PaneUpper.Controls.Add(this.ButtonLogout);
            this.PaneUpper.Controls.Add(this.ButtonLogin);
            this.PaneUpper.Controls.Add(this.LabelFacebook);
            this.PaneUpper.Location = new System.Drawing.Point(-2, 0);
            this.PaneUpper.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PaneUpper.Name = "PaneUpper";
            this.PaneUpper.Size = new System.Drawing.Size(1261, 64);
            this.PaneUpper.TabIndex = 1;
            // 
            // ComboBoxAppID
            // 
            this.ComboBoxAppID.FormattingEnabled = true;
            this.ComboBoxAppID.Location = new System.Drawing.Point(878, 25);
            this.ComboBoxAppID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ComboBoxAppID.Name = "ComboBoxAppID";
            this.ComboBoxAppID.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxAppID.TabIndex = 86;
            this.ComboBoxAppID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAppID_SelectedIndexChanged_1);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLogout.Enabled = false;
            this.ButtonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLogout.Location = new System.Drawing.Point(1068, 20);
            this.ButtonLogout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(53, 26);
            this.ButtonLogout.TabIndex = 70;
            this.ButtonLogout.Text = "Log Out";
            this.ButtonLogout.UseVisualStyleBackColor = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLogin.Location = new System.Drawing.Point(996, 20);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(45, 26);
            this.ButtonLogin.TabIndex = 70;
            this.ButtonLogin.Text = "Log In";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click_1);
            // 
            // LabelFacebook
            // 
            this.LabelFacebook.AutoSize = true;
            this.LabelFacebook.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFacebook.ForeColor = System.Drawing.Color.White;
            this.LabelFacebook.Location = new System.Drawing.Point(22, 20);
            this.LabelFacebook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFacebook.Name = "LabelFacebook";
            this.LabelFacebook.Size = new System.Drawing.Size(119, 33);
            this.LabelFacebook.TabIndex = 70;
            this.LabelFacebook.Text = "facebook";
            // 
            // LabelExplanationAboutDeleteAndAddButton
            // 
            this.LabelExplanationAboutDeleteAndAddButton.AutoSize = true;
            this.LabelExplanationAboutDeleteAndAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelExplanationAboutDeleteAndAddButton.Location = new System.Drawing.Point(12, 278);
            this.LabelExplanationAboutDeleteAndAddButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelExplanationAboutDeleteAndAddButton.Name = "LabelExplanationAboutDeleteAndAddButton";
            this.LabelExplanationAboutDeleteAndAddButton.Size = new System.Drawing.Size(150, 78);
            this.LabelExplanationAboutDeleteAndAddButton.TabIndex = 60;
            this.LabelExplanationAboutDeleteAndAddButton.Text = "Add friends from the list above\r\n to send a recommendation to \r\nby selecting them" +
                " and\r\nclicking \"Add\". \r\nRemove them from the list\r\n by clicking \"Delete\".";
            // 
            // ButtonCheckPlace
            // 
            this.ButtonCheckPlace.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonCheckPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonCheckPlace.Location = new System.Drawing.Point(51, 61);
            this.ButtonCheckPlace.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonCheckPlace.Name = "ButtonCheckPlace";
            this.ButtonCheckPlace.Size = new System.Drawing.Size(195, 40);
            this.ButtonCheckPlace.TabIndex = 58;
            this.ButtonCheckPlace.Text = "Click to check if any of your friends have been there";
            this.ButtonCheckPlace.UseVisualStyleBackColor = false;
            this.ButtonCheckPlace.Click += new System.EventHandler(this.ButtonCheckPlace_Click_1);
            // 
            // TextBoxPlace
            // 
            this.TextBoxPlace.Location = new System.Drawing.Point(59, 31);
            this.TextBoxPlace.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TextBoxPlace.Name = "TextBoxPlace";
            this.TextBoxPlace.Size = new System.Drawing.Size(170, 20);
            this.TextBoxPlace.TabIndex = 57;
            // 
            // LabelPickPlace
            // 
            this.LabelPickPlace.AutoSize = true;
            this.LabelPickPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPickPlace.Location = new System.Drawing.Point(57, 17);
            this.LabelPickPlace.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelPickPlace.Name = "LabelPickPlace";
            this.LabelPickPlace.Size = new System.Drawing.Size(169, 13);
            this.LabelPickPlace.TabIndex = 56;
            this.LabelPickPlace.Text = "Enter a place for recommandation:";
            // 
            // ButtonGetRecommendation
            // 
            this.ButtonGetRecommendation.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGetRecommendation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonGetRecommendation.Location = new System.Drawing.Point(15, 377);
            this.ButtonGetRecommendation.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonGetRecommendation.Name = "ButtonGetRecommendation";
            this.ButtonGetRecommendation.Size = new System.Drawing.Size(158, 39);
            this.ButtonGetRecommendation.TabIndex = 61;
            this.ButtonGetRecommendation.Text = "Click to get recommendation!";
            this.ButtonGetRecommendation.UseVisualStyleBackColor = false;
            this.ButtonGetRecommendation.Click += new System.EventHandler(this.ButtonGetRecommendation_Click);
            // 
            // ListBoxFriendsToAsk
            // 
            this.ListBoxFriendsToAsk.FormattingEnabled = true;
            this.ListBoxFriendsToAsk.Location = new System.Drawing.Point(208, 116);
            this.ListBoxFriendsToAsk.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxFriendsToAsk.Name = "ListBoxFriendsToAsk";
            this.ListBoxFriendsToAsk.Size = new System.Drawing.Size(103, 147);
            this.ListBoxFriendsToAsk.TabIndex = 62;
            // 
            // ButtonAddFriensToList
            // 
            this.ButtonAddFriensToList.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonAddFriensToList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAddFriensToList.Location = new System.Drawing.Point(141, 162);
            this.ButtonAddFriensToList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonAddFriensToList.Name = "ButtonAddFriensToList";
            this.ButtonAddFriensToList.Size = new System.Drawing.Size(48, 33);
            this.ButtonAddFriensToList.TabIndex = 63;
            this.ButtonAddFriensToList.Text = "Add";
            this.ButtonAddFriensToList.UseVisualStyleBackColor = false;
            this.ButtonAddFriensToList.Click += new System.EventHandler(this.ButtonAddFriensToList_Click_1);
            // 
            // ButtonDeleteFriensFromList
            // 
            this.ButtonDeleteFriensFromList.AutoEllipsis = true;
            this.ButtonDeleteFriensFromList.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonDeleteFriensFromList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDeleteFriensFromList.Location = new System.Drawing.Point(141, 213);
            this.ButtonDeleteFriensFromList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonDeleteFriensFromList.Name = "ButtonDeleteFriensFromList";
            this.ButtonDeleteFriensFromList.Size = new System.Drawing.Size(48, 36);
            this.ButtonDeleteFriensFromList.TabIndex = 64;
            this.ButtonDeleteFriensFromList.Text = "Delete";
            this.ButtonDeleteFriensFromList.UseVisualStyleBackColor = false;
            this.ButtonDeleteFriensFromList.Click += new System.EventHandler(this.ButtonDeleteFriensFromList_Click);
            // 
            // PictureBoxLikedPage
            // 
            this.PictureBoxLikedPage.Location = new System.Drawing.Point(336, 268);
            this.PictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PictureBoxLikedPage.Name = "PictureBoxLikedPage";
            this.PictureBoxLikedPage.Size = new System.Drawing.Size(69, 80);
            this.PictureBoxLikedPage.TabIndex = 68;
            this.PictureBoxLikedPage.TabStop = false;
            // 
            // PictureBoxEvent
            // 
            this.PictureBoxEvent.Location = new System.Drawing.Point(135, 430);
            this.PictureBoxEvent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PictureBoxEvent.Name = "PictureBoxEvent";
            this.PictureBoxEvent.Size = new System.Drawing.Size(69, 80);
            this.PictureBoxEvent.TabIndex = 69;
            this.PictureBoxEvent.TabStop = false;
            // 
            // ListBoxEventsByMinimumNumberOfParticipants
            // 
            this.ListBoxEventsByMinimumNumberOfParticipants.DataSource = this.eventBindingSource;
            this.ListBoxEventsByMinimumNumberOfParticipants.DisplayMember = "Name";
            this.ListBoxEventsByMinimumNumberOfParticipants.FormattingEnabled = true;
            this.ListBoxEventsByMinimumNumberOfParticipants.Location = new System.Drawing.Point(12, 151);
            this.ListBoxEventsByMinimumNumberOfParticipants.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxEventsByMinimumNumberOfParticipants.Name = "ListBoxEventsByMinimumNumberOfParticipants";
            this.ListBoxEventsByMinimumNumberOfParticipants.Size = new System.Drawing.Size(147, 121);
            this.ListBoxEventsByMinimumNumberOfParticipants.TabIndex = 71;
            this.ListBoxEventsByMinimumNumberOfParticipants.SelectedIndexChanged += new System.EventHandler(this.ListBoxEventsByMinimumNumberOfParticipants_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // LabelMinimumAttendersNumber
            // 
            this.LabelMinimumAttendersNumber.AutoSize = true;
            this.LabelMinimumAttendersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinimumAttendersNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelMinimumAttendersNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelMinimumAttendersNumber.Location = new System.Drawing.Point(10, 11);
            this.LabelMinimumAttendersNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMinimumAttendersNumber.Name = "LabelMinimumAttendersNumber";
            this.LabelMinimumAttendersNumber.Size = new System.Drawing.Size(142, 30);
            this.LabelMinimumAttendersNumber.TabIndex = 72;
            this.LabelMinimumAttendersNumber.Text = "Please enter the number\r\nof event\'s participants:";
            // 
            // TextBoxMinimumNumber
            // 
            this.TextBoxMinimumNumber.Location = new System.Drawing.Point(12, 44);
            this.TextBoxMinimumNumber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TextBoxMinimumNumber.Name = "TextBoxMinimumNumber";
            this.TextBoxMinimumNumber.Size = new System.Drawing.Size(84, 20);
            this.TextBoxMinimumNumber.TabIndex = 73;
            // 
            // ButtonFindEventsByMinimumAtendees
            // 
            this.ButtonFindEventsByMinimumAtendees.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFindEventsByMinimumAtendees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonFindEventsByMinimumAtendees.Location = new System.Drawing.Point(136, 36);
            this.ButtonFindEventsByMinimumAtendees.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonFindEventsByMinimumAtendees.Name = "ButtonFindEventsByMinimumAtendees";
            this.ButtonFindEventsByMinimumAtendees.Size = new System.Drawing.Size(83, 67);
            this.ButtonFindEventsByMinimumAtendees.TabIndex = 74;
            this.ButtonFindEventsByMinimumAtendees.Text = "Find Events By \r\nMinimum Attendees";
            this.ButtonFindEventsByMinimumAtendees.UseVisualStyleBackColor = false;
            this.ButtonFindEventsByMinimumAtendees.Click += new System.EventHandler(this.ButtonFindEvents_Click);
            // 
            // ListBoxParticipantsOfEvent
            // 
            this.ListBoxParticipantsOfEvent.FormattingEnabled = true;
            this.ListBoxParticipantsOfEvent.Location = new System.Drawing.Point(255, 152);
            this.ListBoxParticipantsOfEvent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxParticipantsOfEvent.Name = "ListBoxParticipantsOfEvent";
            this.ListBoxParticipantsOfEvent.Size = new System.Drawing.Size(147, 121);
            this.ListBoxParticipantsOfEvent.TabIndex = 76;
            // 
            // PictureBoxEventChosenByParticipantsNumber
            // 
            this.PictureBoxEventChosenByParticipantsNumber.Location = new System.Drawing.Point(170, 151);
            this.PictureBoxEventChosenByParticipantsNumber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PictureBoxEventChosenByParticipantsNumber.Name = "PictureBoxEventChosenByParticipantsNumber";
            this.PictureBoxEventChosenByParticipantsNumber.Size = new System.Drawing.Size(69, 80);
            this.PictureBoxEventChosenByParticipantsNumber.TabIndex = 77;
            this.PictureBoxEventChosenByParticipantsNumber.TabStop = false;
            // 
            // LabelListOfParticipants
            // 
            this.LabelListOfParticipants.AutoSize = true;
            this.LabelListOfParticipants.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelListOfParticipants.Location = new System.Drawing.Point(253, 137);
            this.LabelListOfParticipants.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelListOfParticipants.Name = "LabelListOfParticipants";
            this.LabelListOfParticipants.Size = new System.Drawing.Size(132, 13);
            this.LabelListOfParticipants.TabIndex = 80;
            this.LabelListOfParticipants.Text = "List of event\'s participants:";
            // 
            // LabelListOfEvents
            // 
            this.LabelListOfEvents.AutoSize = true;
            this.LabelListOfEvents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelListOfEvents.Location = new System.Drawing.Point(10, 135);
            this.LabelListOfEvents.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelListOfEvents.Name = "LabelListOfEvents";
            this.LabelListOfEvents.Size = new System.Drawing.Size(73, 13);
            this.LabelListOfEvents.TabIndex = 81;
            this.LabelListOfEvents.Text = "List of events:";
            // 
            // LabelNumberOfParticipants
            // 
            this.LabelNumberOfParticipants.AutoSize = true;
            this.LabelNumberOfParticipants.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNumberOfParticipants.Location = new System.Drawing.Point(12, 272);
            this.LabelNumberOfParticipants.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelNumberOfParticipants.Name = "LabelNumberOfParticipants";
            this.LabelNumberOfParticipants.Size = new System.Drawing.Size(138, 26);
            this.LabelNumberOfParticipants.TabIndex = 82;
            this.LabelNumberOfParticipants.Text = "Number of people attending\r\nthe event:";
            // 
            // TextBoxNumberOfParticipants
            // 
            this.TextBoxNumberOfParticipants.Location = new System.Drawing.Point(61, 287);
            this.TextBoxNumberOfParticipants.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TextBoxNumberOfParticipants.Name = "TextBoxNumberOfParticipants";
            this.TextBoxNumberOfParticipants.ReadOnly = true;
            this.TextBoxNumberOfParticipants.Size = new System.Drawing.Size(91, 20);
            this.TextBoxNumberOfParticipants.TabIndex = 83;
            // 
            // ButtonClickToAttend
            // 
            this.ButtonClickToAttend.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonClickToAttend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonClickToAttend.Location = new System.Drawing.Point(176, 240);
            this.ButtonClickToAttend.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonClickToAttend.Name = "ButtonClickToAttend";
            this.ButtonClickToAttend.Size = new System.Drawing.Size(57, 63);
            this.ButtonClickToAttend.TabIndex = 84;
            this.ButtonClickToAttend.Text = "Click to attend";
            this.ButtonClickToAttend.UseVisualStyleBackColor = false;
            this.ButtonClickToAttend.Click += new System.EventHandler(this.ButtonClickToAttend_Click);
            // 
            // PanelPlaceRecommandations
            // 
            this.PanelPlaceRecommandations.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelPlaceRecommandations.Controls.Add(this.LabelAdditionalCheckins);
            this.PanelPlaceRecommandations.Controls.Add(this.NameListBox);
            this.PanelPlaceRecommandations.Controls.Add(this.ListBoxFriendsThatHaveBeenInChosenPlace);
            this.PanelPlaceRecommandations.Controls.Add(this.ButtonGetRecommendation);
            this.PanelPlaceRecommandations.Controls.Add(this.ButtonDeleteFriensFromList);
            this.PanelPlaceRecommandations.Controls.Add(this.LabelExplanationAboutDeleteAndAddButton);
            this.PanelPlaceRecommandations.Controls.Add(this.TextBoxPlace);
            this.PanelPlaceRecommandations.Controls.Add(this.LabelPickPlace);
            this.PanelPlaceRecommandations.Controls.Add(this.ButtonAddFriensToList);
            this.PanelPlaceRecommandations.Controls.Add(this.ButtonCheckPlace);
            this.PanelPlaceRecommandations.Controls.Add(this.ListBoxFriendsToAsk);
            this.PanelPlaceRecommandations.Location = new System.Drawing.Point(513, 115);
            this.PanelPlaceRecommandations.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PanelPlaceRecommandations.Name = "PanelPlaceRecommandations";
            this.PanelPlaceRecommandations.Size = new System.Drawing.Size(324, 449);
            this.PanelPlaceRecommandations.TabIndex = 0;
            // 
            // LabelAdditionalCheckins
            // 
            this.LabelAdditionalCheckins.AutoSize = true;
            this.LabelAdditionalCheckins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelAdditionalCheckins.Location = new System.Drawing.Point(208, 274);
            this.LabelAdditionalCheckins.Name = "LabelAdditionalCheckins";
            this.LabelAdditionalCheckins.Size = new System.Drawing.Size(103, 13);
            this.LabelAdditionalCheckins.TabIndex = 87;
            this.LabelAdditionalCheckins.Text = "Additional Checkins:";
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.Location = new System.Drawing.Point(208, 291);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(103, 147);
            this.NameListBox.TabIndex = 0;
            this.NameListBox.MouseLeave += new System.EventHandler(this.NameListBox_MouseLeave);
            this.NameListBox.MouseHover += new System.EventHandler(this.NameListBox_MouseHover);
            // 
            // ListBoxFriendsThatHaveBeenInChosenPlace
            // 
            this.ListBoxFriendsThatHaveBeenInChosenPlace.DataSource = this.friendsBindingSource;
            this.ListBoxFriendsThatHaveBeenInChosenPlace.DisplayMember = "Name";
            this.ListBoxFriendsThatHaveBeenInChosenPlace.FormattingEnabled = true;
            this.ListBoxFriendsThatHaveBeenInChosenPlace.Location = new System.Drawing.Point(15, 116);
            this.ListBoxFriendsThatHaveBeenInChosenPlace.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxFriendsThatHaveBeenInChosenPlace.Name = "ListBoxFriendsThatHaveBeenInChosenPlace";
            this.ListBoxFriendsThatHaveBeenInChosenPlace.Size = new System.Drawing.Size(103, 147);
            this.ListBoxFriendsThatHaveBeenInChosenPlace.TabIndex = 65;
            this.ListBoxFriendsThatHaveBeenInChosenPlace.SelectedIndexChanged += new System.EventHandler(this.ListBoxFriendsThatHaveBeenInChosenPlace_SelectedIndexChanged);
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // checkinsBindingSource
            // 
            this.checkinsBindingSource.DataMember = "Checkins";
            this.checkinsBindingSource.DataSource = this.friendsBindingSource;
            // 
            // PanelEventsFinderByMinimumAttendees
            // 
            this.PanelEventsFinderByMinimumAttendees.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.ButtonFindEventsByMaximumAtendees);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.EventInfoTitle);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.PanelEventInformation);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.ButtonClickToAttend);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.TextBoxNumberOfParticipants);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.LabelNumberOfParticipants);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.LabelListOfEvents);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.LabelListOfParticipants);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.PictureBoxEventChosenByParticipantsNumber);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.ListBoxParticipantsOfEvent);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.ButtonFindEventsByMinimumAtendees);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.TextBoxMinimumNumber);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.LabelMinimumAttendersNumber);
            this.PanelEventsFinderByMinimumAttendees.Controls.Add(this.ListBoxEventsByMinimumNumberOfParticipants);
            this.PanelEventsFinderByMinimumAttendees.Location = new System.Drawing.Point(842, 79);
            this.PanelEventsFinderByMinimumAttendees.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PanelEventsFinderByMinimumAttendees.Name = "PanelEventsFinderByMinimumAttendees";
            this.PanelEventsFinderByMinimumAttendees.Size = new System.Drawing.Size(415, 485);
            this.PanelEventsFinderByMinimumAttendees.TabIndex = 85;
            // 
            // ButtonFindEventsByMaximumAtendees
            // 
            this.ButtonFindEventsByMaximumAtendees.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonFindEventsByMaximumAtendees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonFindEventsByMaximumAtendees.Location = new System.Drawing.Point(255, 36);
            this.ButtonFindEventsByMaximumAtendees.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonFindEventsByMaximumAtendees.Name = "ButtonFindEventsByMaximumAtendees";
            this.ButtonFindEventsByMaximumAtendees.Size = new System.Drawing.Size(83, 67);
            this.ButtonFindEventsByMaximumAtendees.TabIndex = 87;
            this.ButtonFindEventsByMaximumAtendees.Text = "Find Events By \r\nMaximum \r\nAteendees";
            this.ButtonFindEventsByMaximumAtendees.UseVisualStyleBackColor = false;
            this.ButtonFindEventsByMaximumAtendees.Click += new System.EventHandler(this.ButtonFindEventsByMaximumAtendees_Click);
            // 
            // EventInfoTitle
            // 
            this.EventInfoTitle.AutoSize = true;
            this.EventInfoTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventInfoTitle.Location = new System.Drawing.Point(12, 314);
            this.EventInfoTitle.Name = "EventInfoTitle";
            this.EventInfoTitle.Size = new System.Drawing.Size(71, 13);
            this.EventInfoTitle.TabIndex = 86;
            this.EventInfoTitle.Text = "Event details:";
            // 
            // PanelEventInformation
            // 
            this.PanelEventInformation.BackColor = System.Drawing.Color.White;
            this.PanelEventInformation.Controls.Add(descriptionLabel);
            this.PanelEventInformation.Controls.Add(this.descriptionTextBox);
            this.PanelEventInformation.Controls.Add(endTimeLabel);
            this.PanelEventInformation.Controls.Add(this.endTimeDateTimePicker);
            this.PanelEventInformation.Controls.Add(locationLabel);
            this.PanelEventInformation.Controls.Add(this.locationTextBox);
            this.PanelEventInformation.Controls.Add(nameLabel);
            this.PanelEventInformation.Controls.Add(this.nameTextBox);
            this.PanelEventInformation.Controls.Add(startTimeLabel);
            this.PanelEventInformation.Controls.Add(this.startTimeDateTimePicker);
            this.PanelEventInformation.Location = new System.Drawing.Point(12, 330);
            this.PanelEventInformation.Name = "PanelEventInformation";
            this.PanelEventInformation.Size = new System.Drawing.Size(311, 144);
            this.PanelEventInformation.TabIndex = 85;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(106, 17);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(106, 43);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(106, 69);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(106, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(106, 121);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimeDateTimePicker.TabIndex = 11;
            // 
            // ListBoxFriends
            // 
            this.ListBoxFriends.FormattingEnabled = true;
            this.ListBoxFriends.Location = new System.Drawing.Point(210, 430);
            this.ListBoxFriends.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListBoxFriends.Name = "ListBoxFriends";
            this.ListBoxFriends.Size = new System.Drawing.Size(126, 134);
            this.ListBoxFriends.TabIndex = 86;
            this.ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.ListBoxFriends_SelectedIndexChanged);
            // 
            // PictureBoxFriend
            // 
            this.PictureBoxFriend.Location = new System.Drawing.Point(336, 430);
            this.PictureBoxFriend.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PictureBoxFriend.Name = "PictureBoxFriend";
            this.PictureBoxFriend.Size = new System.Drawing.Size(69, 80);
            this.PictureBoxFriend.TabIndex = 87;
            this.PictureBoxFriend.TabStop = false;
            // 
            // TextBoxNickname
            // 
            this.TextBoxNickname.Location = new System.Drawing.Point(409, 430);
            this.TextBoxNickname.Name = "TextBoxNickname";
            this.TextBoxNickname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNickname.TabIndex = 88;
            this.TextBoxNickname.Leave += new System.EventHandler(this.TextBoxNickname_Leave);
            // 
            // LabelNickname
            // 
            this.LabelNickname.AutoSize = true;
            this.LabelNickname.BackColor = System.Drawing.Color.Transparent;
            this.LabelNickname.Location = new System.Drawing.Point(406, 414);
            this.LabelNickname.Name = "LabelNickname";
            this.LabelNickname.Size = new System.Drawing.Size(87, 13);
            this.LabelNickname.TabIndex = 89;
            this.LabelNickname.Text = "Nickname friend:";
            // 
            // FacebookAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.LabelNickname);
            this.Controls.Add(this.TextBoxNickname);
            this.Controls.Add(this.PictureBoxFriend);
            this.Controls.Add(this.ListBoxFriends);
            this.Controls.Add(this.PanelEventsFinderByMinimumAttendees);
            this.Controls.Add(this.PanelPlaceRecommandations);
            this.Controls.Add(this.PictureBoxEvent);
            this.Controls.Add(this.PictureBoxLikedPage);
            this.Controls.Add(this.PaneUpper);
            this.Controls.Add(this.ListBoxCheckins);
            this.Controls.Add(this.ListBoxLikedPages);
            this.Controls.Add(this.LinkCheckins);
            this.Controls.Add(this.LinkLikedPages);
            this.Controls.Add(this.PictureBoxUser);
            this.Controls.Add(this.LabelPostStatus);
            this.Controls.Add(this.TextBoxStatus);
            this.Controls.Add(this.ButtonPostStatus);
            this.Controls.Add(this.ListBoxEvents);
            this.Controls.Add(this.LinkFriends);
            this.Controls.Add(this.LinkEvents);
            this.Controls.Add(this.LinkPosts);
            this.Controls.Add(this.ListBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookAppUI";
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.PaneUpper.ResumeLayout(false);
            this.PaneUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLikedPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEventChosenByParticipantsNumber)).EndInit();
            this.PanelPlaceRecommandations.ResumeLayout(false);
            this.PanelPlaceRecommandations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
            this.PanelEventsFinderByMinimumAttendees.ResumeLayout(false);
            this.PanelEventsFinderByMinimumAttendees.PerformLayout();
            this.PanelEventInformation.ResumeLayout(false);
            this.PanelEventInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxLikedPages;
        private System.Windows.Forms.LinkLabel LinkLikedPages;
        private System.Windows.Forms.ListBox ListBoxCheckins;
        private System.Windows.Forms.LinkLabel LinkCheckins;
        private System.Windows.Forms.ListBox ListBoxEvents;
        private System.Windows.Forms.LinkLabel LinkEvents;
        private System.Windows.Forms.LinkLabel LinkFriends;
        private System.Windows.Forms.ListBox ListBoxPosts;
        private System.Windows.Forms.LinkLabel LinkPosts;
        private System.Windows.Forms.Label LabelPostStatus;
        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.Button ButtonPostStatus;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.Panel PaneUpper;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelFacebook;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Label LabelExplanationAboutDeleteAndAddButton;
        private System.Windows.Forms.Button ButtonCheckPlace;
        private System.Windows.Forms.TextBox TextBoxPlace;
        private System.Windows.Forms.Label LabelPickPlace;
        private System.Windows.Forms.Button ButtonGetRecommendation;
        private System.Windows.Forms.ListBox ListBoxFriendsToAsk;
        private System.Windows.Forms.Button ButtonAddFriensToList;
        private System.Windows.Forms.Button ButtonDeleteFriensFromList;
        private System.Windows.Forms.PictureBox PictureBoxLikedPage;
        private System.Windows.Forms.PictureBox PictureBoxEvent;
        private System.Windows.Forms.ListBox ListBoxEventsByMinimumNumberOfParticipants;
        private System.Windows.Forms.Label LabelMinimumAttendersNumber;
        private System.Windows.Forms.TextBox TextBoxMinimumNumber;
        private System.Windows.Forms.Button ButtonFindEventsByMinimumAtendees;
        private System.Windows.Forms.ListBox ListBoxParticipantsOfEvent;
        private System.Windows.Forms.PictureBox PictureBoxEventChosenByParticipantsNumber;
        private System.Windows.Forms.Label LabelListOfParticipants;
        private System.Windows.Forms.Label LabelListOfEvents;
        private System.Windows.Forms.Label LabelNumberOfParticipants;
        private System.Windows.Forms.TextBox TextBoxNumberOfParticipants;
        private System.Windows.Forms.Button ButtonClickToAttend;
        private System.Windows.Forms.Panel PanelPlaceRecommandations;
        private System.Windows.Forms.Panel PanelEventsFinderByMinimumAttendees;
        private System.Windows.Forms.ComboBox ComboBoxAppID;
        private System.Windows.Forms.ListBox ListBoxFriendsThatHaveBeenInChosenPlace;
        private System.Windows.Forms.ListBox ListBoxFriends;
        private System.Windows.Forms.PictureBox PictureBoxFriend;
        private System.Windows.Forms.Panel PanelEventInformation;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.BindingSource checkinsBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.Label LabelAdditionalCheckins;
        private System.Windows.Forms.Label EventInfoTitle;
        private System.Windows.Forms.TextBox TextBoxNickname;
        private System.Windows.Forms.Label LabelNickname;
        private System.Windows.Forms.Button ButtonFindEventsByMaximumAtendees;
    }
}