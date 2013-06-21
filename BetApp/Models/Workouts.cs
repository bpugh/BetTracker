using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetApp.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string Notes { get; set; }
    }
}