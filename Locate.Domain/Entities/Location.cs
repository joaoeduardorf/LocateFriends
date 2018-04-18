using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int? FriendId { get; set; }
        public Friend Friend { get; set; }
    }
}
