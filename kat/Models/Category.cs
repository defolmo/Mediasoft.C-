using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Название категории обязательно")]
        [StringLength(100, ErrorMessage = "Название категории не должно превышать 100 символов")]
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}