using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.DTOLayer.Dtos.CategoryDto
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public bool Status { get; set; }=true;
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
