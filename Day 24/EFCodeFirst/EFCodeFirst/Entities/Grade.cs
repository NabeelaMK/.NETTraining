using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entities
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }          //GRADE IS MASTER AND STUDENT IS TRANSACTION
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }     //NAVIGATION PROPERTY
    }
}
