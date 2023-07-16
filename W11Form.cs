using System.Diagnostics;
using System.Text;

namespace W11_Debloater
{
    public partial class W11Form : Form
    {
        public W11Form()
        {
            InitializeComponent();

            if (!Directory.Exists("Mods"))
            {
                MessageBox.Show("La carpeta 'Mods' no existe en el directorio actual. Te recomiendo descargarlo de nuevo en Github", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void texto_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_optimizar_Click(object sender, EventArgs e)
        {
            StringBuilder comandos = new StringBuilder();
            List<string> scripts = new List<string> { };
            texto_info.Text = string.Empty;
            if (cb_OneDrive.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Parando el proceso de Microsoft OneDrive...");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando OneDrive...");
                scripts.Add("onedrive.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Eltiempo.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando El Tiempo...");
                scripts.Add("eltiempo.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Teams.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft Teams...");
                scripts.Add("teams.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Cortana.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Cortana...");
                scripts.Add("cortana.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_CentroOpiniones.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Centro de Opiniones...");
                scripts.Add("opiniones.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Mapas.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Mapas...");
                scripts.Add("mapas.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_News.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft News...");
                scripts.Add("news.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Office.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft Office...");
                scripts.Add("office.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_xbox.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Xbox...");
                scripts.Add("xbox.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_solitario.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando el juego Solitario...");
                scripts.Add("solitario.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_notas.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Notas Rápidas...");
                scripts.Add("notas.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_people.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft People...");
                scripts.Add("people.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_diagnostico.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando datos de diagnóstico...");
                scripts.Add("diagnostico.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_ubicacion.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando rastreos de ubicación...");
                scripts.Add("ubicacion.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_sugerido.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando contenido sugerido...");
                scripts.Add("sugerido.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_consejos.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando consejos de windows...");
                scripts.Add("consejos.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_2plano.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Deshabilitando aplicaciones en segundo plano...");
                scripts.Add("2plano.ps1");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (scripts.Count > 0)
            {
                ejecutarScripts(scripts);
            }
            else
            {
                texto_info.Text = "Debes marcar al menos una casilla";
            }
        }
        private void ejecutarScripts(List<string> scripts)
        {
            StringBuilder scriptBuilder = new StringBuilder();
            foreach (var archivo in scripts)
            {
                string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods", archivo);
                scriptBuilder.Append(System.IO.File.ReadAllText(scriptPath));
                scriptBuilder.Append("\n");
            }

            string tempScriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods", "scriptTemporal.ps1");
            System.IO.File.WriteAllText(tempScriptPath, scriptBuilder.ToString());

            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";

            process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{tempScriptPath}\"";

            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;

            process.Start();
            process.WaitForExit();

            System.IO.File.Delete(tempScriptPath);
        }

        private void btn_innecesarias_Click(object sender, EventArgs e)
        {
            if (panel_privacidad.Visible)
            {
                panel_privacidad.Visible = false;
            }

            if (panel_innecesarias.Visible)
            {
                panel_innecesarias.Visible = false;
            }
            else
            {
                panel_innecesarias.Visible = true;
            }
        }

        private void btn_privacidad_Click(object sender, EventArgs e)
        {
            if (panel_innecesarias.Visible)
            {
                panel_innecesarias.Visible = false;
            }

            if (panel_privacidad.Visible)
            {
                panel_privacidad.Visible = false;
            }
            else
            {
                panel_privacidad.Visible = true;
            }
        }

        private void enlace_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/cipotemanx/W11-Debloater";
            Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
        }
    }
}