
namespace HELADERIA_CA
{
    partial class CRUDProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_producto = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_bus = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_actu = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dgv_producto);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.txt_bus);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_elim);
            this.panel1.Controls.Add(this.btn_actu);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.txt_pre);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_cod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 678);
            this.panel1.TabIndex = 2;
            // 
            // dgv_producto
            // 
            this.dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_producto.Location = new System.Drawing.Point(60, 284);
            this.dgv_producto.Name = "dgv_producto";
            this.dgv_producto.RowHeadersWidth = 51;
            this.dgv_producto.RowTemplate.Height = 24;
            this.dgv_producto.Size = new System.Drawing.Size(520, 334);
            this.dgv_producto.TabIndex = 36;
            this.dgv_producto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_producto_CellMouseClick);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightPink;
            this.btn_exit.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Location = new System.Drawing.Point(548, 624);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 34);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_bus
            // 
            this.txt_bus.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bus.Location = new System.Drawing.Point(208, 243);
            this.txt_bus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_bus.Name = "txt_bus";
            this.txt_bus.Size = new System.Drawing.Size(259, 30);
            this.txt_bus.TabIndex = 35;
            this.txt_bus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bus_KeyPress_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightPink;
            this.btn_back.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(23, 624);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(54, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Buscar Producto:";
            // 
            // btn_elim
            // 
            this.btn_elim.BackColor = System.Drawing.Color.LightPink;
            this.btn_elim.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_elim.Location = new System.Drawing.Point(468, 183);
            this.btn_elim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(104, 32);
            this.btn_elim.TabIndex = 33;
            this.btn_elim.Text = "Eliminar";
            this.btn_elim.UseVisualStyleBackColor = false;
            this.btn_elim.Click += new System.EventHandler(this.btn_elim_Click);
            // 
            // btn_actu
            // 
            this.btn_actu.BackColor = System.Drawing.Color.LightPink;
            this.btn_actu.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_actu.Location = new System.Drawing.Point(272, 182);
            this.btn_actu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_actu.Name = "btn_actu";
            this.btn_actu.Size = new System.Drawing.Size(119, 33);
            this.btn_actu.TabIndex = 32;
            this.btn_actu.Text = "Actualizar";
            this.btn_actu.UseVisualStyleBackColor = false;
            this.btn_actu.Click += new System.EventHandler(this.btn_actu_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LightPink;
            this.btn_guardar.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(52, 183);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(130, 34);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_pre
            // 
            this.txt_pre.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pre.Location = new System.Drawing.Point(220, 130);
            this.txt_pre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(350, 30);
            this.txt_pre.TabIndex = 26;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(220, 92);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(350, 30);
            this.txt_nom.TabIndex = 25;
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(220, 60);
            this.txt_cod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(350, 30);
            this.txt_cod.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "CRUD PRODUCTOS";
            // 
            // CRUDProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(655, 666);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CRUDProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDProducto";
            this.Load += new System.EventHandler(this.CRUDProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_bus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_actu;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_producto;
    }
}