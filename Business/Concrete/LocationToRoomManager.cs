using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationToRoomManager : ILocationToRoomsService
    {
        ILocationToRoomDal _locationToRoomDal;
    

        public LocationToRoomManager(ILocationToRoomDal locationToRoomDal)
        {
            _locationToRoomDal = locationToRoomDal;
          
        }


        public IDataResult<List<LocationToRoom>> GetLocationToRoom()
        {
            try
            {
                var locationToRooms = _locationToRoomDal.GetAll(); // Tüm LocationToRoom verilerini getir

                if (locationToRooms.Count == 0)
                {
                    return new ErrorDataResult<List<LocationToRoom>>(Messages.LocationToRoomsNotFound);
                }

                return new SuccessDataResult<List<LocationToRoom>>(locationToRooms, Messages.LocationToRoomsListed);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<LocationToRoom>>(ex.Message);
            }
        }
    }
}
