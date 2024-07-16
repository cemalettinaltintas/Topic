using Topic.WebUI.Dtos.CategoryDtos;

namespace Topic.WebUI.Dtos.BlogDtos
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string ShortDecription { get; set; }
        public string LongDecription { get; set; }
        public string CoverImageUrl { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }

        public int CategoryId { get; set; }

    }
}
