﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelHolidaysTracking.Core.DTOs
{
    public class PersonnelDto
    {
        public int PersonnelId { get; set; }
        public string PersonnelFirstName { get; set; }
        public string PersonnelLastName { get; set; }
        public long ReaminingDay { get; set; }
        public string Department { get; set; }

    }
}
