namespace SistemaGestion
{
    partial class ProductoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Id = new Label();
            label_precio_venta = new Label();
            label_costo = new Label();
            label_stock = new Label();
            label_descripcion = new Label();
            label_IdUsuario = new Label();
            txtId = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtIdUsuario = new TextBox();
            boton_volver = new Button();
            boton_guardar = new Button();
            boton_eliminar = new Button();
            SuspendLayout();
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_Id.Location = new Point(16, 24);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(32, 30);
            label_Id.TabIndex = 0;
            label_Id.Text = "Id";
            // 
            // label_precio_venta
            // 
            label_precio_venta.AutoSize = true;
            label_precio_venta.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_precio_venta.Location = new Point(16, 145);
            label_precio_venta.Name = "label_precio_venta";
            label_precio_venta.Size = new Size(138, 30);
            label_precio_venta.TabIndex = 1;
            label_precio_venta.Text = "Precio Venta";
            // 
            // label_costo
            // 
            label_costo.AutoSize = true;
            label_costo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_costo.Location = new Point(16, 110);
            label_costo.Name = "label_costo";
            label_costo.Size = new Size(70, 30);
            label_costo.TabIndex = 2;
            label_costo.Text = "Costo";
            // 
            // label_stock
            // 
            label_stock.AutoSize = true;
            label_stock.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_stock.Location = new Point(16, 184);
            label_stock.Name = "label_stock";
            label_stock.Size = new Size(67, 30);
            label_stock.TabIndex = 3;
            label_stock.Text = "Stock";
            // 
            // label_descripcion
            // 
            label_descripcion.AutoSize = true;
            label_descripcion.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_descripcion.Location = new Point(16, 71);
            label_descripcion.Name = "label_descripcion";
            label_descripcion.Size = new Size(129, 30);
            label_descripcion.TabIndex = 4;
            label_descripcion.Text = "Descripción";
            // 
            // label_IdUsuario
            // 
            label_IdUsuario.AutoSize = true;
            label_IdUsuario.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_IdUsuario.Location = new Point(16, 224);
            label_IdUsuario.Name = "label_IdUsuario";
            label_IdUsuario.Size = new Size(113, 30);
            label_IdUsuario.TabIndex = 5;
            label_IdUsuario.Text = "Id Usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(169, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 6;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(169, 152);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(120, 23);
            txtPrecioVenta.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(169, 191);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(120, 23);
            txtStock.TabIndex = 8;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(169, 117);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(120, 23);
            txtCosto.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(169, 78);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(120, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(169, 231);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(120, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // boton_volver
            // 
            boton_volver.Location = new Point(16, 286);
            boton_volver.Name = "boton_volver";
            boton_volver.Size = new Size(75, 29);
            boton_volver.TabIndex = 12;
            boton_volver.Text = "Volver";
            boton_volver.UseVisualStyleBackColor = true;
            boton_volver.Click += boton_volver_Click;
            // 
            // boton_guardar
            // 
            boton_guardar.Location = new Point(214, 286);
            boton_guardar.Name = "boton_guardar";
            boton_guardar.Size = new Size(75, 29);
            boton_guardar.TabIndex = 13;
            boton_guardar.Text = "Guardar";
            boton_guardar.UseVisualStyleBackColor = true;
            boton_guardar.Click += boton_guardar_Click;
            // 
            // boton_eliminar
            // 
            boton_eliminar.Location = new Point(116, 286);
            boton_eliminar.Name = "boton_eliminar";
            boton_eliminar.Size = new Size(75, 29);
            boton_eliminar.TabIndex = 14;
            boton_eliminar.Text = "Eliminar";
            boton_eliminar.UseVisualStyleBackColor = true;
            boton_eliminar.Click += boton_eliminar_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 351);
            Controls.Add(boton_eliminar);
            Controls.Add(boton_guardar);
            Controls.Add(boton_volver);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCosto);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtId);
            Controls.Add(label_IdUsuario);
            Controls.Add(label_descripcion);
            Controls.Add(label_stock);
            Controls.Add(label_costo);
            Controls.Add(label_precio_venta);
            Controls.Add(label_Id);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Id;
        private Label label_precio_venta;
        private Label label_costo;
        private Label label_stock;
        private Label label_descripcion;
        private Label label_IdUsuario;
        private TextBox txtId;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private TextBox txtIdUsuario;
        private Button boton_volver;
        private Button boton_guardar;
        private Button boton_eliminar;
    }
}