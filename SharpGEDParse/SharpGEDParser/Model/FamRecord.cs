﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SharpGEDParser.Model
{
    public class Child
    {
        public string Xref { get; set; }

        public string MotherRelation { get; set; }

        public string FatherRelation { get; set; }
    }

    public class FamRecord : GEDCommon, NoteHold, SourceCitHold, MediaHold
    {
        public override string Tag { get { return "FAM"; } }

        private List<Note> _notes;
        private List<SourceCit> _cits;
        private List<MediaLink> _media;
        private List<LDSEvent> _ldsEvents; // TODO common?

        public List<Note> Notes { get { return _notes ?? (_notes = new List<Note>()); } }
        public List<SourceCit> Cits { get { return _cits ?? (_cits = new List<SourceCit>()); } }
        public List<MediaLink> Media { get { return _media ?? (_media = new List<MediaLink>()); } }
        public List<LDSEvent> LDSEvents { get { return _ldsEvents ?? (_ldsEvents = new List<LDSEvent>()); } }

        // Identity strings for children
        private List<Child> _childs;
        public List<Child> Childs { get { return _childs ?? (_childs = new List<Child>()); } }

        // Identity strings for HUSB (multiple are possible from some programs)
        private List<string> _dads;
        public List<string> Dads { get { return _dads ?? (_dads = new List<string>()); } }

        // Identity strings for WIFE (multiple are possible from some programs)
        private List<string> _moms;
        public List<string> Moms { get { return _moms ?? (_moms = new List<string>()); } }

        private List<FamilyEvent> _famEvents; // TODO common?
        public List<FamilyEvent> FamEvents { get { return _famEvents ?? (_famEvents = new List<FamilyEvent>()); } }

        // Identity strings for submitters
        private List<string> _famSubm; // TODO common?
        public List<string> FamSubm { get { return _famSubm ?? (_famSubm = new List<string>()); } }

        public FamRecord(GedRecord lines, string ident, string remain) : base(lines, ident)
        {
            _childCount = -1;
            GedRecParse.NonStandardRemain(remain, this);
        }

        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return Tag;
        }

        [ExcludeFromCodeCoverage]
        public string Marriage
        {
            get
            {
                foreach (var kbrGedEvent in FamEvents)
                {
                    if (kbrGedEvent.Tag == "MARR")
                    {
                        return kbrGedEvent.Date + " " + kbrGedEvent.Place;
                    }
                }
                return "";
            }
        }

        private int _childCount;
        private string _restriction;

        public int ChildCount
        {
            get { return _childCount; }
            set { _childCount = value; }
        }

        public string Restriction
        {
            get { return _restriction; }
            set { _restriction = value; }
        }

        public void AddChild(string xref, string frel = null, string mrel = null)
        {
            // Add a child record, given a cross reference id.
            // Assumes that the father/mother relation is 'Natural'
            Child ch = new Child();
            ch.Xref = xref;
            ch.FatherRelation = frel;
            ch.MotherRelation = mrel;
            Childs.Add(ch);
        }
    }
}
