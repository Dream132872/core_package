using OnlineCourse.Web.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Web.Entities.Products
{
    public class ProductCategory : BaseEntity
    {
        #region properties

        public int? ParentId { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Slug { get; set; }

        public bool IsActive { get; set; }

        #endregion

        #region relations

        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }

        public ProductCategory Parent { get; set; }

        #endregion
    }
}
