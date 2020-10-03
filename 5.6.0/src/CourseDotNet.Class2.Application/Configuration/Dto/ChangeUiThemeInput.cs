﻿using System.ComponentModel.DataAnnotations;

namespace CourseDotNet.Class2.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}