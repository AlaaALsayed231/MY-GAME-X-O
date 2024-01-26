using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;


namespace project_test
{
    public partial class Form2 : Form
    {
        private string player1Name;
        private string player2Name;
        private char player1Symbol;
        private char player2Symbol;
        private int player1Score = 0;
        private int player2Score = 0;
        private bool isPlayer1Turn = true;

        SqlConnection con;


        void Enable_false()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }

        void SwitchPlayerTurn()
        {
            isPlayer1Turn = !isPlayer1Turn;
        }

        void MakeMove(Button button)
        {
            if (button.Enabled)
            {
                button.Text = (isPlayer1Turn) ? player1Symbol.ToString() : player2Symbol.ToString();
                SwitchPlayerTurn();
                score();
                button.Enabled = false;
            }
        }

        void score()
        {
           
            if (btnTic1.Text == player1Symbol.ToString() && btnTic2.Text == player1Symbol.ToString() && btnTic3.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name}({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic2.Text == player2Symbol.ToString() && btnTic3.Text == player2Symbol.ToString())
            {
                // Player 2 wins
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
            }
            if (btnTic1.Text == player1Symbol.ToString() && btnTic4.Text == player1Symbol.ToString() && btnTic7.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
              
            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic4.Text == player2Symbol.ToString() && btnTic7.Text == player2Symbol.ToString())
            {
                // Player 2 wins
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
              
            }
            if (btnTic1.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {
                // Player 2 wins
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }

            if (btnTic3.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic7.Text == player1Symbol.ToString())
            {
              
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }
            else if (btnTic3.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic7.Text == player2Symbol.ToString())
            {
                
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
              
            }
            if (btnTic2.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic8.Text == player1Symbol.ToString())
            {
               
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }
            else if (btnTic2.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic8.Text == player2Symbol.ToString())
            {
                
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
              
            }
            if (btnTic3.Text == player1Symbol.ToString() && btnTic6.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {
               
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
                
            }
            else if (btnTic3.Text == player2Symbol.ToString() && btnTic6.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {
                
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
                
            }
            if (btnTic4.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic6.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }
            else if (btnTic4.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic6.Text == player2Symbol.ToString())
            {
                // Player 2 wins
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
             
            }
            if (btnTic7.Text == player1Symbol.ToString() && btnTic8.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
              
            }
            else if (btnTic7.Text == player2Symbol.ToString() && btnTic8.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {
               
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
               
            }
           

            
        }



        void UpdateScores()
        {
            libpl1.Text = player1Score.ToString();
            libpl2.Text = player2Score.ToString();
        }
        public Form2(string player1Name, string player2Name, char player1Symbol, char player2Symbol)
        {
            InitializeComponent();
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.player1Symbol = player1Symbol;
            this.player2Symbol = player2Symbol;
            label2.Text = $"{player1Name} ({player1Symbol})";
            label3.Text = $"{player2Name} ({player2Symbol})";
            con = new SqlConnection("Server=.;Database=game;Trusted_Connection=True;TrustServerCertificate=True");

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic1);

        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic2);

        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic3);

        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic4);

        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic5);

        }

        private void btnTic6_Click(object sender, EventArgs e)
        {

            MakeMove(btnTic6);

        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic7);

        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic8);

        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            MakeMove(btnTic9);

        }
        void ResetGame()
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";


            UpdateScores();



        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        void newGame()
        {

            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            player1Score = 0;
            player2Score = 0;
            libpl1.Text = "";
            libpl2.Text = "";



        }

        private void button12_Click(object sender, EventArgs e)
        {
            newGame();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into players([player1Name],[player2Name],[player1Score],[player2Score],[player1Symbol],[player2Symbol],[playDate]) values(@name1,@name2,@score1,@score2,@symbol1,@symbol2,@playtime)", con);
            cmd.Parameters.AddWithValue("name1", player1Name);
            cmd.Parameters.AddWithValue("name2", player2Name);
            cmd.Parameters.AddWithValue("score1", libpl1.Text);
            cmd.Parameters.AddWithValue("score2", libpl2.Text);
            cmd.Parameters.AddWithValue("symbol1", player1Symbol);
            cmd.Parameters.AddWithValue("symbol2", player2Symbol);
            cmd.Parameters.AddWithValue("playtime", DateTime.Now);

            int rowsEffected = 0;
            try
            {

                con.Open();

                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was insereted");
              
            }

            Form3 form3 = new Form3();
            this.Hide();

            form3.ShowDialog();
            this.Close();

        }
    }
}
