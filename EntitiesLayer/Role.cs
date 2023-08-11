﻿using Core.Entites;
using System;
using System.Collections.Generic;

namespace EntitiesLayer;

public partial class Role : IEntity
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int InsertUserId { get; set; }

    public DateTime InsertDate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}