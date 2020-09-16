using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceWithDocker.Models
{
    public class ManageStickNotesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public bool IsDeleted { get; set; }
        public bool Active { get; set; }
    }
}
