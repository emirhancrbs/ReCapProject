﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string? BrandName { get; set; }
        public string? ColorName { get; set; }
        public List<string>? ImagePaths { get; set; }
        public decimal DailyPrice { get; set; }
        public string? Description { get; set; }
    }
}
