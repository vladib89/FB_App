using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public interface IOrderFriendList
    {
        List<User> OrderFriendList(List<User> i_FriendsList);
    }
}
