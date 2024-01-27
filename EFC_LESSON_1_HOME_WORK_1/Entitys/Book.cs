using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_1.Entitys
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }


        public ICollection<Student> students { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public BookType BookType { get; set; }
    }
}
