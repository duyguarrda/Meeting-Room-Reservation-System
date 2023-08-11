using Core.Entites;
using System;
using System.Collections.Generic;

namespace EntitiesLayer;

public partial class UserRole : IEntity
{
    public int UserRoleId { get; set; }

    public int RoleId { get; set; }

    public int UserId { get; set; }

    public int InsertUserId { get; set; }

    public DateTime InsertDate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool Status { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
