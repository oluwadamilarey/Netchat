using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Identity;

namespace Netchat.Models
{

    public class Chat 
    {
        public int Id { get; set; }
        public ICollection<Message> Messages { get; set; } 
        public ICollection<User> Users { get; set; }
        public ChatType Type { get; set; } 
    }
}