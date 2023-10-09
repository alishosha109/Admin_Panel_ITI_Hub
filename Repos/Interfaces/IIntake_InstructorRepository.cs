﻿using Admin_Panel_ITI.Models;

namespace Admin_Panel_ITI.Repos.Interfaces
{
    public interface IIntake_InstructorRepository
    {
        public void deleteIntake_InstructorbyInstructorID(string instructorID);
        public void deleteIntake_Instructor(string intakeID, string insID);
        public void AddIntake_Instructor(Intake_Instructor itc);
        public void AddIntake_Instructor(int IntakeID, string instructorID);


        /*---------------------------------------------- Instructor Repos -----------------------------------------------*/
        public List<Intake_Instructor> GetIntakesByInstructorID(string instructorID);
        public List<Intake_Instructor> getInstructorbyIntakeID(int intakeID, int pageNumber, int pageSize);
    }
}
