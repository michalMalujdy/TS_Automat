﻿using System.Collections.Generic;

namespace TS.Core.Models
{
    public class StatesNet
    {
        public State CurrentState { get; set; }
        public string PreviousStateId { get; set; }
        public string PreviousEventId { get; set; }
        public ICollection<State> AllStates { get; set; }
    }
}
