﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.DTOLayer.Dtos.ContactDtos
{
    public class ResultContactDto
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string MapUrl { get; set; }
    }
}
