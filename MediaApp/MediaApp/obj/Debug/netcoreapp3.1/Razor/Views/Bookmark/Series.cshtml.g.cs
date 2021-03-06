#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c779386400fac9499add0677dcf64897e978d3d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Series), @"mvc.1.0.view", @"/Views/Bookmark/Series.cshtml")]
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
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
using MediaApp.Models.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c779386400fac9499add0677dcf64897e978d3d4", @"/Views/Bookmark/Series.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Series : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookmarkListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "series", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<h1>My bookmarked series</h1>

<div id=""filter-container"" class=""container"">
    <div class=""row"">
        <div class=""col-9"">
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on series title"" />
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
#line 26 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
      if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                There is currently no music bookmarked.\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"items\" class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                     foreach (var series in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 1181, "\"", 1200, 2);
            WriteAttributeValue("", 1186, "div-", 1186, 4, true);
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1190, series.Id, 1190, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-3\"");
            BeginWriteAttribute("name", " name=\"", 1215, "\"", 1234, 1);
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1222, series.Seen, 1222, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"item\">\r\n");
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                 if (series.Seen)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1410, "\"", 1430, 2);
            WriteAttributeValue("", 1415, "seen-", 1415, 5, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1420, series.Id, 1420, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"slashed-eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1462, "\"", 1498, 3);
            WriteAttributeValue("", 1472, "RemoveFromSeen(", 1472, 15, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1487, series.Id, 1487, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1497, ")", 1497, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1502, "\"", 1522, 2);
            WriteAttributeValue("", 1507, "icon-", 1507, 5, true);
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1512, series.Id, 1512, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye-slash\"></i></p>\r\n");
#nullable restore
#line 43 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1705, "\"", 1725, 2);
            WriteAttributeValue("", 1710, "seen-", 1710, 5, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1715, series.Id, 1715, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1749, "\"", 1780, 3);
            WriteAttributeValue("", 1759, "AddToSeen(", 1759, 10, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1769, series.Id, 1769, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1779, ")", 1779, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1784, "\"", 1804, 2);
            WriteAttributeValue("", 1789, "icon-", 1789, 5, true);
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 1794, series.Id, 1794, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye\"></i></p>\r\n");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                 if (series.Bookmarked)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2002, "\"", 2017, 1);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2007, series.Id, 2007, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"red-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2052, "\"", 2078, 2);
            WriteAttributeValue("", 2057, "icon-heart-", 2057, 11, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2068, series.Id, 2068, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2125, 3);
            WriteAttributeValue("", 2089, "RemoveSeriesFromBookmark(", 2089, 25, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2114, series.Id, 2114, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2124, ")", 2124, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 52 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2304, "\"", 2319, 1);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2309, series.Id, 2309, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"grey-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2355, "\"", 2381, 2);
            WriteAttributeValue("", 2360, "icon-heart-", 2360, 11, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2371, series.Id, 2371, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2382, "\"", 2423, 3);
            WriteAttributeValue("", 2392, "AddSeriesToBookmark(", 2392, 20, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2412, series.Id, 2412, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2422, ")", 2422, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c779386400fac9499add0677dcf64897e978d3d414097", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 2638, "\"", 2660, 1);
#nullable restore
#line 58 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
WriteAttributeValue("", 2644, series.PhotoUrl, 2644, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <p>");
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                  Write(series.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 59 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                                  Write(series.ReleaseDate.Year);

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
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                                                                                 WriteLiteral(series.Id);

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
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Series.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
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
        function AddSeriesToBookmark(id) {
            $.post(""/Bookmark/SaveToBookmarks"", { id: id }, function () {
                console.log(""addedtobookmarks"" + id);
            });
            var heart = document.getElementById(id);
            heart.style.color = ""red"";
            var icon = document.get");
            WriteLiteral(@"ElementById(""icon-heart-"" + id);
            icon.onclick = function () { RemoveSeriesFromBookmark(id) };
            console.log(icon);
        }
        function RemoveSeriesFromBookmark(id) {
            $.post(""/Bookmark/RemoveFromBookmarks"", { id: id }, function () {
                console.log(""removedfrombookmarks"" + id);
            });
            var heart = document.getElementById(id);
            heart.style.color = ""black"";
            var icon = document.getElementById(""icon-heart-"" + id);
            icon.onclick = function () { AddSeriesToBookmark(id) };
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
                console.");
            WriteLiteral(@"log(""removedfromseen"" + id);
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
            div.style.background");
            WriteLiteral(@"Color = ""rgba(0, 0, 0, 0.85)"";
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
        position: absolute;
        top: 0;
        left: 10%;
    }

    .container .row .col-3:hover p.slashed-eye {
        co");
            WriteLiteral(@"lor: black;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookmarkListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
