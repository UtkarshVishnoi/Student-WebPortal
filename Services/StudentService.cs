using WebPortal.Data;

namespace WebPortal.Services
{
    public class StudentService
    {
        protected readonly ApplicationDbContext _dbcontext;
        public StudentService(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }

        public List<StudentClass> getAllStudentDetails()
        {
            return _dbcontext.tblStudent.ToList();
        }

        public StudentClass getStudentDetails(int id)
        {
            List<StudentClass> stdList = _dbcontext.tblStudent.ToList();

            for (int i = 0; i < stdList.Count; i++)
            {
                if (stdList[i].id == id)
                {
                    return stdList[i];
                }                    
            }

            return null;
        }

        public StudentClass editDetails(int id)
        {
            StudentClass student = new StudentClass();
            return _dbcontext.tblStudent.FirstOrDefault(u => u.id == id);
        }

        public bool addStudent(StudentClass student)
        {
            _dbcontext.tblStudent.Add(student);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool updateDetails(StudentClass stdUpdate)
        {
            var stdDetails = _dbcontext.tblStudent.FirstOrDefault(u => u.id == stdUpdate.id);
            if (stdDetails != null)
            {
                stdDetails.id = stdUpdate.id;
                stdDetails.name = stdUpdate.name;
                stdDetails.username = stdUpdate.username;
                stdDetails.course = stdUpdate.course;
                stdDetails.semester = stdUpdate.semester;
                stdDetails.cgpa = stdUpdate.cgpa;
                stdDetails.dob = stdUpdate.dob;
                stdDetails.hometown = stdUpdate.hometown;
                stdDetails.password = stdUpdate.password;
                stdDetails.dept_id = stdUpdate.dept_id;
                _dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteStudent(StudentClass stdUpdate)
        {
            var stdDetails = _dbcontext.tblStudent.FirstOrDefault(u => u.id == stdUpdate.id);
            if (stdDetails != null)
            {
                _dbcontext.Remove(stdDetails);
                _dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
