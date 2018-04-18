using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Application.ViewModels
{
    public class FriendLocatedViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
        public string Path { get; set; }
        public string Coordinates { get; set; }
    }
}
