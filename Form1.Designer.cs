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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
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
            dataGridView1 = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Carga = new DataGridViewTextBoxColumn();
            Bateria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Size = new Size(800, 206);
            panel2.TabIndex = 2;
            // 
            // lblTextField
            // 
            lblTextField.AutoSize = true;
            lblTextField.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTextField.Location = new Point(12, 142);
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
            txtTextField.Location = new Point(258, 142);
            txtTextField.Name = "txtTextField";
            txtTextField.Size = new Size(306, 29);
            txtTextField.TabIndex = 4;
            txtTextField.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(574, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Right;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(570, 72);
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
            btnNew.Location = new Point(570, 10);
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
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 174);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tipo, Marca, Modelo, Carga, Bateria });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(800, 174);
            dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label lblTextField;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Carga;
        private DataGridViewTextBoxColumn Bateria;
    }
}
