﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CorMon.Core.Domain
{
   public class User: BaseEntity
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
