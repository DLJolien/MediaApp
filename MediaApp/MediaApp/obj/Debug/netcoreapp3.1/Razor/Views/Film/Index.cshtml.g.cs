#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4693c04912945a97e95b8aa240ed0d798a7059d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Index), @"mvc.1.0.view", @"/Views/Film/Index.cshtml")]
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
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4693c04912945a97e95b8aa240ed0d798a7059d3", @"/Views/Film/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""filter-container"" class=""container"">
    <div class=""row"">
        <div class=""col-6"">
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on film title"" />
        </div>
        <div class=""col-3"">
");
#nullable restore
#line 11 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
              
                var genres = Model.Select(x => x.Genre).Distinct();
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <select class=\"browser-default custom-select\" id=\"selectionGenres\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4693c04912945a97e95b8aa240ed0d798a7059d34695", async() => {
                WriteLiteral("Choose a genre");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                 foreach (var genre in genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4693c04912945a97e95b8aa240ed0d798a7059d36251", async() => {
#nullable restore
#line 18 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                       Write(genre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""col"">
            <button onclick=""FilterOn()"" id=""btn"" class=""btn btn-primary""><i class=""fas fa-search""></i></button>
        </div>
        <div class=""col-2"">
            <button onclick=""ClearFilter()"" id=""btn-clear"" class=""btn btn-dark"">Remove filter</button>
        </div>
    </div>
</div>


");
#nullable restore
#line 32 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
  if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <strong>There are currently no films listed.</strong>\r\n");
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"items\" class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 41 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                 foreach (var film in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 1440, "\"", 1457, 2);
            WriteAttributeValue("", 1445, "div-", 1445, 4, true);
#nullable restore
#line 43 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 1449, film.Id, 1449, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-3\"");
            BeginWriteAttribute("name", " name=\"", 1472, "\"", 1489, 1);
#nullable restore
#line 43 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 1479, film.Seen, 1479, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"item\">\r\n\r\n");
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                             if (signInManager.IsSignedIn(User))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                 if (film.Seen)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1758, "\"", 1776, 2);
            WriteAttributeValue("", 1763, "seen-", 1763, 5, true);
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 1768, film.Id, 1768, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"slashed-eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1808, "\"", 1842, 3);
            WriteAttributeValue("", 1818, "RemoveFromSeen(", 1818, 15, true);
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 1833, film.Id, 1833, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1841, ")", 1841, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1846, "\"", 1864, 2);
            WriteAttributeValue("", 1851, "icon-", 1851, 5, true);
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 1856, film.Id, 1856, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye-slash\"></i></p>\r\n");
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2047, "\"", 2065, 2);
            WriteAttributeValue("", 2052, "seen-", 2052, 5, true);
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2057, film.Id, 2057, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2089, "\"", 2118, 3);
            WriteAttributeValue("", 2099, "AddToSeen(", 2099, 10, true);
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2109, film.Id, 2109, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2117, ")", 2117, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 2122, "\"", 2140, 2);
            WriteAttributeValue("", 2127, "icon-", 2127, 5, true);
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2132, film.Id, 2132, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye\"></i></p>\r\n");
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                 if (film.Bookmarked)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2336, "\"", 2349, 1);
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2341, film.Id, 2341, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"red-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2384, "\"", 2408, 2);
            WriteAttributeValue("", 2389, "icon-heart-", 2389, 11, true);
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2400, film.Id, 2400, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2409, "\"", 2451, 3);
            WriteAttributeValue("", 2419, "RemoveFilmFromBookmark(", 2419, 23, true);
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2442, film.Id, 2442, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2450, ")", 2450, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2630, "\"", 2643, 1);
#nullable restore
#line 63 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2635, film.Id, 2635, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"grey-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2679, "\"", 2703, 2);
            WriteAttributeValue("", 2684, "icon-heart-", 2684, 11, true);
#nullable restore
#line 63 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2695, film.Id, 2695, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2704, "\"", 2741, 3);
            WriteAttributeValue("", 2714, "AddFilmToBookmark(", 2714, 18, true);
