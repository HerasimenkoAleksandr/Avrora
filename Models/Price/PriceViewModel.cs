namespace Avrora.Models.Price
{
    public class PriceViewModel
    {
        public List<PriceModel> Prices { get; set; } = new List<PriceModel>();

        //public PriceViewModel()
        //{
        //    Prices = new List<PriceModel>()
        //    {
        //        new PriceModel
        //        {
        //            CarType = "Легковий",
        //            PricesForType = new Dictionary<string, int>
        //            {
        //                { "Експрес-мийка", 800 },
        //                { "Повна мийка", 1000 },
        //                { "Хімчистка салону", 1200 },
        //                { "Поліровка салону з сервіра", 800 }
        //            }
        //        },
        //        new PriceModel
        //        {
        //             CarType = "Кросовер",
        //            PricesForType = new Dictionary<string, int>
        //            {
        //                { "Експрес-мийка", 800 },
        //                { "Повна мийка", 1000 },
        //                { "Хімчистка салону", 1200 },
        //                { "Поліровка салону з сервіра", 800 }
        //            }
        //        },
        //        new PriceModel
        //        {
        //            CarType = "Універсал",
        //            PricesForType = new Dictionary<string, int>
        //            {
        //                { "Експрес-мийка", 800 },
        //                { "Повна мийка", 1000 },
        //                { "Хімчистка салону", 1200 },
        //                { "Поліровка салону з сервіра", 800 }
        //            }
        //        }
                 

        //    };
        //}


        public PriceViewModel()
        {
            Prices = new List<PriceModel>()
            {
                new PriceModel
                {
                    ServiceName = "Експрес-мийка",
                    PricesForType = new Dictionary<string, int ?>
                    {
                        { "Легковий", 600 },
                        { "Кросовер", 700 },
                        { "Універсал", null },
                       

                    }
                },
                new PriceModel
                {
                     ServiceName = "Повна мийка",
                    PricesForType = new Dictionary<string, int ?>
                    {
                        { "Легковий", 800 },
                        { "Кросовер", 1000 },
                        { "Універсал", 1200 },
                       
                    }
                },
                new PriceModel
                {
                    ServiceName = "Хімчистка салону",
                    PricesForType = new Dictionary<string, int ?>
                    {
                         { "Легковий", 800 },
                        { "Кросовер", 1000 },
                        { "Універсал", 1200 },
                        
                    }
                },
                new PriceModel
                {
                    ServiceName = "Поліровка салону",
                    PricesForType = new Dictionary<string, int ?>
                    {
                        { "Легковий", 800 },
                        { "Кросовер", 1000 },
                        { "Універсал", null },
                       
                    }
                },
                  new PriceModel
                {
                    ServiceName = "Обдув повітрям",
                    PricesForType = new Dictionary<string, int ?>
                    {
                        { "Легковий", 800 },
                        { "Кросовер", 1000 },
                        { "Універсал", 1200 },
                       
                    }
                }


            };
        }
    }
}
