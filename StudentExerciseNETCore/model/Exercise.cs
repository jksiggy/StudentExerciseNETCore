using StudentExerciseNETCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExerciseNETCore
{
   public class Exercise
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }

        public string InstructorId { get; set; }

        public Instructor Instructor { get; set; }
    }
}
