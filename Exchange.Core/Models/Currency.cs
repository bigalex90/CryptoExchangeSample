namespace Exchange.Core.Models
{
    public class Currency
    {
        public string name { get; set; }
        public string code { get; set; }
        public string currency { get; set; }
        public string pricestr { get; set; }
        public decimal price { get; set; }
        public long marketCap { get; set; }
        public decimal circulatingSupply { get; set; }
        public string marketCapstr { get; set; }
        public decimal volume { get; set; }
        public string volumestr { get; set; }
        public decimal changeHour { get; set; }
        public string changeHourstr { get; set; }
        public decimal changeDay { get; set; }
        public string changeDaystr { get; set; }
        public decimal changeWeek { get; set; }
        public string changeWeekstr { get; set; }
    }
}
