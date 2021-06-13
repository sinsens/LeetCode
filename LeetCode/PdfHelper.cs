using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace LeetCode
{
    public class PdfHelper
    {
        public void SaveUrlAsPdf(string url, string filename)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.LoadFromHTML(url, true, false, true, new PdfPageSettings { Margins = new PdfMargins { All = 52 } });
            pdf.SaveToFile(filename);
        }
    }
}