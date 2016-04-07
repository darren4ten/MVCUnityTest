using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcAppTest.Helper
{
    public static class ExtendMvcHtml
    {
        public static MvcHtmlString ToolButton(this HtmlHelper helper, string id, string icon, string text, bool showSeparator)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendFormat("<a id=\"{0}\" style=\"float: left;\" class=\"l-btn l-btn-plain\">", id);
            sb.AppendFormat("<span class=\"l-btn-left\"><span class=\"l-btn-text {0}\" style=\"padding-left: 20px;\">", icon);
            sb.AppendFormat("{0}</span></span></a>", text);
            if (showSeparator)
            {
                sb.Append("<div class=\"datagrid-btn-separator\"></div>");
            }
            return new MvcHtmlString(sb.ToString());
        }
    }
}