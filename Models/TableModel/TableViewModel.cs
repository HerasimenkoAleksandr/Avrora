using Avrora.Models.Price;
using System.Diagnostics;
using System.Globalization;

namespace Avrora.Models.TableModel
{
    public class TableViewModel
    {
        public List<TableModel> Table { get; set; } = new List<TableModel>();
    

     public TableViewModel()
        {
            Table = new List<TableModel>()
            {
                new TableModel
                {
                  Id = 1,
                  DateTime = DateTime.ParseExact("10:00", "HH:mm", CultureInfo.InvariantCulture),
                  Name = "Олексій",
                  Email = "sda@gmail.com",
                  PhoneNumber = "0937018395",
                  CarNamber = "DI8585IK",
                  CarModel = "Opel",
                  ServiceName = "Експрес-мийка",
                  StatusWork = 4
                },
                new TableModel
                {
                  Id = 1,
                  DateTime = DateTime.ParseExact("14:00", "HH:mm", CultureInfo.InvariantCulture),
                  Name = "Андрій",
                  Email = "sda@gmail.com",
                  PhoneNumber = "0937018395",
                  CarNamber = "AI8584IK",
                  CarModel = "Audi",
                  ServiceName = "Експрес-мийка",
                  StatusWork = 2
                },
                new TableModel
                {
                  Id = 1,
                  DateTime = DateTime.ParseExact("18:00", "HH:mm", CultureInfo.InvariantCulture),
                  Name = "Світлана",
                  Email = "sda@gmail.com",
                  PhoneNumber = "0937019635",
                  CarNamber = "Svetka",
                  CarModel = "Tesla",
                  ServiceName = "Експрес-мийка",
                  StatusWork = 1
                }



            };
        }
    }
}
