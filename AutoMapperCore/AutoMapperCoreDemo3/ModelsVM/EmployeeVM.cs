using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperCoreDemo3.ModelsVM
{
    public class EmployeeVM
    {
        
        public string FullName { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }
    }
}
