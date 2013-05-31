﻿using System;
using System.Collections.Generic;
using NzbDrone.Api.REST;

namespace NzbDrone.Api.Qualities
{
    public class QualityProfileResource : RestResource
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public QualityResource Cutoff { get; set; }
        public List<QualityResource> Qualities { get; set; }
        public List<QualityResource> Allowed { get; set; }
    }

    public class QualityResource : RestResource
    {
        public Int32 Id { get; set; }
        public Int32 Weight { get; set; }
        public String Name { get; set; }
    }
}