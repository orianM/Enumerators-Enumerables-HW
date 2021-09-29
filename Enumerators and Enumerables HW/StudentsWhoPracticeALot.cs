using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_and_Enumerables_HW
{
    public class student
    {
        public Guid Identifier { get; set; }//not necessary, just wanted to try using Guid
        public int Grade { get; set; }

        public student(int grade)
        {
            this.Grade = grade;
            this.Identifier = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Student Identifier: {Identifier}\nStudent grade: {Grade}\n";
        }
    }

    class StudentsWhoPracticeALot : IEnumerable<student>
    {
        student[] students;

        public StudentsWhoPracticeALot(student[] students)
        {
            this.students = students;
        }

        /// <summary>
        /// Checks If student grade is higher or equal to 10
        /// </summary>
        /// <returns> 
        /// Returns student with grade higher or equal to 10 
        /// </returns>
        public IEnumerator<student> GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade >= 10)
                {
                    yield return students[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
