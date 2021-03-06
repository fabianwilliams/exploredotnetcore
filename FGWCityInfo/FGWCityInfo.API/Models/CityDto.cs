﻿using System;
using System.Collections.Generic;

namespace FGWCityInfo.API.Models
{
    public class CityDto
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int NumberOfPointOfInterest
        {
            get{
                return PointOfInterest.Count;
            }

        }

        public ICollection<PointOfInterestDto> PointOfInterest { get; set; }
        = new List<PointOfInterestDto>();

    }
}
