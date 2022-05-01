using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;


namespace test
{
	static class Program
	{
		/// <summary>
		/// 해당 애플리케이션의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Mat src = new Mat("00000.jpg");
			Mat gray = new Mat();
			Mat binary = new Mat();

			Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
			Cv2.Threshold(gray, binary, 150, 255, ThresholdTypes.Binary);

			

			Cv2.ImShow("src", src);
			Cv2.ImShow("dst", binary);
			Cv2.WaitKey(0);
		}
	}
}
