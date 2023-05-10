namespace aprovado_reprovado
{
    public partial class media : Form
    {
        public media()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void calc()
        {

            n1 = Convert.ToDecimal(txtn1.Text);
            n2 = Convert.ToDecimal(txtn2.Text);
            n3 = Convert.ToDecimal(txtn3.Text);
            n4 = Convert.ToDecimal(txtn4.Text);




        }

	{

	}





        private void media_Load(object sender, EventArgs e)
        {
         
            


        }
        float n1, n2, n3, n4, mmaior, mmenor, mexame; //mmaior = media maior(igual ou maior que 7), mmenor = media menor(menor que 5), mexame = media exame(entre 7 e 5)

        private void bto_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}