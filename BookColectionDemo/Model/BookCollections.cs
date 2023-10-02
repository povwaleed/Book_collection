using System.ComponentModel.DataAnnotations;

namespace BookColectionDemo.Model
{
    public class BookCollections
    {
        public int ID { get; set; }


        [Required(ErrorMessage ="Please Enter Title name")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="Please enter title name minimum 3 characters")]
        public string Title { get; set; }

        [Display(Name ="Author Name")]
        [Required(ErrorMessage = "Please Enter Auther name")]

        public string AutherName { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Rattng")]
        [RegularExpression(@"[1-5]+$",ErrorMessage ="Rating must be between 1 to 5")]
        [Required(ErrorMessage = "Please Enter ratting")]

        public string Rating { get; set; }


    }
}
