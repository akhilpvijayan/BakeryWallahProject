using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallahProject.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        [Display ( Name = "Product Image")]
        public string ProductImage { get; set; }
        [Required]
        public int BakerId { get; set; }
        [ForeignKey("BakerId")]
        public UserModel UserModel { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool IsVeg { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ManufactureDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpiryDate { get; set; }
    }
}
