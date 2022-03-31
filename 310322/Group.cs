using System;
using System.Collections.Generic;
using System.Text;

namespace _310322
{
    internal class Group
    {
        public string No { get; }
        private Student[] students = new Student[0];
        public GroupType Type { get; set; }

        private static int _programming_count;
        private static int _system_count;
        private static int _design_count;
        public Group(GroupType Type)
        {
            if (Type == GroupType.programming)
            {
                _programming_count++;
                int programing_NumNo = 100 + _programming_count;
                No = "P" + programing_NumNo;
            }
            if (Type == GroupType.system)
            {
                _system_count++;
                int system_NumNo = 100 + _system_count;
                No = "S" + system_NumNo;
            }

            if (Type == GroupType.design)
            {
                _design_count++;
                int desigin_NumNo = 100 + _design_count;
                No = "D" + desigin_NumNo;
            }

        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student GetStudentByNo(int? no)
        {
            if (no == null)
                throw new NullReferenceException("No null ola bilmez");

            foreach (var student in students)
            {
                if (student.No == no)
                    return student;
            }
            return null;
        }
    }



}

