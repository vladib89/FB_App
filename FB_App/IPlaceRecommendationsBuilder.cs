using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FB_App
{
    public interface IPlaceRecommendationsBuilder
    { 
        void BuildIPlaceRecommendations(IOrderFriendList i_Orderer);

        PlaceRecommendations GetResult();
    }
}
