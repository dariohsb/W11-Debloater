$onedriveProcess = Get-Process -Name "OneDrive" -ErrorAction SilentlyContinue
if ($onedriveProcess) {
    Stop-Process -Name "OneDrive" -Force
}

& "$env:SystemRoot\System32\OneDriveSetup.exe" /uninstall

Start-Sleep -Seconds 3

Remove-Item "$env:SystemRoot\SysWOW64\OneDriveSetup.exe" -ErrorAction SilentlyContinue
Remove-Item "$env:ProgramData\Microsoft OneDrive" -Recurse -ErrorAction SilentlyContinue
Remove-Item "$env:ProgramFiles\Microsoft OneDrive" -Recurse -ErrorAction SilentlyContinue
Remove-Item "$env:ProgramFiles(x86)\Microsoft OneDrive" -Recurse -ErrorAction SilentlyContinue
Remove-Item "$env:UserProfile\AppData\Local\Microsoft\OneDrive" -Recurse -ErrorAction SilentlyContinue
Remove-Item "$env:UserProfile\AppData\Roaming\Microsoft\OneDrive" -Recurse -ErrorAction SilentlyContinue