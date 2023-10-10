﻿using Admin_Panel_ITI.Areas.InstructorsArea.ViewModels;
using Admin_Panel_ITI.Models;

namespace Admin_Panel_ITI.Repos.Interfaces
{
    public interface IExam_Std_QuestionRepository
    {
        public List<Exam_Std_Question> GetExambyStdIDExmID(int stdID,int exmID);
        public List<Exam_Std_Question> GetExamsbyqid(int qid);
        public Exam_Std_Question GetExam_Std_QuestionbyID(int examID, int studentID, int questionID);
        public void UpdateExam_Std_Question(int examID, int studentID, int questionID, Exam_Std_Question esq);
        public void DeleteExam_Std_Question(int examID, string studentID, int questionID);
        public void DeleteExam_Std_Question(int examID);
        public void DeleteExam_Std_Question(string studentID);
        public void CreateExam_Std_Question(Exam_Std_Question esq);

        public List<ExamSubmitionsVM> GetExam(int examID);
    }
}
