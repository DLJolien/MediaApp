#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2343813f2418221cf351118e0e2e451263fb86be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Detail), @"mvc.1.0.view", @"/Views/Music/Detail.cshtml")]
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
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2343813f2418221cf351118e0e2e451263fb86be", @"/Views/Music/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediaApp.Models.Detail.MusicDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"grid-container\">\r\n    <div class=\"Photo\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 273, "\"", 294, 1);
#nullable restore
#line 8 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
WriteAttributeValue("", 279, Model.PhotoUrl, 279, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-url\" />\r\n    </div>\r\n    <div class=\"Title\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"Singer-Label\">\r\n        <strong>Singer</strong>\r\n    </div>\r\n    <div class=\"Singer-Input\">\r\n        <p>");
#nullable restore
#line 17 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
      Write(Model.Singer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"Release-Date-Label\">\r\n        <strong>Release date</strong>\r\n    </div>\r\n    <div class=\"Release-Date-Input\">\r\n        <p>");
#nullable restore
#line 23 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
      Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"Duration-Label\">\r\n        <strong>Duration</strong>\r\n    </div>\r\n    <div class=\"Duration-Input\">\r\n        <p>");
#nullable restore
#line 29 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
      Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"Genre-Label\">\r\n        <strong>Genre</strong>\r\n    </div>\r\n    <div class=\"Genre-Input\">\r\n        <p>");
#nullable restore
#line 35 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"Accessibility-Label\">\r\n        <strong>Accessibility</strong>\r\n    </div>\r\n    <div class=\"Accessibility-Input\">\r\n");
#nullable restore
#line 41 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
         if (@Model.Public)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Public</p>\r\n");
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Private</p>\r\n");
#nullable restore
#line 48 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n    <div class=\"View-Content\">\r\n");
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
         if (!String.IsNullOrEmpty(@Model.ContentUrl))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2343813f2418221cf351118e0e2e451263fb86be8601", async() => {
                WriteLiteral("\r\n                <input type=\"submit\" value=\"View Content\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
AddHtmlAttributeValue("", 1453, Model.ContentUrl, 1453, 17, false);

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
#line 58 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"Functions\">\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2343813f2418221cf351118e0e2e451263fb86be10660", async() => {
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
#line 62 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2343813f2418221cf351118e0e2e451263fb86be13051", async() => {
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
#line 63 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2343813f2418221cf351118e0e2e451263fb86be15446", async() => {
                WriteLiteral(" Back to music overview");
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
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 68 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
 if (signInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n            </div>\r\n            <div class=\"col-10\" align=\"left\">\r\n                Post as ");
#nullable restore
#line 75 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                   Write(userManager.GetUserAsync(User).Result.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div id=\"comment-row\" class=\"row\">\r\n            <div id=\"photo-col\" class=\"col-2\" align=\"right\">\r\n                <img id=\"input-comment-user-photo\"");
            BeginWriteAttribute("src", " src=\"", 2410, "\"", 2463, 1);
#nullable restore
#line 80 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
WriteAttributeValue("", 2416, userManager.GetUserAsync(User).Result.PhotoUrl, 2416, 47, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 2775, "\"", 2809, 3);
            WriteAttributeValue("", 2785, "SubmitComment(", 2785, 14, true);
#nullable restore
#line 88 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
WriteAttributeValue("", 2799, Model.Id, 2799, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2808, ")", 2808, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\" type=\"submit\"> Comment</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 92 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You need to sign in first in order to comment.</p>\r\n");
#nullable restore
#line 97 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"comments\">\r\n");
#nullable restore
#line 101 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
     if (Model.Comments.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Comments</h2>\r\n        <p>No comments have been posted yet.</p>\r\n");
#nullable restore
#line 105 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\" align=\"left\">\r\n                    <h2>");
#nullable restore
#line 111 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                   Write(Model.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</h2>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 115 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
             foreach (var comment in Model.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-2\">\r\n                    </div>\r\n                    <div class=\"col-5\">\r\n                        ");
#nullable restore
#line 121 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                   Write(comment.User.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-5\" align=\"right\">\r\n");
#nullable restore
#line 124 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                          
                            var timepassed = DateTime.Now - comment.PublishedDate;
                            if (Math.Round(timepassed.TotalSeconds) < 60)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 128 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalSeconds));

#line default
#line hidden
#nullable disable
            WriteLiteral(" seconds ago</p>\r\n");
#nullable restore
#line 129 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalMinutes) < 60)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 132 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalMinutes));

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes ago</p>\r\n");
#nullable restore
#line 133 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalHours) < 24)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 136 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalHours));

#line default
#line hidden
#nullable disable
            WriteLiteral(" hours ago</p>\r\n");
#nullable restore
#line 137 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                            }
                            else if (Math.Round(timepassed.TotalDays) < 30)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 140 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                                     Write(Math.Round(timepassed.TotalDays));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago</p>\r\n");
#nullable restore
#line 141 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                            }
                            else if (Math.Ceiling(timepassed.TotalDays / 30) < 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>posted ");
#nullable restore
#line 144 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                                     Write(Math.Ceiling(timepassed.TotalDays / 30));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago</p>\r\n");
#nullable restore
#line 145 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-2\" align=\"right\">\r\n                        <img id=\"posted-comment-url\"");
            BeginWriteAttribute("src", " src=\"", 5247, "\"", 5275, 1);
#nullable restore
#line 151 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
WriteAttributeValue("", 5253, comment.User.PhotoUrl, 5253, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-url\" />\r\n                    </div>\r\n                    <div class=\"col-10\">\r\n                        ");
#nullable restore
#line 154 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
                   Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 157 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 159 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Detail.cshtml"
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
        grid-template-rows: 1fr 1fr 1fr 1fr 1fr 1fr 1fr 1fr;
        gap: 1px 1px;
        grid-template-areas: ""Title Title Title"" ""Photo Singer-Label Singer-Input"" ""Photo Release-Date-Label Release-Date-Input"" ""Photo Duration-Label Duration-Input"" ""Photo Genre-Label Genre-Input"" ""Photo Accessibility-Label Accessibility-Input"" ""Photo View-Content View-Content"" ""Functions Functions Functions"";
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

    .View-Content {
        display: flex;
        justify-content: center;
        grid-area: View-Content;
        font-size: 20px");
            WriteLiteral(@";
        padding-left: 5%;
    }

    .Singer-Label {
        grid-area: Singer-Label;
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


    .Singer-Input {
        grid-area: Singer-Input;
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

    .Accessibility-");
            WriteLiteral("Label {\r\n        grid-area: Accessibility-Label;\r\n        padding-left: 10%;\r\n        font-size: 20px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaApp.Models.Detail.MusicDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
