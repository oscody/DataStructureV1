using System;
using DataStructureV1.Problems;

namespace DataStructureV1.Tests
{
	public static class TestScoreSimulation
	{
        private static void Description() {

            /*
                 * Problem Description:
                 * Grade Adjustment Simulation
                 *
                 * This function simulates the adjustment of student grades based on their relative performance
                 * compared to their immediate neighbors. The grades are represented in an array where each grade
                 * belongs to a student seated in a row. The grade adjustment follows these rules:
                 *
                 * - If a student's grade is less than the grades of the students directly to their left and right,
                 *   their grade should increase by 1.
                 * - If a student's grade is greater than the grades of the students directly to their left and right,
                 *   their grade should decrease by 1.
                 *
                 * The adjustment process repeats until no grades change in a full pass through the list, indicating
                 * that equilibrium has been reached.
                 *
                 * Constraints:
                 * - The first and last students in the row do not have two neighbors, thus their grades never change.
                 * - Grades are positive integers.
                 *
                 * Input:
                 * - An array of integers 'grades', where each integer represents the grade of a student seated in a row.
                 *
                 * Output:
                 * - The adjusted array of grades after no further changes can be made.
                 *
                 * Example:
                 * Input:  int[] grades = {3, 4, 2, 5, 3};
                 * Output: Final Grades: 3, 4, 4, 4, 3
                 *
                 * Explanation:
                 * - The student with grade 2 (third student) is sitting between students with grades 4 and 5.
                 *   Since 2 is less than both 4 and 5, the grade of the third student increases to 3.
                 * - The student with grade 5 (fourth student) is sitting between students with grades 2 and 3
                 *   (before their adjustment). Since 5 is greater than both 2 and 3, the grade of the fourth student
                 *   decreases to 4.
                 * - Adjustments continue in subsequent iterations based on updated neighbor comparisons until no
                 *   more changes are necessary.
                 *
                 * This simulation is useful for scenarios where local interactions influence overall system equilibria.
                 */

        }
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

                // Clone grades to gradesCopy at the start of each iteration
                int[] gradesCopy = (int[])grades.Clone(); 

                for (int i = 1; i < grades.Length - 1; i++)
                {
                    // Start from 1 to avoid index out of bounds
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

