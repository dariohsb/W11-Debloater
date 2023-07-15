using System.Diagnostics;

namespace W11_Debloater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btn_analizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_optimizar_Click(object sender, EventArgs e)
        {
            texto_info.Text = string.Empty;
            if (cb_OneDrive.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Parando el proceso de Microsoft OneDrive...");
                kill_OneDrive();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando OneDrive...");
                eliminar_OneDrive();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Eltiempo.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando El Tiempo...");
                eliminar_eltiempo();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Teams.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft Teams...");
                eliminar_Teams();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Cortana.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Cortana...");
                eliminar_cortana();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_CentroOpiniones.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Centro de Opiniones...");
                eliminar_CentroOpiniones();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Mapas.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Mapas...");
                eliminar_Mapas();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_News.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft News...");
                eliminar_News();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_Office.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft Office...");
                eliminar_Office();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_xbox.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Xbox...");
                eliminar_xbox();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_solitario.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando el juego Solitario...");
                eliminar_solitario();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_notas.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Notas Rápidas...");
                eliminar_notas();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_people.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Desinstalando Microsoft People...");
                eliminar_people();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_diagnostico.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando datos de diagnóstico...");
                eliminar_diagnostico();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
            if (cb_ubicacion.Checked)
            {
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Eliminando rastreos de ubicación...");
                eliminar_ubicacion();
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("---------------------------------------------");
            }
        }
        private void kill_OneDrive()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "-command \"& {taskkill /f /im OneDrive.exe}\"";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar_OneDrive()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "& \"" + Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\OneDriveSetup.exe\" /uninstall";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("OneDrive desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar OneDrive");
            }
        }

        private void eliminar_eltiempo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "-command \"& {Get-AppxPackage Microsoft.BingWeather | Remove-AppxPackage}\"";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("El Tiempo desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar El Tiempo");
            }
        }
        private void eliminar_cortana()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage -allusers Microsoft.549981C3F5F10 | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Cortana desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar cortana");
            }
        }
        private void eliminar_Teams()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage MicrosoftTeams * | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Microsoft Teams desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Teams");
            }
        }

        private void eliminar_CentroOpiniones()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage *Microsoft.WindowsFeedbackHub* | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Centro de Opiniones desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Centro de Opiniones");
            }
        }

        private void eliminar_Mapas()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage *windowsmaps* | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Mapas desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Mapas");
            }
        }

        private void eliminar_News()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.BingNews | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Microsoft News desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Microsoft News");
            }
        }
        private void eliminar_Office()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.MicrosoftOfficeHub | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Microsoft Office desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Microsoft Office");
            }
        }

        private void eliminar_xbox()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.Xbox.TCUI | Remove-AppxPackage & Get-AppxPackage Microsoft.XboxGameOverlay | Remove-AppxPackage & Get-AppxPackage Microsoft.XboxGamingOverlay | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Componentes Xbox desinstalados con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar los componentes de Xbox");
            }
        }

        private void eliminar_solitario()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.MicrosoftSolitaireCollection | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Juego Solitario desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar el Solitario");
            }
        }

        private void eliminar_notas()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.MicrosoftStickyNotes | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Sticky Notes desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Sticky Notes");
            }
        }

        private void eliminar_people()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Get-AppxPackage Microsoft.People | Remove-AppxPackage";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Microsoft People desinstalado con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al desinstalar Microsoft People");
            }
        }

        private void eliminar_diagnostico()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Set-ItemProperty -Path \'HKLM:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\' -Name \'AllowTelemetry\' -Value 0";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Datos de diagnóstico eliminados con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al eliminar los datos de diagnóstico");
            }
        }

        private void eliminar_ubicacion()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            startInfo.Arguments = "Set-Location -Path \'HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}\' -Name \'SensorPermissionState\' -Value 0";
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Rastreos de ubicación eliminados con éxito");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                texto_info.AppendText(Environment.NewLine);
                texto_info.AppendText("Error al eliminar los rastreos de ubicación");
            }
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

    }
}