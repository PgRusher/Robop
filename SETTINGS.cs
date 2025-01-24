using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Roboping
{
    public partial class SETTINGS : UserControl
    {
        public static SETTINGS instance;
        private ERROR eror;
        private checkforupdate checkforupdate;
        public SETTINGS()
        {

            InitializeComponent();
            instance = this;
            eror = new ERROR();
            checkforupdate = new checkforupdate();
        }

        private void SETTINGS_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
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

            Invoke(new MethodInvoker(delegate
            {
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        // Prepare the data to send to the server
                        string version = Main.instance.version.Text; // Replace this with actual version
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

                        if (response.StartsWith("Client"))
                        {
                            Invoke(new MethodInvoker(delegate
                            {
                                eror.showdialog();
                                ERROR.instance.errortext.Text = "آخرین ورژنمو دارم نیاز به آپدیتم نیست";
                            }));
                        }
                        else
                        {
                            Invoke(new MethodInvoker(delegate
                            {
                                checkforupdate.showdialog2();
                                checkforupdate.instance.checkupdatetext.Text = "یه آپدیت جدیدی از من اومده میخوای بروزرسانیم کنی ؟";
                            }));
                        }
                    }
                    catch (Exception)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            // MessageBox.Show("Cannot get access to server side ");
                            eror.showdialog();

                            ERROR.instance.errortext.Text = "یه جای کار میلنگه به پشتیبانی بگو";

                            Console.WriteLine("یه جای کار میلنگه به پشتیبانی بگو");
                        }));
                    }
                }
            }));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string url = "https://roboping.ir";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/Roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/nJF6twdEkm";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.goftino.com/c/UP3DN7";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string url = "https://www.aparat.com/Roboping";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                Invoke(new MethodInvoker(delegate
                {
                    eror.showdialog();
                    ERROR.instance.errortext.Text = "صفحه مورد نظر پیدا نشد";
                }));
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
    }
}
