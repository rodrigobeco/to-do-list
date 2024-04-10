using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("todo")]
    public class Todo
    {
        [Key]
        [Column("id")]
        [DisplayName("Código")]
        public int Id { get; set; }

        [Column("title")]
        [DisplayName("Título")]
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Column("content")]
        [DisplayName("Descrição")]
        [Required]
        [StringLength(255)]
        public string Content { get; set; }

        [Column("completed")]
        [DisplayName("Descrição")]
        [Required]
        public bool IsCompleted { get; set; }
    }
}