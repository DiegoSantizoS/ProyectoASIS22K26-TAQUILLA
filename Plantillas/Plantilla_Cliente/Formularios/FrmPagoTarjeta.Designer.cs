namespace Plantilla_Cliente.Formularios
{
    partial class FrmPagoTarjeta
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
            txtNumeroTarjeta = new TextBox();
            picMarcaTarjeta = new PictureBox();
            btnProcesar = new Button();
            lblTotal = new Label();
            txtFechaExpiracion = new TextBox();
            txtCVV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picMarcaTarjeta).BeginInit();
            SuspendLayout();
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Font = new Font("Segoe UI", 11F);
            txtNumeroTarjeta.Location = new Point(347, 72);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(156, 27);
            txtNumeroTarjeta.TabIndex = 2;
            // 
            // picMarcaTarjeta
            // 
            picMarcaTarjeta.Location = new Point(303, 68);
            picMarcaTarjeta.Name = "picMarcaTarjeta";
            picMarcaTarjeta.Size = new Size(38, 31);
            picMarcaTarjeta.SizeMode = PictureBoxSizeMode.Zoom;
            picMarcaTarjeta.TabIndex = 3;
            picMarcaTarjeta.TabStop = false;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(253, 212);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(79, 42);
            btnProcesar.TabIndex = 4;
            btnProcesar.Text = "Procesar Tarjeta";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(303, 22);
            lblTotal.MinimumSize = new Size(100, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 5;
            // 
            // txtFechaExpiracion
            // 
            txtFechaExpiracion.Location = new Point(303, 119);
            txtFechaExpiracion.Name = "txtFechaExpiracion";
            txtFechaExpiracion.PlaceholderText = "MM/AA";
            txtFechaExpiracion.Size = new Size(100, 23);
            txtFechaExpiracion.TabIndex = 6;
            txtFechaExpiracion.Tag = "MM/AA";
            txtFechaExpiracion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(303, 164);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(100, 23);
            txtCVV.TabIndex = 7;
            txtCVV.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(189, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 8;
            label1.Text = "Total a Pagar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(201, 77);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 9;
            label2.Text = "No. Tarjeta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
        //    label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(121, 117);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 10;
            label3.Text = "Fecha de Vencimiento";
            label3.TextAlign = ContentAlignment.MiddleCenter;
         //   label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(181, 164);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 11;
            label4.Text = "No. Seguridad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
         //   label4.Click += label4_Click;
            // 
            // FrmPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(591, 272);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCVV);
            Controls.Add(txtFechaExpiracion);
            Controls.Add(lblTotal);
            Controls.Add(btnProcesar);
            Controls.Add(picMarcaTarjeta);
            Controls.Add(txtNumeroTarjeta);
            Name = "FrmPagoTarjeta";
            Text = "FrmPagoTarjeta";
            Click += btnProcesar_Click;
            ((System.ComponentModel.ISupportInitialize)picMarcaTarjeta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumeroTarjeta;
        private PictureBox picMarcaTarjeta;
        private Button btnProcesar;
        private Label lblTotal;
        private TextBox txtFechaExpiracion;
        private TextBox txtCVV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}