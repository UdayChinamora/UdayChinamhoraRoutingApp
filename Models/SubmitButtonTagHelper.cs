using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UdayChinhamoraWebsite.Models
{
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button"; // makes a button element
            output.TagMode = TagMode.StartTagAndEndTag; 

            // makes it a button with the same attributes as a submit button
            output.Attributes.SetAttribute("type", "submit");

            // appending style/bootstrap classes
            string newClasses = "btn btn-primary";
            string oldClasses = output.Attributes["class"]?.Value?.ToString(); 
            string classes = (string.IsNullOrEmpty(oldClasses)) ? // null checking old classes
                newClasses : $"{oldClasses} {newClasses}"; 
            output.Attributes.SetAttribute("class", classes); 
        }
    }
}

