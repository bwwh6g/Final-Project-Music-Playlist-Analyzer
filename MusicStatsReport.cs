using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAnalyzer
{
    class MusicStatsReport
    {
        public static string GenerateText(List<MusicStats> musicStatsList)
        {
            string report = "Music Playlist Report\n\n";

            if (musicStatsList.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            report += "Songs that received 200 or more plays: \n";
            var manyPlays = from musicStats in musicStatsList where musicStats.Plays >= 200 select musicStats;
            foreach (var plays in manyPlays)
            {
                report += manyPlays;
                report += "\n";
            }

            report += "Number of Alternative songs: ";
            var alternative = from musicStats in musicStatsList where musicStats.Genre == "Alternative" select musicStatsList.Count;
            report += alternative;
            report += "\n";

            report += "Number of Hip-Hop/Rap songs: ";
            var hopRap = from musicStats in musicStatsList where musicStats.Genre == "Hip-Hop/Rap" select musicStatsList.Count;
            report += hopRap;
            report += "\n";

            report += "Songs from the album Welcome to the Fishbowl: /n";
            var fishBowl = from musicStats in musicStatsList where musicStats.Album == "Welcome to the Fishbowl?" select musicStats;
            foreach (var Album in fishBowl)
            {
                report += fishBowl;
                report += "\n";
            }

            report += "Songs from before 1970: /n";
            var oldSong = from musicStats in musicStatsList where musicStats.Year < 1970 select musicStats;
            foreach (var Year in oldSong)
            {
                report += oldSong;
                report += "\n";
            }

            report += "Song names longer than 85 characters: /n";
            var longSong = from musicStats in musicStatsList where musicStats.Name.Length > 85 select musicStats.Name;
            report += longSong;
            report += "\n";

            report += "Longest song: /n";
            var longTimeSong = (from musicStats in musicStatsList select musicStats.Time).Max();
            report += longTimeSong;
            report += "\n";

            return report;
        }
    }
}
