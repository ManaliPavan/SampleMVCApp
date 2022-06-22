using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleMVCApp.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BookID { get; set; }

        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Book Name is required")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Author Name is Required")]
        [MaxLength(20)]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Publisher Name is Required")]
        [MaxLength(40)]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Published date is Required")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(minimum: 10, maximum: 1000, ErrorMessage = "Price should be between 10-1000")]
        public int Price { get; set; }
    }
}