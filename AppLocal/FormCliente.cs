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
    private bool editMode;
    private Cliente clienteSeleccionado;


    public FormCliente() {
      InitializeComponent();
      Cc = new ControladorCliente();
      editMode = false;
    }
    private void button1_Click(object sender, EventArgs e) {
      Cliente c = new Cliente();
      c.Nombre = txbName.Text;
      c.Cedula = txbCedula.Text;
      c.Estado = chbEstado.Checked;
      try {
        if(!editMode) {
          Cc.crearCliente(c);
          MessageBox.Show("Registrado");
        } else {
          c.Id = clienteSeleccionado.Id;
          Cc.actualizarCliente(c);
          editMode = false;
          btnSave.Text = "Guardar";
          MessageBox.Show("Actualizado");
        }
        limpiarForm();
        refrescarTabla();
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

    private void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e) {
      Cliente c = new Cliente();
      c.Id = (int)tblClientes.SelectedCells [0].Value;
      c = Cc.TraerClientePorId(c);
      clienteSeleccionado = c;
      txbName.Text = c.Nombre;
      txbCedula.Text = c.Cedula;
      chbEstado.Checked = c.Estado;

      editMode = true;
      btnSave.Text = "Guardar";
    }

    private void limpiarForm() {
      foreach(Control c in gbxCliente.Controls) {
        if(c.GetType() == txbName.GetType() || c.GetType() == txbCedula.GetType()) {
          c.Text = "";
        }
        chbEstado.Checked = false;
      }
    }
  }
}
