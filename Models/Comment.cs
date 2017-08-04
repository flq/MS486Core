using System.ComponentModel.DataAnnotations.Schema;

namespace MVC486.Models
{
    public class Comment 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId {get;set;}
        public int SessionId {get;set;}
        public string Content {get;set;}
    }
}