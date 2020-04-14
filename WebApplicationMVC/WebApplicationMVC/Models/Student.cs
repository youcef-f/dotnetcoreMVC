
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVC.Models
{

    //[Table("Students")]
    public class Student
    {

        [Key]
        public long StudentId { get; set; }
      
        [Required, StringLength(25)]
        public string Name { get; set; }
        public int Score { get; set; }
    }
}