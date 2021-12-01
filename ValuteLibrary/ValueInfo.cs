namespace ValuteLibrary
{
    public class ValueInfo
    {
        public string Name { get; set; }

        public string CharCode { get; set; }

        public double Value { get; set; }

        public double Previous { get; set; }

        public string Difference() 
        {
            if (Value > Previous)
            {
                return $"По отношению к рублю {Name} вырос на {Math.Round((Value - Previous), 2)}.";
            }
            else if (Value < Previous)
            {
                return $"По отношению к рублю {Name} упал на {Math.Round((Previous - Value), 2)}.";
            }
            else 
                return $"По отношению к рублю {Name} не изменился.";
        }
    }
}