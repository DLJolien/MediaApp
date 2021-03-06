#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7176f0676eb2209818d10996cdde24cd61450b8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Music), @"mvc.1.0.view", @"/Views/Bookmark/Music.cshtml")]
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
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
using MediaApp.Models.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7176f0676eb2209818d10996cdde24cd61450b8a", @"/Views/Bookmark/Music.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Music : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookmarkListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>My bookmarked music</h1>

<div id=""filter-container"" class=""container"">
    <div class=""row"">
        <div class=""col-9"">
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on song title"" />
        </div>

        <div class=""col"">
            <button onclick=""FilterOn()"" id=""btn"" class=""btn btn-primary""><i class=""fas fa-search""></i></button>
        </div>
        <div class=""col-2"">
            <button onclick=""ClearFilter()"" id=""btn-clear"" class=""btn btn-dark"">Remove filter</button>
        </div>
    </div>
</div>



<div id=""items"" class=""container"">
");
#nullable restore
#line 26 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
      if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                There is currently no music bookmarked.\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"items\" class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                     foreach (var music in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 1177, "\"", 1195, 2);
            WriteAttributeValue("", 1182, "div-", 1182, 4, true);
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1186, music.Id, 1186, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-3\"");
            BeginWriteAttribute("name", " name=\"", 1210, "\"", 1228, 1);
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1217, music.Seen, 1217, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"item\">\r\n");
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                 if (music.Seen)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1403, "\"", 1422, 2);
            WriteAttributeValue("", 1408, "seen-", 1408, 5, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1413, music.Id, 1413, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"slashed-eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1454, "\"", 1489, 3);
            WriteAttributeValue("", 1464, "RemoveFromSeen(", 1464, 15, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1479, music.Id, 1479, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1488, ")", 1488, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1493, "\"", 1512, 2);
            WriteAttributeValue("", 1498, "icon-", 1498, 5, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1503, music.Id, 1503, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye-slash\"></i></p>\r\n");
#nullable restore
#line 43 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1695, "\"", 1714, 2);
            WriteAttributeValue("", 1700, "seen-", 1700, 5, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1705, music.Id, 1705, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1738, "\"", 1768, 3);
            WriteAttributeValue("", 1748, "AddToSeen(", 1748, 10, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1758, music.Id, 1758, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1767, ")", 1767, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1772, "\"", 1791, 2);
            WriteAttributeValue("", 1777, "icon-", 1777, 5, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1782, music.Id, 1782, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye\"></i></p>\r\n");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                 if (music.Bookmarked)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1988, "\"", 2002, 1);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 1993, music.Id, 1993, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"red-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2037, "\"", 2062, 2);
            WriteAttributeValue("", 2042, "icon-heart-", 2042, 11, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2053, music.Id, 2053, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2063, "\"", 2102, 3);
            WriteAttributeValue("", 2073, "RemoveFromBookmark(", 2073, 19, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2092, music.Id, 2092, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, ")", 2101, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 52 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2281, "\"", 2295, 1);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2286, music.Id, 2286, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"grey-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2331, "\"", 2356, 2);
            WriteAttributeValue("", 2336, "icon-heart-", 2336, 11, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2347, music.Id, 2347, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2357, "\"", 2391, 3);
            WriteAttributeValue("", 2367, "AddToBookmark(", 2367, 14, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2381, music.Id, 2381, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2390, ")", 2390, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7176f0676eb2209818d10996cdde24cd61450b8a14021", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 2604, "\"", 2625, 1);
#nullable restore
#line 58 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
WriteAttributeValue("", 2610, music.PhotoUrl, 2610, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <p>");
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                  Write(music.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                                 Write(music.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                ");
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
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                                                                                WriteLiteral(music.Id);

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
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Music.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <script src=""https://kit.fontawesome.com/a6748bd2b3.js"" crossorigin=""anonymous""></script>
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
        function AddToBookmark(id) {
            $.post(""/Bookmark/SaveToBookmarks"", { id: id }, function () {
                console.log(""addedtobookmarks"" + id);
            });
            var heart = document.getElementById(id);
            heart.style.color = ""red"";
            var icon = docume");
            WriteLiteral(@"nt.getElementById(""icon-heart-"" + id);
            icon.onclick = function () { RemoveFromBookmark(id) };
            console.log(icon);
        }
        function RemoveFromBookmark(id) {
            $.post(""/Bookmark/RemoveFromBookmarks"", { id: id }, function () {
                console.log(""removedfrombookmarks"" + id);
            });
            var heart = document.getElementById(id);
            heart.style.color = ""black"";
            var icon = document.getElementById(""icon-heart-"" + id);
            icon.onclick = function () { AddToBookmark(id) };
            console.log(icon);
        }
        function FilterOn() {
            var filter = document.getElementById('filter').value
            window.location.href = ""?filter="" + filter;
        }
        function ClearFilter() {
            window.location.href = ""?filter="";
        }
        function RemoveFromSeen(id) {
            $.post(""/Media/RemoveFromSeen"", { id: id }, function () {
                console.log(""removed");
            WriteLiteral(@"fromseen"" + id);
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
            div.style.backgroundColor = ""rgb");
            WriteLiteral(@"a(0, 0, 0, 0.85)"";
        }
    </script>
    <style>
        .container .row .col-3 p.red-heart {
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
            pos");
            WriteLiteral(@"ition: absolute;
            top: 0;
            left: 10%;
        }

        .container .row .col-3:hover p.slashed-eye {
            color: black;
            visibility: visible !important;
            cursor: pointer;
        }

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
            height: 280px;
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
        }");
            WriteLiteral("\r\n\r\n            #filter-container > * {\r\n                justify-content: space-around;\r\n                height: 40px;\r\n                width: 100%;\r\n            }\r\n\r\n        #items {\r\n            padding-top: 5%;\r\n        }\r\n    </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookmarkListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
