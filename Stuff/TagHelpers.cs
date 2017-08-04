using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC486.LayoutTagHelpers
{
    public class RowTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "row");
        }
    }

    public class ColumnTagHelper : TagHelper 
    {
        public string Size { get;set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var colName = Size == "one" ? "column" : "columns";
            output.TagName = "div";
            output.Attributes.SetAttribute("class", $"{Size} {colName}");
        }
    }
}