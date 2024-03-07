namespace Notas_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            int n1 = int.Parse(txt_nota1.Text);
            int n2 = int.Parse(txt_nota2.Text);
            int n3 = int.Parse(txt_nota3.Text);
            int n4 = int.Parse(txt_nota4.Text);
            double promedio = (n1 + n2 + n3 + n4) / 4;
            string resultado = "El estiduante aprobo";
            string resultado2 = "El estudiante reprobó";
            if (promedio >= 70)
            {
                txt_promedio.Text = promedio.ToString();
                txt_promedio.BackColor = Color.Green;
                txt_promedio.ForeColor = Color.White;
                txt_situacion.Text = resultado;
                txt_situacion.BackColor = Color.Green;
                txt_situacion.ForeColor = Color.White;
                txt_prueba.Enabled = false;
                txt_total.Enabled = false;
                txt_completivo.Enabled = false;
                txt_ReP.Enabled = false;
                txt_situacion2.Enabled = false;

            }
            else
            {

                txt_promedio.Text = promedio.ToString();
                txt_promedio.BackColor = Color.Red;
                txt_promedio.ForeColor = Color.White;
                txt_situacion.Text = resultado2;
                txt_situacion.BackColor = Color.Red;
                txt_situacion.ForeColor = Color.White;
                txt_prueba.Enabled = true;

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Clear();
            txt_promedio.Clear();
            txt_situacion.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_completivo_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt_nota1.Text);
            int n2 = int.Parse(txt_nota2.Text);
            int n3 = int.Parse(txt_nota3.Text);
            int n4 = int.Parse(txt_nota4.Text);
            double promedio = (n1 + n2 + n3 + n4) / 4;
            double completivo = promedio / 2;
            int completivo1 = int.Parse(txt_prueba.Text);
            double completivo2 = completivo1 / 2;
            double total = completivo + completivo2;
            string resultado = "El estudiante paso el completivo";
            string resultado2 = "El estudiante reprobó el completivo";
            if (total >= 70)
            {
                txt_completivo.Text = completivo.ToString();
                txt_ReP.Text = completivo2.ToString();
                txt_total.Text = total.ToString();
                txt_situacion2.Text = resultado;
                txt_prueba.Enabled = false;
            }
            else
            {
                txt_completivo.Text = completivo.ToString();
                txt_ReP.Text = completivo2.ToString();
                txt_total.Text = total.ToString();
                txt_situacion2.Text = resultado2;
                txt_prueba.Enabled = true;
            }
        }
    }
}