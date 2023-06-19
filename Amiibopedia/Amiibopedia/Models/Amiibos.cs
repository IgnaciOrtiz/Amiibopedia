using System;
using System.Collections.Generic;
using System.Text;

namespace Amiibopedia.Models
{

    public class Amiibos
    {
        public Amiibo[] amiibo { get; set; }
    }

    public class Amiibo
    {
        public string amiiboSeries { get; set; }
        public string character { get; set; }
        public string gameSeries { get; set; }
        public Games3ds[] games3DS { get; set; }
        public Gamesswitch[] gamesSwitch { get; set; }
        public Gameswiiu[] gamesWiiU { get; set; }
        public string head { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public Release release { get; set; }
        public string tail { get; set; }
        public string type { get; set; }
    }

    public class Release
    {
        public string au { get; set; }
        public string eu { get; set; }
        public string jp { get; set; }
        public string na { get; set; }
    }

    public class Games3ds
    {
        public Amiibousage[] amiiboUsage { get; set; }
        public string[] gameID { get; set; }
        public string gameName { get; set; }
    }

    public class Amiibousage
    {
        public string Usage { get; set; }
        public bool write { get; set; }
    }

    public class Gamesswitch
    {
        public Amiibousage1[] amiiboUsage { get; set; }
        public string[] gameID { get; set; }
        public string gameName { get; set; }
    }

    public class Amiibousage1
    {
        public string Usage { get; set; }
        public bool write { get; set; }
    }

    public class Gameswiiu
    {
        public Amiibousage2[] amiiboUsage { get; set; }
        public string[] gameID { get; set; }
        public string gameName { get; set; }
    }

    public class Amiibousage2
    {
        public string Usage { get; set; }
        public bool write { get; set; }
    }

}
