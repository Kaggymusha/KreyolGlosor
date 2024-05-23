using IniParser.Model;
using IniParser;
using KreyolGlosor.GUI;
using System.Diagnostics.Tracing;

namespace KreyolGlosor
{
    public partial class Main : Form
    {
        public List<Glossary> words = new List<Glossary>();
        public int wordIndex = 0;
        public int wordsSuccess = 0;
        public Main()
        {
            InitializeComponent();
            foreach (string line in File.ReadLines("glosor.txt"))
            {
                string[] word = line.Split(',');
                Glossary glossary = new()
                {
                    Kreyol = word[0].Trim(),
                    Swedish = word[1].Trim(),
                };
                words.Add(glossary);
            }
            words = words.OrderBy(x => Random.Shared.Next()).ToList();
            completedLabel.Text = $"{wordIndex}/200";
            UpdateWordLabel();
        }
        private void statBtn_Click(object sender, EventArgs e)
        {
            StatsWindow statsWindow = new StatsWindow();
            statsWindow.Show();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool success = InputCorrect(inputBox.Text, words[wordIndex]);
                inputBox.Clear();
                if (success)
                {
                    wordsSuccess++;
                    MessageBox.Show("Korrekt!", "Resultat", MessageBoxButtons.OK);
                    wordIndex++;
                    completedLabel.Text = $"{wordIndex}/200";
                    if (wordIndex == words.Count)
                    {
                        MessageBox.Show("Alla glosor genomförda! Ta en titt på statistiken.", "Information", MessageBoxButtons.OK);
                        restartBtn.Enabled = true;
                        UpdateStats();
                        inputBox.Enabled = false;
                        return;
                    }
                    UpdateWordLabel();
                    return;
                }
                MessageBox.Show($"Det var tyvärr fel. Rätt: {words[wordIndex].Swedish}", "Resultat", MessageBoxButtons.OK);
                wordIndex++;
                completedLabel.Text = $"{wordIndex}/200";
                if (wordIndex == words.Count)
                {
                    MessageBox.Show("Alla glosor genomförda! Ta en titt på statistiken.", "Information", MessageBoxButtons.OK);
                    restartBtn.Enabled = true;
                    UpdateStats();
                    inputBox.Enabled = false;
                    return;
                }
                UpdateWordLabel();
            }
        }
        private bool InputCorrect(string input, Glossary glossary)
        {
            if (input.ToLower() == glossary.Swedish!.ToLower())
            {
                return true;
            }
            return false;
        }
        private void UpdateWordLabel()
        {
            wordLabel.Text = words[wordIndex].Kreyol;
        }
        private void UpdateStats()
        {
            double successRate = (double)wordsSuccess / words.Count * 100;
            string successRate_ = successRate != 0 ? String.Format("{0:.##}", successRate) : "0";
            var ini = new FileIniDataParser();
            IniData data = ini.ReadFile("config.ini");

            var hej = data["SummaryStats"]["TimesPlayed"];
            data["SummaryStats"]["TimesPlayed"] = (int.Parse(data["SummaryStats"]["TimesPlayed"]) + 1).ToString();

            data["CurrentResult"]["WordsCorrect"] = wordsSuccess.ToString();
            data["CurrentResult"]["SuccessRate"] = successRate_ + "%";

            if (data["History"]["SuccessRate"] == "")
            {
                data["History"]["SuccessRate"] = data["History"]["SuccessRate"] + $"{successRate_}";
            }
            else if (data["History"]["SuccessRate"] != "")
            {
                data["History"]["SuccessRate"] = data["History"]["SuccessRate"] + $",{successRate_}";
            }

            List<double> successRateTrend = data["History"]["SuccessRate"].Split(",").Where(x => x != "").Select(x => double.Parse(x.Trim())).ToList();
            double averageSuccessRate = successRateTrend.Sum() / double.Parse(data["SummaryStats"]["TimesPlayed"]);
            string avgSuccessRate = String.Format("{0:.##}", averageSuccessRate);
            double bestResult = successRateTrend.Max();
            string bestResult_ = String.Format("{0:.##}", bestResult);

            data["SummaryStats"]["AverageSuccessRate"] = avgSuccessRate;
            data["SummaryStats"]["BestResult"] = bestResult_;
            ini.WriteFile("config.ini", data);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            words = words.OrderBy(x => Random.Shared.Next()).ToList();
            wordIndex = 0;
            wordsSuccess = 0;
            completedLabel.Text = $"{wordIndex}/200";
            inputBox.Enabled = true ;
            UpdateWordLabel();
            restartBtn.Enabled = false;
        }
    }
    public class Glossary
    {
        public string? Kreyol { get; set; }
        public string? Swedish { get; set; }
    }
}
