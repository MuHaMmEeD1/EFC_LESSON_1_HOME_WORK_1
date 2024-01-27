using EFC_LESSON_1_HOME_WORK_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_1.Entitys
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; } 
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; } 
        public DateTime UpdatedDate { get; set; }


    }
}
