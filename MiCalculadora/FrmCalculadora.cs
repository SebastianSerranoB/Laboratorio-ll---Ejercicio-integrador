using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Esistema sistema;
        private Numeracion? primerOperando;
        private Numeracion? segundoOperando;
        private Numeracion? resultado;
        private Operacion? calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultado.Text = "Resultado:";
            this.resultado = null;
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.rdbDecimal.Checked = true;
            this.cmbOperacion.SelectedItem = "";
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbDecimal.Checked == true)
            {
                this.sistema = Esistema.Decimal;
                this.SetResultado();
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbBinario.Checked == true)
            {
                this.sistema = Esistema.Binario;
                this.SetResultado();
            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(this.txtPrimerOperador.Text, Esistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text, Esistema.Decimal);
        }

        private void SetResultado()
        {
            if (this.resultado is not null)
            {
                this.lblResultado.Text = "Resultado: " + this.resultado.ConvertirA(this.sistema);
            }
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if ( double.TryParse(this.txtPrimerOperador.Text, out double primerOperadorIngresado) && double.TryParse(this.txtSegundoOperador.Text, out double segundoOperadorIngresado) )
            {
                this.primerOperando = new Numeracion(primerOperadorIngresado, Esistema.Decimal);
                this.segundoOperando = new Numeracion(segundoOperadorIngresado, Esistema.Decimal);

                calculadora = new Operacion(primerOperando, segundoOperando);

                char.TryParse(this.cmbOperacion.SelectedItem.ToString(), out char operador);  //error , null
                this.resultado = this.calculadora.Operar(operador);

                this.SetResultado();
            }
            else
            { 
                MessageBox.Show("Debe ingresar numeros decimales.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

      

    }
}