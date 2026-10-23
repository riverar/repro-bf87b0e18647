// Add a dummy value to the backing registry key
// reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\COAWOS\PowerGrid" /v Repro /t REG_DWORD /d 1 /f

// Run this sample.

Windows.Devices.Power.PowerGridForecast.ForecastUpdated += (s, e) => { };
Thread.Sleep(Timeout.Infinite);

// Update the dummy value to trigger the registry listener
// reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\COAWOS\PowerGrid" /v Repro /t REG_DWORD /d 2 /f

