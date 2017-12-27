using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.Common;
using Exceptions;
namespace AdmissonDAL
{
    public class DAL
    {
        public bool AddStud(student newStud,int courseid,int instid )
        {
            bool studAdded = false;
            try
            {
                DbCommand com = DataConnection.CreateCommand();
                com.CommandText = "AddStud";
                DbParameter param1 = com.CreateParameter();

                //param1 = com.CreateParameter();
                //param1.ParameterName = "@studid";
                //param1.DbType = DbType.Int32;
                //param1.Direction = ParameterDirection.Output;
                //com.Parameters.Add(param1);

                param1 = com.CreateParameter();
                param1.ParameterName = "@studentname";
                param1.DbType = DbType.String;
                param1.Value = newStud.studentName;
                com.Parameters.Add(param1);

                param1 = com.CreateParameter();
                param1.ParameterName = "@dob";
                param1.DbType = DbType.DateTime;
                param1.Value = newStud.dob;
                com.Parameters.Add(param1);

                param1 = com.CreateParameter();
                param1.ParameterName = "@courseid";
                param1.DbType = DbType.Int32;
                param1.Value = courseid;
                com.Parameters.Add(param1);

                param1 = com.CreateParameter();
                param1.ParameterName = "@instituteid";
                param1.DbType = DbType.Int32;
                param1.Value = instid;
                com.Parameters.Add(param1);

                int rowsaff = DataConnection.ExecuteNonQueryCommand(com);
                if(rowsaff > 0)
                {
                    studAdded = true;
                }
            }
            catch(DbException ex)
            {
                string errormessage;
                switch(ex.ErrorCode)
                {
                    case -2146232060:
                        errormessage = "Database Does NotExists Or AccessDenied";
                        break;
                    default:
                        errormessage = ex.Message;
                        break;
                }
                throw new AdmissionException(errormessage);
            }
            return studAdded;
        }
        public List<Course> getCourses()
        {
            DbCommand com = DataConnection.CreateCommand();
            com.CommandText = "getcourses";
            DataTable dt = new DataTable();
            dt = DataConnection.ExecuteSelectCommand(com);
            
            List<Course> courses = new List<Course>();
            if (dt.Rows.Count > 0)
            {
                for(int row = 0; row < dt.Rows.Count; row++)
                {
                    Course cr = new Course();
                    cr.courseID = Convert.ToInt16(dt.Rows[row][0]);
                    cr.courseName = Convert.ToString(dt.Rows[row][1]);
                    courses.Add(cr);
                }
            }
            return courses;
        }
        public List<Institute> getInstitute()
        {
            DbCommand com = DataConnection.CreateCommand();
            com.CommandText = "getinstitute";
            DataTable dt = new DataTable();
            dt = DataConnection.ExecuteSelectCommand(com);
            List<Institute> institutes = new List<Institute>();
            if(dt.Rows.Count>0)
            {
                for(int row=0;row<dt.Rows.Count;row++)
                {
                    Institute ins = new Institute();
                    ins.instituteID = Convert.ToInt16(dt.Rows[row][0]);
                    ins.instituteCity = Convert.ToString(dt.Rows[row][1]);
                    institutes.Add(ins);
                }
            }
            return institutes;
        }
        
    }
}
