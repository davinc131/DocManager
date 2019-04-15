using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public interface IMarkupConverter
    {
        string ConvertXamlToHtml(string xamlText);
        string ConvertHtmlToXaml(string htmlText);
        string ConvertRtfToHtml(string rtfText);
        string ConvertHtmlToRtf(string htmlText);
    }
}
