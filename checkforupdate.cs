using Guna.UI2.WinForms;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roboping
{
    public partial class checkforupdate : Form
    {
        public static checkforupdate instance;
        public checkforupdate()
        {
            InitializeComponent();
            instance = this;
        }

        private void checkforupdate_Load(object sender, EventArgs e)
        {

        }

        private void DONE1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void showdialog2()
        {
            checkforupdate msg1 = new checkforupdate();
            msg1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2ProgressBar1.Visible = true;
            checkupdatetext.Text = "درحال دریافت نسخه جدید";

            string url = "https://roboping.ir/Roboping.zip";
            string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Roboping.zip";

            Console.WriteLine(downloadPath);

            using (HttpClient clientt = new HttpClient())
            {
                using (HttpResponseMessage responsee = await clientt.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    if (responsee.IsSuccessStatusCode)
                    {
                        using (Stream contentStream = await responsee.Content.ReadAsStreamAsync())
                        {
                            using (FileStream fileStream = File.Create(downloadPath))
                            {
                                // Get the total file size
                                long? contentLength = responsee.Content.Headers.ContentLength;

                                // Initialize variables for tracking progress
                                long totalBytesRead = 0;
                                byte[] buffer = new byte[8192]; // 8 KB buffer
                                int bytesRead;

                                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await Task.Run(() =>
                                    {
                                        //guna2Button1.Visible = false;
                                        guna2Button3.Invoke((Action)(() => { guna2Button3.Visible = false; }));
                                        //guna2Button3.Visible = false;
                                        guna2Button3.Invoke((Action)(() => { guna2Button3.Visible = false; }));
                                        // guna2Button2.Visible = true;
                                        // guna2Button2.Invoke((Action)(() => { guna2Button2.Visible = true; }));

                                        guna2Button2.Invoke((Action)(() => { guna2Button2.Visible = false; }));
                                    });

                                    await fileStream.WriteAsync(buffer, 0, bytesRead);

                                    // Update progress
                                    totalBytesRead += bytesRead;
                                    int progressPercentage = (int)((double)totalBytesRead / contentLength * 100);
                                    guna2ProgressBar1.Invoke(new MethodInvoker(() => guna2ProgressBar1.Value = progressPercentage));
                                }

                                fileStream.Close();
                                contentStream.Close();
                                await Task.Delay(2000);
                                checkupdatetext.Text = "نسخه جدید دریافت شد";
                                await Task.Delay(2000);
                                //await Task.Delay(2000);

                               // Main.instance.SessionStop();

                                checkupdatetext.Text = "در حال نصب نسخه جدید";

                                string downloadPath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                                string zipFilePath = Path.Combine(downloadPath1, "Roboping.zip");
                                string msiFilePath = Path.Combine(downloadPath1, "Roboping.msi");

                                try
                                {
                                    using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                                    {
                                        foreach (ZipArchiveEntry entry in archive.Entries)
                                        {
                                            entry.ExtractToFile(Path.Combine(downloadPath1, entry.FullName), true);
                                        }
                                    }

                                    // Run the MSI file in quiet mode without any UI
                                    ProcessStartInfo msiProcessInfo = new ProcessStartInfo
                                    {
                                        FileName = "msiexec",
                                        Arguments = $"/i \"{msiFilePath}\" /qn",  // /i - install, /qn - quiet (no UI)
                                        UseShellExecute = false,
                                        CreateNoWindow = true
                                    };

                                    Process msiProcess = Process.Start(msiProcessInfo);
                                    // msiProcess.WaitForExit();

                                    //label1.Text = "Closing App";
                                    /*
                                    try
                                    {
                                        string username = Main.instance.guna2HtmlLabel1.Text;

                                        client = new TcpClient(server, port);
                                        stream = client.GetStream();

                                        // Send username and "stop" signal to the server
                                        string message = username + "|stop";
                                        byte[] data = Encoding.UTF8.GetBytes(message);
                                        stream.Write(data, 0, data.Length);

                                        //MessageBox.Show("Stop signal sent to the server for user: " + username);
                                    }
                                    catch (Exception)
                                    {

                                        guna2Button1.Invoke((Action)(() => { guna2Button1.Visible = true; }));

                                        guna2Button3.Invoke((Action)(() => { guna2Button3.Visible = false; }));

                                        guna2Button2.Invoke((Action)(() => { guna2Button2.Visible = false; }));

                                        guna2Button4.Invoke((Action)(() => { guna2Button4.Visible = false; }));

                                    }
                                    finally
                                    {
                                        stream?.Close();
                                        client?.Close();
                                    }
                                    */
                                    checkupdatetext.Text = "در حال نصب نسخه جدید";

                                    await Task.Delay(4000);

                                    Environment.Exit(1);

                                    await Task.Run(() =>
                                    {
                                        //guna2Button1.Visible = false;
                                        guna2Button3.Invoke((Action)(() => { guna2Button3.Visible = false; }));
                                        //guna2Button3.Visible = false;
                                        guna2Button3.Invoke((Action)(() => { guna2Button3.Visible = false; }));
                                        // guna2Button2.Visible = true;
                                        guna2Button2.Invoke((Action)(() => { guna2Button2.Visible = false; }));

                                        guna2Button4.Invoke((Action)(() => { guna2Button4.Visible = true; }));
                                    });
                                }
                                catch (Exception)
                                {
                                    checkupdatetext.Text = "لطفا دوباره تلاش کنید";

                                    Console.WriteLine("توی نصب آپدیتم مشکلی هست به پشتیبانی خبر بده");

                                    guna2Button3.Visible = true;

                                    guna2Button3.Visible = false;

                                    guna2Button2.Visible = false;

                                    guna2Button4.Visible = false;


                                }

                            }
                        }
                    }
                    else
                    {
                        guna2Button3.Visible = true;

                        guna2Button3.Visible = false;

                        guna2Button2.Visible = false;

                        guna2Button4.Visible = false;


                        Console.WriteLine("توی دریافت آپدیتم مشکلی هست به پشتیبانی خبر بده");
                        checkupdatetext.Text = "توی دریافت آپدیتم مشکلی هست به پشتیبانی خبر بده";
                    }
                }
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
