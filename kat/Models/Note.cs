using System;
using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "Содержание заметки обязательно")]
        [StringLength(1000, ErrorMessage = "Содержание заметки не должно превышать 1000 символов")]
        public string Content { get; set; }

        public Category Category { get; set; }
    }
}