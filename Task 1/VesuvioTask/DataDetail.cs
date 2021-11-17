using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VesuvioTask
{
    public class DataDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Full Name is Missing")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Group Name is Missing")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Age is Missing")]
        public int Age { get; set; }
    }
}
