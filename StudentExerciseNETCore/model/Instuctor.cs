using StudentExerciseNETCore.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExerciseNETCore.Model
{
   public class Instructor
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }

        public string CohortId { get; set; }

        public Cohort Cohort { get; set; }




    }
}
