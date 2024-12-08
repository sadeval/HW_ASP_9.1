using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HW_ASP_9._1.TagHelpers
{
    [HtmlTargetElement("cosmic-header")]
    public class CosmicHeaderTagHelper : TagHelper
    {
        public string Title { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.Add("class", "cosmic-header");
            output.Content.SetHtmlContent($@"
                <span class='cosmic-text'>{Title}</span>
            ");
        }
    }
}