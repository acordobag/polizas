namespace AppLocal {
  partial class FormCliente {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.gbxCliente = new System.Windows.Forms.GroupBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.chbEstado = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txbCedula = new System.Windows.Forms.MaskedTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txbName = new System.Windows.Forms.TextBox();
      this.tblClientes = new System.Windows.Forms.DataGridView();
      this.gbxCliente.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
      this.SuspendLayout();
      // 
      // gbxCliente
      // 
      this.gbxCliente.Controls.Add(this.btnSave);
      this.gbxCliente.Controls.Add(this.chbEstado);
      this.gbxCliente.Controls.Add(this.label3);
      this.gbxCliente.Controls.Add(this.txbCedula);
      this.gbxCliente.Controls.Add(this.label2);
      this.gbxCliente.Controls.Add(this.label1);
      this.gbxCliente.Controls.Add(this.txbName);
      this.gbxCliente.Location = new System.Drawing.Point(12, 12);
      this.gbxCliente.Name = "gbxCliente";
      this.gbxCliente.Size = new System.Drawing.Size(730, 138);
      this.gbxCliente.TabIndex = 0;
      this.gbxCliente.TabStop = false;
      this.gbxCliente.Text = "Datos cliente";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(649, 109);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Crear";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.button1_Click);
      // 
      // chbEstado
      // 
      this.chbEstado.AutoSize = true;
      this.chbEstado.Location = new System.Drawing.Point(77, 99);
      this.chbEstado.Name = "chbEstado";
      this.chbEstado.Size = new System.Drawing.Size(15, 14);
      this.chbEstado.TabIndex = 5;
      this.chbEstado.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 100);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Estado";
      // 
      // txbCedula
      // 
      this.txbCedula.Location = new System.Drawing.Point(77, 57);
      this.txbCedula.Mask = "0-0000-0000";
      this.txbCedula.Name = "txbCedula";
      this.txbCedula.Size = new System.Drawing.Size(169, 20);
      this.txbCedula.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Cédula";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nombre";
      // 
      // txbName
      // 
      this.txbName.Location = new System.Drawing.Point(77, 22);
      this.txbName.Name = "txbName";
      this.txbName.Size = new System.Drawing.Size(169, 20);
      this.txbName.TabIndex = 0;
      // 
      // tblClientes
      // 
      this.tblClientes.AllowUserToAddRows = false;
      this.tblClientes.AllowUserToDeleteRows = false;
      this.tblClientes.AllowUserToResizeColumns = false;
      this.tblClientes.AllowUserToResizeRows = false;
      this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblClientes.Location = new System.Drawing.Point(13, 157);
      this.tblClientes.Name = "tblClientes";
      this.tblClientes.ReadOnly = true;
      this.tblClientes.Size = new System.Drawing.Size(729, 150);
      this.tblClientes.TabIndex = 1;
      this.tblClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblClientes_CellClick);
      // 
      // FormCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(754, 332);
      this.Controls.Add(this.tblClientes);
      this.Controls.Add(this.gbxCliente);
      this.Name = "FormCliente";
      this.Text = "FormCliente";
      this.Load += new System.EventHandler(this.FormCliente_Load);
      this.gbxCliente.ResumeLayout(false);
      this.gbxCliente.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbxCliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txbName;
    private System.Windows.Forms.MaskedTextBox txbCedula;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.CheckBox chbEstado;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView tblClientes;
  }
}