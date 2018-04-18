using System;
using System.Collections.Generic;
using System.Text;

namespace Locate.Domain.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Location Location { get; set; }
    }
}
