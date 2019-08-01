using System;
using StudentExerciseNETCore.Data;
using System.Collections.Generic;
using StudentExerciseNETCore.Model;

namespace StudentExerciseNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            List<Exercise> exercises = repository.GetAllExercises();

            PrintExerciseReport("All Exercises", exercises);

            Pause();
        }

        public static void PrintExerciseReport(string title, List<Exercise> exercises)
        {
            foreach(Exercise exercise in exercises)
            {
                Console.WriteLine(exercise.ExerciseName);
            }
        }
            
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
