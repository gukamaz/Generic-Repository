using System;
using System.ComponentModel.DataAnnotations;

namespace Generic_Repository.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }

        [Key]
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
