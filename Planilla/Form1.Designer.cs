namespace Planilla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ju1 = new System.Windows.Forms.Label();
            this.ju2 = new System.Windows.Forms.Label();
            this.ju3 = new System.Windows.Forms.Label();
            this.tju1 = new System.Windows.Forms.TextBox();
            this.tju2 = new System.Windows.Forms.TextBox();
            this.tju3 = new System.Windows.Forms.TextBox();
            this.tju6 = new System.Windows.Forms.TextBox();
            this.tju5 = new System.Windows.Forms.TextBox();
            this.tju4 = new System.Windows.Forms.TextBox();
            this.ju6 = new System.Windows.Forms.Label();
            this.ju5 = new System.Windows.Forms.Label();
            this.ju4 = new System.Windows.Forms.Label();
            this.equip = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 Jugador",
            "2 Jugadores",
            "3 Jugadores",
            "4 Jugadores",
            "5 Jugadores",
            "6 Jugadores"});
            this.comboBox1.Location = new System.Drawing.Point(440, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.label2.Location = new System.Drawing.Point(689, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "30 Minutos",
            "1 Hora",
            "2 Horas",
            "Tiempo Libre"});
            this.comboBox2.Location = new System.Drawing.Point(845, 263);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.button1.Location = new System.Drawing.Point(590, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ju1
            // 
            this.ju1.AutoSize = true;
            this.ju1.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju1.Location = new System.Drawing.Point(283, 346);
            this.ju1.Name = "ju1";
            this.ju1.Size = new System.Drawing.Size(75, 25);
            this.ju1.TabIndex = 6;
            this.ju1.Text = "Jugador 1";
            this.ju1.Visible = false;
            // 
            // ju2
            // 
            this.ju2.AutoSize = true;
            this.ju2.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju2.Location = new System.Drawing.Point(283, 436);
            this.ju2.Name = "ju2";
            this.ju2.Size = new System.Drawing.Size(79, 25);
            this.ju2.TabIndex = 7;
            this.ju2.Text = "Jugador 2";
            this.ju2.Visible = false;
            // 
            // ju3
            // 
            this.ju3.AutoSize = true;
            this.ju3.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju3.Location = new System.Drawing.Point(283, 526);
            this.ju3.Name = "ju3";
            this.ju3.Size = new System.Drawing.Size(78, 25);
            this.ju3.TabIndex = 8;
            this.ju3.Text = "Jugador 3";
            this.ju3.Visible = false;
            // 
            // tju1
            // 
            this.tju1.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju1.Location = new System.Drawing.Point(439, 343);
            this.tju1.Name = "tju1";
            this.tju1.Size = new System.Drawing.Size(121, 33);
            this.tju1.TabIndex = 9;
            this.tju1.Visible = false;
            // 
            // tju2
            // 
            this.tju2.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju2.Location = new System.Drawing.Point(439, 433);
            this.tju2.Name = "tju2";
            this.tju2.Size = new System.Drawing.Size(121, 33);
            this.tju2.TabIndex = 10;
            this.tju2.Visible = false;
            // 
            // tju3
            // 
            this.tju3.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju3.Location = new System.Drawing.Point(439, 523);
            this.tju3.Name = "tju3";
            this.tju3.Size = new System.Drawing.Size(121, 33);
            this.tju3.TabIndex = 11;
            this.tju3.Visible = false;
            // 
            // tju6
            // 
            this.tju6.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju6.Location = new System.Drawing.Point(845, 523);
            this.tju6.Name = "tju6";
            this.tju6.Size = new System.Drawing.Size(121, 33);
            this.tju6.TabIndex = 17;
            this.tju6.Visible = false;
            // 
            // tju5
            // 
            this.tju5.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju5.Location = new System.Drawing.Point(845, 433);
            this.tju5.Name = "tju5";
            this.tju5.Size = new System.Drawing.Size(121, 33);
            this.tju5.TabIndex = 16;
            this.tju5.Visible = false;
            // 
            // tju4
            // 
            this.tju4.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.tju4.Location = new System.Drawing.Point(845, 343);
            this.tju4.Name = "tju4";
            this.tju4.Size = new System.Drawing.Size(121, 33);
            this.tju4.TabIndex = 15;
            this.tju4.Visible = false;
            // 
            // ju6
            // 
            this.ju6.AutoSize = true;
            this.ju6.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju6.Location = new System.Drawing.Point(689, 526);
            this.ju6.Name = "ju6";
            this.ju6.Size = new System.Drawing.Size(78, 25);
            this.ju6.TabIndex = 14;
            this.ju6.Text = "Jugador 6";
            this.ju6.Visible = false;
            // 
            // ju5
            // 
            this.ju5.AutoSize = true;
            this.ju5.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju5.Location = new System.Drawing.Point(689, 436);
            this.ju5.Name = "ju5";
            this.ju5.Size = new System.Drawing.Size(78, 25);
            this.ju5.TabIndex = 13;
            this.ju5.Text = "Jugador 5";
            this.ju5.Visible = false;
            // 
            // ju4
            // 
            this.ju4.AutoSize = true;
            this.ju4.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.ju4.Location = new System.Drawing.Point(689, 346);
            this.ju4.Name = "ju4";
            this.ju4.Size = new System.Drawing.Size(79, 25);
            this.ju4.TabIndex = 12;
            this.ju4.Text = "Jugador 4";
            this.ju4.Visible = false;
            // 
            // equip
            // 
            this.equip.AutoSize = true;
            this.equip.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.equip.Location = new System.Drawing.Point(283, 606);
            this.equip.Name = "equip";
            this.equip.Size = new System.Drawing.Size(110, 25);
            this.equip.TabIndex = 18;
            this.equip.Text = "Nombre equipo";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Kenyan Coffee Rg", 15.75F);
            this.textBox7.Location = new System.Drawing.Point(439, 603);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 33);
            this.textBox7.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.equip);
            this.Controls.Add(this.tju6);
            this.Controls.Add(this.tju5);
            this.Controls.Add(this.tju4);
            this.Controls.Add(this.ju6);
            this.Controls.Add(this.ju5);
            this.Controls.Add(this.ju4);
            this.Controls.Add(this.tju3);
            this.Controls.Add(this.tju2);
            this.Controls.Add(this.tju1);
            this.Controls.Add(this.ju3);
            this.Controls.Add(this.ju2);
            this.Controls.Add(this.ju1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ju1;
        private System.Windows.Forms.Label ju2;
        private System.Windows.Forms.Label ju3;
        private System.Windows.Forms.TextBox tju1;
        private System.Windows.Forms.TextBox tju2;
        private System.Windows.Forms.TextBox tju3;
        private System.Windows.Forms.TextBox tju6;
        private System.Windows.Forms.TextBox tju5;
        private System.Windows.Forms.TextBox tju4;
        private System.Windows.Forms.Label ju6;
        private System.Windows.Forms.Label ju5;
        private System.Windows.Forms.Label ju4;
        private System.Windows.Forms.Label equip;
        private System.Windows.Forms.TextBox textBox7;
    }
}

