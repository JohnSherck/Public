#pragma checksum "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0fda2d973ea488307fda8aa7730987c799aa1c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowTime_Index), @"mvc.1.0.view", @"/Views/ShowTime/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShowTime/Index.cshtml", typeof(AspNetCore.Views_ShowTime_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fda2d973ea488307fda8aa7730987c799aa1c5", @"/Views/ShowTime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9b07c050a0c51332b819e62acfb82d2ccb8e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowTime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserFilmVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DateSelection.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary button-centered desktop-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFilm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("danger btn btn-primary button-centered settings-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
  
    ViewData["Title"] = "Showtimes";

#line default
#line hidden
            BeginContext(64, 2085, true);
            WriteLiteral(@"<style>
    a.button-centered {
        margin-left: auto;
        margin-right: auto;
        margin-top: 1rem;
    }

    img.show-time-card {
        margin-top: auto;
        margin-bottom: auto;
    }

    h4.heading {
        text-decoration: underline;
        font-weight: bold;
        text-align: center;
        margin-left: auto;
        margin-right: auto;
    }

    p.heading {
        text-decoration: underline;
        text-align: center;
    }

    div.show-times {
        align-self: center;
    }

    div.film-info-container {
        display: flex;
    }

    button.desktop-button {
        display: inline;
        width: 100%;
    }

    div.film-link-home {
        width: 100%;
        text-align: center;
    }

    img.film-image-home {
        resize: 50%;
    }

    div.film-card-showtimes {
        display: grid;
        grid-template-columns: 2fr 3fr;
        grid-template-areas: ""pic title"" ""pic showhead"" ""pic showtimes"" ""btn  btn"";
");
            WriteLiteral(@"    }

    img.showtime-image {
        grid-area: pic;
    }

    h4.film-heading {
        grid-area: title;
    }

    p.show-heading {
        grid-area: showhead;
    }

    button.desktop-button {
        grid-area: btn;
    }

    div.show-times {
        grid-area: showtimes;
    }


    div.view-showtime-selection {
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        grid-template-areas: ""title title title"" ""prev date next"";
        text-align: center;
        padding: 1rem;
    }

    #last-day {
        grid-area: prev;
    }

    #next-day {
        grid-area: next;
    }

    #day-of-week {
        grid-area: date;
    }

    h2.showtime-heading {
        grid-area: title;
        text-decoration: underline;
    }

    button.disabled-button {
        background-color: gray;
        color: black;
        border-color: black;
        display: none;
    }
    #edit-button {
    margin-left: 90%;
    }
    footer {
    ");
            WriteLiteral("    display: none;\r\n    }\r\n</style>\r\n");
            EndContext();
#line 117 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
  
    DateTime selectedDay = DateTime.Now;
    TimeSpan currentTimeStamp = selectedDay.TimeOfDay;

#line default
#line hidden
            BeginContext(2254, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2258, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54664fe7f74347dd8c3741f393bc249e", async() => {
                BeginContext(2294, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2305, 176, true);
            WriteLiteral("\r\n\r\n<div class=\"view-showtime-selection\">\r\n    <h2 class=\"table-head showtime-heading\">Showtimes For:</h2>\r\n    <button id=\"last-day\">&#8249</button>\r\n    <p id=\"current-date\">");
            EndContext();
            BeginContext(2482, 32, false);
#line 129 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                    Write(selectedDay.ToString("M/d/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 84, true);
            WriteLiteral("</p>\r\n    <button id=\"next-day\">&#8250</button>\r\n</div>\r\n<div class=\"Home-Page\">\r\n\r\n");
            EndContext();
#line 134 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
     foreach (Film film in Model.FilmList)
    {

#line default
#line hidden
            BeginContext(2649, 57, true);
            WriteLiteral("    <div class=\"film-card\">\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2706, "\"", 2729, 1);
#line 137 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2714, film.startDate, 2714, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2730, 36, true);
            WriteLiteral(" name=\"startDate\" class=\"start-date\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2766, "\"", 2782, 1);
#line 137 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2771, film.Title, 2771, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2783, 33, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2816, "\"", 2837, 1);
#line 138 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2824, film.endDate, 2824, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2838, 32, true);
            WriteLiteral(" name=\"endDate\" class=\"end-date\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2870, "\"", 2886, 1);
#line 138 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2875, film.Title, 2875, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2887, 53, true);
            WriteLiteral(" />\r\n        <img class=\"card-img-top show-time-card\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2940, "\"", 2961, 1);
#line 139 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2946, film.ImageLink, 2946, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2962, "\"", 2979, 1);
#line 139 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 2968, film.Title, 2968, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2980, 46, true);
            WriteLiteral(" />\r\n        <h4 class=\"heading film-heading\">");
            EndContext();
            BeginContext(3027, 10, false);
#line 140 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                                    Write(film.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3037, 100, true);
            WriteLiteral("</h4>\r\n        <p class=\"heading show-heading\">Showings:</p>\r\n        <div class=\"film-link-home\">\r\n");
            EndContext();
#line 143 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
             foreach (ShowTime showtime in film.Showings)
            {
                string hour = showtime.Showtime.ToString().Substring(0, 2);
                string minutes = showtime.Showtime.ToString().Substring(3, 2);
                DateTime result = DateTime.Now;
                TimeSpan movieTime = new TimeSpan(int.Parse(hour), int.Parse(minutes), 0);
                result = result.Date + movieTime;
                string displayShowtime = showtime.Showtime.ToString(@"hh\:mm");

#line default
#line hidden
            BeginContext(3641, 36, true);
            WriteLiteral("                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3677, "\"", 3696, 1);
#line 151 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
WriteAttributeValue("", 3685, film.Title, 3685, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3697, 21, true);
            WriteLiteral(" name=\"FilmName\" />\r\n");
            EndContext();
            BeginContext(3720, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3736, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89286b7767f348f7b3e539f7b91b2f9a", async() => {
                BeginContext(3852, 58, true);
                WriteLiteral("\r\n                    <button class=\"sht-but time-button\">");
                EndContext();
                BeginContext(3911, 15, false);
#line 154 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                                                   Write(displayShowtime);

#line default
#line hidden
                EndContext();
                BeginContext(3926, 27, true);
                WriteLiteral("</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-showTimeID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 153 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                                                                            WriteLiteral(showtime.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showTimeID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-showTimeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showTimeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 153 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
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
            BeginContext(3957, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 156 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(3976, 24, true);
            WriteLiteral("        </div>\r\n        ");
            EndContext();
            BeginContext(4000, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e0f02a108c34532a0b74c66e03c704e", async() => {
                BeginContext(4124, 17, true);
                WriteLiteral("View More Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 159 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                                                       WriteLiteral(film.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 160 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
         if(Model.CurrentUser != null)
        {
            if(Model.CurrentUser.Role == "Admin" || Model.CurrentUser.Role == "admin")
            {

#line default
#line hidden
            BeginContext(4301, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4317, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df14d78adb84693bfaa1fa7552a360a", async() => {
                BeginContext(4469, 1, true);
                WriteLiteral("⚙");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 164 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
                                                                  WriteLiteral(film.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4474, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 165 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(4502, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 168 "C:\Users\JSherck\GIT\c-final-capstone-team-cinema\mvc_dotnet\WebApplication.Web\Views\ShowTime\Index.cshtml"
       // }
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserFilmVM> Html { get; private set; }
    }
}
#pragma warning restore 1591