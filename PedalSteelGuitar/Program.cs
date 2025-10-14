using MusicTheory.Models;
using MusicTheory.Functions;

var c4 = new Note(PitchClass.C, 4);
var e4 = NoteHelper.Transpose(c4, 12);   // C up 4 semitones → E4
Console.WriteLine(e4);
