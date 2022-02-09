using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Models
{
    public class TaskInputModel
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        // Foreign Key Relationships
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int QuadrantId { get; set; }
        public Quadrant Quadrant { get; set; }

    }
}
