namespace Notas_color
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
            btn_calcular = new Button();
            btn_limpiar = new Button();
            btn_cerrar = new Button();
            txt_nota1 = new TextBox();
            txt_nota2 = new TextBox();
            txt_nota3 = new TextBox();
            txt_nota4 = new TextBox();
            txt_promedio = new TextBox();
            txt_situacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_completivo = new Button();
            txt_prueba = new TextBox();
            txt_completivo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txt_total = new TextBox();
            label9 = new Label();
            txt_situacion2 = new TextBox();
            label10 = new Label();
            txt_ReP = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.Lime;
            btn_calcular.ForeColor = Color.Black;
            btn_calcular.Location = new Point(301, 433);
            btn_calcular.Margin = new Padding(4, 5, 4, 5);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(205, 75);
            btn_calcular.TabIndex = 0;
            btn_calcular.Text = "calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Lime;
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.Location = new Point(514, 433);
            btn_limpiar.Margin = new Padding(4, 5, 4, 5);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(176, 75);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Lime;
            btn_cerrar.ForeColor = Color.Black;
            btn_cerrar.Location = new Point(709, 433);
            btn_cerrar.Margin = new Padding(4, 5, 4, 5);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(219, 75);
            btn_cerrar.TabIndex = 2;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // txt_nota1
            // 
            txt_nota1.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nota1.Location = new Point(260, 28);
            txt_nota1.Margin = new Padding(4, 5, 4, 5);
            txt_nota1.Name = "txt_nota1";
            txt_nota1.Size = new Size(141, 37);
            txt_nota1.TabIndex = 3;
            // 
            // txt_nota2
            // 
            txt_nota2.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nota2.Location = new Point(260, 92);
            txt_nota2.Margin = new Padding(4, 5, 4, 5);
            txt_nota2.Name = "txt_nota2";
            txt_nota2.Size = new Size(141, 37);
            txt_nota2.TabIndex = 4;
            // 
            // txt_nota3
            // 
            txt_nota3.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nota3.Location = new Point(260, 157);
            txt_nota3.Margin = new Padding(4, 5, 4, 5);
            txt_nota3.Name = "txt_nota3";
            txt_nota3.Size = new Size(141, 37);
            txt_nota3.TabIndex = 5;
            // 
            // txt_nota4
            // 
            txt_nota4.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nota4.Location = new Point(260, 222);
            txt_nota4.Margin = new Padding(4, 5, 4, 5);
            txt_nota4.Name = "txt_nota4";
            txt_nota4.Size = new Size(141, 37);
            txt_nota4.TabIndex = 6;
            // 
            // txt_promedio
            // 
            txt_promedio.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_promedio.Location = new Point(260, 285);
            txt_promedio.Margin = new Padding(4, 5, 4, 5);
            txt_promedio.Name = "txt_promedio";
            txt_promedio.Size = new Size(141, 37);
            txt_promedio.TabIndex = 7;
            // 
            // txt_situacion
            // 
            txt_situacion.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_situacion.Location = new Point(260, 348);
            txt_situacion.Margin = new Padding(4, 5, 4, 5);
            txt_situacion.Name = "txt_situacion";
            txt_situacion.Size = new Size(277, 37);
            txt_situacion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 9;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 10;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 11;
            label3.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 12;
            label4.Text = "Nota 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(104, 298);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 13;
            label5.Text = "Promedio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(104, 362);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 22);
            label6.TabIndex = 14;
            label6.Text = "Situación";
            // 
            // btn_completivo
            // 
            btn_completivo.BackColor = Color.Lime;
            btn_completivo.ForeColor = Color.Black;
            btn_completivo.Location = new Point(104, 433);
            btn_completivo.Margin = new Padding(4, 5, 4, 5);
            btn_completivo.Name = "btn_completivo";
            btn_completivo.Size = new Size(177, 75);
            btn_completivo.TabIndex = 15;
            btn_completivo.Text = "Completivo";
            btn_completivo.UseVisualStyleBackColor = false;
            btn_completivo.Click += btn_completivo_Click;
            // 
            // txt_prueba
            // 
            txt_prueba.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_prueba.Location = new Point(813, 48);
            txt_prueba.Margin = new Padding(4, 5, 4, 5);
            txt_prueba.Name = "txt_prueba";
            txt_prueba.Size = new Size(141, 37);
            txt_prueba.TabIndex = 16;
            // 
            // txt_completivo
            // 
            txt_completivo.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_completivo.Location = new Point(813, 120);
            txt_completivo.Margin = new Padding(4, 5, 4, 5);
            txt_completivo.Name = "txt_completivo";
            txt_completivo.Size = new Size(141, 37);
            txt_completivo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(623, 133);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 22);
            label7.TabIndex = 18;
            label7.Text = "Completivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(623, 62);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(162, 22);
            label8.TabIndex = 19;
            label8.Text = "Prueba Completiva";
            // 
            // txt_total
            // 
            txt_total.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_total.Location = new Point(813, 265);
            txt_total.Margin = new Padding(4, 5, 4, 5);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(141, 37);
            txt_total.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(623, 278);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 22);
            label9.TabIndex = 21;
            label9.Text = "Total completivo";
            // 
            // txt_situacion2
            // 
            txt_situacion2.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_situacion2.Location = new Point(813, 348);
            txt_situacion2.Margin = new Padding(4, 5, 4, 5);
            txt_situacion2.Name = "txt_situacion2";
            txt_situacion2.Size = new Size(296, 37);
            txt_situacion2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(626, 355);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(181, 22);
            label10.TabIndex = 23;
            label10.Text = "Situación Completiva";
            // 
            // txt_ReP
            // 
            txt_ReP.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ReP.Location = new Point(813, 198);
            txt_ReP.Margin = new Padding(4, 5, 4, 5);
            txt_ReP.Name = "txt_ReP";
            txt_ReP.Size = new Size(141, 37);
            txt_ReP.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(623, 205);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(193, 22);
            label11.TabIndex = 25;
            label11.Text = "Resultado de la Prueba";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1143, 750);
            Controls.Add(label11);
            Controls.Add(txt_ReP);
            Controls.Add(label10);
            Controls.Add(txt_situacion2);
            Controls.Add(label9);
            Controls.Add(txt_total);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_completivo);
            Controls.Add(txt_prueba);
            Controls.Add(btn_completivo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_situacion);
            Controls.Add(txt_promedio);
            Controls.Add(txt_nota4);
            Controls.Add(txt_nota3);
            Controls.Add(txt_nota2);
            Controls.Add(txt_nota1);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_calcular);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Reporte de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calcular;
        private Button btn_limpiar;
        private Button btn_cerrar;
        private TextBox txt_nota1;
        private TextBox txt_nota2;
        private TextBox txt_nota3;
        private TextBox txt_nota4;
        private TextBox txt_promedio;
        private TextBox txt_situacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_completivo;
        private TextBox txt_prueba;
        private TextBox txt_completivo;
        private Label label7;
        private Label label8;
        private TextBox txt_total;
        private Label label9;
        private TextBox txt_situacion2;
        private Label label10;
        private TextBox txt_ReP;
        private Label label11;
    }
}