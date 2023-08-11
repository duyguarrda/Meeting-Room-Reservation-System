using Core.Utilities.Results;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAllRooms();
        // IDataResult<List<Room>> GetAvailableRoomsByDateRange(DateTime startDate, DateTime endDate);
        IDataResult<List<Room>> GetRoomsByEquipment(List<string> equipmentNames);
        IDataResult<List<Room>> GetById(int id);
        IDataResult<List<Room>> GetRoomsByCapacity(int capasity);
        IDataResult<List<Room>> GetRoomsByLocationName(string location);
        IResult Add(Room room);
        IResult Remove(Room room);
        IResult Update(Room room);

    }
}
