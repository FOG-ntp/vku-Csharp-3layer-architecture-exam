using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GUI.Repository.Models;

[Table("BOOK")]
public partial class Book
{
    [Key]
    [Column("BOOK_ID")]
    [StringLength(10)]
    public string BookId { get; set; } = null!;

    [Column("BOOKNAME")]
    [StringLength(100)]
    public string? Bookname { get; set; }

    [Column("AUTHOR")]
    [StringLength(50)]
    public string? Author { get; set; }

    [Column("PUBLICATION_YEAR")]
    public int? PublicationYear { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
}
