namespace App.DesktopClient
{
    using System;
    using App.Data.Models;
    using Data;
    using Data.Interfaces;

    public class DataContextProvider : IDataContextProvider
    {
        public DataContext GetContext()
        {
            var dbContext = new DataContext();
#if DEBUG
            if (!dbContext.Database.Exists())
            {
                dbContext.Database.Create();

                if (!dbContext.Database.Exists())
                {
                    throw new ApplicationException("App doesn't have database");
                }

                var d1 = new Device()
                {
                    Name = "Device 1",
                    Description = "Desc 1",
                    DeviceType = new DeviceType()
                    {
                        Name = "Type 1"
                    },
                    Place = new Place()
                    {
                        Name = "Place 1"
                    }
                };
                var d2 = new Device()
                {
                    Name = "Device 2",
                    Description = "Desc 2",
                    DeviceType = new DeviceType()
                    {
                        Name = "Type 2"
                    },
                    Place = new Place()
                    {
                        Name = "Place 2"
                    }
                };
                var d3 = new Device()
                {
                    Name = "Urządzenie",
                    Description = "Opis",
                    DeviceType = new DeviceType()
                    {
                        Name = "Typ Urządzenia"
                    },
                    Place = new Place()
                    {
                        Name = "Miejsce Składowania"
                    }
                };

                dbContext.Add(d1);
                dbContext.Add(d2);
                dbContext.Add(d3);

                dbContext.SaveChanges();

            }
#endif
            return dbContext;
        }
    }
}
