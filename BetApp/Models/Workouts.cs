using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetApp.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public Bet Bet { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int UserId { get; set; }
        public string Notes { get; set; }
    }
}