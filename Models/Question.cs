﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Admin_Panel_ITI.Models
{
    //public enum QuestionType { MCQ, Paragraph, NA }

    [Table("Question")]
    public class Question
    {
        [Key]
        [JsonIgnore]
        public int ID { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        public int Mark { get; set; }

        public virtual IEnumerable<Exam_Std_Question>? Student_Quest_Exam { get; set; }

        public virtual IEnumerable<Exam_Question>? Exam_Question { get; set; }

    }
}
