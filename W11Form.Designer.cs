namespace W11_Debloater
{
    partial class W11Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W11Form));
            panelLateral = new Panel();
            panel_privacidad = new Panel();
            cb_2plano = new CheckBox();
            cb_consejos = new CheckBox();
            cb_sugerido = new CheckBox();
            cb_diagnostico = new CheckBox();
            cb_ubicacion = new CheckBox();
            btn_privacidad = new Button();
            panel_innecesarias = new Panel();
            cb_people = new CheckBox();
            cb_notas = new CheckBox();
            cb_solitario = new CheckBox();
            cb_xbox = new CheckBox();
            cb_Office = new CheckBox();
            cb_News = new CheckBox();
            cb_Mapas = new CheckBox();
            cb_CentroOpiniones = new CheckBox();
            cb_Teams = new CheckBox();
            cb_OneDrive = new CheckBox();
            cb_Eltiempo = new CheckBox();
            cb_Cortana = new CheckBox();
            btn_innecesarias = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            texto_info = new TextBox();
            enlace_github = new LinkLabel();
            btn_optimizar = new Button();
            panelLateral.SuspendLayout();
            panel_privacidad.SuspendLayout();
            panel_innecesarias.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.BackColor = Color.FromArgb(51, 68, 89);
            panelLateral.Controls.Add(panel_privacidad);
            panelLateral.Controls.Add(btn_privacidad);
            panelLateral.Controls.Add(panel_innecesarias);
            panelLateral.Controls.Add(btn_innecesarias);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(355, 659);
            panelLateral.TabIndex = 0;
            // 
            // panel_privacidad
            // 
            panel_privacidad.BackColor = Color.FromArgb(40, 53, 69);
            panel_privacidad.Controls.Add(cb_2plano);
            panel_privacidad.Controls.Add(cb_consejos);
            panel_privacidad.Controls.Add(cb_sugerido);
            panel_privacidad.Controls.Add(cb_diagnostico);
            panel_privacidad.Controls.Add(cb_ubicacion);
            panel_privacidad.Dock = DockStyle.Top;
            panel_privacidad.Location = new Point(0, 754);
            panel_privacidad.Margin = new Padding(3, 4, 3, 4);
            panel_privacidad.Name = "panel_privacidad";
            panel_privacidad.Size = new Size(334, 174);
            panel_privacidad.TabIndex = 9;
            panel_privacidad.Visible = false;
            // 
            // cb_2plano
            // 
            cb_2plano.AutoSize = true;
            cb_2plano.Checked = true;
            cb_2plano.CheckState = CheckState.Checked;
            cb_2plano.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_2plano.ForeColor = Color.White;
            cb_2plano.Location = new Point(14, 139);
            cb_2plano.Name = "cb_2plano";
            cb_2plano.Size = new Size(310, 27);
            cb_2plano.TabIndex = 6;
            cb_2plano.Text = "Deshabilitar Apps en Segundo Plano";
            cb_2plano.TextAlign = ContentAlignment.MiddleCenter;
            cb_2plano.UseVisualStyleBackColor = true;
            // 
            // cb_consejos
            // 
            cb_consejos.AutoSize = true;
            cb_consejos.Checked = true;
            cb_consejos.CheckState = CheckState.Checked;
            cb_consejos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_consejos.ForeColor = Color.White;
            cb_consejos.Location = new Point(14, 106);
            cb_consejos.Name = "cb_consejos";
            cb_consejos.Size = new Size(264, 27);
            cb_consejos.TabIndex = 5;
            cb_consejos.Text = "Eliminar Consejos de Windows";
            cb_consejos.TextAlign = ContentAlignment.MiddleCenter;
            cb_consejos.UseVisualStyleBackColor = true;
            // 
            // cb_sugerido
            // 
            cb_sugerido.AutoSize = true;
            cb_sugerido.Checked = true;
            cb_sugerido.CheckState = CheckState.Checked;
            cb_sugerido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_sugerido.ForeColor = Color.White;
            cb_sugerido.Location = new Point(14, 7);
            cb_sugerido.Name = "cb_sugerido";
            cb_sugerido.Size = new Size(251, 27);
            cb_sugerido.TabIndex = 4;
            cb_sugerido.Text = "Eliminar Contenido Sugerido";
            cb_sugerido.TextAlign = ContentAlignment.MiddleCenter;
            cb_sugerido.UseVisualStyleBackColor = true;
            // 
            // cb_diagnostico
            // 
            cb_diagnostico.AutoSize = true;
            cb_diagnostico.Checked = true;
            cb_diagnostico.CheckState = CheckState.Checked;
            cb_diagnostico.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_diagnostico.ForeColor = Color.White;
            cb_diagnostico.Location = new Point(14, 40);
            cb_diagnostico.Name = "cb_diagnostico";
            cb_diagnostico.Size = new Size(261, 27);
            cb_diagnostico.TabIndex = 2;
            cb_diagnostico.Text = "Eliminar Datos de Diagnóstico";
            cb_diagnostico.TextAlign = ContentAlignment.MiddleCenter;
            cb_diagnostico.UseVisualStyleBackColor = true;
            // 
            // cb_ubicacion
            // 
            cb_ubicacion.AutoSize = true;
            cb_ubicacion.Checked = true;
            cb_ubicacion.CheckState = CheckState.Checked;
            cb_ubicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ubicacion.ForeColor = Color.White;
            cb_ubicacion.Location = new Point(14, 73);
            cb_ubicacion.Name = "cb_ubicacion";
            cb_ubicacion.Size = new Size(266, 27);
            cb_ubicacion.TabIndex = 3;
            cb_ubicacion.Text = "Eliminar Rastreos de Ubicación";
            cb_ubicacion.TextAlign = ContentAlignment.MiddleCenter;
            cb_ubicacion.UseVisualStyleBackColor = true;
            // 
            // btn_privacidad
            // 
            btn_privacidad.Dock = DockStyle.Top;
            btn_privacidad.Location = new Point(0, 701);
            btn_privacidad.Margin = new Padding(3, 4, 3, 4);
            btn_privacidad.Name = "btn_privacidad";
            btn_privacidad.Size = new Size(334, 53);
            btn_privacidad.TabIndex = 8;
            btn_privacidad.Text = "Problemas de Privacidad";
            btn_privacidad.UseVisualStyleBackColor = true;
            btn_privacidad.Click += btn_privacidad_Click;
            // 
            // panel_innecesarias
            // 
            panel_innecesarias.BackColor = Color.FromArgb(40, 53, 69);
            panel_innecesarias.Controls.Add(cb_people);
            panel_innecesarias.Controls.Add(cb_notas);
            panel_innecesarias.Controls.Add(cb_solitario);
            panel_innecesarias.Controls.Add(cb_xbox);
            panel_innecesarias.Controls.Add(cb_Office);
            panel_innecesarias.Controls.Add(cb_News);
            panel_innecesarias.Controls.Add(cb_Mapas);
            panel_innecesarias.Controls.Add(cb_CentroOpiniones);
            panel_innecesarias.Controls.Add(cb_Teams);
            panel_innecesarias.Controls.Add(cb_OneDrive);
            panel_innecesarias.Controls.Add(cb_Eltiempo);
            panel_innecesarias.Controls.Add(cb_Cortana);
            panel_innecesarias.Dock = DockStyle.Top;
            panel_innecesarias.Location = new Point(0, 244);
            panel_innecesarias.Margin = new Padding(3, 4, 3, 4);
            panel_innecesarias.Name = "panel_innecesarias";
            panel_innecesarias.Size = new Size(334, 457);
            panel_innecesarias.TabIndex = 7;
            panel_innecesarias.Visible = false;
            // 
            // cb_people
            // 
            cb_people.AutoSize = true;
            cb_people.Checked = true;
            cb_people.CheckState = CheckState.Checked;
            cb_people.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_people.ForeColor = Color.White;
            cb_people.Location = new Point(14, 341);
            cb_people.Name = "cb_people";
            cb_people.Size = new Size(247, 27);
            cb_people.TabIndex = 13;
            cb_people.Text = "Desinstalar Microsoft People";
            cb_people.TextAlign = ContentAlignment.MiddleCenter;
            cb_people.UseVisualStyleBackColor = true;
            // 
            // cb_notas
            // 
            cb_notas.AutoSize = true;
            cb_notas.Checked = true;
            cb_notas.CheckState = CheckState.Checked;
            cb_notas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_notas.ForeColor = Color.White;
            cb_notas.Location = new Point(14, 229);
            cb_notas.Name = "cb_notas";
            cb_notas.Size = new Size(229, 27);
            cb_notas.TabIndex = 12;
            cb_notas.Text = "Desinstalar Notas Rápidas";
            cb_notas.TextAlign = ContentAlignment.MiddleCenter;
            cb_notas.UseVisualStyleBackColor = true;
            // 
            // cb_solitario
            // 
            cb_solitario.AutoSize = true;
            cb_solitario.Checked = true;
            cb_solitario.CheckState = CheckState.Checked;
            cb_solitario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_solitario.ForeColor = Color.White;
            cb_solitario.Location = new Point(14, 193);
            cb_solitario.Name = "cb_solitario";
            cb_solitario.Size = new Size(182, 27);
            cb_solitario.TabIndex = 11;
            cb_solitario.Text = "Desinstalar Solitario";
            cb_solitario.TextAlign = ContentAlignment.MiddleCenter;
            cb_solitario.UseVisualStyleBackColor = true;
            // 
            // cb_xbox
            // 
            cb_xbox.AutoSize = true;
            cb_xbox.Checked = true;
            cb_xbox.CheckState = CheckState.Checked;
            cb_xbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_xbox.ForeColor = Color.White;
            cb_xbox.Location = new Point(14, 156);
            cb_xbox.Name = "cb_xbox";
            cb_xbox.Size = new Size(158, 27);
            cb_xbox.TabIndex = 10;
            cb_xbox.Text = "Desinstalar Xbox";
            cb_xbox.TextAlign = ContentAlignment.MiddleCenter;
            cb_xbox.UseVisualStyleBackColor = true;
            // 
            // cb_Office
            // 
            cb_Office.AutoSize = true;
            cb_Office.Checked = true;
            cb_Office.CheckState = CheckState.Checked;
            cb_Office.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Office.ForeColor = Color.White;
            cb_Office.Location = new Point(14, 304);
            cb_Office.Name = "cb_Office";
            cb_Office.Size = new Size(240, 27);
            cb_Office.TabIndex = 9;
            cb_Office.Text = "Desinstalar Microsoft Office";
            cb_Office.TextAlign = ContentAlignment.MiddleCenter;
            cb_Office.UseVisualStyleBackColor = true;
            // 
            // cb_News
            // 
            cb_News.AutoSize = true;
            cb_News.Checked = true;
            cb_News.CheckState = CheckState.Checked;
            cb_News.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_News.ForeColor = Color.White;
            cb_News.Location = new Point(14, 267);
            cb_News.Name = "cb_News";
            cb_News.Size = new Size(237, 27);
            cb_News.TabIndex = 8;
            cb_News.Text = "Desinstalar Microsoft News";
            cb_News.TextAlign = ContentAlignment.MiddleCenter;
            cb_News.UseVisualStyleBackColor = true;
            // 
            // cb_Mapas
            // 
            cb_Mapas.AutoSize = true;
            cb_Mapas.Checked = true;
            cb_Mapas.CheckState = CheckState.Checked;
            cb_Mapas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Mapas.ForeColor = Color.White;
            cb_Mapas.Location = new Point(14, 119);
            cb_Mapas.Name = "cb_Mapas";
            cb_Mapas.Size = new Size(170, 27);
            cb_Mapas.TabIndex = 7;
            cb_Mapas.Text = "Desinstalar Mapas";
            cb_Mapas.TextAlign = ContentAlignment.MiddleCenter;
            cb_Mapas.UseVisualStyleBackColor = true;
            // 
            // cb_CentroOpiniones
            // 
            cb_CentroOpiniones.AutoSize = true;
            cb_CentroOpiniones.Checked = true;
            cb_CentroOpiniones.CheckState = CheckState.Checked;
            cb_CentroOpiniones.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_CentroOpiniones.ForeColor = Color.White;
            cb_CentroOpiniones.Location = new Point(14, 413);
            cb_CentroOpiniones.Name = "cb_CentroOpiniones";
            cb_CentroOpiniones.Size = new Size(278, 27);
            cb_CentroOpiniones.TabIndex = 6;
            cb_CentroOpiniones.Text = "Desinstalar Centro de Opiniones";
            cb_CentroOpiniones.TextAlign = ContentAlignment.MiddleCenter;
            cb_CentroOpiniones.UseVisualStyleBackColor = true;
            // 
            // cb_Teams
            // 
            cb_Teams.AutoSize = true;
            cb_Teams.Checked = true;
            cb_Teams.CheckState = CheckState.Checked;
            cb_Teams.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Teams.ForeColor = Color.White;
            cb_Teams.Location = new Point(14, 379);
            cb_Teams.Name = "cb_Teams";
            cb_Teams.Size = new Size(243, 27);
            cb_Teams.TabIndex = 4;
            cb_Teams.Text = "Desinstalar Microsoft Teams";
            cb_Teams.TextAlign = ContentAlignment.MiddleCenter;
            cb_Teams.UseVisualStyleBackColor = true;
            // 
            // cb_OneDrive
            // 
            cb_OneDrive.AutoSize = true;
            cb_OneDrive.Checked = true;
            cb_OneDrive.CheckState = CheckState.Checked;
            cb_OneDrive.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_OneDrive.ForeColor = Color.White;
            cb_OneDrive.Location = new Point(14, 7);
            cb_OneDrive.Name = "cb_OneDrive";
            cb_OneDrive.Size = new Size(191, 27);
            cb_OneDrive.TabIndex = 2;
            cb_OneDrive.Text = "Desinstalar OneDrive";
            cb_OneDrive.TextAlign = ContentAlignment.MiddleCenter;
            cb_OneDrive.UseVisualStyleBackColor = true;
            cb_OneDrive.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cb_Eltiempo
            // 
            cb_Eltiempo.AutoSize = true;
            cb_Eltiempo.Checked = true;
            cb_Eltiempo.CheckState = CheckState.Checked;
            cb_Eltiempo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Eltiempo.ForeColor = Color.White;
            cb_Eltiempo.Location = new Point(14, 44);
            cb_Eltiempo.Name = "cb_Eltiempo";
            cb_Eltiempo.Size = new Size(195, 27);
            cb_Eltiempo.TabIndex = 3;
            cb_Eltiempo.Text = "Desinstalar El Tiempo";
            cb_Eltiempo.TextAlign = ContentAlignment.MiddleCenter;
            cb_Eltiempo.UseVisualStyleBackColor = true;
            // 
            // cb_Cortana
            // 
            cb_Cortana.AutoSize = true;
            cb_Cortana.Checked = true;
            cb_Cortana.CheckState = CheckState.Checked;
            cb_Cortana.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Cortana.ForeColor = Color.White;
            cb_Cortana.Location = new Point(14, 81);
            cb_Cortana.Name = "cb_Cortana";
            cb_Cortana.Size = new Size(181, 27);
            cb_Cortana.TabIndex = 5;
            cb_Cortana.Text = "Desinstalar Cortana";
            cb_Cortana.TextAlign = ContentAlignment.MiddleCenter;
            cb_Cortana.UseVisualStyleBackColor = true;
            // 
            // btn_innecesarias
            // 
            btn_innecesarias.Dock = DockStyle.Top;
            btn_innecesarias.Location = new Point(0, 191);
            btn_innecesarias.Margin = new Padding(3, 4, 3, 4);
            btn_innecesarias.Name = "btn_innecesarias";
            btn_innecesarias.Size = new Size(334, 53);
            btn_innecesarias.TabIndex = 6;
            btn_innecesarias.Text = "Aplicaciones Innecesarias";
            btn_innecesarias.UseVisualStyleBackColor = true;
            btn_innecesarias.Click += btn_innecesarias_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(51, 68, 89);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(334, 191);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // texto_info
            // 
            texto_info.BackColor = Color.FromArgb(242, 252, 255);
            texto_info.BorderStyle = BorderStyle.None;
            texto_info.Dock = DockStyle.Fill;
            texto_info.Location = new Point(355, 0);
            texto_info.Margin = new Padding(3, 4, 3, 4);
            texto_info.Multiline = true;
            texto_info.Name = "texto_info";
            texto_info.ReadOnly = true;
            texto_info.ScrollBars = ScrollBars.Vertical;
            texto_info.Size = new Size(673, 659);
            texto_info.TabIndex = 2;
            texto_info.TextChanged += texto_info_TextChanged;
            // 
            // enlace_github
            // 
            enlace_github.AutoSize = true;
            enlace_github.Location = new Point(871, 536);
            enlace_github.Name = "enlace_github";
            enlace_github.Size = new Size(135, 20);
            enlace_github.TabIndex = 3;
            enlace_github.TabStop = true;
            enlace_github.Text = "Sígueme en Github";
            enlace_github.LinkClicked += enlace_github_LinkClicked;
            // 
            // btn_optimizar
            // 
            btn_optimizar.BackColor = Color.FromArgb(28, 38, 48);
            btn_optimizar.Cursor = Cursors.Hand;
            btn_optimizar.Dock = DockStyle.Bottom;
            btn_optimizar.FlatAppearance.BorderSize = 0;
            btn_optimizar.FlatStyle = FlatStyle.Flat;
            btn_optimizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_optimizar.ForeColor = SystemColors.Window;
            btn_optimizar.Location = new Point(355, 559);
            btn_optimizar.Name = "btn_optimizar";
            btn_optimizar.Size = new Size(673, 100);
            btn_optimizar.TabIndex = 4;
            btn_optimizar.Text = "OPTIMIZAR";
            btn_optimizar.UseVisualStyleBackColor = false;
            btn_optimizar.Click += btn_optimizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 659);
            Controls.Add(btn_optimizar);
            Controls.Add(enlace_github);
            Controls.Add(texto_info);
            Controls.Add(panelLateral);
            MinimumSize = new Size(1046, 706);
            Name = "Form1";
            Text = "W11-Debloater";
            panelLateral.ResumeLayout(false);
            panel_privacidad.ResumeLayout(false);
            panel_privacidad.PerformLayout();
            panel_innecesarias.ResumeLayout(false);
            panel_innecesarias.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLateral;
        private Panel panelLogo;
        private CheckBox cb_OneDrive;
        private PictureBox pictureBox1;
        private TextBox texto_info;
        private CheckBox cb_Eltiempo;
        private CheckBox cb_Teams;
        private CheckBox cb_Cortana;
        private Button btn_innecesarias;
        private Panel panel_innecesarias;
        private CheckBox cb_CentroOpiniones;
        private CheckBox cb_Mapas;
        private CheckBox cb_News;
        private CheckBox cb_Office;
        private CheckBox cb_xbox;
        private CheckBox cb_solitario;
        private CheckBox cb_notas;
        private CheckBox cb_people;
        private Panel panel_privacidad;
        private CheckBox cb_diagnostico;
        private CheckBox cb_ubicacion;
        private Button btn_privacidad;
        private LinkLabel enlace_github;
        private CheckBox cb_sugerido;
        private CheckBox cb_consejos;
        private CheckBox cb_2plano;
        private Button btn_optimizar;
    }
}