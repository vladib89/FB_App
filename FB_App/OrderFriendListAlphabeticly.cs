using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public class OrderFriendListAlphabeticly : IOrderFriendList
    {
        public List<User> OrderFriendList(List<User> i_FriendsList)
        {
            List<User> friendListToReturn = new List<User>();

            friendListToReturn = i_FriendsList.OrderBy(x => x.Name).ToList();

            return friendListToReturn;
        }
    }
}
