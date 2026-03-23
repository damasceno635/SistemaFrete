namespace SistemaFrete
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            lblPeso = new Label();
            txtPeso = new TextBox();
            txtDistancia = new TextBox();
            lblDistancia = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = SystemColors.ControlLight;
            lblPeso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(46, 34);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(40, 20);
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(47, 63);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(210, 27);
            txtPeso.TabIndex = 1;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(47, 138);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(210, 27);
            txtDistancia.TabIndex = 2;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.BackColor = SystemColors.ControlLight;
            lblDistancia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistancia.Location = new Point(45, 108);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(71, 20);
            lblDistancia.TabIndex = 3;
            lblDistancia.Text = "Distância";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.ControlLight;
            lblTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(46, 184);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(47, 213);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(210, 28);
            cmbTipo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.MediumSeaGreen;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.Desktop;
            btnCalcular.Location = new Point(47, 283);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(155, 41);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular Frete";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.WindowFrame;
            lblResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(47, 362);
            lblResultado.Name = "lblResultado";
            lblResultado.RightToLeft = RightToLeft.No;
            lblResultado.Size = new Size(97, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(318, 414);
            dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 414);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblDistancia);
            Controls.Add(txtDistancia);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "Sistema de Cálculo de Frete";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtDistancia;
        private Label lblDistancia;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnCalcular;
        private Label lblResultado;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
