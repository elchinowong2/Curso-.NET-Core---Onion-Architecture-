using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
