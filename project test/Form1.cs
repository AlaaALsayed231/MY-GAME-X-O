namespace project_test
{
    public partial class Form1 : Form
    {

        private string player1Name;
        private string player2Name;
        private char player1Symbol;
        private char player2Symbol;
        string userx = "";
        string userO = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            player1Name = txtuser1.Text;
            player2Name = txtuser2.Text;
            player1Symbol = rduserAX.Checked ? 'X' : 'O';
            player2Symbol = player1Symbol == 'X' ? 'O' : 'X';


            ingresar();



        }

        private void ingresar()
        {
            if (txtuser1.Text == "" && txtuser2.Text == "")
            {
                MessageBox.Show("You must enter the name of players");
            }
            else
            {
                if (txtuser1.Text == "")
                {
                    MessageBox.Show("You must enter the name of player1");
                }
                if (txtuser2.Text == "")
                {
                    MessageBox.Show("You must enter the name of player2");
                }


            }

            if (txtuser1.Text != "" && txtuser2.Text != "")
            {
                if (rduserAX.Checked && rdubO.Checked)
                {
                    userx = txtuser1.Text;
                    userO = txtuser2.Text;
                    rduAo.Enabled = false;
                    rdubx.Enabled = false;
                    playGame();

                }
                if (rduAo.Checked && rdubx.Checked)
                {
                    userx = txtuser2.Text;
                    userO = txtuser1.Text;
                    rduserAX.Enabled = false;
                    rdubO.Enabled = false;
                    playGame();
                }
                if (rduserAX.Checked && rdubx.Checked)
                {
                    MessageBox.Show("sorry but it is not allow to choose the same symbol for two players ");
                }
                if (rduAo.Checked && rdubO.Checked)
                {
                    MessageBox.Show("sorry but it is not allow to choose the same symbol for two players ");
                }
                if (rduserAX.Checked == false && rduAo.Checked == false || rdubx.Checked == false && rdubO.Checked == false)
                {
                    MessageBox.Show("you must select x or o for each player  ");
                }


            }


        }
        private void playGame()
        {
            Form2 form2 = new Form2(player1Name, player2Name, player1Symbol, player2Symbol);
            this.Hide();

            form2.ShowDialog();
            this.Close();

        }
    }
}
