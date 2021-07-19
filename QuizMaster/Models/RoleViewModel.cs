using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizMaster.Models
{
    public class RoleViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
