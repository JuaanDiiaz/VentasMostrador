namespace VentasMostrador
{
    partial class InvoiceForm
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
            textBoxRazonSocial = new TextBox();
            textBoxCorreo = new TextBox();
            comboBoxUsoCFDI = new ComboBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            labelTitle = new Label();
            textBoxRFC = new TextBox();
            SuspendLayout();
            // 
            // textBoxRazonSocial
            // 
            textBoxRazonSocial.Location = new Point(12, 41);
            textBoxRazonSocial.Name = "textBoxRazonSocial";
            textBoxRazonSocial.Size = new Size(203, 23);
            textBoxRazonSocial.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(12, 99);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(203, 23);
            textBoxCorreo.TabIndex = 1;
            // 
            // comboBoxUsoCFDI
            // 
            comboBoxUsoCFDI.FormattingEnabled = true;
            comboBoxUsoCFDI.Items.AddRange(new object[] { "G03 - Gastos en general", "P01 - Por definir", "D01 - Honorarios médicos, dentales y gastos hospitalarios", "I01 - Adquisición de mercancías", "I08 - Otra maquinaria y equipo" });
            comboBoxUsoCFDI.Location = new Point(12, 128);
            comboBoxUsoCFDI.Name = "comboBoxUsoCFDI";
            comboBoxUsoCFDI.Size = new Size(203, 23);
            comboBoxUsoCFDI.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            buttonAceptar.FlatStyle = FlatStyle.Popup;
            buttonAceptar.Location = new Point(33, 160);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 3;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(114, 160);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(24, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(176, 15);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Ingrese sus datos de facturacion";
            // 
            // textBoxRFC
            // 
            textBoxRFC.Location = new Point(12, 70);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.Size = new Size(203, 23);
            textBoxRFC.TabIndex = 6;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 201);
            ControlBox = false;
            Controls.Add(textBoxRFC);
            Controls.Add(labelTitle);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAceptar);
            Controls.Add(comboBoxUsoCFDI);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxRazonSocial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InvoiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRazonSocial;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxUsoCFDI;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private Label labelTitle;
        private TextBox textBoxRFC;
    }
}