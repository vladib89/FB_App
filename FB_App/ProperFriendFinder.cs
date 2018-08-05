using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public class ProperFriendFinder : IEnumerable<User>
    {
        public User FacebookUser { get; set; }

        public string PlaceName { get; set; }

        private readonly object sr_CheckIfProperLock = new object();

        private readonly object sr_AddToListLock = new object();

        private readonly object sr_CheckNameLock = new object();

        public List<User> FriendListBeenThere { get; private set; }

        public ProperFriendFinder()
        {
            FriendListBeenThere = new List<User>();
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User friend in FacebookUser.Friends)
            {
                lock (sr_AddToListLock)
                {
                    if (checkIfFriendWasThere(friend))
                    {
                        FriendListBeenThere.Add(friend);

                        yield return friend;
                    }
                }
            }
        }

        private bool checkIfFriendWasThere(User i_Friend)
        {
            bool isProper = false;
            foreach (Status friendStatus in i_Friend.Statuses)
            {
                if (friendStatus.Place != null)
                {
                    lock (sr_CheckIfProperLock)
                    {
                        if (friendStatus.Place.Name == PlaceName && !checkIfNameExistsInList(i_Friend.UserName))
                        {
                            isProper = true;
                            break;
                        }
                    }
                }
            }

            foreach (Photo friendPhoto in i_Friend.PhotosTaggedIn)
            {
                if (friendPhoto.Place != null)
                {
                    lock (sr_CheckIfProperLock)
                    {
                        if (friendPhoto.Place.Name == PlaceName && !checkIfNameExistsInList(i_Friend.UserName))
                        {
                            isProper = true;
                            break;
                        }
                    }
                }
            }

            foreach (Checkin friendCheckin in i_Friend.Checkins)
            {
                if (friendCheckin.Place != null)
                {
                    lock (sr_CheckIfProperLock)
                    {
                        if (friendCheckin.Place.Name == PlaceName && !checkIfNameExistsInList(i_Friend.UserName))
                        {
                            isProper = true;
                            break;
                        }
                    }
                }
            }

            return isProper;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private bool checkIfNameExistsInList(string i_FriendName)
        {
            bool nameExists = false;

            foreach (User friend in FriendListBeenThere)
            {
                lock (sr_CheckNameLock)
                {
                    if (friend.UserName == i_FriendName)
                    {
                        nameExists = true;
                        break;
                    }
                }
            }

            return nameExists;
        }
    }
}