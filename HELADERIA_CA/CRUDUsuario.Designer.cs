
namespace HELADERIA_CA
{
    partial class CRUDUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_usu = new System.Windows.Forms.DataGridView();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_bus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_actu = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_dire = new System.Windows.Forms.TextBox();
            this.txt_ced = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dgv_usu);
            this.panel1.Controls.Add(this.cmb_estado);
            this.panel1.Controls.Add(this.cmb_rol);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_bus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_elim);
            this.panel1.Controls.Add(this.btn_actu);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.txt_dire);
            this.panel1.Controls.Add(this.txt_ced);
            this.panel1.Controls.Add(this.txt_contra);
            this.panel1.Controls.Add(this.txt_ape);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 866);
            this.panel1.TabIndex = 0;
            // 
            // dgv_usu
            // 
            this.dgv_usu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usu.Location = new System.Drawing.Point(97, 474);
            this.dgv_usu.Name = "dgv_usu";
            this.dgv_usu.RowHeadersWidth = 51;
            this.dgv_usu.RowTemplate.Height = 24;
            this.dgv_usu.Size = new System.Drawing.Size(1099, 275);
            this.dgv_usu.TabIndex = 45;
            this.dgv_usu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_usu_CellMouseClick);
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmb_estado.Location = new System.Drawing.Point(220, 398);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 26);
            this.cmb_estado.TabIndex = 44;
            // 
            // cmb_rol
            // 
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmb_rol.Location = new System.Drawing.Point(220, 363);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(121, 26);
            this.cmb_rol.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 42;
            this.label12.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 363);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 22);
            this.label11.TabIndex = 40;
            this.label11.Text = "Rol:";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_salir.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Location = new System.Drawing.Point(1154, 761);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(112, 40);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(41, 767);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(220, 242);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(350, 30);
            this.txt_correo.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Correo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // txt_bus
            // 
            this.txt_bus.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bus.Location = new System.Drawing.Point(782, 65);
            this.txt_bus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_bus.Name = "txt_bus";
            this.txt_bus.Size = new System.Drawing.Size(259, 30);
            this.txt_bus.TabIndex = 35;
            this.txt_bus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bus_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(638, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Buscar Usuario:";
            // 
            // btn_elim
            // 
            this.btn_elim.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_elim.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_elim.Location = new System.Drawing.Point(468, 434);
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
            this.btn_actu.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_actu.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_actu.Location = new System.Drawing.Point(272, 433);
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
            this.btn_guardar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_guardar.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(52, 434);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(130, 34);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(220, 317);
            this.txt_num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(350, 30);
            this.txt_num.TabIndex = 30;
            // 
            // txt_dire
            // 
            this.txt_dire.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dire.Location = new System.Drawing.Point(220, 279);
            this.txt_dire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_dire.Name = "txt_dire";
            this.txt_dire.Size = new System.Drawing.Size(350, 30);
            this.txt_dire.TabIndex = 29;
            // 
            // txt_ced
            // 
            this.txt_ced.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ced.Location = new System.Drawing.Point(220, 205);
            this.txt_ced.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ced.Name = "txt_ced";
            this.txt_ced.Size = new System.Drawing.Size(350, 30);
            this.txt_ced.TabIndex = 28;
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(220, 168);
            this.txt_contra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(350, 30);
            this.txt_contra.TabIndex = 27;
            // 
            // txt_ape
            // 
            this.txt_ape.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ape.Location = new System.Drawing.Point(220, 131);
            this.txt_ape.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(350, 30);
            this.txt_ape.TabIndex = 26;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(220, 96);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(350, 30);
            this.txt_nom.TabIndex = 25;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(220, 60);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(350, 30);
            this.txt_user.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 325);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Número celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 104);
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
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(472, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "CRUD USUARIOS";
            // 
            // CRUDUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 861);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CRUDUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDUsuario";
            this.Load += new System.EventHandler(this.CRUDUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_bus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_actu;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_dire;
        private System.Windows.Forms.TextBox txt_ced;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.DataGridView dgv_usu;
    }
}