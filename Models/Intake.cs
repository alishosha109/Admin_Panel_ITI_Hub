﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_ITI.Models
{
    [Table("Intake")]
    public class Intake
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required, Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required, Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Required, Range(3, 12)]
        public int Duration { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required, Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }





        [ForeignKey(nameof(Admin))]
        public string AdminID { get; set; }
        public virtual Admin? Admin { get; set; }


        public virtual IEnumerable<Student>? Students { get; set; }
        public virtual IEnumerable<Intake_Track>? IntakeTracks { get; set; }
        public virtual IEnumerable<Intake_Instructor>? IntakeInstructors { get; set; }
        public virtual IEnumerable<Intake_Track_Course>? IntakeTrackCourse { get; set; }

    }
}
