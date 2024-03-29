﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace tagHelper.Basic.MVC.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("article-track")]
    public class ArticleTrackTagHelper : TagHelper
    {
        public string TrackName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {   
            string preContent = $@"                        
                            <h2>{TrackName}</h2>
                            <div class='row'>
                        ";
            const string postContent = @"
                        </div>
                    ";

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "track");
            output.PreContent.SetHtmlContent(preContent);
            output.PostContent.SetHtmlContent(postContent);
        }
    }
}
