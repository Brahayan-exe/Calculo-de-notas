namespace NotasEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dtgEstudiantes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEstudiante = new TextBox();
            txtCorte1 = new TextBox();
            txtCorte2 = new TextBox();
            txtCorte3 = new TextBox();
            btnDefinitiva = new Button();
            btnBuscarEstudiante = new Button();
            btnActualizarNota = new Button();
            btnEliminarEstudiante = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dtgEstudiantes
            // 
            dtgEstudiantes.AllowUserToAddRows = false;
            dtgEstudiantes.AllowUserToDeleteRows = false;
            dtgEstudiantes.AllowUserToOrderColumns = true;
            dtgEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstudiantes.Location = new Point(22, 254);
            dtgEstudiantes.Name = "dtgEstudiantes";
            dtgEstudiantes.ReadOnly = true;
            dtgEstudiantes.Size = new Size(728, 161);
            dtgEstudiantes.TabIndex = 0;
            dtgEstudiantes.CellContentClick += dtgEstudiantes_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.DodgerBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 43);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 1;
            label1.Text = "Estudiante";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.DodgerBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(271, 43);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 2;
            label2.Text = "Corte 1 (35%)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.DodgerBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(404, 43);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 3;
            label3.Text = "Corte 2 (35%)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.DodgerBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Semibold", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(538, 43);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 4;
            label4.Text = "Corte 3 (30%)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEstudiante
            // 
            txtEstudiante.Anchor = AnchorStyles.None;
            txtEstudiante.BorderStyle = BorderStyle.FixedSingle;
            txtEstudiante.Font = new Font("Segoe UI", 10F);
            txtEstudiante.Location = new Point(66, 81);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(181, 25);
            txtEstudiante.TabIndex = 5;
            txtEstudiante.TextChanged += textBox1_TextChanged;
            // 
            // txtCorte1
            // 
            txtCorte1.Anchor = AnchorStyles.None;
            txtCorte1.BorderStyle = BorderStyle.FixedSingle;
            txtCorte1.Font = new Font("Segoe UI", 10F);
            txtCorte1.Location = new Point(271, 81);
            txtCorte1.Name = "txtCorte1";
            txtCorte1.Size = new Size(114, 25);
            txtCorte1.TabIndex = 6;
            // 
            // txtCorte2
            // 
            txtCorte2.Anchor = AnchorStyles.None;
            txtCorte2.BorderStyle = BorderStyle.FixedSingle;
            txtCorte2.Font = new Font("Segoe UI", 10F);
            txtCorte2.Location = new Point(404, 81);
            txtCorte2.Name = "txtCorte2";
            txtCorte2.Size = new Size(114, 25);
            txtCorte2.TabIndex = 7;
            // 
            // txtCorte3
            // 
            txtCorte3.Anchor = AnchorStyles.None;
            txtCorte3.BorderStyle = BorderStyle.FixedSingle;
            txtCorte3.Font = new Font("Segoe UI", 10F);
            txtCorte3.Location = new Point(538, 81);
            txtCorte3.Name = "txtCorte3";
            txtCorte3.Size = new Size(114, 25);
            txtCorte3.TabIndex = 8;
            // 
            // btnDefinitiva
            // 
            btnDefinitiva.BackgroundImage = (Image)resources.GetObject("btnDefinitiva.BackgroundImage");
            btnDefinitiva.BackgroundImageLayout = ImageLayout.None;
            btnDefinitiva.Location = new Point(56, 160);
            btnDefinitiva.Name = "btnDefinitiva";
            btnDefinitiva.Size = new Size(85, 77);
            btnDefinitiva.TabIndex = 9;
            btnDefinitiva.UseVisualStyleBackColor = true;
            btnDefinitiva.Click += btnDefinitiva_Click;
            // 
            // btnBuscarEstudiante
            // 
            btnBuscarEstudiante.BackgroundImage = (Image)resources.GetObject("btnBuscarEstudiante.BackgroundImage");
            btnBuscarEstudiante.BackgroundImageLayout = ImageLayout.None;
            btnBuscarEstudiante.Location = new Point(246, 160);
            btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            btnBuscarEstudiante.Size = new Size(85, 77);
            btnBuscarEstudiante.TabIndex = 10;
            btnBuscarEstudiante.UseVisualStyleBackColor = true;
            btnBuscarEstudiante.Click += btnBuscarEstudiante_Click;
            // 
            // btnActualizarNota
            // 
            btnActualizarNota.BackgroundImage = (Image)resources.GetObject("btnActualizarNota.BackgroundImage");
            btnActualizarNota.BackgroundImageLayout = ImageLayout.None;
            btnActualizarNota.Location = new Point(433, 160);
            btnActualizarNota.Name = "btnActualizarNota";
            btnActualizarNota.Size = new Size(85, 77);
            btnActualizarNota.TabIndex = 11;
            btnActualizarNota.UseVisualStyleBackColor = true;
            btnActualizarNota.Click += btnActualizarNota_Click;
            // 
            // btnEliminarEstudiante
            // 
            btnEliminarEstudiante.BackgroundImage = (Image)resources.GetObject("btnEliminarEstudiante.BackgroundImage");
            btnEliminarEstudiante.BackgroundImageLayout = ImageLayout.None;
            btnEliminarEstudiante.Location = new Point(634, 160);
            btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            btnEliminarEstudiante.Size = new Size(85, 77);
            btnEliminarEstudiante.TabIndex = 12;
            btnEliminarEstudiante.UseVisualStyleBackColor = true;
            btnEliminarEstudiante.Click += btnEliminarEstudiante_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F);
            label5.Location = new Point(66, 136);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 13;
            label5.Text = "Guardar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F);
            label6.Location = new Point(256, 136);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 14;
            label6.Text = "Buscar";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F);
            label7.Location = new Point(416, 136);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 15;
            label7.Text = "Actualizar nota";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F);
            label8.Location = new Point(643, 136);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 16;
            label8.Text = "Eliminar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEliminarEstudiante);
            Controls.Add(btnActualizarNota);
            Controls.Add(btnBuscarEstudiante);
            Controls.Add(btnDefinitiva);
            Controls.Add(txtCorte3);
            Controls.Add(txtCorte2);
            Controls.Add(txtCorte1);
            Controls.Add(txtEstudiante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgEstudiantes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgEstudiantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEstudiante;
        private TextBox txtCorte1;
        private TextBox txtCorte2;
        private TextBox txtCorte3;
        private Button btnDefinitiva;
        private Button btnBuscarEstudiante;
        private Button btnActualizarNota;
        private Button btnEliminarEstudiante;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
