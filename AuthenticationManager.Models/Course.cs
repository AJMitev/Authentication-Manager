namespace AuthenticationManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AuthenticationManager.Models.Contracts;

    public class Course : ICourse
    {

        public Course(string name)
        {
            this.Name = name;
            this.Students = new HashSet<IStudent>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Teacher TeacherId { get; set; }

        public virtual ICollection<IStudent> Students { get; set; }
        
    }
}