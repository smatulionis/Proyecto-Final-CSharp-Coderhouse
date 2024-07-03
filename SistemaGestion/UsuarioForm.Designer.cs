namespace SistemaGestion
{
    partial class UsuarioForm
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
            label_nombreUsuario = new Label();
            label_apellido = new Label();
            label_contrasenia = new Label();
            label_nombre = new Label();
            label_mail = new Label();
            txtId = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContrasenia = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtMail = new TextBox();
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
            // label_nombreUsuario
            // 
            label_nombreUsuario.AutoSize = true;
            label_nombreUsuario.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_nombreUsuario.Location = new Point(16, 145);
            label_nombreUsuario.Name = "label_nombreUsuario";
            label_nombreUsuario.Size = new Size(176, 30);
            label_nombreUsuario.TabIndex = 1;
            label_nombreUsuario.Text = "Nombre Usuario";
            // 
            // label_apellido
            // 
            label_apellido.AutoSize = true;
            label_apellido.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_apellido.Location = new Point(16, 110);
            label_apellido.Name = "label_apellido";
            label_apellido.Size = new Size(97, 30);
            label_apellido.TabIndex = 2;
            label_apellido.Text = "Apellido";
            // 
            // label_contrasenia
            // 
            label_contrasenia.AutoSize = true;
            label_contrasenia.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_contrasenia.Location = new Point(16, 184);
            label_contrasenia.Name = "label_contrasenia";
            label_contrasenia.Size = new Size(125, 30);
            label_contrasenia.TabIndex = 3;
            label_contrasenia.Text = "Contraseña";
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_nombre.Location = new Point(16, 71);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(95, 30);
            label_nombre.TabIndex = 4;
            label_nombre.Text = "Nombre";
            // 
            // label_mail
            // 
            label_mail.AutoSize = true;
            label_mail.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_mail.Location = new Point(16, 224);
            label_mail.Name = "label_mail";
            label_mail.Size = new Size(56, 30);
            label_mail.TabIndex = 5;
            label_mail.Text = "Mail";
            // 
            // txtId
            // 
            txtId.Location = new Point(192, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 6;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(192, 152);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(120, 23);
            txtNombreUsuario.TabIndex = 7;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(192, 191);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(120, 23);
            txtContrasenia.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(192, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(120, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(192, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(192, 231);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(120, 23);
            txtMail.TabIndex = 11;
            // 
            // boton_volver
            // 
            boton_volver.Location = new Point(28, 286);
            boton_volver.Name = "boton_volver";
            boton_volver.Size = new Size(75, 29);
            boton_volver.TabIndex = 12;
            boton_volver.Text = "Volver";
            boton_volver.UseVisualStyleBackColor = true;
            boton_volver.Click += boton_volver_Click;
            // 
            // boton_guardar
            // 
            boton_guardar.Location = new Point(226, 286);
            boton_guardar.Name = "boton_guardar";
            boton_guardar.Size = new Size(75, 29);
            boton_guardar.TabIndex = 13;
            boton_guardar.Text = "Guardar";
            boton_guardar.UseVisualStyleBackColor = true;
            boton_guardar.Click += boton_guardar_Click;
            // 
            // boton_eliminar
            // 
            boton_eliminar.Location = new Point(128, 286);
            boton_eliminar.Name = "boton_eliminar";
            boton_eliminar.Size = new Size(75, 29);
            boton_eliminar.TabIndex = 14;
            boton_eliminar.Text = "Eliminar";
            boton_eliminar.UseVisualStyleBackColor = true;
            boton_eliminar.Click += boton_eliminar_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 327);
            Controls.Add(boton_eliminar);
            Controls.Add(boton_guardar);
            Controls.Add(boton_volver);
            Controls.Add(txtMail);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtId);
            Controls.Add(label_mail);
            Controls.Add(label_nombre);
            Controls.Add(label_contrasenia);
            Controls.Add(label_apellido);
            Controls.Add(label_nombreUsuario);
            Controls.Add(label_Id);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            Load += UsuarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Id;
        private Label label_nombreUsuario;
        private Label label_apellido;
        private Label label_contrasenia;
        private Label label_nombre;
        private Label label_mail;
        private TextBox txtId;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtMail;
        private Button boton_volver;
        private Button boton_guardar;
        private Button boton_eliminar;
    }
}