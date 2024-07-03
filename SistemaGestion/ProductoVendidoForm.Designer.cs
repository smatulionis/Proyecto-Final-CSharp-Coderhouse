using System.Windows.Forms;

namespace SistemaGestion
{
    partial class ProductoVendidoForm
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
            label_stock = new Label();
            label_idProducto = new Label();
            label_idVenta = new Label();
            txtId = new TextBox();
            txtStock = new TextBox();
            txtIdVenta = new TextBox();
            txtIdProducto = new TextBox();
            boton_volver = new Button();
            boton_guardar = new Button();
            boton_eliminar = new Button();
            SuspendLayout();
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_Id.Location = new Point(16, 68);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(32, 30);
            label_Id.TabIndex = 0;
            label_Id.Text = "Id";
            // 
            // label_stock
            // 
            label_stock.AutoSize = true;
            label_stock.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_stock.Location = new Point(16, 151);
            label_stock.Name = "label_stock";
            label_stock.Size = new Size(67, 30);
            label_stock.TabIndex = 1;
            label_stock.Text = "Stock";
            // 
            // label_idProducto
            // 
            label_idProducto.AutoSize = true;
            label_idProducto.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_idProducto.Location = new Point(16, 110);
            label_idProducto.Name = "label_idProducto";
            label_idProducto.Size = new Size(129, 30);
            label_idProducto.TabIndex = 2;
            label_idProducto.Text = "Id Producto";
            // 
            // label_idVenta
            // 
            label_idVenta.AutoSize = true;
            label_idVenta.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_idVenta.Location = new Point(16, 191);
            label_idVenta.Name = "label_idVenta";
            label_idVenta.Size = new Size(95, 30);
            label_idVenta.TabIndex = 3;
            label_idVenta.Text = "Id Venta";
            // 
            // txtId
            // 
            txtId.Location = new Point(169, 75);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(169, 158);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(120, 23);
            txtStock.TabIndex = 7;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(169, 198);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(120, 23);
            txtIdVenta.TabIndex = 8;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(169, 117);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(120, 23);
            txtIdProducto.TabIndex = 9;
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
            // ProductoVendidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 334);
            Controls.Add(boton_eliminar);
            Controls.Add(boton_guardar);
            Controls.Add(boton_volver);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(txtIdVenta);
            Controls.Add(txtId);
            Controls.Add(label_stock);
            Controls.Add(label_idProducto);
            Controls.Add(label_idVenta);
            Controls.Add(label_Id);
            Name = "ProductoVendidoForm";
            Text = "ProductoVendidoForm";
            Load += ProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Id;
        private Label label_stock;
        private Label label_idProducto;
        private Label label_idVenta;
        private TextBox txtId;
        private TextBox txtStock;
        private TextBox txtIdVenta;
        private TextBox txtIdProducto;
        private Button boton_volver;
        private Button boton_guardar;
        private Button boton_eliminar;
    }
}