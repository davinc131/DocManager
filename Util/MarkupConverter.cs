using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Util
{
    public class MarkupConverter:IMarkupConverter
    {
        public string ConvertXamlToHtml(string xamlText)
        {
            //return HtmlToXamlConverter.ConvertXamlToHtml(xamlText, false);
            return HtmlToXamlConverter.ConvertHtmlToXaml(xamlText, false);
        }

        public string ConvertHtmlToXaml(string htmlText)
        {
            return HtmlToXamlConverter.ConvertHtmlToXaml(htmlText, true);
        }

        public string ConvertRtfToHtml(string rtfText)
        {
            return RtfToHtmlConverter.ConvertRtfToHtml(rtfText);
        }

        public string ConvertHtmlToRtf(string htmlText)
        {
            return Util.HtmlToRtfConverter.ConvertHtmlToRtf(htmlText);
        }
    }
}
