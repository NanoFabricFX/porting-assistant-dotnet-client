﻿using PortingAssistant.Client.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortingAssistant.Client.Model
{
    public class PackageDetailsWithApiIndices
    {
        public PackageDetails PackageDetails { get; set; }
        public Dictionary<string, int> IndexDict { get; set; }
    }
}
