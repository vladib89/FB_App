using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

// working edition
namespace FB_App
{
    public partial class FacebookAppUI : Form
    {
        public User LoggedInUser { get; private set; }

        public PlaceRecommendations PlaceRecommendationsInstance { get; private set; }

        public EventsFinderBy EventsFinderByInstance { get; private set; }

        public Dictionary<string, string> AppIDList { get; private set; }

        private string m_AppID = null;

        private void constructPlaceRecommendations(IPlaceRecommendationsBuilder builder)
        {
            if (PlaceRecommendationsInstance == null)
            {
                builder.BuildIPlaceRecommendations(new OrderFriendsxBySocialLife());
                PlaceRecommendationsInstance = builder.GetResult();
            }
        }

        public FacebookAppUI()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            InitializeComponent();
            AppIDList = new Dictionary<string, string>();
            constructPlaceRecommendations(new DefaultPlaceRecommendationsBuilder());
            loadAppIDList();
        }

        private void loadAppIDList()
        {
            AppIDList.Add("Student AppID", "357690298021371");
            AppIDList.Add("Course AppID", "1450160541956417");
            foreach (KeyValuePair<string, string> entry in AppIDList)
            {
                ComboBoxAppID.Items.Add(entry.Key);
            }
        }

        private void ComboBoxAppID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AppIDList.TryGetValue(ComboBoxAppID.SelectedItem.ToString(), out m_AppID);
        }

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            if (m_AppID != null)
            {
                loginAndInit();
            }
            else
            {
                MessageBox.Show("Please choose an AppID in order to log in.");
            }
        }

        private void loginAndInit()
        {
            try
            {
                LoginResult result = FacebookService.Login(
                m_AppID,
                "user_about_me",
                "user_posts",
                "read_custom_friendlists",
                "user_photos",
                "user_friends",
                "publish_actions",
                "user_likes",
                "user_events",
                "user_status",
                "user_location",
                "user_tagged_places",
                "rsvp_event");

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    LoggedInUser = result.LoggedInUser;
                    PictureBoxUser.LoadAsync(LoggedInUser.PictureNormalURL);
                    ButtonLogin.Enabled = false;
                    ButtonLogout.Enabled = true;
                    ComboBoxAppID.Enabled = false;
                }
                else
                {
                    throw new Exception(result.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ButtonPostStatus_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (LoggedInUser != null)
                {
                    LoggedInUser.PostStatus(TextBoxStatus.Text);
                    MessageBox.Show("Status Posted successfully! :)");
                    TextBoxStatus.Clear();
                }
                else
                {
                    throw new Exception("You must be logged in, in order to proceed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LinkPosts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                fetchPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fetchPosts()
        {
            ListBoxPosts.Items.Clear();
            ListBoxPosts.DisplayMember = "Name";
            if (LoggedInUser != null)
            {
                if (LoggedInUser.Posts.Count > 0)
                {
                    foreach (Post post in LoggedInUser.Posts)
                    {
                        if (post.Message != null)
                        {
                            ListBoxPosts.Items.Add(post.Message);
                        }
                        else if (post.Caption != null)
                        {
                            ListBoxPosts.Items.Add(post.Caption);
                        }
                        else
                        {
                            ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There are no posts to display.");
                }
            }
            else
            {
                throw new Exception("You must be logged in, in order to proceed.");
            }
        }

        private void LinkFriends_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                fetchFriends();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fetchFriends()
        {
            ListBoxFriends.Items.Clear();
            ListBoxFriends.DisplayMember = "Name";
            if (LoggedInUser != null)
            {
                if (LoggedInUser.Friends.Count > 0)
                {
                    foreach (User friend in LoggedInUser.Friends)
                    {
                        ListBoxFriends.Items.Add(friend);
                    }
                }
                else
                {
                    MessageBox.Show("There are no friends to display.");
                }
            }
            else
            {
                throw new Exception("You must be logged in, in order to proceed.");
            }
        }

        private void LinkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                fetchEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fetchEvents()
        {
            ListBoxEvents.Items.Clear();
            ListBoxEvents.DisplayMember = "Name";
            if (LoggedInUser != null)
            {
                if (LoggedInUser.Events.Count > 0)
                {
                    foreach (Event fbEvent in LoggedInUser.Events)
                    {
                        ListBoxEvents.Items.Add(fbEvent);
                    }
                }
                else
                {
                    MessageBox.Show("There are no events to display.");
                }
            }
            else
            {
                throw new Exception("You must be logged in, in order to proceed.");
            }
        }

        private void LinkCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                fetchCheckins();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fetchCheckins()
        {
            ListBoxCheckins.Items.Clear();
            ListBoxCheckins.DisplayMember = "Name";
            if (LoggedInUser != null)
            {
                if (LoggedInUser.Checkins.Count > 0)
                {
                    foreach (Checkin checkin in LoggedInUser.Checkins)
                    {
                        ListBoxCheckins.Items.Add(checkin.Place.Name);
                    }
                }
                else
                {
                    MessageBox.Show("There are no checkins to display.");
                }
            }
            else
            {
                throw new Exception("You must be logged in, in order to proceed.");
            }
        }

        private void LinkLikedPages_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                fetchLikedPages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fetchLikedPages()
        {
            ListBoxLikedPages.Items.Clear();
            ListBoxLikedPages.DisplayMember = "Name";

            if (LoggedInUser != null)
            {
                if (LoggedInUser.LikedPages.Count > 0)
                {
                    foreach (Page page in LoggedInUser.LikedPages)
                    {
                        ListBoxLikedPages.Items.Add(page);
                    }
                }
                else
                {
                    MessageBox.Show("There are no pages to display.");
                }
            }
            else
            {
                throw new Exception("You must be logged in, in order to proceed.");
            }
        }

        private void ListBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = ListBoxLikedPages.SelectedItem as Page;
                PictureBoxLikedPage.LoadAsync(selectedPage.PictureURL);
            }
        }

        private void ListBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (ListBoxFriends.SelectedItems.Count == 1)
            {
                if (ListBoxFriends.SelectedItem is AlteredUser)
                {
                    AlteredUser selectedFriend = ListBoxFriends.SelectedItem as AlteredUser;
                    TextBoxNickname.Text = selectedFriend.Name;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        PictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }
                    else
                    {
                        PictureBoxUser.Image = PictureBoxUser.ErrorImage;
                    }
                }
                else
                {
                    User selectedFriend = ListBoxFriends.SelectedItem as User;
                    TextBoxNickname.Text = selectedFriend.Name;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        PictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }
                    else
                    {
                        PictureBoxUser.Image = PictureBoxUser.ErrorImage;
                    }
                }
            }
        }

        private void ListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = ListBoxEvents.SelectedItem as Event;
                PictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            if (LoggedInUser != null)
            {
                FacebookService.Logout(new Action(logout));
                LoggedInUser = null;
                ControlsReseter.ResetAllControls(this);
                ButtonLogin.Enabled = true;
                ButtonLogout.Enabled = false;
                ComboBoxAppID.Enabled = true;
            }
        }

        private void ButtonAddFriensToList_Click_1(object sender, EventArgs e)
        {
            PlaceRecommendationsInstance.AddFriendsToAskToList(
                LoggedInUser, 
                ListBoxFriendsThatHaveBeenInChosenPlace, 
                ListBoxFriendsToAsk);
        }

        private void ButtonDeleteFriensFromList_Click(object sender, EventArgs e)
        {
            PlaceRecommendationsInstance.DeleteFriendsToAskFromList(
                LoggedInUser, 
                ListBoxFriendsToAsk);
        }

        private void ButtonCheckPlace_Click_1(object sender, EventArgs e)
        {
            checkPlace(TextBoxPlace.Text);
        }

        private void checkPlace(string i_PlaceName)
        {
            ListBoxFriendsToAsk.Invoke(new Action(() => ListBoxFriendsToAsk.Items.Clear()));
            Thread threadCheckPlace = new Thread(() => PlaceRecommendationsInstance.CheckPlace(
                i_PlaceName, 
                LoggedInUser, 
                ListBoxFriendsThatHaveBeenInChosenPlace,
                friendsBindingSource));

            threadCheckPlace.Start();
        }

        private void ButtonGetRecommendation_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoggedInUser != null)
                {
                    if (ListBoxFriendsToAsk.Items.Count != 0)
                    {
                        List<User> friendsToAsk = new List<User>();
                        foreach (User friend in ListBoxFriendsToAsk.Items)
                        {
                            friendsToAsk.Add(friend as User);
                        }

                        PlaceRecommendationsInstance.AskFriendForRecommendation(LoggedInUser, friendsToAsk, TextBoxPlace.Text);
                        ListBoxFriendsToAsk.Items.Clear();
                        ListBoxFriendsThatHaveBeenInChosenPlace.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("There are no friends to get recommandation from.");
                    }
                }
                else
                {
                    throw new Exception("You must be logged in, in order to proceed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ButtonFindEvents_Click(object sender, EventArgs e)
        {
            EventsFinderByInstance = new EventsFinderByMinimumAttendees();
            Thread threadFindEvents = new Thread(() => EventsFinderByInstance.FetchUserEventsByAttendings(
                LoggedInUser,
                ListBoxEventsByMinimumNumberOfParticipants,
                TextBoxMinimumNumber,
                eventBindingSource));

            threadFindEvents.Start();
        }

        private void ListBoxEventsByMinimumNumberOfParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEventsByMinimumNumberOfParticipants.SelectedItems.Count == 1)
            {
                EventsFinderByInstance.LoadPictureAndNumberOfAttenders(
                ListBoxEventsByMinimumNumberOfParticipants,
                PictureBoxEventChosenByParticipantsNumber,
                TextBoxNumberOfParticipants);

                EventsFinderByInstance.LoadListOfAttenders(ListBoxEventsByMinimumNumberOfParticipants.SelectedItem as Event);
                loadAttendersList();
            }
        }

        private void loadAttendersList()
        {
            ListBoxParticipantsOfEvent.Items.Clear();
            foreach (User attender in EventsFinderByInstance.ListOfPeopleWhoAttendToEvent)
            {
                ListBoxParticipantsOfEvent.Items.Add(attender);
            }
        }

        private void ButtonClickToAttend_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoggedInUser != null)
                {
                    EventsFinderByInstance.AttendToEvent(ListBoxEventsByMinimumNumberOfParticipants);
                }
                else
                {
                    throw new Exception("You must be logged in, in order to proceed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ListBoxFriendsThatHaveBeenInChosenPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxFriendsThatHaveBeenInChosenPlace.SelectedItem != null)
            {
                NameListBox.Invoke(new Action(() => NameListBox.DataSource = checkinsBindingSource));
            }
        }

        private void NameListBox_MouseHover(object sender, EventArgs e)
        {
            if (NameListBox.Items.Count > 0)
            {
                NameListBox.Left = LabelAdditionalCheckins.Left = ListBoxFriendsThatHaveBeenInChosenPlace.Left;
                NameListBox.Width = ListBoxFriendsToAsk.Right - ListBoxFriendsThatHaveBeenInChosenPlace.Left;
                LabelExplanationAboutDeleteAndAddButton.Visible = false;
            }
        }

        private void NameListBox_MouseLeave(object sender, EventArgs e)
        {
            if (NameListBox.Items.Count > 0)
            {
                NameListBox.Left = LabelAdditionalCheckins.Left = ListBoxFriendsToAsk.Left;
                NameListBox.Width = ListBoxFriendsToAsk.Width;
                LabelExplanationAboutDeleteAndAddButton.Visible = true;
            }
        }

        private void TextBoxNickname_Leave(object sender, EventArgs e)
        {
            User selectedFriend = ListBoxFriends.SelectedItem as User;
            int index = ListBoxFriends.SelectedIndex;
            if (selectedFriend != null)
            {
                AlteredUser alteredFriend = new AlteredUser();
                alteredFriend.Name = TextBoxNickname.Text;
                alteredFriend.PictureNormalURL = selectedFriend.PictureNormalURL;
                ListBoxFriends.Items.RemoveAt(index);
                ListBoxFriends.Items.Insert(index, alteredFriend);
            }
        }

        private void ButtonFindEventsByMaximumAtendees_Click(object sender, EventArgs e)
        {
            EventsFinderByInstance = new EventsFinderByMaximumAttendees();
            Thread threadFindEvents = new Thread(() => EventsFinderByInstance.FetchUserEventsByAttendings(
                LoggedInUser,
                ListBoxEventsByMinimumNumberOfParticipants,
                TextBoxMinimumNumber,
                eventBindingSource));

            threadFindEvents.Start();
        }
    }
}