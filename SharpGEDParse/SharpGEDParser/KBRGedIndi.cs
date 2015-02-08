﻿namespace SharpGEDParser
{
    public class KBRGedIndi : KBRGedRec
    {
        public KBRGedIndi(GedRecord lines, string ident) : base(lines)
        {
            Ident = ident;
            Tag = "INDI"; // TODO use enum
        }

        public override string ToString()
        {
            return string.Format("{0}({1}):{2}", Tag, Ident, Lines);
        }
    }
}
