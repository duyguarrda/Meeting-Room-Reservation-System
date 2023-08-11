using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public object InsertDate { get; set; }
        public object InsertUserId { get; set; }
        public object UpdateDate { get; set; }
        public object UpdateUserId { get; set; }
    }
}
