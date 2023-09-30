namespace MiCalculadora
{
    partial class FrmCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPrimerOperando = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblSegundoOperador = new System.Windows.Forms.Label();
            this.txtSegundoOperador = new System.Windows.Forms.TextBox();
            this.txtPrimerOperador = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.grpSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(20, 321);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(196, 48);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(237, 321);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(196, 48);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(458, 321);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(196, 48);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblPrimerOperando
            // 
            this.lblPrimerOperando.AutoSize = true;
            this.lblPrimerOperando.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerOperando.Location = new System.Drawing.Point(31, 220);
            this.lblPrimerOperando.Name = "lblPrimerOperando";
            this.lblPrimerOperando.Size = new System.Drawing.Size(167, 25);
            this.lblPrimerOperando.TabIndex = 3;
            this.lblPrimerOperando.Text = "Primer operador:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(13, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(195, 51);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperacion.Location = new System.Drawing.Point(275, 220);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(109, 25);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            this.lblSegundoOperador.AutoSize = true;
            this.lblSegundoOperador.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoOperador.Location = new System.Drawing.Point(458, 220);
            this.lblSegundoOperador.Name = "lblSegundoOperador";
            this.lblSegundoOperador.Size = new System.Drawing.Size(188, 25);
            this.lblSegundoOperador.TabIndex = 6;
            this.lblSegundoOperador.Text = "Segundo operador:";
            // 
            // txtSegundoOperador
            // 
            this.txtSegundoOperador.Location = new System.Drawing.Point(458, 248);
            this.txtSegundoOperador.Multiline = true;
            this.txtSegundoOperador.Name = "txtSegundoOperador";
            this.txtSegundoOperador.ShortcutsEnabled = false;
            this.txtSegundoOperador.Size = new System.Drawing.Size(196, 43);
            this.txtSegundoOperador.TabIndex = 2;
            // 
            // txtPrimerOperador
            // 
            this.txtPrimerOperador.Location = new System.Drawing.Point(20, 248);
            this.txtPrimerOperador.Multiline = true;
            this.txtPrimerOperador.Name = "txtPrimerOperador";
            this.txtPrimerOperador.ShortcutsEnabled = false;
            this.txtPrimerOperador.Size = new System.Drawing.Size(196, 43);
            this.txtPrimerOperador.TabIndex = 0;
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownHeight = 150;
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.IntegralHeight = false;
            this.cmbOperacion.ItemHeight = 15;
            this.cmbOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperacion.Location = new System.Drawing.Point(275, 248);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(121, 23);
            this.cmbOperacion.TabIndex = 1;
            // 
            // grpSistema
            // 
            this.grpSistema.Controls.Add(this.rdbBinario);
            this.grpSistema.Controls.Add(this.rdbDecimal);
            this.grpSistema.Location = new System.Drawing.Point(233, 151);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Size = new System.Drawing.Size(200, 54);
            this.grpSistema.TabIndex = 6;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Representar resultado en:";
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Checked = true;
            this.rdbDecimal.Location = new System.Drawing.Point(7, 25);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(68, 19);
            this.rdbDecimal.TabIndex = 7;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Location = new System.Drawing.Point(110, 25);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(62, 19);
            this.rdbBinario.TabIndex = 8;
            this.rdbBinario.TabStop = true;
            this.rdbBinario.Text = "Binario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(674, 386);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.txtPrimerOperador);
            this.Controls.Add(this.txtSegundoOperador);
            this.Controls.Add(this.lblSegundoOperador);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPrimerOperando);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de: Sebastian Serrano";
            this.grpSistema.ResumeLayout(false);
            this.grpSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblPrimerOperando;
        private Label lblResultado;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
        private ComboBox cmbOperacion;
        private GroupBox grpSistema;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
    }
}