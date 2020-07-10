#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61a04cb574cb85bf3b011ba517f8bd41b50d563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Film), @"mvc.1.0.view", @"/Views/Bookmark/Film.cshtml")]
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
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
using MediaApp.Models.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61a04cb574cb85bf3b011ba517f8bd41b50d563", @"/Views/Bookmark/Film.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Film : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookmarkListViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>My bookmarked films</h1>

<div id=""filter-container"" class=""container"">
    <div class=""row"">
        <div class=""col-9"">
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on film title"" />
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
#line 25 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
  if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <strong>There are currently no films bookmarked.</strong>\r\n");
#nullable restore
#line 29 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"items\" class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                 foreach (var film in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 1075, "\"", 1092, 2);
            WriteAttributeValue("", 1080, "div-", 1080, 4, true);
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1084, film.Id, 1084, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-3\"");
            BeginWriteAttribute("name", " name=\"", 1107, "\"", 1124, 1);
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1114, film.Seen, 1114, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"item\">\r\n");
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                             if (film.Seen)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p");
            BeginWriteAttribute("id", " id=\"", 1282, "\"", 1300, 2);
            WriteAttributeValue("", 1287, "seen-", 1287, 5, true);
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1292, film.Id, 1292, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"slashed-eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1332, "\"", 1366, 3);
            WriteAttributeValue("", 1342, "RemoveFromSeen(", 1342, 15, true);
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1357, film.Id, 1357, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1365, ")", 1365, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1370, "\"", 1388, 2);
            WriteAttributeValue("", 1375, "icon-", 1375, 5, true);
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1380, film.Id, 1380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye-slash\"></i></p>\r\n");
#nullable restore
#line 41 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p");
            BeginWriteAttribute("id", " id=\"", 1555, "\"", 1573, 2);
            WriteAttributeValue("", 1560, "seen-", 1560, 5, true);
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1565, film.Id, 1565, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1597, "\"", 1626, 3);
            WriteAttributeValue("", 1607, "AddToSeen(", 1607, 10, true);
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1617, film.Id, 1617, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1625, ")", 1625, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1630, "\"", 1648, 2);
            WriteAttributeValue("", 1635, "icon-", 1635, 5, true);
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1640, film.Id, 1640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye\"></i></p>\r\n");
#nullable restore
#line 45 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                             if (film.Bookmarked)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p");
            BeginWriteAttribute("id", " id=\"", 1828, "\"", 1841, 1);
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1833, film.Id, 1833, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"red-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 1876, "\"", 1900, 2);
            WriteAttributeValue("", 1881, "icon-heart-", 1881, 11, true);
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1892, film.Id, 1892, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1901, "\"", 1943, 3);
            WriteAttributeValue("", 1911, "RemoveFilmFromBookmark(", 1911, 23, true);
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 1934, film.Id, 1934, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1942, ")", 1942, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p");
            BeginWriteAttribute("id", " id=\"", 2106, "\"", 2119, 1);
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 2111, film.Id, 2111, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"grey-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2155, "\"", 2179, 2);
            WriteAttributeValue("", 2160, "icon-heart-", 2160, 11, true);
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 2171, film.Id, 2171, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2180, "\"", 2217, 3);
            WriteAttributeValue("", 2190, "AddFilmToBookmark(", 2190, 18, true);
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 2208, film.Id, 2208, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2216, ")", 2216, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61a04cb574cb85bf3b011ba517f8bd41b50d56313800", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 2416, "\"", 2436, 1);
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
WriteAttributeValue("", 2422, film.PhotoUrl, 2422, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <p>");
#nullable restore
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                              Write(film.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
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
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
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
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 62 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Bookmark\Film.cshtml"

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
        $.post(""/Film/RemoveFromSeen"", { id: id }, function () {
         ");
            WriteLiteral(@"   console.log(""removedfromseen"" + id);
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
        $.post(""/Film/AddToSeen"", { id: id }, function () {
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
    .container .row");
            WriteLiteral(@" .col-3 p.red-heart {
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
            WriteLiteral(@"  }

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