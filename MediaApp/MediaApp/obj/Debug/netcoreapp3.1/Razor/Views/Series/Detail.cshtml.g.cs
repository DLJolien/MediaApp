#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164b1293f35d3df62eb54214f4d0ec9569dbef3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Detail), @"mvc.1.0.view", @"/Views/Series/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164b1293f35d3df62eb54214f4d0ec9569dbef3b", @"/Views/Series/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediaApp.Models.Detail.SeriesDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "series", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "media", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"grid-container\">\r\n        <div class=\"Photo\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 286, "\"", 307, 1);
#nullable restore
#line 8 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
WriteAttributeValue("", 292, Model.PhotoUrl, 292, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-url\" />\r\n        </div>\r\n        <div class=\"Title\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"Broadcaster-Label\">\r\n            <strong>Broadcaster</strong>\r\n        </div>\r\n        <div class=\"Broadcaster-Input\">\r\n            <p>");
#nullable restore
#line 17 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.Broadcaster);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"NumberOfSeasons-Label\">\r\n            <strong>Number Of Seasons</strong>\r\n        </div>\r\n        <div class=\"NumberOfSeasons-Input\">\r\n            <p>");
#nullable restore
#line 23 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.NumberOfSeasons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"NumberOfEpisodes-Label\">\r\n            <strong>Number Of Episodes</strong>\r\n        </div>\r\n        <div class=\"NumberOfEpisodes-Input\">\r\n            <p>");
#nullable restore
#line 29 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.NumberOfEpisodes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"Release-Date-Label\">\r\n            <strong>Release date</strong>\r\n        </div>\r\n        <div class=\"Release-Date-Input\">\r\n            <p>");
#nullable restore
#line 35 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"Duration-Label\">\r\n            <strong>Duration</strong>\r\n        </div>\r\n        <div class=\"Duration-Input\">\r\n            <p>");
#nullable restore
#line 41 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"Genre-Label\">\r\n            <strong>Genre</strong>\r\n        </div>\r\n        <div class=\"Genre-Input\">\r\n            <p>");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
          Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"Accessibility-Label\">\r\n            <strong>Accessibility</strong>\r\n        </div>\r\n        <div class=\"Accessibility-Input\">\r\n");
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
             if (@Model.Public)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Public</p>\r\n");
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Private</p>\r\n");
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n        <div class=\"View-Content\">\r\n");
#nullable restore
#line 65 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
             if (!String.IsNullOrEmpty(@Model.ContentUrl))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164b1293f35d3df62eb54214f4d0ec9569dbef3b9741", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"View Content\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
