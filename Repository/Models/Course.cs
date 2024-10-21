using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Repository.Models;

public partial class Course
{
    [Key]
    [Column("CourseID")]
    public int CourseId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string CourseName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Lecturer { get; set; } = null!;

    [InverseProperty("Course")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
