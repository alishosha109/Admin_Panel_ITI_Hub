﻿using Admin_Panel_ITI.Data;
using Admin_Panel_ITI.Models;
using Admin_Panel_ITI.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Admin_Panel_ITI.Repos.RepoServices
{
    public class Intake_InstructorRepoServices : IIntake_InstructorRepository
    {
        private MainDBContext Context { get; set; }

        public Intake_InstructorRepoServices(MainDBContext context)
        {
            Context = context;
        }
        void IIntake_InstructorRepository.deleteIntake_InstructorbyInstructorID(string instructorID)
        {
            var records = Context.Intake_Instructors.Where(ii => ii.InstructorID == instructorID);
            foreach (var item in records)
            {
                Context.Intake_Instructors.Remove(item);
            }
            Context.SaveChanges();
        }

        void IIntake_InstructorRepository.AddIntake_Instructor(Intake_Instructor itc)
        {
            Context.Intake_Instructors.Add(itc);
            Context.SaveChanges();
        }

        public void AddIntake_Instructor(int IntakeID, string instructorID)
        {
            Intake_Instructor intake_Instructor = new Intake_Instructor()
            {
                IntakeID = IntakeID,
                InstructorID = instructorID
            };

            Context.Intake_Instructors.Add(intake_Instructor);
            Context.SaveChanges();
        }

        public List<Intake_Instructor> GetIntakesByInstructorID(string instructorID)
        {
            return Context.Intake_Instructors.Where(ii => ii.InstructorID == instructorID).Include(ii => ii.Intake).ToList();
        }

        void IIntake_InstructorRepository.deleteIntake_Instructor(string intakeID, string insID)
        {
            Intake_Instructor ii = new Intake_Instructor()
            {

                IntakeID = int.Parse(intakeID),
                InstructorID = insID,
            };
            Context.Intake_Instructors.Remove(ii);
            Context.SaveChanges();
        }

        public List<Intake_Instructor> getInstructorbyIntakeID(int intakeID, int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
            return Context.Intake_Instructors.Include(i => i.Instructor).ThenInclude(i=>i.AspNetUser)
                                  .Include(i => i.Intake)
                                  .Where(intake => intake.IntakeID == intakeID)
                                  .Skip((pageNumber - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();
        }

    }
}
