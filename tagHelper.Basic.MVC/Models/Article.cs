using System;
using System.Collections.Generic;

namespace tagHelper.Basic.MVC.Models
{
    public class Article
    {
        public string ArxivId { get; private set; }
        public string HtmlLink { get; private set; }
        public string PdfUrl { get; set; }
        public string OtherFormatUrl { get; set; }
        public string Title { get; private set; }
        public string AbstractText { get; private set; }
        public string Comments { get; private set; }
        public string JournalReference { get; private set; }
        public string JournalReferenceHtmlLink { get; private set; }
        public DateTime DisplayDate { get; private set; }
        public DateTime ScrapedDate { get; private set; }
    }
}
