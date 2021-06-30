using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razordemo.Models
{
    public class Credentials
    {
        public String lastName { get; set; }
        public String studentid { get; set; }

        public Credentials(String argStudentid, String argLastName)
        {
            lastName = argLastName;
            studentid = argStudentid;
        }
    }
}
