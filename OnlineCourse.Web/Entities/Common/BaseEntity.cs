using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Web.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
