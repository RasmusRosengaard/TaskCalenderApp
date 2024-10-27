using System.ComponentModel.DataAnnotations;

namespace TaskCalApp.Models
{
    public class Task
    {

        public int TaskId { get; set; }


        [Required]
        public string? Title { get; set; }


        public string? Description { get; set; }




        [DateRange(1, 5, ErrorMessage = "Date must be within the last year and up to 5 years in the future")]
        [Display(Name = "Estimated Start Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [Display(Name = "Estimated End Date")]
        [Required]
        public DateTime DoneDate { get; set; } = DateTime.Now;

    }
}
