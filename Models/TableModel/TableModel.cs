namespace Avrora.Models.TableModel
{
    public class TableModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = String.Empty;
        public string? CarNamber { get; set; } = string.Empty;
        public string? CarModel { get; set; } = string.Empty;
        public string? ServiceName { get; set; }
        public int StatusWork { get; set; }
        

    }
}

