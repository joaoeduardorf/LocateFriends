using Locate.Domain.Entities;
using LocateFriend.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application.Interfaces
{
    public interface IFriendAppService
    {
        Friend Add(Friend friend, Location location);
        Friend GetById(int id);
        IEnumerable<Friend> GetAll();
        Friend Update(Friend friend);
        void Remove(Friend friend);
        IEnumerable<Friend> GetFriendsAround(int myX, int myY);
        IEnumerable<FriendLocatedViewModel> LocateFriends(int id);
        void Dispose();
    }
}
