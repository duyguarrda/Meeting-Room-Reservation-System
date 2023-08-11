using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class LocationWithRoomCountDto:IDto
    {
        
            public int LocationId { get; set; }
            public string LocationName { get; set; }
            public string Adress { get; set; }
            public short? RoomCount { get; set; }
        

    }
}
