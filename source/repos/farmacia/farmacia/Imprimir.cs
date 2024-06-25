using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace farmacia
{
    public partial class Imprimir : Form
    {
        public Imprimir()
        {
            InitializeComponent();
        }
        private void Imprimir_Load(object sender, EventArgs e)
        {
            this.Text = "Pedido al distribuidor ";
            if (farmaciaForm.instance.radioButton1.Checked)
            {
                this.Text += "Cofarma";
            }
            else if (farmaciaForm.instance.radioButton2.Checked)
            {
                this.Text += "Empsephar";
            }
            else
            {
                this.Text += "Cemefar";
            }

            label1.Text = farmaciaForm.instance.quantity.Text
                + " unidades de "
                + farmaciaForm.instance.typeField.Text
                + " "
                + farmaciaForm.instance.nameField.Text;

            String direction1 = "Calle de la Rosa n.28";
            String direction2 = "Calle Alcazabilla n. 3";
            String direction = "";

            if (farmaciaForm.instance.checkBox1.Checked && farmaciaForm.instance.checkBox2.Checked)
            {
                direction = direction1 + " y " + direction2;
            }
            else
            {
                if (farmaciaForm.instance.checkBox1.Checked)
                {
                    direction = direction1;
                }
                else
                {
                    direction = direction2;
                }
            }
            label2.Text = "Para la farmacia situada en " + direction;
        }

        private void Imprimir_FormClosed(object sender, FormClosedEventArgs e)
        {
            farmaciaForm.instance.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            farmaciaForm.instance.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Pedido enviado");
            farmaciaForm.instance.Close();
        }
    }
}
