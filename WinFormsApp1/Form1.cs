namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public class Arma
        {
            public string Nome { get; set; } = "";
            public int Dano { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        public class Alvo
        {
            public string Nome { get; set; } = "";
            public int Vida { get; set; }

            public override string ToString()
            {
                return Nome;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Armas
            comboBox1.Items.Add(new Arma { Nome = "Eoka Pistol", Dano = 180 });
            comboBox1.Items.Add(new Arma { Nome = "Pedra", Dano = 12 });
            comboBox1.Items.Add(new Arma { Nome = "Arco", Dano = 50 });
            comboBox1.Items.Add(new Arma { Nome = "Arco Composto", Dano = 70 });
            comboBox1.Items.Add(new Arma { Nome = "Pistola", Dano = 35 });
            comboBox1.Items.Add(new Arma { Nome = "Waterpipe Shotgun", Dano = 180 });
            comboBox1.Items.Add(new Arma { Nome = "Combat Knife", Dano = 35 });
            comboBox1.Items.Add(new Arma { Nome = "M92 Pistol", Dano = 45 });
            // Segunda arma 
            comboBox2.Items.Add(new Arma { Nome = "Pedra", Dano = 12 });
            comboBox2.Items.Add(new Arma { Nome = "Flecha de Pedra", Dano = 50 });
            comboBox2.Items.Add(new Arma { Nome = "Flecha de Fogo", Dano = 60 });
            comboBox2.Items.Add(new Arma { Nome = "9mm", Dano = 20 });

            // Alvos
            comboBox3.Items.Add(new Alvo { Nome = "Porta de Metal", Vida = 2000 });
            comboBox3.Items.Add(new Alvo { Nome = "Porta de Madeira", Vida = 200 });
            comboBox3.Items.Add(new Alvo { Nome = "Parede de Pedra", Vida = 500 });


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            var arma1 = comboBox1.SelectedItem as Arma;
            var arma2 = comboBox2.SelectedItem as Arma;
            var alvo = comboBox3.SelectedItem as Alvo;


            // Soma do dano das duas armas
            int danoTotal = arma1.Dano + arma2.Dano;

            if (danoTotal <= 0)
            {
                MessageBox.Show("O dano deve ser maior que zero.");
                return;
            }

            // Calcula a quantidade de golpes
            double golpes = (double)alvo.Vida / danoTotal;

            textBox1.Text = Math.Ceiling(golpes).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
