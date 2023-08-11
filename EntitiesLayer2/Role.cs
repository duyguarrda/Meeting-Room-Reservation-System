using Core.Entities;

namespace EntitiesLayer2
{
  
        public class Role : IEntity
    {
            public int RoleId { get; set; }
            public string RoleName { get; set; }
            public int InsertUserID { get; set; }
            public DateTime InsertDate { get; set; }
            public int? UpdateUserID { get; set; }
            public DateTime? UpdateDate { get; set; }
            public bool Status { get; set; }
        }
    }
