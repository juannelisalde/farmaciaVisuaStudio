using System.Reflection.Emit;
using System.Windows.Forms;

namespace farmacia
{
    public partial class farmaciaForm : Form
    {
        public static farmaciaForm instance;
        public farmaciaForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validatefields())
            {
                this.Hide();
                Imprimir imprimir = new Imprimir();
                imprimir.Show();
            }
        }

        private bool validatefields()
        {
            bool valid = true;
            if (nameField.Text.Trim().Length == 0)
            {
                valid = false;
                errorProvider.SetError(nameField, "Digite el nombre");
            }
            else
            {
                errorProvider.SetError(nameField, null);
            }

            if (typeField.SelectedIndex == -1)
            {
                valid = false;
                errorProvider.SetError(typeField, "Seleccione tipo");
            }
            else
            {
                errorProvider.SetError(typeField, null);
            }

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                valid = false;
                errorProvider.SetError(groupBox1, "Seleccione distribuidor");
            }
            else
            {
                errorProvider.SetError(groupBox1, null);
            }

            if (quantity.Text.Length == 0 || Convert.ToInt64(quantity.Text) == 0)
            {
                valid = false;
                errorProvider.SetError(quantity, "Digite un valor mayor a cero (0)");
            }
            else
            {
                errorProvider.SetError(quantity, null);
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                valid = false;
                errorProvider.SetError(checkBox2, "Selecciones distribuidor");
            }
            else
            {
                errorProvider.SetError(checkBox2, null);
            }

            return valid;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nameField.Text = null;
            typeField.Text = null;
            quantity.Text = null;
            typeField.TabIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}