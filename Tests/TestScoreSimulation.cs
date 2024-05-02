using System;
using DataStructureV1.Problems;

namespace DataStructureV1.Tests
{
	public static class TestScoreSimulation
	{
		public static void Soulution() {

            Console.WriteLine("Test Score Simulation");

            int[] list = new int[] { 1, 6, 4, 3,5 };
            Try1(list);

            // Test the function with example inputs
            int[] example1 = { 1, 6, 3, 4, 3, 5 };
            int[] example2 = { 100, 50, 40, 30 };

            var finalExample1 = FinalScores(example1);
            var finalExample2 = FinalScores(example2);

            Try1(example1);

            Console.WriteLine($"Example 1 Final Scores: {String.Join(", ", finalExample1)}");
            Console.WriteLine($"Example 2 Final Scores: {String.Join(", ", finalExample2)}");

        }

        private static void Try1(int[] grades)
        {
            Console.WriteLine("My try");

            bool changed = true;

            while (changed)
            {
                changed = false; 
                int[] gradesCopy = (int[])grades.Clone(); // Clone grades to gradesCopy at the start of each iteration

                for (int i = 1; i < grades.Length - 1; i++)
                { // Start from 1 to avoid index out of bounds
                    Console.WriteLine($"this is i-{i}");
                    if (grades[i] < grades[i - 1] && grades[i] < grades[i + 1])
                    {
                        gradesCopy[i] += 1;
                        changed = true;
                    }
                    else if (grades[i] > grades[i - 1] && grades[i] > grades[i + 1])
                    {
                        gradesCopy[i] -= 1;
                        changed = true;
                    }
                }

                grades = gradesCopy; // Update grades only after all changes for the iteration are done
            }

            // Print the updated array
            Console.WriteLine($"Final Grades: {String.Join(", ", grades)}");
            Helper.ArrayToString(grades);
        }



        public static int[] FinalScores(int[] initialScores)
        {
            bool changed = true;  // Start with 'changed' as true to enter the loop
            int[] scores = (int[])initialScores.Clone();

            while (changed)
            {
                changed = false;
                int[] newScores = (int[])scores.Clone();

                for (int i = 1; i < scores.Length - 1; i++)
                {
                    if (scores[i] < scores[i - 1] && scores[i] < scores[i + 1])
                    {
                        newScores[i]++;
                        changed = true;
                    }
                    else if (scores[i] > scores[i - 1] && scores[i] > scores[i + 1])
                    {
                        newScores[i]--;
                        changed = true;
                    }
                }

                scores = newScores;
            }

            return scores;
        }

        public static int[] FinalScoresDoWhile(int[] initialScores)
        {
            bool changed;
            int[] scores = (int[])initialScores.Clone();

            do
            {
                changed = false;
                int[] newScores = (int[])scores.Clone();

                for (int i = 1; i < scores.Length - 1; i++)
                {
                    if (scores[i] < scores[i - 1] && scores[i] < scores[i + 1])
                    {
                        newScores[i]++;
                        changed = true;
                    }
                    else if (scores[i] > scores[i - 1] && scores[i] > scores[i + 1])
                    {
                        newScores[i]--;
                        changed = true;
                    }
                }

                scores = newScores;
            } while (changed);

            return scores;
        }

        public static List<int> FinalScoresList(List<int> A)
        {
            bool changed;
            List<int> scores = new List<int>(A);
            do
            {
                changed = false;
                List<int> newScores = new List<int>(scores);

                for (int i = 1; i < scores.Count - 1; i++)
                {
                    if (scores[i] < scores[i - 1] && scores[i] < scores[i + 1])
                    {
                        newScores[i]++;
                        changed = true;
                    }
                    else if (scores[i] > scores[i - 1] && scores[i] > scores[i + 1])
                    {
                        newScores[i]--;
                        changed = true;
                    }
                }

                scores = new List<int>(newScores); // Make sure to clone the list, not the array
            } while (changed);

            return scores;
        }

    }
}

