namespace Cola_Doble_Dinamica
{
    public partial class Form1 : Form
    {
        ColaDoble<int> cola;

        public Form1()
        {
            InitializeComponent();
            cola = new ColaDoble<int>();
        }



        public void MostrarColaEnListBox()
        {
            listBoxCola.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos elementos

            if (cola.EstaVacia())
            {
                MessageBox.Show("La cola est� vac�a.");
                return;
            }

            List<int> elementos = cola.ObtenerElementos(); // Obtener los elementos de la cola

            foreach (int elemento in elementos)
            {
                listBoxCola.Items.Add(elemento); // A�adir cada elemento al ListBox
            }
        }

        // Evento Click del bot�n Mostrar Cola


        private void btnInsertarFrente_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValor.Text, out valor))
            {
                cola.InsertarFrente(valor);
                MessageBox.Show($"Se ha insertado {valor} al frente.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un n�mero v�lido.");
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValor.Text, out valor))
            {
                cola.InsertarFinal(valor);
                MessageBox.Show($"Se ha insertado {valor} al final.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un n�mero v�lido.");
            }
        }

        private void btnEliminarFrente_Click(object sender, EventArgs e)
        {
            try
            {
                int valorEliminado = cola.EliminarFrente();
                MessageBox.Show($"Se ha eliminado {valorEliminado} del frente.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            try
            {
                int valorEliminado = cola.EliminarFinal();
                MessageBox.Show($"Se ha eliminado {valorEliminado} del final.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerFrente_Click(object sender, EventArgs e)
        {
            try
            {
                int valorFrente = cola.VerFrente();
                MessageBox.Show($"El valor en el frente es {valorFrente}.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerFinal_Click(object sender, EventArgs e)
        {
            try
            {
                int valorFinal = cola.VerFinal();
                MessageBox.Show($"El valor en el final es {valorFinal}.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarCola_Click(object sender, EventArgs e)
        {
            MostrarColaEnListBox();
        }
    }
}
