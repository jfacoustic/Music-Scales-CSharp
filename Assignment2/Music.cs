using System;
namespace MusicLib
{
    // Future:  implement enharmonics
    enum Chromatic { A, As, B, C, Cs, D, Ds, E, F, Fs, G, Gs };
    
    interface IMusicScale
    {
         Chromatic NextNote();

    }
    class MusicNote
    {
        protected Chromatic Note { get; set; }

        public MusicNote(Chromatic note) 
        {
            this.Note = note;
        }

        public double Frequency()
        {
            const double freq_A = 440.0;
            double a = Math.Pow(2.0, 1.0 / 12.0);  // For some reason this can't be a const.
            int pos = (int)this.Note;
            return Math.Round(freq_A * Math.Pow(a, pos), 2);
        }
    }

    class MajorScale : MusicNote, IMusicScale
    {
        private readonly int[] spaces = new int[] { 2, 2, 1, 2, 2, 2, 1 };
        private int Pos;
        private readonly Chromatic BaseNote;

        public MajorScale(Chromatic note) : base(note)
        {
            this.Note = note;
            this.BaseNote = note;
            this.Pos = 0;
        }
        // Since I can't inherit an implementation from an interface, I'll have to reuse code:
        // Doing this to complete requirement for assignment.
        public Chromatic NextNote()
        {
            int noteNum = (int)Note;
            noteNum = (noteNum + this.spaces[this.Pos]) % 12;
            this.Note = (Chromatic)noteNum;
            this.Pos = (this.Pos + 1) % 7;
            return this.Note;
        }

        public void PrintScale()
        {
            Console.WriteLine("Scale: " + BaseNote + " Major");
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(this.Note + " " + this.Frequency() + " Hz");
                this.NextNote();
            }
            Console.WriteLine(this.Note + " " + 2 * this.Frequency());
            Console.WriteLine("");
        }

    }
    class NaturalMinorScale : MusicNote, IMusicScale
    {
        private readonly int[] spaces = new int[] { 2, 1, 2, 2, 1, 2, 2 };
        private int Pos;
        private readonly Chromatic BaseNote;

        public NaturalMinorScale(Chromatic note) : base(note)
        {
            this.Note = note;
            this.BaseNote = note;
            this.Pos = 0;
        }
        // Since I can't inherit an implementation from an interface, I'll have to reuse code:
        // Doing this to complete requirement for assignment.  
        public Chromatic NextNote()
        {
            int noteNum = (int)Note;
            noteNum = (noteNum + this.spaces[this.Pos]) % 12;
            this.Note = (Chromatic)noteNum;
            this.Pos = (this.Pos + 1) % 7;
            return this.Note;
        }
        // Not DRY at all :(
        public void PrintScale()
        {
            Console.WriteLine("Scale: " + BaseNote + " Minor");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(this.Note + " " + this.Frequency() + " Hz");
                this.NextNote();
            }
            Console.WriteLine(this.Note + " " + 2 * this.Frequency());
            Console.WriteLine("");
        }
    }

}
