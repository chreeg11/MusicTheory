namespace MusicTheory.Models
{
    public enum IntervalQuality
    {
        Perfect,
        Major,
        Minor,
        Augmented,
        Diminished
    }

    public readonly record struct Interval(int Semitones, bool IsDescending);
}
