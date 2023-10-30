using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GUI.Repository.Models;

[Table("BORROWER")]
public partial class Borrower
{
    [Key]
    [Column("BORROWER_ID")]
    [StringLength(10)]
    public string BorrowerId { get; set; } = null!;

    [Column("FIRSTNAME")]
    [StringLength(50)]
    public string? Firstname { get; set; }

    [Column("LASTNAME")]
    [StringLength(50)]
    public string? Lastname { get; set; }

    [Column("ADDRESS")]
    [StringLength(100)]
    public string? Address { get; set; }

    [Column("PHONE")]
    [StringLength(15)]
    public string? Phone { get; set; }

    [InverseProperty("Borrower")]
    public virtual ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
}
