namespace SistemaGestion
{
    partial class VentaForm
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
            label_comentarios = new Label();
            label_IdUsuario = new Label();
            txtId = new TextBox();
            txtComentarios = new TextBox();
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
            label_Id.Location = new Point(16, 74);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(32, 30);
            label_Id.TabIndex = 0;
            label_Id.Text = "Id";
            // 
            // label_comentarios
            // 
            label_comentarios.AutoSize = true;
            label_comentarios.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_comentarios.Location = new Point(16, 128);
            label_comentarios.Name = "label_comentarios";
            label_comentarios.Size = new Size(139, 30);
            label_comentarios.TabIndex = 1;
            label_comentarios.Text = "Comentarios";
            // 
            // label_IdUsuario
            // 
            label_IdUsuario.AutoSize = true;
            label_IdUsuario.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_IdUsuario.Location = new Point(16, 179);
            label_IdUsuario.Name = "label_IdUsuario";
            label_IdUsuario.Size = new Size(113, 30);
            label_IdUsuario.TabIndex = 5;
            label_IdUsuario.Text = "Id Usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(169, 83);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 6;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(169, 135);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(120, 23);
            txtComentarios.TabIndex = 7;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(169, 186);
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
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 332);
            Controls.Add(boton_eliminar);
            Controls.Add(boton_guardar);
            Controls.Add(boton_volver);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtId);
            Controls.Add(label_IdUsuario);
            Controls.Add(label_comentarios);
            Controls.Add(label_Id);
            Name = "VentaForm";
            Text = "VentaForm";
            Load += VentaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Id;
        private Label label_comentarios;
        private Label label_IdUsuario;
        private TextBox txtId;
        private TextBox txtComentarios;
        private TextBox txtIdUsuario;
        private Button boton_volver;
        private Button boton_guardar;
        private Button boton_eliminar;
    }
}