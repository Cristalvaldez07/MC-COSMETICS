namespace BeautyProducts
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTACTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.cONTACTOToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
            // 
            // cONTACTOToolStripMenuItem
            // 
            this.cONTACTOToolStripMenuItem.Name = "cONTACTOToolStripMenuItem";
            this.cONTACTOToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.cONTACTOToolStripMenuItem.Text = "CONTACTO";
            this.cONTACTOToolStripMenuItem.Click += new System.EventHandler(this.cONTACTOToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(208, 25);
            this.aYUDAToolStripMenuItem.Text = "PREGUNTAS FRECUENTES";
            this.aYUDAToolStripMenuItem.Click += new System.EventHandler(this.aYUDAToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO A MC COSMETICS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESCUBRE NUESTRA AMPLIA SELECCIÓN DE PRODUCTOS DE BELLEZA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DE ALTA CALIDAD A LOS MEJORES PRECIOS. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "¡ENCUENTRA LO QUE NECESITAS PARA REALZAR TU BELLEZA!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(626, 416);
            this.dataGridViewProductos.TabIndex = 6;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(748, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar nuevo producto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(748, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(748, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(748, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(748, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(748, 276);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(748, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 21;
            this.button3.Text = "Actualizar producto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 555);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTACTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}