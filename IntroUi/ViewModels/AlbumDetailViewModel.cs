using System.Collections.Generic;

namespace IntroUi.ViewModels
{
    public class AlbumDetailViewModel
    {
        public long AlbumId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<TrackViewModel> Tracks { get; set; }
    }
}