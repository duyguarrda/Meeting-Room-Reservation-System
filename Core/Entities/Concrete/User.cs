using Core.Entities;
using System;
using System.Collections.Generic;

namespace Core.Entities.Concrete
{
    public partial class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }

        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }

        public DateTime? Birthday { get; set; }

        public int? GenderId { get; set; }

        public int StafftitleId { get; set; }

        public int InsertUserId { get; set; }

        public DateTime InsertDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Gender? Gender { get; set; }

        public virtual Stafftitle Stafftitle { get; set; } = null!;
    }
}