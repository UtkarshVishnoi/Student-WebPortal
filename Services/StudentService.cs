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

        public StudentClass? getStudentDetails(int id)
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

        public StudentClass? findUser(string username, string password)
        {
            List<StudentClass> stdList = getAllStudentDetails();

            for (int i = 0; i < stdList.Count; i++)
            {
                if (stdList[i].username == username && stdList[i].password == password)
                {
                    return stdList[i];
                }
            }

            return null;
        }

        public StudentClass? editDetails(int id)
        {
            return _dbcontext.tblStudent.FirstOrDefault(u => u.id == id);
        }

        public void addStudent(StudentClass student)
        {
            _dbcontext.tblStudent.Add(student);
            _dbcontext.SaveChanges();
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
                stdDetails.is_logged = stdUpdate.is_logged;
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

        public void toggleLoggedStatus(StudentClass obj)
        {
			var stdDetails = _dbcontext.tblStudent.FirstOrDefault(u => u.id == obj.id);
            if (stdDetails != null) { 
                stdDetails.is_logged = stdDetails.is_logged ? false : true;
                _dbcontext.SaveChanges();
            }
		}

        public int getLoggedUser()
        {
			List<StudentClass> stdList = _dbcontext.tblStudent.ToList();

			for (int i = 0; i < stdList.Count; i++)
			{
				if (stdList[i].is_logged) return stdList[i].id;
			}

			return 0;
		}
    }
}
