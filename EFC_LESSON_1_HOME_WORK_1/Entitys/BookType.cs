﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_1_HOME_WORK_1.Entitys
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }


        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
