﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Person
    {
        [Key]
        public string? IdCard { get; set; }
        public string? Name { get; set; }
        public string? LastNameOne { get; set; }
        public string? LastNameTwo { get; set; }
        public string? Email { get; set; }

    }
}
