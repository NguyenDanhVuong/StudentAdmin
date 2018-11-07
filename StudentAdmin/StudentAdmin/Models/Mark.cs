using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmin.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string StudentRollNumber { get; set; }
        public int SubjectMark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("StudentRollNumber")]
        public Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public Mark()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}
