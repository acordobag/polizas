using AccesoDatos;
using AppLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLocal {
  public partial class FormCliente : Form {

    private ControladorCliente Cc;

    public FormCliente() {
      InitializeComponent();
      Cc = new ControladorCliente();
    }
    private void button1_Click(object sender, EventArgs e) {
      Cliente c = new Cliente();
      c.Nombre = txbName.Text;
      c.Cedula = txbCedula.Text;
      c.Estado = chbEstado.Checked;
      try {
        Cc.crearCliente(c);
        refrescarTabla();
        MessageBox.Show("Registrado");
      } catch(Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }

    private void FormCliente_Load(object sender, EventArgs e) {
      refrescarTabla();
    }

    private void refrescarTabla() {
      var list = Cc.listarClientes();
      tblClientes.DataSource = list;
    }
  }
}
