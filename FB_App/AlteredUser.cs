using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public class AlteredUser : User
    {
        public new string Name { get; set; }

        public new string PictureNormalURL { get; set; }
    }
}
