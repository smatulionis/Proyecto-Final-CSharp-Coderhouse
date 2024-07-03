namespace SistemaGestion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGeneral = new DataGridView();
            comboBox1 = new ComboBox();
            boton_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGeneral).BeginInit();
            SuspendLayout();
            // 
            // dgvGeneral
            // 
            dgvGeneral.AllowUserToAddRows = false;
            dgvGeneral.AllowUserToDeleteRows = false;
            dgvGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGeneral.Location = new Point(23, 86);
            dgvGeneral.Name = "dgvGeneral";
            dgvGeneral.ReadOnly = true;
            dgvGeneral.RowTemplate.Height = 25;
            dgvGeneral.Size = new Size(753, 340);
            dgvGeneral.TabIndex = 0;
            dgvGeneral.CellClick += dgvGeneral_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Productos", "Productos Vendidos", "Usuarios", "Ventas" });
            comboBox1.Location = new Point(23, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // boton_agregar
            // 
            boton_agregar.Location = new Point(693, 39);
            boton_agregar.Name = "boton_agregar";
            boton_agregar.Size = new Size(83, 23);
            boton_agregar.TabIndex = 2;
            boton_agregar.Text = "Agregar";
            boton_agregar.UseVisualStyleBackColor = true;
            boton_agregar.Click += boton_agregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton_agregar);
            Controls.Add(comboBox1);
            Controls.Add(dgvGeneral);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGeneral).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGeneral;
        private ComboBox comboBox1;
        private Button boton_agregar;
    }
}
