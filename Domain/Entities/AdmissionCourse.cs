using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities;

public class AdmissionCourse
{
    public int Id { get; set; }
    public int AdmissionId { get; set; }
    public Admission Admission { get; set; } = null!;
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
}