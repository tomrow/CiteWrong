﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CiteWrong
{
    [Serializable]
    public struct BibliographyEntry
    {
        public string sourceFmt;
        public string authorName;
        public string publisherName;
        public string coAuthorName;
        public string workTitle;
        public string seriesName;
        public string volumeName;
        public string editionName;
        public string chapterName;
        public string sectionName;
        public string pageStart;
        public string pageEnd;
        public string mediaFmtName;
        public string retrievalLocation;
        public string notes;
        public DateTime publicationDate;
        public DateTime originalPublicationDate;
        public DateTime fetchDate;
        public override string ToString()
        {
            int macrosFound = 1; //set it to 1 at the start so it actually starts, this is to account for nested macros
            string OriginalPublicationDate = originalPublicationDate.ToString("dd MMMM yyyy");
            string output = "An equivalent category has not been found in the current bibliography scheme. Author$ Year$ Title$";
            foreach (SchemeDefinition s in Bibliography.SchemeFormats)
            { 
                if (s.title == sourceFmt){output = s.syntax;}
            }
            if(macrosFound>0)
            {
                macrosFound = 0;
                foreach (SchemeDefinition s in Bibliography.SchemeFormats) 
                {
                    macrosFound++;
                    if (s.title.Substring(s.title.Length - 1) == "$") 
                    { output = output.Replace(s.title, s.syntax); } 
                }
                output = output.Replace("Year$", publicationDate.Year.ToString());
                output = output.Replace("RestOfPublicationDate$", publicationDate.ToString("dd MMMM"));
                output = output.Replace("Author$", authorName);
                output = output.Replace("Location$", retrievalLocation);
                output = output.Replace("fetchedDate$", fetchDate.ToString("dd MMMM yyyy"));
                output = output.Replace("Publisher$", publisherName);
                output = output.Replace("PublicationTime$", publicationDate.ToString("HH:mm"));
                output = output.Replace("Title$", workTitle);
                output = output.Replace("Media$", mediaFmtName);
                output = output.Replace("DateRange$", originalPublicationDate.ToString("dd MMMM yyyy") + " to " + publicationDate.ToString("dd MMMM yyyy"));
                output = output.Replace("OriginalYear$", originalPublicationDate.Year.ToString());
                output = output.Replace("OriginalPublicationDate$", originalPublicationDate.ToString("dd MMMM yyyy"));
                output = output.Replace("Series$", seriesName);
                output = output.Replace("Volume$", volumeName);
                output = output.Replace("Notes$", notes);
                output = output.Replace("Chapter$", chapterName);
                output = output.Replace("Section$", sectionName);
                output = output.Replace("Edition$", editionName);
                output = output.Replace("CoAuthor$", coAuthorName);
                output = output.Replace("PageRange$", pageStart+"-"+pageEnd);
                output = output.Replace("Page$", pageStart);
                            }
            return output;

            
        }
    }

    public struct SchemeDefinition
    {
        public string title;
        public string syntax;
    }
    public static class UIState
    { public static int SelectedItem; }
    public static class Bibliography
    { 
        public static List<BibliographyEntry> bDatabase = new List<BibliographyEntry>();
        public static string SchemePath = "";
        public static List<SchemeDefinition> SchemeFormats = new List<SchemeDefinition>();

    }
    public struct BibSave
    {
        public List<BibliographyEntry> bDatabase;
        public string SchemePath;
        public List<SchemeDefinition> SchemeFormats;

    }
    public struct SchemeSave { public List<SchemeDefinition> SchemeFormats; }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
        }
    }
}
