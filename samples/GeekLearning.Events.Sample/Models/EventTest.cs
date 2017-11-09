﻿using GeekLearning.Events.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekLearning.Events.Sample.Models
{
    public class EventTest : EventBaseSample
    {
        public EventTest()
        {

        }

        public string Message { get; set; }

        public EventTest(string name, string msg)
            : base($"{name}")
        {
            this.Message = msg;
        }
    }
}
