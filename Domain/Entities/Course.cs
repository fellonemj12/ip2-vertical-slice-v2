using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
