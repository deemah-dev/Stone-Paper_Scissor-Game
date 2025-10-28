using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StonePaperScissorGameWinForm
{
    public partial class Form1 : Form
    {
        private enum GameChoice
        {
            Stone = 1,
            Paper,
            Scissor,
            UNKNOWN
        }
        private enum Winner
        {
            Player = 1,
            Computer,
            Draw,
            UNKNOWN
        }
        private byte Rounds = 1;
        private byte CurrentRound = 1;
        private GameChoice PlayerChoice = new GameChoice();
        private GameChoice ComputerChoice = new GameChoice();
        private byte PlayerWon = 0;
        private byte ComputerWon = 0;
        private byte Draw = 0;
        private Winner FinalWinner = new Winner();
        public Form1()
        {
            InitializeComponent();
            hopeTabPage1.SelectedTab = tabPGame;
            tabPPlay.Enabled = false;
            tabPResult.Enabled = false;
            lblPlayerChoice.Visible = false;
            lblComputerChoice.Visible = false;
            WaitForComputerChoice.Visible = false;
        }

        private void numRounds_ValueChanged(object sender, EventArgs e)
        {
            Rounds = Convert.ToByte(numRounds.Value);
        }

        private void PrintOrRefreshRoundNumber()
        {
            lblRound.Text = CurrentRound.ToString();
            if (CurrentRound <= Rounds)
                CurrentRound++;
            if (CurrentRound > Rounds)
                btnNext.Text = "Get Result";
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            tabPPlay.Enabled = true;
            tabPGame.Enabled = false;
            hopeTabPage1.SelectedTab = tabPPlay;
            PrintOrRefreshRoundNumber();
            btnNext.Enabled = false;
        }

        private GameChoice PutPlayerChoice(string Choice)
        {
            switch (Choice)
            {
                case "Stone":
                    return GameChoice.Stone;
                case "Paper":
                    return GameChoice.Paper;
                case "Scissor":
                    return GameChoice.Scissor;
            }
            return GameChoice.UNKNOWN;
        }

        private GameChoice GetComputerChoice()
        {
            Random Random = new Random();
            return (GameChoice)Random.Next(1, 3);
        }

        private Winner GetRoundWinner()
        {
            if (PlayerChoice == ComputerChoice)
                return Winner.Draw;
            switch (PlayerChoice)
            {
                case GameChoice.Stone:
                    return (ComputerChoice == GameChoice.Paper ? Winner.Computer : Winner.Player);
                case GameChoice.Paper:
                    return (ComputerChoice == GameChoice.Scissor ? Winner.Computer : Winner.Player);
                case GameChoice.Scissor:
                    return (ComputerChoice == GameChoice.Stone ? Winner.Computer : Winner.Player);
            }
            return Winner.UNKNOWN;
        }

        private void RefreshFinalWinner()
        {
            if (Draw > PlayerWon || Draw > ComputerWon)
                FinalWinner = Winner.Draw;

            if (PlayerWon > ComputerWon)
                FinalWinner = Winner.Player;

            else if (ComputerWon > PlayerWon)
                FinalWinner = Winner.Computer;
        }

        private void RefreshWonTimes(Winner winner)
        {
            switch (winner)
            {
                case Winner.Player:
                    PlayerWon++;
                    break;
                case Winner.Computer:
                    ComputerWon++;
                    break;
                case Winner.Draw:
                    Draw++;
                    break;
            }
            RefreshFinalWinner();
        }

        private async Task WaitForComputer()
        {
            await Task.Delay(200);
            WaitForComputerChoice.Visible = true;
            WaitForComputerChoice.Start();
            await Task.Delay(1000);
            WaitForComputerChoice.Stop();
            WaitForComputerChoice.Visible = false;
        }

        private void PrintPlayerChoice()
        {
            lblComputerChoice.Visible = false;
            lblPlayerChoice.Visible = true;
            lblPlayerChoice.Text = PlayerChoice.ToString();
        }

        private void PrintComputerChoice()
        {
            lblComputerChoice.Visible = true;
            lblComputerChoice.Text = ComputerChoice.ToString();
        }

        private void TurnOnChoicesButton()
        {
            btnStone.Enabled = true;
            btnPaper.Enabled = true;
            btnScissor.Enabled = true;
        }

        private void TurnOffChoicesButton()
        {
            btnStone.Enabled = false;
            btnPaper.Enabled = false;
            btnScissor.Enabled = false;
        }

        private async void PlayerChoice_Click(object sender, EventArgs e)
        {
            PlayerChoice = PutPlayerChoice(((ReaLTaiizor.Controls.Button)sender).Text);
            PrintPlayerChoice();

            await WaitForComputer();

            ComputerChoice = GetComputerChoice();
            PrintComputerChoice();

            Winner RoundWinner = GetRoundWinner();
            RefreshWonTimes(RoundWinner);
            btnNext.Enabled = true;
            TurnOffChoicesButton();
        }

        private void PrintResults()
        {
            lblRoundsNumber.Text = Rounds.ToString();
            lblPlayerWonTimes.Text = PlayerWon.ToString();
            lblComputerWonTimes.Text = ComputerWon.ToString();
            lblDrawTimes.Text = Draw.ToString();
            lblFinalWinner.Text = FinalWinner.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Get Result")
            {
                PrintResults();
                tabPPlay.Enabled = false;
                hopeTabPage1.SelectedTab = tabPResult;
            }
            else
            {
                PrintOrRefreshRoundNumber();
                TurnOnChoicesButton();
                btnNext.Enabled = false;
            }
        }
    }
}