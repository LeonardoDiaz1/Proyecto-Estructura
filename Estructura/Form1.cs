namespace Estructura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Equals("TEC") && textPassword.Text.Equals("1234"))
            {
                Estructura sic = new Estructura();
                sic.Show();
            }
            else
            {
                MessageBox.Show("USUARIO Y CONTRASEÑA ERRONES");
            }
        }
    }
}