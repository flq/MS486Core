using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC486.Models
{
    public class Speaker 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpeakerID {get;set;}

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Speaker")]
        public string Name {get;set;}

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get;set;}
        
        //public virtual List<Session> Sessions {get;set;}

    }

}