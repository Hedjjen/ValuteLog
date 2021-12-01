namespace ValuteLibrary
{
    public class Valute
    {
        public ValueInfo EUR { get; set; }
        public ValueInfo USD { get; set; }
        public ValueInfo GBP { get; set; }
        public ValueInfo JPY { get; set; }

        public Dictionary<string, ValueInfo> GetFullInfo()
        {
            Dictionary<string, ValueInfo> keyValue = new Dictionary<string, ValueInfo>();
            keyValue.Add("EUR", EUR);
            keyValue.Add("USD", USD);
            keyValue.Add("GBP", GBP);
            keyValue.Add("JPY", JPY);

            return keyValue;

        }  

    }
}