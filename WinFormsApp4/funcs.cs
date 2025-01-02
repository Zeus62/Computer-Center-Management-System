using WinFormsApp4;
using System.Text.RegularExpressions;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;

using WinFormsApp4.data;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace funcs
{
    // this is mohamed ramadan elaryb branch dont touch it 

    public static class ValidationMethods
    {
        static AppDbContext db = AppDbContext.Instance;
        public static bool AddStudent(StudentsTable student)
        {
            DataBaseMethods.AddStudent(student);
            return true;
        }
        public static List<string> Employee(EmployeeTable emp)
        {
            List<string> empty_ent = new List<string>();

            if (string.IsNullOrEmpty(emp.name) && string.IsNullOrWhiteSpace(emp.name))
                empty_ent.Add("Name");

            if (string.IsNullOrEmpty(emp.employee_n_id) && string.IsNullOrWhiteSpace(emp.employee_n_id))
                empty_ent.Add("National id");

            if (string.IsNullOrEmpty(emp.phone_number) && string.IsNullOrWhiteSpace(emp.phone_number))
                empty_ent.Add("Phone Number");

            if (string.IsNullOrEmpty(emp.email) && string.IsNullOrWhiteSpace(emp.email))
                empty_ent.Add("Email");
            if (string.IsNullOrEmpty(emp.user_name) && string.IsNullOrWhiteSpace(emp.user_name))
                empty_ent.Add("User Name");
            if (string.IsNullOrEmpty(emp.password) && string.IsNullOrWhiteSpace(emp.password))
                empty_ent.Add("Password");
            return empty_ent;
        }
        public static bool password(EmployeeTable emp, string confirmed_pass)
        {
            if (emp.password == confirmed_pass)
            {
                //MessageBox.Show("Done", "Registration complete", MessageBoxButtons.OK,
                //MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Regeister not complete, please check that password is the same as comfirmed passwoard"
                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public static bool Employee_val(string user_name, string password)
        {
            if (string.IsNullOrWhiteSpace(user_name) &&
                      string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please insert user name and password");
                return false;
            }
            else if (DataBaseMethods.Is_Employee(user_name, password))
            {
                MessageBox.Show("Welcome", DataBaseMethods.getEmpName(user_name),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }



        public static string CreateEmployeeImageFilePath(string imageLocationFolder, EmployeeTable employee)
        {
            string newImageName = $"{employee.user_name}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
            string newImagePath = Path.Combine(imageLocationFolder, newImageName);
            employee.photo_path = newImagePath;
            return newImagePath;
        }

        public static void CopyImage(string imagePath, string newImagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException($"Image not found: {imagePath}");
            }

            Directory.CreateDirectory(Path.GetDirectoryName(newImagePath));

            if (File.Exists(newImagePath))
                File.Delete(newImagePath);

            File.Copy(imagePath, newImagePath);
        }

        public static decimal RoundMoney(decimal amount, decimal roundingValue)
        {
            decimal roundedAmount = Math.Round(amount / roundingValue) * roundingValue;
            return roundedAmount;
        }






        /*  Old Function
        public static bool CopyImage(string source, string usernow, EmployeeTable emp)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                string dest = Environment.CurrentDirectory + "\\images" +
                             $"\\{usernow}.jpg";

                if (File.Exists(dest))
                {
                    File.Delete(dest);
                }

                File.Copy(source, dest);

                emp.photo_path = dest;

                return true;

            }
            else
            {

                MessageBox.Show("Select a photo");
                return false;
            }
        }
        */


        public static bool Email(string email)
        {
            string expectedEmailFormat = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return (Regex.IsMatch(email, expectedEmailFormat) == true);
        }
        public static bool UserName(string username)
        {
            AppDbContext db = AppDbContext.Instance;
            var IsUserFound = db.employees.
                   Where(a => a.user_name == username).FirstOrDefault();
            return (IsUserFound != null);

        }
        public static bool NationalIdLen(string id)
        {

            return Regex.IsMatch(id, @"^\d{14}$");
        }

        public static bool EmpNationalId(string id)
        {
            // elaraby comment this 
            //EmployeeTable IsUserFound = DataBaseMethods.getEmployee(id);
            ////MessageBox.Show("" +(IsUserFound != null));
            //return ((IsUserFound != null)); // return true if id exist

            return (IsNationalExist(id));
        }
        public static bool IsStudent(string id)
        {
            //elaraby comment this
            //StudentsTable IsUserFound = DataBaseMethods.getStudent(id);
            ////MessageBox.Show("" + ((IsUserFound != null) && (ValidationMethods.EmpNationalId(id))));
            //return ((IsUserFound != null) || (ValidationMethods.EmpNationalId(id)));

            return (IsNationalExist(id));
        }

        // elaraby add this 
        public static bool IsNationalExist(string id)
        {
            StudentsTable IsStudentExist = DataBaseMethods.getStudent(id);
            EmployeeTable IsEmpExist = DataBaseMethods.getEmployee(id);
            return ((IsEmpExist != null) || (IsStudentExist != null));
        }

        public static bool StudentCheckOut(string id, string employee_id)
        {
            // return true if this student is in
            if (!DataBaseMethods.IsIn(id))
            {
                MessageBox.Show("Check The ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var totalTime = new TimeSpan(0);

            var stud = db.in_students
                                 .Where(h => h.student_n_id == id)
                                 .FirstOrDefault();

            var timeIn = Convert.ToDateTime(stud.in_time);
            var timeOut = DateTime.Now;
            totalTime += timeOut - timeIn;

            var totalMinutes = totalTime.TotalMinutes/60.0;
            var totalCost = (totalMinutes * SharedValues.CostPerHour) + (stud.paper_printed * SharedValues.CostPerPaper);
            totalCost = Math.Min(totalCost, SharedValues.CostPerHour/2);
            totalCost = (SharedValues.EnableRound ? (double)ValidationMethods.RoundMoney((decimal)totalCost, (decimal)SharedValues.RoundingValue) : totalCost);
            MessageBox.Show($"Student with ID {id} removed\n" +
            $"Time spent: {totalTime.Hours} hours and {totalTime.Minutes} minutes\n" +
            $"Total cost: {totalCost:F2} Pound", "Student Removal Confirmation",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataBaseMethods.StudentCheckOut(id, employee_id, totalCost);
            return true;
        }
        public static bool PhoneNumber(string Number)
        {
            return (Number.Length == 11);
        }

        public static bool IsRightPass(EmployeeTable emp, string password)
        {
            return (emp.password == password);
        }

        public static bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath)?.ToLowerInvariant();
            if (extension != null)
            {
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                return allowedExtensions.Contains(extension);
            }
            return false;
        }
        public static bool StudentCheckIn(string id)
        {
            if (!ValidationMethods.NationalIdLen(id))
            {
                MessageBox.Show("Invalid National ID", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidationMethods.IsStudent(id))
            {
                MessageBox.Show("User Not found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DataBaseMethods.IsIn(id))
            {
                MessageBox.Show("User Already in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DataBaseMethods.AddToInStudent(id);
            return true;
        }

    }


    public static class DataBaseMethods
    {
        static AppDbContext db = AppDbContext.Instance;
        public static bool AddEmployee(EmployeeTable emp)
        {
            //if (ValidationMethods.CopyImage(emp.photo_path, emp.user_name, emp)) // Edited by Abbas & Araby, Cuz image copy should be indpendent
            //{
            try
            {

                db.employees.Add(emp);

                db.SaveChanges();

                return true;
            }
            catch { MessageBox.Show("Error ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }


            //}
            //else return false;
        }


        public static StudentsTable getStudent(string id)
        {
            return db.students.Where((x) => x.student_n_id == id).FirstOrDefault();
        }


        public static EmployeeTable getEmployee(string id)
        {
            return db.employees.Where((x) => x.employee_n_id == id).FirstOrDefault();
        }


        public static string getEmpName(string User_name)
        {
            return (string)db.employees.Where((x) => x.user_name == User_name).Select((x) => x.name).FirstOrDefault();
        }

        public static bool Is_Employee(string user_name, string password)
        {
            return db.employees.Any((x) => x.user_name == user_name && x.password == password);
        }

        public static void AddToInStudent(string id)
        {
            db.in_students.Add(
                new InStudentsTable { student_n_id = id, in_time = DateTime.Now.ToString("HH:mm"), }
                );
            db.SaveChanges();
            MessageBox.Show("Successfully added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<List<string>> getInView()
        {
            return db.students
            .Join(db.in_students, (x) => x.student_n_id, (y) => y.student_n_id, (x, y) => new
            List<string>(){
                x.student_n_id,
                x.name,
                x.faculty,
                x.level.ToString(),
                y.in_time,
            }).ToList();
        }
        public static List<List<string>> GetInHistoryView(string id)
        {
            return db.history
              .Where((x) => ((x.student_n_id == id) || (x.employee_n_id == id)))
              .Select((x) =>
              new List<string>(){
                x.employee_n_id,
                x.student_n_id,
                x.time_in,
                x.time_out,
                x.date,
                x.cost.ToString(),
                x.paper_count.ToString()

              })
              .ToList();
        }

        public static List<List<string>> GetInHistoryView()
        {
            return db.history.Select((x) =>
              new List<string>(){
                x.employee_n_id,
                x.student_n_id,
                x.time_in,
                x.time_out,
                x.date,
                x.cost.ToString(),
                x.paper_count.ToString()

              }).ToList();
        }


        public static void AddStudent(StudentsTable student)
        {
            db.students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Successfully added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void StudentCheckOut(string id, string employee_id, double cost)
        {
            var student = db.in_students.Where((x) => x.student_n_id == id).FirstOrDefault();
            db.history.Add(new HistoryTable
            {
                student_n_id = id,
                time_in = student.in_time,
                time_out = DateTime.Now.ToString("HH:mm"),
                date = DateTime.Now.ToString("dd/MM/yyyy"),
                employee_n_id = employee_id,
                paper_count = student.paper_printed,
                cost = cost
            });
            db.in_students.Remove(student); // added to remove student 
            db.SaveChanges();
            MessageBox.Show("Successfully Checkout", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static EmployeeTable GetEmlpyeeByID(string id)
        {
            var emp = db.employees
                .Where((x) => x.employee_n_id == id)
                .Select((x) => x)
                .FirstOrDefault();
            return emp;
        } // Repeated 

        public static void DeleteEmployeeById(string id) // Delete
        {
            var emp = db.employees
                .Where((x) => x.employee_n_id == id)
                .FirstOrDefault();
            db.employees.Remove(emp);
            db.SaveChanges();
        }

        public static void UpdateEmployeeById(string id, EmployeeTable tempEmp) // Update
        {
            var emp = db.employees.FirstOrDefault(x => x.employee_n_id == id);
            if (emp != null)
            {
                emp.name = tempEmp.name;
                emp.phone_number = tempEmp.phone_number;
                emp.email = tempEmp.email;
                emp.user_name = tempEmp.user_name;
                emp.photo_path = tempEmp.photo_path;
                emp.password = tempEmp.password;

                db.SaveChanges();
            }
        }
        public static bool IsIn(string id)
        {
            return (db.in_students.Where((x) => x.student_n_id == id).FirstOrDefault() != null);
        }


    }


}


