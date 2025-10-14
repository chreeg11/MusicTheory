namespace MusicTheory.Functions
{
    using MusicTheory.Models;

    public static class IntervalHelper
    {
        private static readonly string[] IntervalNames = new[]
        {
            "Unison",        // 0
            "Minor 2nd",     // 1
            "Major 2nd",     // 2
            "Minor 3rd",     // 3
            "Major 3rd",     // 4
            "Perfect 4th",   // 5
            "Tritone",       // 6
            "Perfect 5th",   // 7
            "Minor 6th",     // 8
            "Major 6th",     // 9
            "Minor 7th",     // 10
            "Major 7th",     // 11
            "Octave"         // 12
        };

        public static string GetIntervalName(int semitones, bool descending = false)
        {
            // Protect against out-of-bounds values
            if (semitones < 0)
            {
                semitones = -semitones;
                descending = !descending;
            }
            semitones = semitones % 12;
            return IntervalNames[semitones];
        }

        public static Interval GetInterval(Note from, Note to)
        {
            // Returns semitone distance and direction
            return new Interval();
        }

    }
}
