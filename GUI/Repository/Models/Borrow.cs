using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GUI.Repository.Models;

[PrimaryKey("BorrowerId", "BookId")]
[Table("BORROW")]
public partial class Borrow
{
    [Key]
    [Column("BORROWER_ID")]
    [StringLength(10)]
    public string BorrowerId { get; set; } = null!;

    [Key]
    [Column("BOOK_ID")]
    [StringLength(10)]
    public string BookId { get; set; } = null!;

    [Column("BORROWED_DATE", TypeName = "datetime")]
    public DateTime? BorrowedDate { get; set; }

    [Column("RETURN_DATE", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("Borrows")]
    public virtual Book Book { get; set; } = null!;

    [ForeignKey("BorrowerId")]
    [InverseProperty("Borrows")]
    public virtual Borrower Borrower { get; set; } = null!;
}
