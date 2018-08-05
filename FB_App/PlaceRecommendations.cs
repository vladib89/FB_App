using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public class PlaceRecommendations
    {
        public IOrderFriendList FriendListOrderer { get; set; }

        public List<User> FriendListBeenThere { get; private set; }

        private readonly object sr_AddToListLock = new object();

        public bool FoundFriend { get; private set; }

        public PlaceRecommendations()
        {
            FriendListBeenThere = new List<User>();
            FriendListOrderer = new OrderFriendListAlphabeticly();
        }

        public void AddFriendListOrderer(IOrderFriendList i_Orderer)
        {
            FriendListOrderer = i_Orderer;
        }

        public void AskFriendForRecommendation(User i_User, List<User> i_FriendsToAsk, string i_PlaceName)
        {
            try
            {
                if (i_User != null)
                {
                    string askFriendPost = string.Format("Hey! I'm interested about {0}, how was there? I would love a recommendation please :)", i_PlaceName);

                    foreach (User friend in i_FriendsToAsk)
                    {
                        i_User.PostStatus(askFriendPost, null, null, friend.Id);
                    }

                    MessageBox.Show("Your question was posted");
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

        public void CheckPlace(string i_PlaceName, User i_User, ListBox i_GivenListBox, System.Windows.Forms.BindingSource i_BindingSource)
        {
            FriendListBeenThere.Clear();
            i_GivenListBox.Invoke(new Action(() =>
            {
                i_GivenListBox.DataSource = null;
                i_GivenListBox.Items.Clear();
            }));

            FoundFriend = false;
            ProperFriendFinder properFriendFinder = new ProperFriendFinder { FacebookUser = i_User, PlaceName = i_PlaceName };

            try
            {
                if (i_User != null)
                {
                    if (i_User.Friends.Count > 0)
                    {
                        IEnumerator<User> currentFriend = properFriendFinder.GetEnumerator();
                        User properFriend = currentFriend.Current;

                        lock (sr_AddToListLock)
                        {
                            while (currentFriend.MoveNext())
                            {
                                FoundFriend = true;
                                properFriend = currentFriend.Current;
                                FriendListBeenThere.Add(currentFriend.Current);
                            }
                        }

                        if (FoundFriend)
                        {
                            FriendListOrderer.OrderFriendList(FriendListBeenThere);
                            i_BindingSource.DataSource = FriendListBeenThere;
                            i_GivenListBox.Invoke(new Action(() => i_GivenListBox.DataSource = i_BindingSource));
                        }
                        else
                        {
                            string message = string.Format("None of your friends were in {0}", i_PlaceName);
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        string message = string.Format("You have no friends to ask from.");
                        MessageBox.Show(message);
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
                
        public void AddFriendsToAskToList(User i_User, ListBox i_FriendsThatBeenThere, ListBox i_FriendsToAsk)
        {
            try
            {
                if (i_User != null)
                {
                    if (i_FriendsThatBeenThere.SelectedItem as User != null)
                    {
                        if (i_FriendsToAsk.Items.Contains(i_FriendsThatBeenThere.SelectedItem))
                        {
                            MessageBox.Show("This friend has already been added to the list.");
                        }
                        else
                        {
                            i_FriendsToAsk.Items.Add(i_FriendsThatBeenThere.SelectedItem as User);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no friends to add.");
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

        public void DeleteFriendsToAskFromList(User i_User, ListBox i_FriendsToAsk)
        {
            try
            {
                if (i_User != null)
                {
                    if (i_FriendsToAsk.SelectedItem != null)
                    {
                        i_FriendsToAsk.Items.Remove(i_FriendsToAsk.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("There are no friends to delete.");
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
    }
}
