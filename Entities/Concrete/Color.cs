using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color:IEntities
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}