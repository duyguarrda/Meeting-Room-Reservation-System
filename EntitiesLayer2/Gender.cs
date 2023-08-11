using System;
using Core.Entities;
using System.Collections.Generic;

namespace EntitiesLayer2;

public partial class Gender :IEntity
{
    public int GenderId { get; set; }

    public string GenderName { get; set; } = null!;

    public int InsertUserId { get; set; }

    public DateTime InsertDate { get; set; }

    public int? UpdateUserId { get; set; }

    public int? UpdateDate { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<IEntityUser> Users { get; set; } = new List<IEntityUser>();
}
