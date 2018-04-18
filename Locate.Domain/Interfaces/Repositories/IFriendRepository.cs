using Locate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Interfaces.Repositories
{
    public interface IFriendRepository
    {
        Friend Add(Friend friend);
        Friend GetById(int id);
        IEnumerable<Friend> GetAll();
        Friend Update(Friend friend);
        void Remove(Friend friend);
        void Dispose();
    }
}
