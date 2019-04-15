using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Util;

namespace Control
{
    public class Converter
    {

        IMarkupConverter markupConverter;

        public Converter()
        {
            markupConverter = new Util.MarkupConverter();
        }

        public void ConverterRtfToHtml(TextRange text)
        {
            string t = "";
            t = markupConverter.ConvertRtfToHtml(t);
        }
    }
}
