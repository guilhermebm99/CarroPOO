namespace UWinFormsApp1
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
            this.buttonLigar = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonFrear = new System.Windows.Forms.Button();
            this.buttonTrocarPneu = new System.Windows.Forms.Button();
            this.textBoxImpulso = new System.Windows.Forms.TextBox();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDe = new System.Windows.Forms.TextBox();
            this.textBoxDd = new System.Windows.Forms.TextBox();
            this.textBoxTe = new System.Windows.Forms.TextBox();
            this.textBoxTd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.comboBoxPneu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonLigar
            // 
            this.buttonLigar.Location = new System.Drawing.Point(28, 359);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.Size = new System.Drawing.Size(94, 29);
            this.buttonLigar.TabIndex = 0;
            this.buttonLigar.Text = "ligar";
            this.buttonLigar.UseVisualStyleBackColor = true;
            this.buttonLigar.Click += new System.EventHandler(this.buttonLigar_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(128, 359);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(94, 29);
            this.buttonAcelerar.TabIndex = 1;
            this.buttonAcelerar.Text = "acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonFrear
            // 
            this.buttonFrear.Location = new System.Drawing.Point(228, 359);
            this.buttonFrear.Name = "buttonFrear";
            this.buttonFrear.Size = new System.Drawing.Size(94, 29);
            this.buttonFrear.TabIndex = 2;
            this.buttonFrear.Text = "Frear";
            this.buttonFrear.UseVisualStyleBackColor = true;
            this.buttonFrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTrocarPneu
            // 
            this.buttonTrocarPneu.Location = new System.Drawing.Point(128, 453);
            this.buttonTrocarPneu.Name = "buttonTrocarPneu";
            this.buttonTrocarPneu.Size = new System.Drawing.Size(151, 29);
            this.buttonTrocarPneu.TabIndex = 3;
            this.buttonTrocarPneu.Text = "Trocar Pneu";
            this.buttonTrocarPneu.UseVisualStyleBackColor = true;
            this.buttonTrocarPneu.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxImpulso
            // 
            this.textBoxImpulso.Location = new System.Drawing.Point(28, 307);
            this.textBoxImpulso.Name = "textBoxImpulso";
            this.textBoxImpulso.Size = new System.Drawing.Size(394, 27);
            this.textBoxImpulso.TabIndex = 4;
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.Location = new System.Drawing.Point(678, 60);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExibir.Size = new System.Drawing.Size(418, 422);
            this.textBoxExibir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Impulso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalhes do carro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDe
            // 
            this.textBoxDe.Location = new System.Drawing.Point(469, 60);
            this.textBoxDe.Multiline = true;
            this.textBoxDe.Name = "textBoxDe";
            this.textBoxDe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDe.Size = new System.Drawing.Size(176, 163);
            this.textBoxDe.TabIndex = 8;
            // 
            // textBoxDd
            // 
            this.textBoxDd.Location = new System.Drawing.Point(1102, 60);
            this.textBoxDd.Multiline = true;
            this.textBoxDd.Name = "textBoxDd";
            this.textBoxDd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDd.Size = new System.Drawing.Size(176, 163);
            this.textBoxDd.TabIndex = 9;
            // 
            // textBoxTe
            // 
            this.textBoxTe.Location = new System.Drawing.Point(469, 319);
            this.textBoxTe.Multiline = true;
            this.textBoxTe.Name = "textBoxTe";
            this.textBoxTe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTe.Size = new System.Drawing.Size(176, 163);
            this.textBoxTe.TabIndex = 10;
            // 
            // textBoxTd
            // 
            this.textBoxTd.Location = new System.Drawing.Point(1093, 319);
            this.textBoxTd.Multiline = true;
            this.textBoxTd.Name = "textBoxTd";
            this.textBoxTd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTd.Size = new System.Drawing.Size(176, 163);
            this.textBoxTd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pneu dianteiro esquerdo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1102, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pneu dianteiro direito";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pneu traseiro esquerdo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1102, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pneu traseiro direito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estepe";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(807, 518);
            this.textBoxE.Multiline = true;
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxE.Size = new System.Drawing.Size(176, 163);
            this.textBoxE.TabIndex = 16;
            // 
            // comboBoxPneu
            // 
            this.comboBoxPneu.FormattingEnabled = true;
            this.comboBoxPneu.Items.AddRange(new object[] {
            "Pneu dianteiro esquerdo",
            "Pneu dianteiro direito",
            "Pneu traseiro esquerdo",
            "Pneu traseiro direito"});
            this.comboBoxPneu.Location = new System.Drawing.Point(128, 404);
            this.comboBoxPneu.Name = "comboBoxPneu";
            this.comboBoxPneu.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPneu.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 693);
            this.Controls.Add(this.comboBoxPneu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTd);
            this.Controls.Add(this.textBoxTe);
            this.Controls.Add(this.textBoxDd);
            this.Controls.Add(this.textBoxDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.textBoxImpulso);
            this.Controls.Add(this.buttonTrocarPneu);
            this.Controls.Add(this.buttonFrear);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLigar;
        private Button buttonAcelerar;
        private Button buttonFrear;
        private Button buttonTrocarPneu;
        private TextBox textBoxImpulso;
        private TextBox textBoxExibir;
        private Label label1;
        private Label label2;
        private TextBox textBoxDe;
        private TextBox textBoxDd;
        private TextBox textBoxTe;
        private TextBox textBoxTd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxE;
        private ComboBox comboBoxPneu;
    }
}