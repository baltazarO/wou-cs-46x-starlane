﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iCollections.Models
{
    public class SearchList
    {
        public IcollectionUser loggedInUser { get; set; }
        public IEnumerable<IcollectionUser> results { get; set; }
    }
}
