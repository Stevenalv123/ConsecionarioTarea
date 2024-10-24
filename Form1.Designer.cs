namespace Consecionario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            lblMedida = new Label();
            lblTextField = new Label();
            label7 = new Label();
            txtTextField = new TextBox();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            btnNew = new Button();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            cmbItems = new ComboBox();
            panel3 = new Panel();
            dtgVehiculos = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Carga = new DataGridViewTextBoxColumn();
            Bateria = new DataGridViewTextBoxColumn();
            cmMetVehiculos = new ContextMenuStrip(components);
            cIniciar = new ToolStripMenuItem();
            cMo = new ToolStripMenuItem();
            cDetener = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            cmMetVehElectricos = new ContextMenuStrip(components);
            cCargar = new ToolStripMenuItem();
            cInit = new ToolStripMenuItem();
            cMov = new ToolStripMenuItem();
            cStop = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).BeginInit();
            cmMetVehiculos.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            cmMetVehElectricos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(234, 13);
            label1.Name = "label1";
            label1.Size = new Size(332, 45);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Vehiculos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(23, 8);
            label2.Name = "label2";
            label2.Size = new Size(197, 30);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Vehiculo: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblMedida);
            panel2.Controls.Add(lblTextField);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTextField);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtModelo);
            panel2.Controls.Add(lblModelo);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(lblMarca);
            panel2.Controls.Add(cmbItems);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 227);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(434, 15);
            label3.TabIndex = 10;
            label3.Text = "*Si quieres realizar alguna accion con el vehiculo, haz click derecho sobre la celda";
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMedida.Location = new Point(461, 147);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(78, 25);
            lblMedida.TabIndex = 9;
            lblMedida.Text = "medida";
            lblMedida.Visible = false;
            // 
            // lblTextField
            // 
            lblTextField.AutoSize = true;
            lblTextField.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTextField.Location = new Point(12, 144);
            lblTextField.Name = "lblTextField";
            lblTextField.Size = new Size(63, 30);
            lblTextField.TabIndex = 8;
            lblTextField.Text = "label";
            lblTextField.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(646, 183);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 7;
            label7.Text = "Car Sale";
            // 
            // txtTextField
            // 
            txtTextField.Font = new Font("Segoe UI", 12F);
            txtTextField.Location = new Point(258, 145);
            txtTextField.Name = "txtTextField";
            txtTextField.Size = new Size(197, 29);
            txtTextField.TabIndex = 4;
            txtTextField.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Right;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(570, 82);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(218, 56);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar...";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Right;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNew.Location = new Point(570, 20);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(218, 56);
            btnNew.TabIndex = 5;
            btnNew.Text = "Nuevo...";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 12F);
            txtModelo.Location = new Point(214, 103);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(350, 29);
            txtModelo.TabIndex = 4;
            txtModelo.Visible = false;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblModelo.Location = new Point(72, 99);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(98, 30);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo:";
            lblModelo.Visible = false;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.Location = new Point(214, 55);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(350, 29);
            txtMarca.TabIndex = 4;
            txtMarca.Visible = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMarca.Location = new Point(79, 51);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(84, 30);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca:";
            lblMarca.Visible = false;
            // 
            // cmbItems
            // 
            cmbItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItems.Font = new Font("Segoe UI", 12F);
            cmbItems.FormattingEnabled = true;
            cmbItems.Items.AddRange(new object[] { "Camiones", "Auto", "Auto electrico", "Motocicleta" });
            cmbItems.Location = new Point(214, 12);
            cmbItems.Name = "cmbItems";
            cmbItems.Size = new Size(350, 29);
            cmbItems.TabIndex = 2;
            cmbItems.SelectedIndexChanged += cmbItems_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgVehiculos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 153);
            panel3.TabIndex = 3;
            // 
            // dtgVehiculos
            // 
            dtgVehiculos.AllowUserToAddRows = false;
            dtgVehiculos.AllowUserToDeleteRows = false;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVehiculos.Columns.AddRange(new DataGridViewColumn[] { Tipo, Marca, Modelo, Carga, Bateria });
            dtgVehiculos.Dock = DockStyle.Fill;
            dtgVehiculos.Location = new Point(0, 0);
            dtgVehiculos.MultiSelect = false;
            dtgVehiculos.Name = "dtgVehiculos";
            dtgVehiculos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgVehiculos.RowHeadersVisible = false;
            dtgVehiculos.Size = new Size(800, 153);
            dtgVehiculos.TabIndex = 0;
            dtgVehiculos.CellMouseDown += dtgVehiculos_CellMouseDown;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Carga
            // 
            Carga.HeaderText = "Carga";
            Carga.Name = "Carga";
            Carga.ReadOnly = true;
            // 
            // Bateria
            // 
            Bateria.HeaderText = "Bateria";
            Bateria.Name = "Bateria";
            Bateria.ReadOnly = true;
            // 
            // cmMetVehiculos
            // 
            cmMetVehiculos.Items.AddRange(new ToolStripItem[] { cIniciar, cMo, cDetener });
            cmMetVehiculos.Name = "cmMetodos";
            cmMetVehiculos.Size = new Size(116, 70);
            cmMetVehiculos.Text = "Mover";
            // 
            // cIniciar
            // 
            cIniciar.Name = "cIniciar";
            cIniciar.Size = new Size(115, 22);
            cIniciar.Text = "Iniciar";
            cIniciar.Click += cIniciar_Click;
            // 
            // cMo
            // 
            cMo.Name = "cMo";
            cMo.Size = new Size(115, 22);
            cMo.Text = "Mover";
            cMo.Click += cMo_Click;
            // 
            // cDetener
            // 
            cDetener.Name = "cDetener";
            cDetener.Size = new Size(115, 22);
            cDetener.Text = "Detener";
            cDetener.Click += cDetener_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip1.Name = "cmMetodos";
            contextMenuStrip1.Size = new Size(149, 92);
            contextMenuStrip1.Text = "Mover";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(148, 22);
            toolStripMenuItem1.Text = "Detener";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(148, 22);
            toolStripMenuItem2.Text = "Mover";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(148, 22);
            toolStripMenuItem3.Text = "Cargar Bateria";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(148, 22);
            toolStripMenuItem4.Text = "Iniciar";
            // 
            // cmMetVehElectricos
            // 
            cmMetVehElectricos.Items.AddRange(new ToolStripItem[] { cCargar, cInit, cMov, cStop });
            cmMetVehElectricos.Name = "cmMetVehElectricos";
            cmMetVehElectricos.Size = new Size(120, 92);
            // 
            // cCargar
            // 
            cCargar.Name = "cCargar";
            cCargar.Size = new Size(119, 22);
            cCargar.Text = "Cargar";
            cCargar.Click += cCargar_Click;
            // 
            // cInit
            // 
            cInit.Name = "cInit";
            cInit.Size = new Size(119, 22);
            cInit.Text = "Iniciar";
            cInit.Click += cInit_Click;
            // 
            // cMov
            // 
            cMov.Name = "cMov";
            cMov.Size = new Size(119, 22);
            cMov.Text = "Moverse";
            cMov.Click += cMov_Click;
            // 
            // cStop
            // 
            cStop.Name = "cStop";
            cStop.Size = new Size(119, 22);
            cStop.Text = "Detener";
            cStop.Click += cStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Vehiculos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).EndInit();
            cmMetVehiculos.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            cmMetVehElectricos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private ComboBox cmbItems;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label label5;
        private Label label6;
        private Button btnGuardar;
        private Button btnNew;
        private TextBox txtTextField;
        private TextBox textBox3;
        private Panel panel3;
        private DataGridView dtgVehiculos;
        private Label label7;
        private PictureBox pictureBox1;
        private Label lblTextField;
        private Label lblMedida;
        private DataGridViewTextBoxColumn Estado;
        private ContextMenuStrip cmMetVehiculos;
        private ToolStripMenuItem cDetener;
        private ToolStripMenuItem cMo;
        private ToolStripMenuItem cIniciar;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Carga;
        private DataGridViewTextBoxColumn Bateria;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip cmMetVehElectricos;
        private ToolStripMenuItem cCargar;
        private ToolStripMenuItem cInit;
        private ToolStripMenuItem cMov;
        private ToolStripMenuItem cStop;
        private Label label3;
    }
}
