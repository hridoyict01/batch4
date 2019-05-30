using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExam
{
    public partial class HomeForm : Form
    {
        string message;
        List<string> soldierNos = new List<string>();
        List<string> soldierNames = new List<string>();
        List<double> totalScores= new List<double>();
        List<double> averageScore= new List<double>();


        public HomeForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //number validation check
            string soldierNumber = soldierNoTextBox.Text;
            foreach (string soldierNo in soldierNos)
            {
                if (soldierNo == soldierNumber)
                {
                    MessageBox.Show("Soldier Already exists");
                    soldierNoTextBox.Clear();
                    return;
                }
            }


            soldierNos.Add(soldierNumber); 
            soldierNames.Add(soldierNameTextBox.Text);
            double score;
            try
            {
                 score = Convert.ToDouble(score1TextBox.Text);
                score += Convert.ToDouble(score2TextBox.Text);
                score += Convert.ToDouble(score3TextBox.Text);
                score += Convert.ToDouble(score4TextBox.Text);
                totalScores.Add(score);
                double avg = score / 4;
                averageScore.Add(avg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Score should be a number, please correct it ,\nException Details: "+ex.Message);
            }

            soldierNoTextBox.Clear();
            soldierNameTextBox.Clear();
            score1TextBox.Clear();
            score2TextBox.Clear();
            score3TextBox.Clear();
            score4TextBox.Clear();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            message = "";
            message = "Soldier no. \t Soldier Name\t Average Score \t Total Score\n";
            int index = 0;
            foreach (string soldierNo in soldierNos)
            {
                
                message += soldierNo + "    \t\t" + soldierNames[index] + " \t\t\t" + averageScore[index] + " \t\t" +
                          totalScores[index] + "\n";
                index++;
            }
            double topTotal = totalScores.Max();
            int i = 0;
            foreach (double totalScore in totalScores)
            {
                if (totalScore == topTotal)
                {
                    topTotalScoreTextBox.Text = soldierNames[i];
                }

                i++;
            }
            double topAverage = averageScore.Max();
            int j = 0;
            foreach (double avg in averageScore)
            {
                if (avg == topAverage)
                {
                    topAverageScoreTextBox.Text = soldierNames[j];
                }

                j++;
            }


            showRichTextBox.Text = message;
            


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            topAverageScoreTextBox.Clear();
            topTotalScoreTextBox.Clear();
            message = "";
            string choice = crteriaComboBox.Text;
            if (choice == "Soldier No")
            {
                message = "Soldier no. \t Soldier Name\t Average Score \t Total Score\n";
                int index = 0;
                foreach (string soldierNo in soldierNos)
                {
                    if (soldierNo == choiceTextBox.Text)
                    {
                        message += soldierNo + "    \t\t" + soldierNames[index] + " \t\t\t" + averageScore[index] +
                                   " \t\t" +
                                   totalScores[index] + "\n";
                    }
                   

                    index++;
                }
                showRichTextBox.Text = message;
            }
            else if (choice == "Soldier Name")
            {
                message = "Soldier no. \t Soldier Name\t Average Score \t Total Score\n";
                int index = 0;
                foreach (string soldierName in soldierNames)
                {
                    if (soldierName == choiceTextBox.Text)
                    {
                        message += soldierNos[index] + "    \t\t" + soldierNames[index] + " \t\t\t" + averageScore[index] +
                                   " \t\t" +
                                   totalScores[index] + "\n";
                    }

                    index++;
                }
                showRichTextBox.Text = message;
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
