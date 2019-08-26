using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxyPlotWinFormCSharp
{
    public partial class Form1 : Form
    {
        private int[] m_nHistgram = new int[256];

        public Form1()
        {
            InitializeComponent();

            chart.Model = new OxyPlot.PlotModel { PlotType = OxyPlot.PlotType.XY };
        }

        public void OnClickBtnFileSelect(object sender, EventArgs e)
        {
            ComOpenFileDialog openFileDlg = new ComOpenFileDialog();
            openFileDlg.Filter = "JPG|*.jpg|PNG|*.png";
            openFileDlg.Title = "Open the file";
            if (openFileDlg.ShowDialog() == true)
            {
                image.Image = null;
                image.ImageLocation = openFileDlg.FileName;

                var bitmap = (Bitmap)new Bitmap(openFileDlg.FileName).Clone();

                DrawHistgram(bitmap);
            }
            return;
        }

        public void DrawHistgram(Bitmap _bitmap)
        {
            InitHistgram();

            CalHistgram(_bitmap);

            var series = new ColumnSeries { FillColor = OxyColors.DarkBlue };
            for (int nIdx = 0; nIdx < m_nHistgram.Length; nIdx++)
            {
                series.Items.Add(new ColumnItem(m_nHistgram[nIdx]));
            }
            chart.Model.Series.Clear();
            chart.Model.Series.Add(series);
            chart.Model.InvalidatePlot(true);
        }

        public void CalHistgram(Bitmap _bitmap)
        {
            int nWidthSize = _bitmap.Width;
            int nHeightSize = _bitmap.Height;

            BitmapData bitmapData = _bitmap.LockBits(new Rectangle(0, 0, nWidthSize, nHeightSize), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int nIdxWidth;
            int nIdxHeight;

            unsafe
            {
                for (nIdxHeight = 0; nIdxHeight < nHeightSize; nIdxHeight++)
                {
                    for (nIdxWidth = 0; nIdxWidth < nWidthSize; nIdxWidth++)
                    {
                        byte* pPixel = (byte*)bitmapData.Scan0 + nIdxHeight * bitmapData.Stride + nIdxWidth * 4;
                        byte nGrayScale = (byte)((pPixel[(int)ComInfo.Pixel.B] + pPixel[(int)ComInfo.Pixel.G] + pPixel[(int)ComInfo.Pixel.R]) / 3);

                        m_nHistgram[nGrayScale] += 1;
                    }
                }
            }
        }

        public void InitHistgram()
        {
            for (int nIdx = 0; nIdx < m_nHistgram.Length; nIdx++)
            {
                m_nHistgram[nIdx] = 0;
            }
        }
    }
}
