using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace KreyolGlosor.GUI
{
    public partial class StatsWindow : Form
    {
        public StatsWindow()
        {
            InitializeComponent();
            var ini = new FileIniDataParser();
            IniData data = ini.ReadFile("config.ini");
            correctWordsLabel.Text = $"Korrekta ord: {data["CurrentResult"]["WordsCorrect"]}";
            successRateLabel.Text = $"Kvot: {data["CurrentResult"]["SuccessRate"]}";
            timesPlayedLabel.Text = $"Spelade omgångar: {data["SummaryStats"]["TimesPlayed"]}";
            bestResult.Text = $"Bästa kvot: {data["SummaryStats"]["BestResult"]}%";
            averageSuccess.Text = $"Genomsnitt: {data["SummaryStats"]["AverageSuccessRate"]}%";

            historyPlot.Plot.YLabel("Resultat [%]");
            historyPlot.Plot.XLabel("Omgång #");
            historyPlot.Plot.Title("Statistik");

            if (data["History"]["SuccessRate"] == "")
            {
                return;
            }
            double[] y = data["History"]["SuccessRate"].Split(',').Select(x => double.Parse(x.Trim())).ToArray();
            double[] x = new double[y.Length];
            for (int i = 0; i < y.Length; i++)
            {
                x[i] = i;
            }
            
            historyPlot.Plot.Add.Scatter(x, y);
        }
    }
}
