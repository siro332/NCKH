﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models.Entities
{
    [Table("course_class")]
    public class CourseClass
    {
        [Key]
        public long id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string time { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string location { get; set; }

        [ForeignKey("Courseid")]
        public long Courseid { get; set; }

        public Course Course { get; set; }
    }
}