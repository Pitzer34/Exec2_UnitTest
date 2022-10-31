using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDateCheck_Click(object sender, EventArgs e)
		{
			DateTime dt;
			
			try
			{
				dt = DateRule();
				string result = TradingTime(dt);
				MessageBox.Show(result);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private DateTime DateRule()
		{
			string input = txtDate.Text;
			bool isDateTime = DateTime.TryParse(input, out DateTime dt);

			if (isDateTime == false)
			{
				throw new Exception("格式錯誤");
			}
			return dt;
		}
		private string TradingTime(DateTime dt)
		{
			string result;

			int day = Convert.ToInt32(dt.DayOfWeek);
			
			DateTime time = Convert.ToDateTime(dt.ToString("HH:mm"));
			DateTime StartTime = Convert.ToDateTime("09:00");
			DateTime EndTime = Convert.ToDateTime("13:30");

			if (day > 5 || day < 1)
			{
				result = "非營業日期";
			}
			else if (time > EndTime || time < StartTime)
			{
				result = "非營業時間";
			}
			else
			{
				result = dt.ToString("yyyy/MM/dd,HH:mm")+"為營業時間";
			}
			return result;
		}
	}
}
