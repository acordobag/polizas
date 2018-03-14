using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic {
  public class ControladorCliente {
    private PolizasModelContainer db;

    public ControladorCliente() {
      db = new PolizasModelContainer();
    }

    public void crearCliente(Cliente c) {
      db.ClienteSet.Add(c);
      db.SaveChanges();
    }

    public List<Cliente> listarClientes() {
      return db.ClienteSet.ToList();
    }

    public Cliente TraerClientePorId(Cliente c) {
      var res = db.ClienteSet.Find(c.Id);
      return res;
    }
    public void actualizarCliente(Cliente c) {
      Cliente oldC = db.ClienteSet.Find(c.Id);
      oldC.Cedula = c.Cedula;
      oldC.Nombre = c.Nombre;
      oldC.Estado = c.Estado;
      db.SaveChanges();
    }

  }
}
