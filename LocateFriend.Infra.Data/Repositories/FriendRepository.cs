using Locate.Domain.Entities;
using Locate.Domain.Interfaces.Repositories;
using LocateFriend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Infra.Data.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        protected LocateFriendContext _locateFriendContext;

        public FriendRepository(LocateFriendContext locateFriendContext)
        {
            _locateFriendContext = locateFriendContext;
        }

        public Friend Add(Friend obj)
        {
            _locateFriendContext.Friends.Add(obj);
            _locateFriendContext.SaveChanges();
            return obj;
        }

        public Friend GetById(int id)
        {
            return _locateFriendContext.Friends.Find(id);
        }

        public IEnumerable<Friend> GetAll()
        {
            return _locateFriendContext.Friends;
        }

        public Friend Update(Friend obj)
        {
            _locateFriendContext.Entry<Friend>(obj).State = EntityState.Modified;
            _locateFriendContext.SaveChanges();
            return obj;
        }

        public void Remove(Friend obj)
        {
            _locateFriendContext.Friends.Remove(obj);
            _locateFriendContext.SaveChanges();
        }

        public void Dispose()
        {
            _locateFriendContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
