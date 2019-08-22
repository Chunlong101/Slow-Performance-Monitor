using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.PageLoadPerformance
{
    public class PageLoadMetrics
    {
        public DateTime TimeStamp { get; set; }
        public string Url { get; set; }
        public TimeSpan PageLoadTime { get; set; }

        public PageLoadMetrics(DateTime TimeStamp, string Url, TimeSpan PageLoadTime)
        {
            this.TimeStamp = TimeStamp;
            this.Url = Url;
            this.PageLoadTime = PageLoadTime;
        }

        /// <summary>
        /// Get performance metrics from csv file, the file path comes from the config fie
        /// </summary>
        /// <returns>a list of PageLoadMetrics</returns>
        public static List<PageLoadMetrics> GetMetricsCsv()
        {
            try
            {
                string path = Properties.Settings.Default.PageLoadMetricsCsv;

                if (!File.Exists(path))
                {
                    return null;
                }

                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader))
                {
                    var t = csv.GetRecords<PageLoadMetrics>();

                    return csv.GetRecords<PageLoadMetrics>().ToList<PageLoadMetrics>();
                }
            }
            catch (Exception ex)
            {
                Core.Logging.Logger.GetLogger(typeof(PageLoadMetrics)).Error(ex, "Something went wrong, pls check the log file");
                return null;
            }
        }

        /// <summary>
        /// Get last 3 items from performance metrics csv file 
        /// </summary>
        /// <param name="Num">How many items you'd prefer get from the bottom of the csv file</param>
        /// <returns>a list of PageLoadMetrics</returns>
        public static List<PageLoadMetrics> GetMetricsCsvLast(int Num)
        {
            try
            {
                List<PageLoadMetrics> records = GetMetricsCsv();

                return records.Skip(records.Count - Num).ToList<PageLoadMetrics>();
            }
            catch (Exception ex)
            {
                Core.Logging.Logger.GetLogger(typeof(PageLoadMetrics)).Error(ex, "Something went wrong, pls check the log file");
                return null;
            }
        }

        /// <summary>
        /// Save current object to a csv file using CsvHelper, the file path comes from the config file
        /// </summary>
        /// <returns>1 means okay, -1 means error</returns>
        public int SaveToCsv()
        {
            try
            {
                int fb = -1;

                string path = Properties.Settings.Default.PageLoadMetricsCsv;

                if (File.Exists(path))
                {
                    fb = AppendToCsv();
                    return fb;
                }

                var records = new List<PageLoadMetrics>
            {
                this,
            };

                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(records);
                    fb = 1;
                }

                return fb;
            }
            catch (Exception ex)
            {
                Core.Logging.Logger.GetLogger(this.GetType()).Error(ex, "Something went wrong, pls check the log file");
                return -1;
            }
        }

        /// <summary>
        /// Append current object to a csv file using CsvHelper, the file path comes from the config file
        /// </summary>
        /// <returns>1 means okay, -1 means error</returns>
        public int AppendToCsv()
        {
            try
            {
                int fb = -1;

                string path = Properties.Settings.Default.PageLoadMetricsCsv;

                if (!File.Exists(path))
                {
                    fb = SaveToCsv();
                    return fb;
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(this.TimeStamp + "," + this.Url + "," + this.PageLoadTime);
                    fb = 1;
                }

                return fb;
            }
            catch (Exception ex)
            {
                Core.Logging.Logger.GetLogger(this.GetType()).Error(ex, "Something went wrong, pls check the log file");
                return -1;
            }
        }
    }
}
