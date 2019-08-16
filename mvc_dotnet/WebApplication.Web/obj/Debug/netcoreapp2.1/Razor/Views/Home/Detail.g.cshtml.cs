#pragma checksum "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d5e5c7407bb681716408ff879cc1b9cbc34f29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#line 2 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5e5c7407bb681716408ff879cc1b9cbc34f29c", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9b07c050a0c51332b819e62acfb82d2ccb8e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmUserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFilm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("danger btn btn-primary button-centered settings-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    DateTime day = DateTime.Now;

#line default
#line hidden
            BeginContext(95, 937, true);
            WriteLiteral(@"
<script>
    document.addEventListener('DOMContentLoaded', initilizePage);

    function initilizePage() {
        CheckDate();
    }

    function CheckDate() {
        document.querySelectorAll('.time-button').forEach((element) => {
            let time = new Date();
            let today = new Date();
            time.setHours(element.textContent.substr(0, 2));
            time.setMinutes(element.textContent.substr(element.textContent.length - 2, 2));
            if (time.getTime() < today.getTime()) {
                element.classList.add('disabled-button');
                element.classList.remove('sht-but');
                document.querySelectorAll('.disabled-button').forEach((element) => {
                    let link = element.parentElement;
                    link.classList.add('disabled-link');

                })
            }
        })
    }
</script>


<style>

</style>

<h2>");
            EndContext();
            BeginContext(1033, 16, false);
#line 38 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
Write(Model.Film.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 39 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
  
    // Within the film model, the cast is a list of strings. Here, we convert that list to a comma-separeted list as a string
    string cast = "";
    // Make sure there's content in the list
    if (Model.Film.Actors.Count > 0)
    {
        foreach (string actor in Model.Film.Actors)
        {
            cast += ", ";
            cast += actor;
        }
        cast = cast.Substring(2);

    }

#line default
#line hidden
#line 54 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
  
    // Within the film model, the genre field is a list of strings. Here, we convert that list to a comma-separeted list as a string

    string displayGenres = "";
    //Make sure there's content in the list
    if (Model.Film.Genre.Count > 0)
    {
        foreach (string genre in Model.Film.Genre)
        {
            displayGenres += ", ";
            displayGenres += genre;
        }
        displayGenres = displayGenres.Substring(2);
    }

#line default
#line hidden
            BeginContext(1949, 109, true);
            WriteLiteral("<div class=\"detail-body\">\r\n    <div id=\"film-detail-box\">\r\n        <div class=\"film-image\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2058, "\"", 2085, 1);
#line 72 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2064, Model.Film.ImageLink, 2064, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2086, 103, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"film-info-bullets\">\r\n            <div class=\"detail-synopsis\">");
            EndContext();
            BeginContext(2190, 19, false);
#line 75 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                    Write(Model.Film.Synopsis);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 76 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (cast != "")
            {

#line default
#line hidden
            BeginContext(2262, 38, true);
            WriteLiteral("                <div><b>Starring:</b> ");
            EndContext();
            BeginContext(2301, 4, false);
#line 78 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                 Write(cast);

#line default
#line hidden
            EndContext();
            BeginContext(2305, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 79 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"

            }

#line default
#line hidden
            BeginContext(2330, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 81 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (Model.Film.Rating != null)
            {

#line default
#line hidden
            BeginContext(2390, 36, true);
            WriteLiteral("                <div><b>Rating:</b> ");
            EndContext();
            BeginContext(2427, 17, false);
#line 83 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                               Write(Model.Film.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 84 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2467, 32, true);
            WriteLiteral("            <div><b>Length:</b> ");
            EndContext();
            BeginContext(2500, 18, false);
#line 85 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                           Write(Model.Film.RunTime);

#line default
#line hidden
            EndContext();
            BeginContext(2518, 16, true);
            WriteLiteral(" minutes</div>\r\n");
            EndContext();
#line 86 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (displayGenres != "")
            {

#line default
#line hidden
            BeginContext(2588, 35, true);
            WriteLiteral("                <div><b>Genre:</b> ");
            EndContext();
            BeginContext(2624, 13, false);
#line 88 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                              Write(displayGenres);

#line default
#line hidden
            EndContext();
            BeginContext(2637, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 89 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2660, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 90 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (Model.Film.Director != null)
            {

#line default
#line hidden
            BeginContext(2722, 41, true);
            WriteLiteral("                <div><b>Directed by:</b> ");
            EndContext();
            BeginContext(2764, 19, false);
#line 92 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                    Write(Model.Film.Director);

#line default
#line hidden
            EndContext();
            BeginContext(2783, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 93 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2806, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 94 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (Model.Film.LinkToSite != null)
            {

#line default
#line hidden
            BeginContext(2870, 23, true);
            WriteLiteral("                <div><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2893, "\"", 2922, 1);
#line 96 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2900, Model.Film.LinkToSite, 2900, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2923, 22, true);
            WriteLiteral("><b>Official site for ");
            EndContext();
            BeginContext(2946, 16, false);
#line 96 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                                                      Write(Model.Film.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2962, 16, true);
            WriteLiteral("</b></a></div>\r\n");
            EndContext();
#line 97 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2993, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 98 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
             if (Model.Film.ReleaseDate != null)
            {

#line default
#line hidden
            BeginContext(3058, 42, true);
            WriteLiteral("                <div><b>Release Date:</b> ");
            EndContext();
            BeginContext(3101, 45, false);
#line 100 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                     Write(Model.Film.ReleaseDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3146, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 101 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3169, 98, true);
            WriteLiteral("            <div class=\"show-times\">\r\n                <hr />\r\n                <h4>Showings:</h4>\r\n");
            EndContext();
#line 105 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                 foreach (ShowTime time in Model.Film.Showings)
                {
                    DateTime result = new DateTime();
                    result = day.Add(time.Showtime);
                    string displayShowtime = time.Showtime.ToString(@"hh\:mm");

#line default
#line hidden
            BeginContext(3541, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3561, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78683005148a45edb1f85045e7df9114", async() => {
                BeginContext(3673, 62, true);
                WriteLiteral("\r\n                        <button class=\"sht-but time-button\">");
                EndContext();
                BeginContext(3736, 15, false);
#line 111 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                                       Write(displayShowtime);

#line default
#line hidden
                EndContext();
                BeginContext(3751, 31, true);
                WriteLiteral("</button>\r\n                    ");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-showTimeID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                                                                WriteLiteral(time.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showTimeID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-showTimeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showTimeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                                                                                               WriteLiteral(result);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MovieDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3786, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 113 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3807, 58, true);
            WriteLiteral("            </div>\r\n            <div class=\"edit-field\">\r\n");
            EndContext();
#line 116 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                 if (Model.User != null)
                {
                    if (Model.User.Role == "Admin" || Model.User.Role == "admin")
                    {

#line default
#line hidden
            BeginContext(4032, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4056, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea8623c0bf1d477082907f5851e81d63", async() => {
                BeginContext(4214, 14, true);
                WriteLiteral("Edit This Film");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                                                                          WriteLiteral(Model.Film.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 121 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\Home\Detail.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4276, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmUserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591