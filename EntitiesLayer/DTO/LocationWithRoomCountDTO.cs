using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.DTO
{
    public class LocationWithRoomCountDTO : IDto
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Adress { get; set; }

        public int RoomCount { get; set; }

    }
}
