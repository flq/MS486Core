using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC486.Models
{
    public class Speaker 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpeakerID {get;set;}

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Speaker")]
        public string Name {get;set;}

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get;set;}
        public virtual List<Session> Sessions {get;set;}

    }

}