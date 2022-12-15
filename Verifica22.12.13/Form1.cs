namespace Verifica22._12._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila Riviste = new Pila();
        Pila Libro = new Pila();
        private void btAggiungi_Click(object sender, EventArgs e)
        {
            if(comboBox.SelectedItem.ToString()== "Riviste")
            {
                
                bool ret= Riviste.Push(txtTitolo.Text, "Riviste");
                if (ret)
                {
                    MessageBox.Show("Inserimento riuscito");
                }
                else
                {
                    MessageBox.Show("Errore");
                }
            }
            if(comboBox.SelectedItem.ToString()== "Libri")
            {
                
                bool ret= Libro.Push(txtTitolo.Text, "Libri"); //ritorna ret = true
                if (ret)
                {
                    MessageBox.Show("Inserimento riuscito");
                }
                else
                {
                    MessageBox.Show("Errore");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Libri");
            comboBox.Items.Add("Riviste");
        }

        private void btRimuovi_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Riviste")
            {
                Lettura g = Riviste.Pop();
                MessageBox.Show("titolo: " + g.getTitolo() + " tipo:" + g.getTipo());
            }
            if (comboBox.SelectedItem.ToString() == "Libri")
            {
                Lettura g = Libro.Pop();
                MessageBox.Show("titolo: " + g.getTitolo() + " tipo:" + g.getTipo());
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedItem.ToString() == "Riviste")
            {
                lbStampa.Text = "";
                if (Riviste != null)
                lbStampa.Text = Riviste.ToString();
            }

            if (comboBox.SelectedItem.ToString() == "Libri")
            {
                lbStampa.Text = "";
                if(Libro!=null)
                lbStampa.Text = Libro.ToString();
            }
        }
    }
}