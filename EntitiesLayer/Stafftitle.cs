using Core.Entites;
using System;
using System.Collections.Generic;

namespace EntitiesLayer;

public partial class Stafftitle : IEntity
{
    public int StafftitleId { get; set; }

    public string? StafftitleName { get; set; }

    public int? InsertUserId { get; set; }

    public DateTime? InsertDate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
