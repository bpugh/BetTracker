using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetApp.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatorId { get; set; }
        public int PartnerId { get; set; }
        public string Description { get; set; }
    }
}