using OnlineCourse.Web.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourse.Web.Entities.Products
{
    public class ProductGallery : BaseEntity
    {
        #region properties

        public int ProductId { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImageName { get; set; }

        #endregion

        #region relations

        public Product Product { get; set; }

        #endregion
    }
}
