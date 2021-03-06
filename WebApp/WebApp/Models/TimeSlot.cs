﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Holds information for the time of a class section
    /// </summary>
    public class TimeSlot
    {
        public int Id { get; set; }
        public string dayofweek { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public virtual Section section { get; set; }
    }
}