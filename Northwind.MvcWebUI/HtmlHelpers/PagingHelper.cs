using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.MvcWebUI.Models;
using System;
using System.Text;
using System.Text.Encodings.Web;

namespace Northwind.MvcWebUI.HtmlHelpers
{
    public static class PagingHelper
    {
        public static IHtmlContent Pager(this IHtmlHelper html, PagingInfo pagingInfo)
        {
            StringBuilder sb = new StringBuilder();
            int totalPage = (int)Math.Ceiling((decimal)pagingInfo.totalProductCount / pagingInfo.pageSize);           
                        
            for (int i = 1; i <= totalPage; i++)
            {
                if (i==1)
                {
                    TagBuilder prevliTag = new TagBuilder("li");
                    prevliTag.AddCssClass("page-item");
                    TagBuilder prevaTag = new TagBuilder("a");
                    prevaTag.AddCssClass("page-link");
                    if (pagingInfo.currentPage != 1)
                        prevaTag.MergeAttribute("href", string.Format("/product?p={0}&c={1}", (pagingInfo.currentPage - 1), pagingInfo.currentCategory));
                    else
                        prevliTag.AddCssClass("disabled");
                    prevaTag.InnerHtml.Append("Previous");

                    prevliTag.InnerHtml.AppendHtml(prevaTag);
                    sb.Append(GetString(prevliTag));
                }

                TagBuilder liTag = new TagBuilder("li");
                liTag.AddCssClass("page-item");
                if (i == pagingInfo.currentPage)
                    liTag.AddCssClass("active");

                TagBuilder aTag = new TagBuilder("a");
                aTag.MergeAttribute("href", string.Format("?p={0}&c={1}", i, pagingInfo.currentCategory));
                aTag.AddCssClass("page-link");
                aTag.InnerHtml.Append(i.ToString());

                liTag.InnerHtml.AppendHtml(aTag);
                sb.Append(GetString(liTag));

                if (i == totalPage)
                {
                    TagBuilder nextliTag = new TagBuilder("li");
                    nextliTag.AddCssClass("page-item");
                    TagBuilder nextaTag = new TagBuilder("a");
                    nextaTag.AddCssClass("page-link");
                    if (pagingInfo.currentPage < totalPage)
                        nextaTag.MergeAttribute("href", string.Format("/product?p={0}&c={1}", (pagingInfo.currentPage + 1), pagingInfo.currentCategory));
                    else
                        nextliTag.AddCssClass("disabled");
                    nextaTag.InnerHtml.Append("Next");
                    nextliTag.InnerHtml.AppendHtml(nextaTag);
                    sb.Append(GetString(nextliTag));
                }
            }

            return new HtmlString(sb.ToString());
        }

        public static string GetString(IHtmlContent content)
        {
            var writer = new System.IO.StringWriter();
            content.WriteTo(writer, HtmlEncoder.Default);
            return writer.ToString();
        }
    }
}
