using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Repository.Models;

public partial class Student
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string StudentName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("CourseID")]
    public int? CourseId { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Students")]
    public virtual Course? Course { get; set; }
}
