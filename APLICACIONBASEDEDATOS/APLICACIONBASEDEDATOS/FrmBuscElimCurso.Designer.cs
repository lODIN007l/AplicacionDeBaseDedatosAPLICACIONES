
namespace APLICACIONBASEDEDATOS {
    partial class FrmBuscElimCurso {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnPasElim = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCod = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.LblTituloFrm = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.guna2PictureBox2);
            this.guna2GroupBox2.Controls.Add(this.BtnPasElim);
            this.guna2GroupBox2.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2GroupBox2.Controls.Add(this.BtnCancelar);
            this.guna2GroupBox2.Controls.Add(this.LblTituloFrm);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(207)))), ((int)(((byte)(212)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(729, 417);
            this.guna2GroupBox2.TabIndex = 28;
            // 
            // BtnPasElim
            // 
            this.BtnPasElim.BorderRadius = 15;
            this.BtnPasElim.CheckedState.Parent = this.BtnPasElim;
            this.BtnPasElim.CustomImages.Parent = this.BtnPasElim;
            this.BtnPasElim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPasElim.ForeColor = System.Drawing.Color.White;
            this.BtnPasElim.HoverState.Parent = this.BtnPasElim;
            this.BtnPasElim.Image = global::APLICACIONBASEDEDATOS.Properties.Resources.icons8_delete_bin_32;
            this.BtnPasElim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPasElim.Location = new System.Drawing.Point(196, 359);
            this.BtnPasElim.Name = "BtnPasElim";
            this.BtnPasElim.ShadowDecoration.Parent = this.BtnPasElim;
            this.BtnPasElim.Size = new System.Drawing.Size(154, 45);
            this.BtnPasElim.TabIndex = 31;
            this.BtnPasElim.Text = "Ir a eliminar";
            this.BtnPasElim.Click += new System.EventHandler(this.BtnPasElim_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.DataGridView3);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnBuscar);
            this.guna2CustomGradientPanel1.Controls.Add(this.TxtCod);
            this.guna2CustomGradientPanel1.Controls.Add(this.LblCodigo);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(36, 70);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(653, 265);
            this.guna2CustomGradientPanel1.TabIndex = 29;
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows = false;
            this.DataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView3.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView3.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView3.EnableHeadersVisualStyles = false;
            this.DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView3.Location = new System.Drawing.Point(56, 119);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.ReadOnly = true;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView3.Size = new System.Drawing.Size(542, 105);
            this.DataGridView3.TabIndex = 33;
            this.DataGridView3.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView3.ThemeStyle.ReadOnly = true;
            this.DataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGridView3.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderRadius = 15;
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Image = global::APLICACIONBASEDEDATOS.Properties.Resources.search_52px;
            this.btnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscar.Location = new System.Drawing.Point(406, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TxtCod
            // 
            this.TxtCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCod.DefaultText = "";
            this.TxtCod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCod.DisabledState.Parent = this.TxtCod;
            this.TxtCod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCod.FocusedState.Parent = this.TxtCod;
            this.TxtCod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCod.HoverState.Parent = this.TxtCod;
            this.TxtCod.Location = new System.Drawing.Point(212, 48);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.PasswordChar = '\0';
            this.TxtCod.PlaceholderText = "";
            this.TxtCod.SelectedText = "";
            this.TxtCod.ShadowDecoration.Parent = this.TxtCod;
            this.TxtCod.Size = new System.Drawing.Size(151, 36);
            this.TxtCod.TabIndex = 1;
            this.TxtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCod_KeyPress);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(144, 55);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(60, 21);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
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
            this.BtnCancelar.Location = new System.Drawing.Point(394, 359);
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
            this.LblTituloFrm.Location = new System.Drawing.Point(281, 29);
            this.LblTituloFrm.Name = "LblTituloFrm";
            this.LblTituloFrm.Size = new System.Drawing.Size(185, 25);
            this.LblTituloFrm.TabIndex = 0;
            this.LblTituloFrm.Text = "Eliminar un curso";
            this.LblTituloFrm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::APLICACIONBASEDEDATOS.Properties.Resources.exitL;
            this.guna2PictureBox2.Location = new System.Drawing.Point(683, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(34, 33);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 31;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // FrmBuscElimCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 417);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscElimCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarCurso";
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCod;
        private System.Windows.Forms.Label LblCodigo;
        private Guna.UI2.WinForms.Guna2Button BtnCancelar;
        private System.Windows.Forms.Label LblTituloFrm;
        private Guna.UI2.WinForms.Guna2Button BtnPasElim;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}