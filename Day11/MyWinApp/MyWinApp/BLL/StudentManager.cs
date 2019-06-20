using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;
using MyWinApp.Repository;

namespace MyWinApp.BLL
{
   public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public DataTable LoadDistrict()
        {
            return _studentRepository.LoadDistrict();
        }

        public DataTable ShowStudents()
        {
            return _studentRepository.ShowStudents();
        }

        internal int InsertStudent(Student student)
        {
            
            return _studentRepository.InsertStudent(student);
        }
        internal int EditStudent(Student student, int Id)
        {

            return _studentRepository.EditStudent(student, Id);
        }

        public int DeleteStudent(int Id)
        {
            int result = _studentRepository.DeleteStudent(Id);
            return result;
        }

        public DataTable SearchStudent(string name)
        {
            return _studentRepository.SearchStudent(name);
        }
    }
}
