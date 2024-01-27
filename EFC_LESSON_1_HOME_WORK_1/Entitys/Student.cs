using EFC_LESSON_1_HOME_WORK_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_1.Entitys
{
    public class Student : BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime BDay {  get; set; } 
        public string PhoneNumder { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}
