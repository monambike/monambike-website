using System;
using System.Collections.Generic;

namespace Monambike.WebAPI.Models.Diary
{
    public class DiaryTest
    {
        public DateTime WhenIWrote { get; set; }

        public decimal HowIWasFeeling { get; set; }

        public string WhatHappened { get; set; }


        public List<Tag> Tags { get; set; }
    }
}
