using Microsoft.Data.SqlClient;
using System.Data;

namespace Hospital_Management
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
    @"Server=(localdb)\MSSQLLocalDB;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";




        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


      

        public static bool Login(string username, string password, string role)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Users u
                INNER JOIN Roles r
                    ON u.RoleID = r.RoleID
                WHERE u.UserName = @username
                  AND u.Password = @password
                  AND r.RoleName = @role";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }


        public static int GetPatientID(string username)
        {
            string query = @"
                SELECT p.PatientID
                FROM Patients p
                INNER JOIN Users u
                    ON p.UserID = u.UserID
                WHERE u.UserName = @username";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }

        public static bool SignUp(string username, string password, string role)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Get RoleID
                        string roleQuery = @"
                            SELECT RoleID
                            FROM Roles
                            WHERE RoleName = @role";

                        int roleID;

                        using (SqlCommand roleCmd = new SqlCommand(roleQuery, con, transaction))
                        {
                            roleCmd.Parameters.AddWithValue("@role", role);

                            object result = roleCmd.ExecuteScalar();

                            if (result == null)
                            {
                                transaction.Rollback();
                                return false;
                            }

                            roleID = Convert.ToInt32(result);
                        }


                        // 2. Insert into Users
                        string userQuery = @"
                            INSERT INTO Users (UserName, Password, RoleID)
                            OUTPUT INSERTED.UserID
                            VALUES (@username, @password, @roleID)";

                        int userID;

                        using (SqlCommand userCmd = new SqlCommand(userQuery, con, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@username", username);
                            userCmd.Parameters.AddWithValue("@password", password);
                            userCmd.Parameters.AddWithValue("@roleID", roleID);

                            userID = Convert.ToInt32(userCmd.ExecuteScalar());
                        }


                        // 3. Create profile according to role

                        if (role == "Patient")
                        {
                            string patientQuery = @"
                                INSERT INTO Patients
                                (
                                    UserID,
                                    PatientName
                                )
                                VALUES
                                (
                                    @userID,
                                    @patientName
                                )";

                            using (SqlCommand patientCmd =
                                new SqlCommand(patientQuery, con, transaction))
                            {
                                patientCmd.Parameters.AddWithValue("@userID", userID);
                                patientCmd.Parameters.AddWithValue("@patientName", username);

                                patientCmd.ExecuteNonQuery();
                            }
                        }

                        else if (role == "Doctor")
                        {
                            string doctorQuery = @"
                                    INSERT INTO Doctors
                                    (
                                        UserID,
                                        DoctorName,
                                        Specialization
                                    )
                                    VALUES
                                    (
                                        @userID,
                                        @doctorName,
                                        @specialization
                                    )";

                            using (SqlCommand doctorCmd =new SqlCommand(doctorQuery, con, transaction))
                                {
                                    doctorCmd.Parameters.AddWithValue("@userID", userID);
                                    doctorCmd.Parameters.AddWithValue("@doctorName", username);
                                    doctorCmd.Parameters.AddWithValue("@specialization", "");

                                    doctorCmd.ExecuteNonQuery();
                                }
                        }

                        else if (role == "Cashier")
                        {
                            string cashierQuery = @"
                                    INSERT INTO Cashiers
                                    (
                                        UserID,
                                        CashierName
                                    )
                                    VALUES
                                    (
                                        @userID,
                                        @cashierName
                                    )";

                            using (SqlCommand cashierCmd =
                                new SqlCommand(cashierQuery, con, transaction))
                            {
                                cashierCmd.Parameters.AddWithValue("@userID", userID);
                                cashierCmd.Parameters.AddWithValue("@cashierName", username);

                                cashierCmd.ExecuteNonQuery();
                            }
                        }

                        // 4. Everything succeeded
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        // If anything fails, undo everything
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }



        public static bool UsernameExists(string username)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE UserName = @username";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }




        public static DataTable SearchPatient(string patientName)
        {
            string query = @"
               SELECT
                    PatientID,
                    PatientName,
                    Age,
                    Gender,
                    BloodGroup,
                    MedicalHistory
                FROM Patients
                WHERE PatientName LIKE @name";

                using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + patientName + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        return table;
                    }
                }
            }
        }


  


        public static bool AddPatient(string name,int age,string gender,string bloodGroup,string medicalHistory)
        {
            string query = @"
                INSERT INTO Patients
                (
                    PatientName,
                    Age,
                    Gender,
                    BloodGroup,
                    MedicalHistory
                )
                VALUES
                (
                    @name,
                    @age,
                    @gender,
                    @bloodGroup,
                    @medicalHistory
                )";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@bloodGroup", bloodGroup);
                    cmd.Parameters.AddWithValue("@medicalHistory", medicalHistory);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool AddPrescriptionToHistory(int patientID,string prescriptionText)
        {
            string query = @"
                UPDATE Patients
                SET MedicalHistory =
                    CASE
                        WHEN MedicalHistory IS NULL
                             OR MedicalHistory = ''
                        THEN @prescription
                        ELSE MedicalHistory
                             + CHAR(13) + CHAR(10)
                             + CHAR(13) + CHAR(10)
                             + @prescription
                    END
                WHERE PatientID = @patientID";

            int rowsAffected = ExecuteNonQuery(
                query,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@patientID",
                    patientID),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@prescription",
                    prescriptionText));

            return rowsAffected > 0;
        }

        public static DataTable GetDoctors()
        {
            string query = @"
                SELECT DoctorID, DoctorName, Specialization,Age
                FROM Doctors";

            return ExecuteQuery(query);
        }

        public static DataTable GetCashiers()
        {
            string query = @"
                SELECT
                    c.CashierID,
                    c.UserID,
                    c.CashierName,
                    c.Specialization,
                    c.Age
                FROM Cashiers c
                INNER JOIN Users u
                    ON c.UserID = u.UserID
                INNER JOIN Roles r
                    ON u.RoleID = r.RoleID
                WHERE r.RoleName = 'Cashier'";

            return ExecuteQuery(query);
        }

        public static int ExecuteNonQuery(string query,params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query,params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        return table;
                    }
                }
            }
        }

        public static bool UpdateDoctor(int doctorID,string doctorName,string specialization,int age)
        {
            string query = @"
                UPDATE Doctors
                SET 
                    DoctorName = @name,
                    Specialization = @specialization,
                    Age = @age
                WHERE DoctorID = @doctorID";

            int result = ExecuteNonQuery(
                query,
                new SqlParameter("@doctorID", doctorID),
                new SqlParameter("@name", doctorName),
                new SqlParameter("@specialization", specialization),
                new SqlParameter("@age", age)
            );

            return result > 0;
        }

        public static bool DeleteDoctor(int doctorID)
        {
            string query = @"
                DELETE FROM Doctors
                WHERE DoctorID = @doctorID";

            int result = ExecuteNonQuery(query, new SqlParameter("@doctorID", doctorID)
            );

            return result > 0;
        }

        public static bool UpdateCashier(int cashierID,string cashierName,string specialization,int age)
        {
            string query = @"
                UPDATE Cashiers
                SET
                    CashierName = @name,
                    Specialization = @specialization,
                    Age = @age
                WHERE CashierID = @cashierID";

            int result = ExecuteNonQuery(
                query,
                new SqlParameter("@cashierID", cashierID),
                new SqlParameter("@name", cashierName),
                new SqlParameter("@specialization", specialization),
                new SqlParameter("@age", age)
            );

            return result > 0;
        }


        public static bool DeleteCashier(int cashierID)
        {
            string query = @"
                DELETE FROM Cashiers
                WHERE CashierID = @cashierID";

            int result = ExecuteNonQuery(
                query,
                new SqlParameter("@cashierID", cashierID)
            );

            return result > 0;
        }

        public static string GetPatientHistory(int patientID)
        {
            string query = @"
                    SELECT MedicalHistory
                    FROM Patients
                    WHERE PatientID = @patientID";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return "";
                    }

                    return result.ToString();
                }
            }
        }

        public static bool UpdatePatient(int patientID,string patientName,int age,string gender,string bloodGroup,string medicalHistory)
        {
            string query = @"
                UPDATE Patients
                SET
                    PatientName = @name,
                    Age = @age,
                    Gender = @gender,
                    BloodGroup = @bloodGroup,
                    MedicalHistory = @medicalHistory
                WHERE PatientID = @patientID";

            int result = ExecuteNonQuery(
                query,
                new SqlParameter("@patientID", patientID),
                new SqlParameter("@name", patientName),
                new SqlParameter("@age", age),
                new SqlParameter("@gender", gender),
                new SqlParameter("@bloodGroup", bloodGroup),
                new SqlParameter("@medicalHistory", medicalHistory)
            );

            return result > 0;
        }
        public static DataTable GetDoctorsForAppointment()
        {
            string query = @"
                SELECT
                    DoctorID,
                    DoctorName,
                    Specialization
                FROM Doctors
                ORDER BY DoctorName";

            return ExecuteQuery(query);
        }

        public static bool IsTimeSlotBooked(int doctorID,DateTime appointmentDate,TimeSpan startTime,TimeSpan endTime)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Appointments
                WHERE DoctorID = @doctorID
                  AND CAST(AppointmentDate AS DATE) = @appointmentDate
                  AND StartTime < @endTime
                  AND EndTime > @startTime
                  AND Status <> 'Cancelled'";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@doctorID", doctorID);
                    cmd.Parameters.AddWithValue(
                        "@appointmentDate",
                        appointmentDate.Date);
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static bool BookAppointment(int patientID,int doctorID,DateTime appointmentDate,TimeSpan startTime,TimeSpan endTime)
        {
            string query = @"
                INSERT INTO Appointments
                (
                    PatientID,
                    DoctorID,
                    AppointmentDate,
                    StartTime,
                    EndTime,
                    Status
                )
                VALUES
                (
                    @patientID,
                    @doctorID,
                    @appointmentDate,
                    @startTime,
                    @endTime,
                    'Booked'
                )";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);
                    cmd.Parameters.AddWithValue("@doctorID", doctorID);
                    cmd.Parameters.AddWithValue(
                        "@appointmentDate",
                        appointmentDate.Date);
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}