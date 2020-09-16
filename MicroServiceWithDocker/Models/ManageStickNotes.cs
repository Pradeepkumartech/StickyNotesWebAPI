using System;

namespace MicroServiceWithDocker.Models
{
    public class ManageStickNotes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public bool IsDeleted { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
