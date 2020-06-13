﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace programmirovanje.Models
{
    public class EditModel
    {
        public int Year { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}