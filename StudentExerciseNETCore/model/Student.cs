using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExerciseNETCore.model
{
   public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }
    }
}
