using Core.Entities;
using System.Data;

namespace EntitiesLayer2
{
    public class UserRole : IEntity
    {
        public int UserRoleId { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
        public int InsertUserID { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateUserID { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Status { get; set; }

        // Navigation Properties
        public Role Role { get; set; } // Assuming you have a Role class
        public User User { get; set; } // Assuming you have a User class
    }
}
