using System;

namespace Truke.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public DateTime Datetime { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUserOwner { get; set; }
    }
}