using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC486.Models
{
    public class Session 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SessionId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        [DataType(DataType.MultilineText)]
        public string Abstract {get;set;}
        public int SpeakerID {get;set;}
        public virtual Speaker Speaker {get;set;}
    }

}