using OnlineCourse.Web.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace OnlineCourse.Web.Entities.Products
{
    public class Product : BaseEntity
    {
        #region properties

        [MaxLength(255)]
        [Required]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(255)]
        public string ShortDescription { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        public int Inventory { get; set; }

        [MaxLength(1000)]
        public string Tags { get; set; }

        [Required]
        [MaxLength(300)]
        public string Image { get; set; }

        public int Price { get; set; }

        public bool IsActive { get; set; }

        #endregion

        #region MyRegion

        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }

        #endregion
    }
}
