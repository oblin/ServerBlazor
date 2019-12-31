using System;
using System.ComponentModel.DataAnnotations;

namespace ServerBlazor.Data
{
    public class JobApplication
    {
        [Required, StringLength(10, ErrorMessage = "不要超過10個字")]
        public string FullName { get; set; }       
        public string Description { get; set; }
        [Required, Range(10000, 50000, ErrorMessage = "Between 10000 ~ 50000")]
        public int Salary { get; set; }
        [Required]
        public bool DoesOpenSource { get; set; }
        [Required]
        public DateTime Available { get; set; }
    }
}