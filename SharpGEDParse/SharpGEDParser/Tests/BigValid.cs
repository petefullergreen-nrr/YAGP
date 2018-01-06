﻿// a legit set of GEDCOM strings larger than the 4K buffer

using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace SharpGEDParser.Tests
{
    [TestFixture]
    public class BigValid : ReadingUtil
    {
        private readonly string[] lines =
        {
        "0 HEAD",
        "1 SOUR FTW",
        "2 VERS 4.00",
        "2 NAME Family Tree Maker for Windows",
        "2 CORP Broderbund Software, Banner Blue Division",
        "3 ADDR 39500 Stevenson Pl.  #204",
        "4 CONT Fremont, CA 95439",
        "3 PHON (510) 794-6850",
        "1 DEST FTW",
        "1 DATE 18 Feb 1998",
        "1 CHAR ANSI",
        "1 SUBM @SUBM@",
        @"1 FILE C:\Genealogy\Family Files\Tehee\CharlesTehee.GED",
        "1 GEDC",
        "2 VERS 5.5",
        "1 _SCHEMA",
        "2 INDI",
        "3 _FA1",
        "4 LABL Fact 1",
        "3 _FA2",
        "4 LABL Fact 2",
        "3 _FA3",
        "4 LABL Fact 3",
        "3 _FA4",
        "4 LABL Fact 4",
        "3 _FA5",
        "4 LABL Fact 5",
        "3 _FA6",
        "4 LABL Fact 6",
        "3 _FA7",
        "4 LABL Fact 7",
        "3 _FA8",
        "4 LABL Fact 8",
        "3 _FA9",
        "4 LABL Fact 9",
        "3 _FA10",
        "4 LABL Fact 10",
        "3 _FA11",
        "4 LABL Fact 11",
        "3 _FA12",
        "4 LABL Fact 12",
        "3 _FA13",
        "4 LABL Fact 13",
        "3 _MREL",
        "4 LABL Relationship to Mother",
        "3 _FREL",
        "4 LABL Relationship to Father",
        "2 FAM",
        "3 _FA1",
        "4 LABL Marriage fact",
        "3 _FA2",
        "4 LABL Fact 2",
        "3 _MSTAT",
        "4 LABL Marriage Beginning Status",
        "3 _MEND",
        "4 LABL Marriage Ending Status",
        "0 @SUBM@ SUBM",
        "0 @I01@ INDI",
        "1 NAME Aaron Hoke /Kees/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 22 Jun 1982",
        "2 PLAC Tyler, Texas",
        "1 _FA1",
        "2 DATE 1982",
        "2 PLAC Born at Mother Francis Hospital, Smith County Tyler,Texas on 22 of June.",
        "1 _FA2",
        "2 PLAC Goes to Eustace School, Eustace, Texas",
        "1 _MDCL Broke Collarbone when four.",
        "1 FAMC @F1@",
        "0 @I02@ INDI",
        "1 NAME Holli Jean /Boone/",
        "1 SEX F",
        "1 BIRT",
        "2 DATE 21 Sep 1957",
        "2 PLAC Dallas, Texas Dallas County",
        "1 _FA1",
        "2 DATE 1957",
        "2 PLAC Born at Methodist Hospital in Dallas, Texas.",
        "1 FAMS @F1@",
        "0 @I03@ INDI",
        "1 NAME Shawn Paul /Kees/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 29 Dec 1980",
        "2 PLAC Dallas, Texas",
        "1 DEAT",
        "2 DATE 27 Feb 1981",
        "2 PLAC Grand Prairie, Texas",
        "2 CAUS Sudden Infant Death Syndrome",
        "1 _FA1",
        "2 PLAC Born in Methodist Hospital at 1:30 am.",
        "1 _FA2",
        "2 PLAC Died at home at 1 month and 29 days",
        "1 FAMC @F1@",
        "1 NOTE @NI03@",
        "0 @NI03@ NOTE",
        "1 CONC Buried at Restland Memorial Park, Dallas Texas-Section Babyland V.",
        "1 CONT Inscription on Headstone reads:",
        "1 CONT Now I lay me down to sleep,",
        "1 CONT I pray the Lord my soul to keep.",
        "1 CONT Shawn Paul Kees",
        "1 CONT Dec. 29, 1980-Feb. 27, 1981",
        "0 @I04@ INDI",
        "1 NAME Travis Roland /Kees/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 16 Aug 1952",
        "2 PLAC Gardenia, California",
        "1 FAMS @F1@",
        "1 FAMC @F2@",
        "0 @I05@ INDI",
        "1 NAME Travis Roland /Kees/ II",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 26 Feb 1978",
        "2 PLAC Dallas, Texas Dallas County",
        "1 _FA1",
        "2 DATE 1978",
        "2 PLAC Born at Parkland Hospital at 1:30am 26 February.",
        "1 _FA2",
        "2 DATE 1978",
        "2 PLAC Born 1 month premature.",
        "1 _FA3",
        "2 DATE 1996",
        "2 PLAC Graduated from Eustace High School, Henderson County Eustace, Texas.",
        "1 _MDCL Was on life support system for 1st week of life. Being born early was the cause.",
        "1 FAMC @F1@",
        "0 @I06@ INDI",
        "1 NAME Alonzie Roland /Kees/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 17 Jan 1921",
        "2 PLAC Williamsport Maryland",
        "1 DEAT",
        "2 DATE 15 May 1975",
        "2 PLAC Dallas, Dallas County Texas",
        "1 FAMS @F2@",
        "1 NOTE @NI06@",
        "0 @NI06@ NOTE",
        "1 CONC Birth Certificate Number 1466",
        "1 CONT Buried at Restland Memorial Park, Dallas Texas-Section Veterans Garden II.",
        "1 CONT Inscription on Headstone reads:",
        "1 CONT Alonzie Roland Kees",
        "1 CONT SSGT US ARMY",
        "1 CONT WORLD WAR II",
        "1 CONT Jan. 17, 1921-May 15, 1975",
        "0 @I07@ INDI",
        "1 NAME Wanda Matalois /Tehee/",
        "1 SEX F",
        "1 BIRT",
        "2 DATE 20 Apr 1926",
        "2 PLAC Luling Texas Caldwell County",
        "1 FAMS @F2@",
        "1 FAMC @F3@",
        "0 @I08@ INDI",
        "1 NAME Hoke /Tehee/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 7 Jun 1893",
        "2 PLAC Oklahoma",
        "2 SOUR Broderbund Family Archive #110, Vol. 2, Ed. 5, Social Security Death Index: U.S., Date of Import: Dec 23, 1997, Internal Ref. #1.112.5.92952.128",
        "1 DEAT",
        "2 DATE 24 Jan 1982",
        "2 PLAC Monahans Texas",
        "2 SOUR Broderbund Family Archive #110, Vol. 2, Ed. 5, Social Security Death Index: U.S., Date of Import: Dec 23, 1997, Internal Ref. #1.112.5.92952.128",
        "1 FAMS @F3@",
        "1 FAMC @F4@",
        "0 @I09@ INDI",
        "1 NAME Mandy Pearl /McKibben/",
        "1 SEX F",
        "1 BIRT",
        "2 DATE 26 Jun 1903",
        "2 PLAC Oklahoma,  Nowata County",
        "1 DEAT",
        "2 DATE 23 Jun 1994",
        "2 PLAC Bastrop Texas",
        "1 _FA1",
        "2 PLAC Went to Armstrong School when she was eight years old.",
        "1 FAMS @F3@",
        "0 @I10@ INDI",
        "1 NAME Charles /Tehee/",
        "1 SEX M",
        "1 BIRT",
        "2 DATE 1835",
        "2 PLAC Cherokee Nations Oklahoma",
        "1 DEAT",
        "2 DATE UNKNOWN",
        "2 PLAC Oklahoma",
        "1 FAMS @F5@",
        "1 FAMS @F4@",
        "0 @I11@ INDI",
        "1 NAME Peggy /Vann/",
        "1 SEX F",
        "1 BIRT",
        "2 DATE UNKNOWN",
        "2 PLAC Oklahoma",
        "1 DEAT",
        "2 DATE UNKNOWN",
        "2 PLAC Oklahoma",
        "1 FAMS @F4@",
        "0 @I12@ INDI",
        "1 NAME Linda Lee Tehee /Kees/",
        "1 SEX F",
        "1 BIRT",
        "2 DATE 20 Feb 1948",
        "1 FAMC @F2@",
        "0 @I13@ INDI",
        "1 NAME Lizzie /Tehee/",
        "1 SEX F",
        "1 FAMS @F5@",
        "0 @I14@ INDI",
        "1 NAME Enoch /Tehee/",
        "1 SEX M",
        "1 FAMC @F5@",
        "0 @I15@ INDI",
        "1 NAME Sophie /Tehee/",
        "1 SEX F",
        "1 FAMC @F5@",
        "0 @F1@ FAM",
        "1 HUSB @I04@",
        "1 WIFE @I02@",
        "1 CHIL @I05@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 CHIL @I03@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 CHIL @I01@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 MARR",
        "2 DATE 25 Mar 1977",
        "2 PLAC Dallas, Texas",
        "0 @F2@ FAM",
        "1 HUSB @I06@",
        "1 WIFE @I07@",
        "1 CHIL @I12@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 CHIL @I04@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 MARR",
        "2 DATE 7 Aug 1944",
        "2 PLAC Ward City Texas",
        "0 @F3@ FAM",
        "1 HUSB @I08@",
        "1 WIFE @I09@",
        "1 CHIL @I07@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 MARR",
        "2 DATE 26 Jun 1920",
        "2 PLAC Kellyville Oklahoma",
        "0 @F4@ FAM",
        "1 HUSB @I10@",
        "1 WIFE @I11@",
        "1 CHIL @I08@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 MARR",
        "2 DATE UNKNOWN",
        "2 PLAC Oklahoma",
        "0 @F5@ FAM",
        "1 HUSB @I10@",
        "1 WIFE @I13@",
        "1 CHIL @I14@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "1 CHIL @I15@",
        "2 _FREL Natural",
        "2 _MREL Natural",
        "0 TRLR",
        };

        [Test]
        public void LargeLFNoBom()
        {
            var r = BuildAndRead(lines, GedReader.LB.UNIX, false, true);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeDOSNoBom()
        {
            var r = BuildAndRead(lines, GedReader.LB.DOS, false, true);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeLFBom()
        {
            var r = BuildAndRead(lines, GedReader.LB.UNIX, true, true);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeDOSBom()
        {
            var r = BuildAndRead(lines, GedReader.LB.DOS, true, true);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeLFNoBomNoTerm()
        {
            var r = BuildAndRead(lines, GedReader.LB.UNIX, false, false);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeDOSNoBomNoTerm()
        {
            var r = BuildAndRead(lines, GedReader.LB.DOS, false, false);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeLFBomNoTerm()
        {
            var r = BuildAndRead(lines, GedReader.LB.UNIX, true, false);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
        [Test]
        public void LargeDOSBomNoTerm()
        {
            var r = BuildAndRead(lines, GedReader.LB.DOS, true, false);
            Assert.AreEqual(lines.Length, r.NumberLines);
        }
    }
}
