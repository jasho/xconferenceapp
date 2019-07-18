using System.Collections.Generic;
using Xamarin.Forms;
using XConferenceApp.Models;

namespace XConferenceApp.Repositories
{
    public class RoomRepository : RepositoryBase<RoomModel, int>
    {
        protected override List<RoomModel> items { get; } = new List<RoomModel>
        {
            new RoomModel
            {
                Id = 1,
                Name = "HALL A",
                AccentColor = new Color(253.0 / 256,173.0 / 256,0.0 / 256)
            },
            new RoomModel
            {
                Id = 2,
                Name = "HALL B",
                AccentColor = new Color(132.0 / 256,191.0 / 256,0.0 / 256)
            },
            new RoomModel
            {
                Id = 3,
                Name = "HALL C",
                AccentColor = new Color(70.0 / 256,175.0 / 256,231.0 / 256)
            }
        };
    }
}