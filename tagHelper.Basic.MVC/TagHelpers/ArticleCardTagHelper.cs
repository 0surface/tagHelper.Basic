using Microsoft.AspNetCore.Razor.TagHelpers;
using tagHelper.Basic.MVC.Models;

namespace tagHelper.Basic.MVC.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("article-card")]
    public class ArticleCardTagHelper : TagHelper
    {
        public Article Article { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string content = $@"<div class='card' style='width: 50rem;'>
                                     <div class ='card-title'><i>{Article.Title}<i></div>
                                    <p>{Article.AbstractText}</p>
                                </div>
                ";

            output.Attributes.SetAttribute("class", "col-xs-12 col-sm-6 col-md-4 col-lg-3");
            output.TagName = "div";
            output.Content.SetHtmlContent(content);
        }

    }
}