#nullable restore
#line 63 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2732, film.Id, 2732, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2740, ")", 2740, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4693c04912945a97e95b8aa240ed0d798a7059d317509", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 2975, "\"", 2995, 1);
#nullable restore
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
WriteAttributeValue("", 2981, film.PhotoUrl, 2981, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <p>");
#nullable restore
#line 68 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                              Write(film.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 68 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                            Write(film.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            ");
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
#line 66 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                                                                           WriteLiteral(film.Id);

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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 75 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Film\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://kit.fontawesome.com/a6748bd2b3.js"" crossorigin=""anonymous""></script>
<script>
    window.onload = function () {
        var hearts = document.getElementsByName(""heart"");
        console.log(hearts);
        var eyes = document.getElementsByName(""eye"");
        console.log(eyes);
        for (var i = 0; i < hearts.length; i++) {
            hearts[i].style.visibility = ""hidden"";
            eyes[i].style.visibility = ""hidden"";
        }
        console.log(""hidden"");
        var divs = document.getElementsByName(""name"");
        divs.forEach(x => x.style.backgroundColor = ""rgba(0, 0, 0, 0.85)"");
    }
    function AddFilmToBookmark(id) {
        $.post(""/Bookmark/SaveToBookmarks"", { id: id }, function () {
            console.log(""addedtobookmarks"" + id);
        });
        var heart = document.getElementById(id);
        heart.style.color = ""red"";
        var icon = document.getElementById(""icon-heart-"" + id);
        icon.onclick = function () { RemoveFilmFromBookm");
            WriteLiteral(@"ark(id) };
        console.log(icon);
    }
    function RemoveFilmFromBookmark(id) {
        $.post(""/Bookmark/RemoveFromBookmarks"", { id: id }, function () {
            console.log(""removedfrombookmarks"" + id);
        });
        var heart = document.getElementById(id);
        heart.style.color = ""black"";
        var icon = document.getElementById(""icon-heart-"" + id);
        icon.onclick = function () { AddFilmToBookmark(id) };
        console.log(icon);
    }
    function FilterOn() {
        var filterTitle = document.getElementById('filter').value
        var e = document.getElementById(""selectionGenres"");
        var filterGenre = e.options[e.selectedIndex].text;
        window.location.href = ""?filterTitle="" + filterTitle + ""&filterGenre="" + filterGenre;
    }
    function ClearFilter() {
        window.location.href = ""?filterTitle=&filterGenre=Choose+a+genre"";
    }
    function RemoveFromSeen(id) {
        $.post(""/Media/RemoveFromSeen"", { id: id }, function () {
        ");
            WriteLiteral(@"    console.log(""removedfromseen"" + id);
        });
        var seen = document.getElementById(""seen-"" + id);
        seen.onclick = function () { AddToSeen(id) };
        console.log(seen);
        var icon = document.getElementById(""icon-"" + id);
        icon.className = ""far fa-eye"";
        console.log(icon);
        var div = document.getElementById(""div-"" + id);
        console.log(div);
        div.style.backgroundColor = ""white"";
    }
    function AddToSeen(id) {
        $.post(""/Media/AddToSeen"", { id: id }, function () {
            console.log(""addedtoseen"" + id);
        });
        var seen = document.getElementById(""seen-"" + id);
        seen.onclick = function () { RemoveFromSeen(id) };
        var icon = document.getElementById(""icon-"" + id);
        icon.className = ""far fa-eye-slash"";
        var div = document.getElementById(""div-"" + id);
        console.log(div);
        div.style.backgroundColor = ""rgba(0, 0, 0, 0.85)"";
    }
</script>
<style>
    .container .r");
            WriteLiteral(@"ow .col-3 p.red-heart {
        position: absolute;
        top: 0;
        right: 10%;
    }

    .container .row .col-3:hover p.red-heart {
        color: red;
        visibility: visible !important;
        cursor: pointer;
    }

    .container .row .col-3 p.grey-heart {
        position: absolute;
        top: 0;
        right: 10%;
    }

    .container .row .col-3:hover p.grey-heart {
        color: black;
        visibility: visible !important;
        cursor: pointer;
    }

    .container .row .col-3 p.eye {
        position: absolute;
        top: 0;
        left: 10%;
    }

    .container .row .col-3:hover p.eye {
        color: black;
        visibility: visible !important;
        cursor: pointer;
    }

    .container .row .col-3 p.slashed-eye {
        position: absolute;
        top: 0;
        left: 10%;
    }

    .container .row .col-3:hover p.slashed-eye {
        color: black;
        visibility: visible !important;
        cursor: pointer;
");
            WriteLiteral(@"    }

    div .col-3 .item {
        width: 100%;
    }

        div .col-3 .item a {
            display: flex;
            flex-direction: column;
            align-items: center;
            color: black;
        }

    div .col-3 {
        display: flex;
        flex-direction: column;
        align-items: flex-start;
    }

    img {
        width: 100%;
        height: 320px;
        display: block;
    }


    .container .row .col-3 div > a > p {
        font-weight: 600;
        text-shadow: 2px 2px 8px #FFFFFF;
    }

    #filter-container {
        position: fixed;
        z-index: 1;
        background-color: white;
    }

        #filter-container > * {
            justify-content: space-around;
            height: 40px;
            width: 100%;
        }

    #items {
        padding-top: 5%;
    }
</style>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
