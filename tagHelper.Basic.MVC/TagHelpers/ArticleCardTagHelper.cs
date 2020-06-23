using Microsoft.AspNetCore.Razor.TagHelpers;
using tagHelper.Basic.MVC.Models;

namespace tagHelper.Basic.MVC.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(ParentTag ="article-track")]
    public class ArticleCardTagHelper : TagHelper
    {
        public Article Article { get; set; }
        private readonly string arxivBaseUrl = @"https://export.arxiv.org";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string pdfUrl = $"{arxivBaseUrl}{Article.PdfUrl}";
            string truncatedAbstract = Truncate(Article.AbstractText, 100);
            string imgSrc = @"~/subject/cond/-mat/cond-mat.mes-hall_nanotechnology.svg";

            string content = $@"<div class='card' style='max-width:500px'>
                                    <img class='card-img-top' src='{imgSrc}' alt=''>
                                    <div class='card-body'>
                                        <h5 class ='card-title'>{Article.Title}</h5>
                                        <div class ='card-text'>{truncatedAbstract}</div>
                                        <p class='font-italic'>{Article.Comments}</p>
                                        <a href='{pdfUrl}' class='card-link'>Pdf Link</a>
                                      </div>
                                </div>
                ";

            //output.Attributes.SetAttribute("class", "col-xs-12 col-sm-6 col-md-4 col-lg-3");
            output.TagName = "div";
            output.Content.SetHtmlContent(content);
        }

        public  string Truncate( string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }

    }
}
