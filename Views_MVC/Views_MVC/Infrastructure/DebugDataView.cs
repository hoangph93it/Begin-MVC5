using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace Views_MVC.Infrastructure
{
    public class DebugDataView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            Write(writer, "---Routing Data");
            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writer, "Key{0}, Value{1}", key, viewContext.RouteData.Values[key]);
            }
            Write(writer, "---Views Data---");
            foreach (string key in viewContext.ViewData.Keys)
            {
                Write(writer, "Key{0},Value{1}", key, viewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] value)
        {
            writer.Write(string.Format(template, value) + "<p/>");
        }
    }
}