using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcCleanArchitecture.Domain.Common
{
    public  class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? RegisterDateTime { get; set; }
    }
}
