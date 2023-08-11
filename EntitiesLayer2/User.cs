using Core.Entities;
using EntitiesLayer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer2
{
    public class User :IEntity
    {

        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string UserSurname { get; set; } = null!;

        public DateTime? Birthday { get; set; }

        public int? GenderId { get; set; }

        public int StafftitleId { get; set; }

        public int InsertUserId { get; set; }

        public DateTime InsertDate { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool Status { get; set; }

        public string Email { get; set; } = null!;

        public bool PasswordSalt { get; set; }

        public bool PasswordHash { get; set; }

        public virtual Gender? Gender { get; set; }

        public virtual Stafftitle Stafftitle { get; set; } = null!;

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
