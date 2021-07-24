
namespace APLICACIONBASEDEDATOS {
    partial class FrmAddCurso {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ComboBoxLeng = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblLenguaje = new System.Windows.Forms.Label();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.LblTituloFrm = new System.Windows.Forms.Label();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.guna2PictureBox2);
            this.guna2GroupBox2.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2GroupBox2.Controls.Add(this.BtnCancelar);
            this.guna2GroupBox2.Controls.Add(this.LblTituloFrm);
            this.guna2GroupBox2.Controls.Add(this.BtnAdd);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(212)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(732, 405);
            this.guna2GroupBox2.TabIndex = 26;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.ComboBoxLeng);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtDescripcion);
            this.guna2CustomGradientPanel1.Controls.Add(this.LblDesc);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtPrecio);
            this.guna2CustomGradientPanel1.Controls.Add(this.LblPrecio);
            this.guna2CustomGradientPanel1.Controls.Add(this.LblLenguaje);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtTitulo);
            this.guna2CustomGradientPanel1.Controls.Add(this.LblTitulo);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(36, 73);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(653, 235);
            this.guna2CustomGradientPanel1.TabIndex = 29;
            // 
            // ComboBoxLeng
            // 
            this.ComboBoxLeng.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxLeng.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxLeng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLeng.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxLeng.FocusedState.Parent = this.ComboBoxLeng;
            this.ComboBoxLeng.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxLeng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxLeng.FormattingEnabled = true;
            this.ComboBoxLeng.HoverState.Parent = this.ComboBoxLeng;
            this.ComboBoxLeng.ItemHeight = 30;
            this.ComboBoxLeng.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Java",
            "Python",
            "PHP",
            "SQL",
            "Ruby",
            "Visual Basic. NET",
            "R",
            "TypeScript",
            "Swift",
            "Rust",
            "Go",
            "Kotlin",
            "JavaScript",
            "Scheme",
            "Erlang",
            "Elixir",
            "Pascal",
            "Scala",
            "Objective-C",
            "Lua"});
            this.ComboBoxLeng.ItemsAppearance.Parent = this.ComboBoxLeng;
            this.ComboBoxLeng.Location = new System.Drawing.Point(122, 106);
            this.ComboBoxLeng.Name = "ComboBoxLeng";
            this.ComboBoxLeng.ShadowDecoration.Parent = this.ComboBoxLeng;
            this.ComboBoxLeng.Size = new System.Drawing.Size(150, 36);
            this.ComboBoxLeng.TabIndex = 10;
            this.ComboBoxLeng.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLeng_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(419, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(184, 165);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.Color.Black;
            this.LblDesc.Location = new System.Drawing.Point(320, 47);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(91, 21);
            this.LblDesc.TabIndex = 8;
            this.LblDesc.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.Location = new System.Drawing.Point(122, 169);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(150, 36);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.Black;
            this.LblPrecio.Location = new System.Drawing.Point(63, 176);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(53, 21);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // LblLenguaje
            // 
            this.LblLenguaje.AutoSize = true;
            this.LblLenguaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLenguaje.ForeColor = System.Drawing.Color.Black;
            this.LblLenguaje.Location = new System.Drawing.Point(42, 112);
            this.LblLenguaje.Name = "LblLenguaje";
            this.LblLenguaje.Size = new System.Drawing.Size(73, 21);
            this.LblLenguaje.TabIndex = 4;
            this.LblLenguaje.Text = "Lenguaje";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.Parent = this.txtTitulo;
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.FocusedState.Parent = this.txtTitulo;
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.HoverState.Parent = this.txtTitulo;
            this.txtTitulo.Location = new System.Drawing.Point(122, 40);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.ShadowDecoration.Parent = this.txtTitulo;
            this.txtTitulo.Size = new System.Drawing.Size(150, 36);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Black;
            this.LblTitulo.Location = new System.Drawing.Point(66, 47);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(49, 21);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Titulo";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BorderRadius = 15;
            this.BtnCancelar.CheckedState.Parent = this.BtnCancelar;
            this.BtnCancelar.CustomImages.Parent = this.BtnCancelar;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverState.Parent = this.BtnCancelar;
            this.BtnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancelar.Location = new System.Drawing.Point(413, 333);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShadowDecoration.Parent = this.BtnCancelar;
            this.BtnCancelar.Size = new System.Drawing.Size(154, 45);
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.Text = "Camcelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblTituloFrm
            // 
            this.LblTituloFrm.AutoSize = true;
            this.LblTituloFrm.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloFrm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFrm.ForeColor = System.Drawing.Color.Black;
            this.LblTituloFrm.Location = new System.Drawing.Point(234, 29);
            this.LblTituloFrm.Name = "LblTituloFrm";
            this.LblTituloFrm.Size = new System.Drawing.Size(283, 25);
            this.LblTituloFrm.TabIndex = 0;
            this.LblTituloFrm.Text = "Ingreso de un nuevo curso";
            this.LblTituloFrm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BorderRadius = 15;
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Image = global::APLICACIONBASEDEDATOS.Properties.Resources.icons8_add_32;
            this.BtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAdd.Location = new System.Drawing.Point(177, 333);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(140, 45);
            this.BtnAdd.TabIndex = 26;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::APLICACIONBASEDEDATOS.Properties.Resources.exitL;
            this.guna2PictureBox2.Location = new System.Drawing.Point(686, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(34, 33);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 30;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // FrmAddCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 405);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCurso";
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button BtnCancelar;
        private System.Windows.Forms.Label LblTituloFrm;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private System.Windows.Forms.Label LblDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblLenguaje;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxLeng;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}