AddHtmlAttributeValue("", 2096, Model.ContentUrl, 2096, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"Functions\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164b1293f35d3df62eb54214f4d0ec9569dbef3b11830", async() => {
                WriteLiteral(" Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164b1293f35d3df62eb54214f4d0ec9569dbef3b14231", async() => {
                WriteLiteral(" Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164b1293f35d3df62eb54214f4d0ec9569dbef3b16635", async() => {
                WriteLiteral(" Back to series overview");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 80 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
 if (signInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n            </div>\r\n            <div class=\"col-10\" align=\"left\">\r\n                Post as ");
#nullable restore
#line 87 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                    Write((await userManager.GetUserAsync(User)).UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div id=\"comment-row\" class=\"row\">\r\n            <div id=\"photo-col\" class=\"col-2\" align=\"right\">\r\n                <img id=\"input-comment-user-photo\"");
            BeginWriteAttribute("src", " src=\"", 3107, "\"", 3163, 1);
#nullable restore
#line 92 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
WriteAttributeValue("", 3113, (await userManager.GetUserAsync(User)).PhotoUrl, 3113, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-10"" align=""left"">
                <textarea id=""comment-text"" placeholder=""Write your comment here..."" rows=""3""></textarea>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"" align=""right"">
                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3475, "\"", 3509, 3);
            WriteAttributeValue("", 3485, "SubmitComment(", 3485, 14, true);
#nullable restore
#line 100 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
WriteAttributeValue("", 3499, Model.Id, 3499, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3508, ")", 3508, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\" type=\"submit\"> Comment</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 104 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You need to sign in first in order to comment.</p>\r\n");
#nullable restore
#line 109 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"comments\">\r\n");
#nullable restore
#line 113 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
     if (Model.Comments.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Comments</h2>\r\n        <p>No comments have been posted yet.</p>\r\n");
#nullable restore
#line 117 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\" align=\"left\">\r\n                    <h2>");
#nullable restore
#line 123 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                   Write(Model.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</h2>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 127 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
             foreach (var comment in Model.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-2\">\r\n                    </div>\r\n                    <div class=\"col-5\">\r\n                        ");
#nullable restore
#line 133 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                   Write(comment.User.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-5\" align=\"right\">\r\n");
#nullable restore
#line 136 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                          
                            var timepassed = DateTime.Now - comment.PublishedDate;
                            if (Math.Round(timepassed.TotalSeconds) < 60)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 140 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalSeconds));

#line default
#line hidden
#nullable disable
            WriteLiteral(" seconds ago</p>\r\n");
#nullable restore
#line 141 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalMinutes) < 60)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 144 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalMinutes));

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes ago</p>\r\n");
#nullable restore
#line 145 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalHours) < 24)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 148 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalHours));

#line default
#line hidden
#nullable disable
            WriteLiteral(" hours ago</p>\r\n");
#nullable restore
#line 149 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalDays) < 30)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 152 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalDays));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago</p>\r\n");
#nullable restore
#line 153 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                            }
                            else if (Math.Ceiling(timepassed.TotalDays / 30) < 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 156 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                                     Write(Math.Ceiling(timepassed.TotalDays / 30));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago</p>\r\n");
#nullable restore
#line 157 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-2\" align=\"right\">\r\n                        <img id=\"posted-comment-url\"");
            BeginWriteAttribute("src", " src=\"", 5947, "\"", 5975, 1);
#nullable restore
#line 163 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
WriteAttributeValue("", 5953, comment.User.PhotoUrl, 5953, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-url\" />\r\n                    </div>\r\n                    <div class=\"col-10\">\r\n                        ");
#nullable restore
#line 166 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
                   Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 169 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 171 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Series\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    async function SubmitComment(id) {
        var comment = document.getElementById(""comment-text"");
        await $.post(""/Media/Comment"", { id: id, comment: comment.value }, function () {
            console.log(""posted comment: "" + comment.value);
        });
        comment.value = ""Your comment is awaiting approval"";
    }
</script>

<style>
    #comment-row {
        height: 30%;
    }

    #photo-col {
        height: 30%;
    }
    #posted-comment-url {
        width: 30%;
    }

    #comment-text {
        width: 100%;
    }

    #input-comment-user-photo {
        width: 50%;
        height: 15%;
    }

    .View-Content form {
        width: 100%;
    }

        .View-Content form input {
            width: 100%;
            height: 100%;
        }

    .photo-url {
        max-width: 400px;
        max-height: 7fr;
    }

    div .col {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

 ");
            WriteLiteral(@"   .grid-container {
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        grid-template-rows: 1fr 1fr 1fr 1fr 1fr 1fr 1fr 1fr 1fr 1fr;
        gap: 1px 1px;
        grid-template-areas: ""Title Title Title"" ""Photo Broadcaster-Label Broadcaster-Input"" ""Photo NumberOfSeasons-Label NumberOfSeasons-Input"" ""Photo NumberOfEpisodes-Label NumberOfEpisodes-Input"" ""Photo Release-Date-Label Release-Date-Input"" ""Photo Duration-Label Duration-Input"" ""Photo Genre-Label Genre-Input"" ""Photo Accessibility-Label Accessibility-Input"" ""Photo View-Content View-Content"" ""Functions Functions Functions"";
    }

    .Photo {
        display: flex;
        justify-content: center;
        grid-area: Photo;
    }

    .Title {
        display: flex;
        justify-content: center;
        grid-area: Title;
        font-size: 40px;
        letter-spacing: 2px;
    }

    .Functions {
        grid-area: Functions;
        display: flex;
        justify-content: center;
    }

    .View-Co");
            WriteLiteral(@"ntent {
        display: flex;
        justify-content: center;
        grid-area: View-Content;
        font-size: 20px;
        padding-left: 5%;
    }

    .Broadcaster-Label {
        grid-area: Broadcaster-Label;
        padding-left: 10%;
        font-size: 20px;
    }

    .NumberOfEpisodes-Label {
        grid-area: NumberOfEpisodes-Label;
        padding-left: 10%;
        font-size: 20px;
    }

    .NumberOfSeasons-Label {
        grid-area: NumberOfSeasons-Label;
        padding-left: 10%;
        font-size: 20px;
    }

    .Release-Date-Label {
        grid-area: Release-Date-Label;
        padding-left: 10%;
        font-size: 20px;
    }

    .Duration-Label {
        grid-area: Duration-Label;
        padding-left: 10%;
        font-size: 20px;
    }

    .Genre-Label {
        grid-area: Genre-Label;
        padding-left: 10%;
        font-size: 20px;
    }


    .Broadcaster-Input {
        grid-area: Broadcaster-Input;
        font-size: 20px;");
            WriteLiteral(@"
    }

    .NumberOfEpisodes-Input {
        grid-area: NumberOfEpisodes-Input;
        font-size: 20px;
    }

    .NumberOfSeasons-Input {
        grid-area: NumberOfSeasons-Input;
        font-size: 20px;
    }

    .Release-Date-Input {
        grid-area: Release-Date-Input;
        font-size: 20px;
    }

    .Duration-Input {
        grid-area: Duration-Input;
        font-size: 20px;
    }

    .Genre-Input {
        grid-area: Genre-Input;
        font-size: 20px;
    }

    .Accessibility-Input {
        grid-area: Accessibility-Input;
        font-size: 20px;
    }

    .Accessibility-Label {
        grid-area: Accessibility-Label;
        padding-left: 10%;
        font-size: 20px;
    }
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<MediaApp.Domain.User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<MediaApp.Domain.User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaApp.Models.Detail.SeriesDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
