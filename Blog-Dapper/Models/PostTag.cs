using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Dapper.Models
{
    [Table("[PostTag]")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
