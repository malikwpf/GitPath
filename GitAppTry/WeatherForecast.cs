namespace GitAppTry
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int Degrees { get; set; }
<<<<<<< Updated upstream
        public int Frequency { get; set; }
=======

        public string Names { get; set; }
>>>>>>> Stashed changes
    }
}