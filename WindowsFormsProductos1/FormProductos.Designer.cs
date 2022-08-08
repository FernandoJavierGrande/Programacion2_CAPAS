namespace WindowsFormsProductos1
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.boton_cargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_egreso = new System.Windows.Forms.RadioButton();
            this.rad_ingreso = new System.Windows.Forms.RadioButton();
            this.lbl_stockMov = new System.Windows.Forms.Label();
            this.Boton_aceptar = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_descMov = new System.Windows.Forms.Label();
            this.lbl_codMov = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // boton_cargar
            // 
            this.boton_cargar.Location = new System.Drawing.Point(382, 124);
            this.boton_cargar.Name = "boton_cargar";
            this.boton_cargar.Size = new System.Drawing.Size(82, 34);
            this.boton_cargar.TabIndex = 3;
            this.boton_cargar.Text = "Cargar";
            this.boton_cargar.UseVisualStyleBackColor = true;
            this.boton_cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(53, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 224);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_stock);
            this.tabPage1.Controls.Add(this.txt_desc);
            this.tabPage1.Controls.Add(this.txt_codigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.boton_cargar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(138, 121);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 22);
            this.txt_stock.TabIndex = 6;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(157, 70);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 22);
            this.txt_desc.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(123, 12);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lbl_stockMov);
            this.tabPage2.Controls.Add(this.Boton_aceptar);
            this.tabPage2.Controls.Add(this.txt_cant);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbl_descMov);
            this.tabPage2.Controls.Add(this.lbl_codMov);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_egreso);
            this.panel1.Controls.Add(this.rad_ingreso);
            this.panel1.Location = new System.Drawing.Point(290, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 72);
            this.panel1.TabIndex = 8;
            // 
            // rad_egreso
            // 
            this.rad_egreso.AutoSize = true;
            this.rad_egreso.Location = new System.Drawing.Point(3, 39);
            this.rad_egreso.Name = "rad_egreso";
            this.rad_egreso.Size = new System.Drawing.Size(72, 20);
            this.rad_egreso.TabIndex = 5;
            this.rad_egreso.Text = "Egreso";
            this.rad_egreso.UseVisualStyleBackColor = true;
            // 
            // rad_ingreso
            // 
            this.rad_ingreso.AutoSize = true;
            this.rad_ingreso.Checked = true;
            this.rad_ingreso.Location = new System.Drawing.Point(3, 13);
            this.rad_ingreso.Name = "rad_ingreso";
            this.rad_ingreso.Size = new System.Drawing.Size(73, 20);
            this.rad_ingreso.TabIndex = 4;
            this.rad_ingreso.TabStop = true;
            this.rad_ingreso.Text = "Ingreso";
            this.rad_ingreso.UseVisualStyleBackColor = true;
            // 
            // lbl_stockMov
            // 
            this.lbl_stockMov.AutoSize = true;
            this.lbl_stockMov.Location = new System.Drawing.Point(36, 95);
            this.lbl_stockMov.Name = "lbl_stockMov";
            this.lbl_stockMov.Size = new System.Drawing.Size(0, 16);
            this.lbl_stockMov.TabIndex = 7;
            // 
            // Boton_aceptar
            // 
            this.Boton_aceptar.Location = new System.Drawing.Point(424, 95);
            this.Boton_aceptar.Name = "Boton_aceptar";
            this.Boton_aceptar.Size = new System.Drawing.Size(108, 68);
            this.Boton_aceptar.TabIndex = 6;
            this.Boton_aceptar.Text = "Aceptar";
            this.Boton_aceptar.UseVisualStyleBackColor = true;
            this.Boton_aceptar.Click += new System.EventHandler(this.Boton_aceptar_Click);
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(129, 129);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(100, 22);
            this.txt_cant.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // lbl_descMov
            // 
            this.lbl_descMov.AutoSize = true;
            this.lbl_descMov.Location = new System.Drawing.Point(33, 58);
            this.lbl_descMov.Name = "lbl_descMov";
            this.lbl_descMov.Size = new System.Drawing.Size(44, 16);
            this.lbl_descMov.TabIndex = 1;
            this.lbl_descMov.Text = "label5";
            // 
            // lbl_codMov
            // 
            this.lbl_codMov.AutoSize = true;
            this.lbl_codMov.Location = new System.Drawing.Point(33, 28);
            this.lbl_codMov.Name = "lbl_codMov";
            this.lbl_codMov.Size = new System.Drawing.Size(44, 16);
            this.lbl_codMov.TabIndex = 0;
            this.lbl_codMov.Text = "label4";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(57, 290);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(616, 201);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 532);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_cargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Boton_aceptar;
        private System.Windows.Forms.RadioButton rad_egreso;
        private System.Windows.Forms.RadioButton rad_ingreso;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_descMov;
        private System.Windows.Forms.Label lbl_codMov;
        private System.Windows.Forms.Label lbl_stockMov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
    }
}