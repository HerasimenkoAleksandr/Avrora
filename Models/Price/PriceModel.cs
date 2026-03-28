using Avrora.Models.Enums;

namespace Avrora.Models.Price
{
    public class PriceModel
    {
        public required string ServiceName { get; set; }
        public required Dictionary<String, int?> PricesForType { get; set; }

    }

}
