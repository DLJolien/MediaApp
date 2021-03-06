#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3186e410998d64063bf1f0db49d97663171cb915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Index), @"mvc.1.0.view", @"/Views/Music/Index.cshtml")]
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
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3186e410998d64063bf1f0db49d97663171cb915", @"/Views/Music/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaListViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""filter-container"" class=""container"">
    <div class=""row"">
        <div class=""col-6"">
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on music title"" />
        </div>
        <div class=""col-3"">
");
#nullable restore
#line 11 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
              
                var genres = Model.Select(x => x.Genre).Distinct();
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <select class=\"browser-default custom-select\" id=\"selectionGenres\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3186e410998d64063bf1f0db49d97663171cb9154704", async() => {
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
#line 16 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                 foreach (var genre in genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3186e410998d64063bf1f0db49d97663171cb9156261", async() => {
#nullable restore
#line 18 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
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
#line 19 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
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

<div id=""items"" class=""container"">

");
#nullable restore
#line 33 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
      if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                There is currently no music listed.\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n");
#nullable restore
#line 42 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                 foreach (var music in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 1479, "\"", 1497, 2);
            WriteAttributeValue("", 1484, "div-", 1484, 4, true);
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 1488, music.Id, 1488, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-3\"");
            BeginWriteAttribute("name", " name=\"", 1512, "\"", 1530, 1);
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 1519, music.Seen, 1519, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"item\">\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                             if (signInManager.IsSignedIn(User))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                 if (music.Seen)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 1800, "\"", 1819, 2);
            WriteAttributeValue("", 1805, "seen-", 1805, 5, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 1810, music.Id, 1810, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"slashed-eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1851, "\"", 1886, 3);
            WriteAttributeValue("", 1861, "RemoveFromSeen(", 1861, 15, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 1876, music.Id, 1876, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1885, ")", 1885, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 1890, "\"", 1909, 2);
            WriteAttributeValue("", 1895, "icon-", 1895, 5, true);
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 1900, music.Id, 1900, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye-slash\"></i></p>\r\n");
#nullable restore
#line 52 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2092, "\"", 2111, 2);
            WriteAttributeValue("", 2097, "seen-", 2097, 5, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2102, music.Id, 2102, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"eye\" class=\"eye\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2135, "\"", 2165, 3);
            WriteAttributeValue("", 2145, "AddToSeen(", 2145, 10, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2155, music.Id, 2155, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2164, ")", 2164, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("id", " id=\"", 2169, "\"", 2188, 2);
            WriteAttributeValue("", 2174, "icon-", 2174, 5, true);
#nullable restore
#line 55 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2179, music.Id, 2179, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"far fa-eye\"></i></p>\r\n");
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                 if (music.Bookmarked)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2385, "\"", 2399, 1);
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2390, music.Id, 2390, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"red-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2434, "\"", 2459, 2);
            WriteAttributeValue("", 2439, "icon-heart-", 2439, 11, true);
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2450, music.Id, 2450, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2460, "\"", 2503, 3);
            WriteAttributeValue("", 2470, "RemoveFilmFromBookmark(", 2470, 23, true);
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2493, music.Id, 2493, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2502, ")", 2502, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 61 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("id", " id=\"", 2682, "\"", 2696, 1);
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2687, music.Id, 2687, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"grey-heart\" name=\"heart\"><i");
            BeginWriteAttribute("id", " id=\"", 2732, "\"", 2757, 2);
            WriteAttributeValue("", 2737, "icon-heart-", 2737, 11, true);
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2748, music.Id, 2748, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2758, "\"", 2796, 3);
            WriteAttributeValue("", 2768, "AddFilmToBookmark(", 2768, 18, true);
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 2786, music.Id, 2786, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2795, ")", 2795, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-heart\"></i></p>\r\n");
#nullable restore
#line 65 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3186e410998d64063bf1f0db49d97663171cb91517602", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 3032, "\"", 3053, 1);
#nullable restore
#line 68 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
WriteAttributeValue("", 3038, music.PhotoUrl, 3038, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <p>");
#nullable restore
#line 69 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                              Write(music.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 69 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                                             Write(music.ReleaseDate.Year);

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
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 75 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Music\Index.cshtml"
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
        function AddFilmToBookmark(id) {
            $.post(""/Bookmark/SaveToBookmarks"", { id: id }, function () {
                console.log(""addedtobookmarks"" + id);
            });
            var heart = document.getElementById(id);
            heart.style.color = ""red"";
            var icon = docume");
            WriteLiteral(@"nt.getElementById(""icon-heart-"" + id);
            icon.onclick = function () { RemoveFilmFromBookmark(id) };
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
            windo");
            WriteLiteral(@"w.location.href = ""?filterTitle=&filterGenre=Choose+a+genre"";
        }
        function RemoveFromSeen(id) {
            $.post(""/Media/RemoveFromSeen"", { id: id }, function () {
                console.log(""removedfromseen"" + id);
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
            var icon = docume");
            WriteLiteral(@"nt.getElementById(""icon-"" + id);
            icon.className = ""far fa-eye-slash"";
            var div = document.getElementById(""div-"" + id);
            console.log(div);
            div.style.backgroundColor = ""rgba(0, 0, 0, 0.85)"";
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

    ");
            WriteLiteral(@"    .container .row .col-3:hover p.eye {
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
  ");
            WriteLiteral(@"          font-weight: 600;
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
