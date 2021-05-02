using System.Collections.Generic;

namespace IntroUi.ViewModels
{
    public class TrackViewModel
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; } 
        public decimal Price { get; set; }
    }
}