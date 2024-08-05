using filmesApp2B.Models;

namespace filmesApp2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contexto db;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();

            /* Ator johnny = new Ator();
             johnny.Nome = "Johnny Depp";

             this.db.Ator.Add(johnny);
             this.db.SaveChanges();*/

            List<Ator> a = this.db.Ator.ToList();
            dgvAtores.DataSource = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
