using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntities
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
