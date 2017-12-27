using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using AdmissonDAL;
using Exceptions;
namespace AdmissionBAL
{
    public class BAL
    {
        public bool AddStud(student newStud,int courseid,int insid)
        {
            bool studAdded;
            try
            {
                DAL studal = new DAL();
                studAdded = studal.AddStud(newStud,courseid,insid);
            }
            catch (AdmissionException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return studAdded;
        }

        public List<Institute> getInstitute()
        {
            DAL obj = new DAL();
            return obj.getInstitute();
        }

        public List<Course> getCourse()
        {
            DAL obj = new DAL();
            return obj.getCourses();
        }
    }
}
