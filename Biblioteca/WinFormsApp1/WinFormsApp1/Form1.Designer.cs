namespace WinFormsApp1
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Libro,
            this.Fecha_Actual,
            this.Fecha_Entrega});
            this.data1.Location = new System.Drawing.Point(3, 390);
            this.data1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data1.Name = "data1";
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 25;
            this.data1.Size = new System.Drawing.Size(639, 378);
            this.data1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            this.Libro.Width = 125;
            // 
            // Fecha_Actual
            // 
            this.Fecha_Actual.HeaderText = "Fecha_Actual";
            this.Fecha_Actual.MinimumWidth = 6;
            this.Fecha_Actual.Name = "Fecha_Actual";
            this.Fecha_Actual.Width = 125;
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.HeaderText = "Fecha_Entrega";
            this.Fecha_Entrega.MinimumWidth = 6;
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            this.Fecha_Entrega.Width = 125;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(285, 28);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 36);
            this.txtnombre.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnok.Location = new System.Drawing.Point(14, 197);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(104, 31);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(157, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Libro";
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(285, 77);
            this.txtlibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlibro.Multiline = true;
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(302, 36);
            this.txtlibro.TabIndex = 5;
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncerrar.Location = new System.Drawing.Point(17, 297);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(101, 31);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 792);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.data1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn Fecha_Actual;
        private DataGridViewTextBoxColumn Fecha_Entrega;
        private TextBox txtnombre;
        private Button btnok;
        private Label label1;
        private Label label2;
        private TextBox txtlibro;
        private Button btncerrar;
        private Button button1;
    }
}