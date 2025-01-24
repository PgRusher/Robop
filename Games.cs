using NAudio.Wave;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Roboping
{
    public partial class Games : UserControl
    {
        public static Games instance;

        private SETTINGS setting;
        private about about;


        System.Drawing.Bitmap arenalogo = Properties.Resources.arena;
        System.Drawing.Bitmap bfvlogo = Properties.Resources.bfv;
        System.Drawing.Bitmap aralogo = Properties.Resources.ara;
        System.Drawing.Bitmap apexlogo = Properties.Resources.apex;
        System.Drawing.Bitmap bf1logo = Properties.Resources.bf1;
        System.Drawing.Bitmap bf2042logo = Properties.Resources.bf2042;
        System.Drawing.Bitmap bf3logo = Properties.Resources.bf3;
        System.Drawing.Bitmap bf4logo = Properties.Resources.bf4;
        System.Drawing.Bitmap chiv2logo = Properties.Resources.chiv2;
        System.Drawing.Bitmap ck3logo = Properties.Resources.ck3;
        System.Drawing.Bitmap conanlogo = Properties.Resources.conan;
        System.Drawing.Bitmap valorantlogo = Properties.Resources.valorant;
        System.Drawing.Bitmap ageofmythologylogo = Properties.Resources.ageofmythology1;
        System.Drawing.Bitmap cs2logo = Properties.Resources.cs2;
        System.Drawing.Bitmap dayzlogo = Properties.Resources.dayz;
        System.Drawing.Bitmap deltaforcelogo = Properties.Resources.deltaforce;
        System.Drawing.Bitmap discordlogo = Properties.Resources.discord1;
        System.Drawing.Bitmap dota2logo = Properties.Resources.dota2;
        System.Drawing.Bitmap ealogo = Properties.Resources.ea;
        System.Drawing.Bitmap epiclogo = Properties.Resources.epic;
        System.Drawing.Bitmap fortnitelogo = Properties.Resources.fortnite;
        System.Drawing.Bitmap esologo = Properties.Resources.eso;
        System.Drawing.Bitmap eu4logo = Properties.Resources.eu4;
        System.Drawing.Bitmap faceitlogo = Properties.Resources.faceit;
        System.Drawing.Bitmap fifa23logo = Properties.Resources.fifa23;
        System.Drawing.Bitmap fc24logo = Properties.Resources.fc24;
        System.Drawing.Bitmap fc25logo = Properties.Resources.fc25;
        System.Drawing.Bitmap fivemlogo = Properties.Resources.fivem;
        System.Drawing.Bitmap hoi4logo = Properties.Resources.hoi4;
        System.Drawing.Bitmap offthegridlogo = Properties.Resources.offthegrid;
        System.Drawing.Bitmap thefinalslogo = Properties.Resources.the_finals;
        System.Drawing.Bitmap victoria3logo = Properties.Resources.victorya3;
        System.Drawing.Bitmap forhonorlogo = Properties.Resources.forhonor;
        System.Drawing.Bitmap forza5logo = Properties.Resources.forza5;
        System.Drawing.Bitmap genshinlogo = Properties.Resources.genshin;
        System.Drawing.Bitmap gtavlogo = Properties.Resources.gtav;
        System.Drawing.Bitmap huntshowdownlogo = Properties.Resources.huntshowdown;
        System.Drawing.Bitmap koh2logo = Properties.Resources.koh2;
        System.Drawing.Bitmap lollogo = Properties.Resources.lol;
        System.Drawing.Bitmap multiversuslogo = Properties.Resources.multiversus;
        System.Drawing.Bitmap narakalogo = Properties.Resources.naraka;
        System.Drawing.Bitmap newworldlogo = Properties.Resources.newworld;
        System.Drawing.Bitmap oncehumanlogo = Properties.Resources.oncehuman;
        System.Drawing.Bitmap overwatch2logo = Properties.Resources.overwatch2;
        System.Drawing.Bitmap pubglogo = Properties.Resources.pubg;
        System.Drawing.Bitmap ragelogo = Properties.Resources.rage;
        System.Drawing.Bitmap raidshadowlegendlogo = Properties.Resources.raidshadowlegend;
        System.Drawing.Bitmap rdr2logo = Properties.Resources.rdr2;
        System.Drawing.Bitmap rocketleaguelogo = Properties.Resources.rocketleague;
        System.Drawing.Bitmap scumlogo = Properties.Resources.scum;
        System.Drawing.Bitmap sealogo = Properties.Resources.sea;
        System.Drawing.Bitmap spacemarine2logo = Properties.Resources.spacemarine2;
        System.Drawing.Bitmap squadlogo = Properties.Resources.squad;
        System.Drawing.Bitmap starcitizenlogo = Properties.Resources.starcitizen;
        System.Drawing.Bitmap warframelogo = Properties.Resources.warframe;
        System.Drawing.Bitmap wowlogo = Properties.Resources.wow;
        System.Drawing.Bitmap xdefiantlogo = Properties.Resources.xdefiant;
        System.Drawing.Bitmap r6logo = Properties.Resources.r6;
        System.Drawing.Bitmap nvidialogo = Properties.Resources.nvidia;
        System.Drawing.Bitmap fs22logo = Properties.Resources.fs22;
        System.Drawing.Bitmap ubisoftlogo = Properties.Resources.ubisoft;
        System.Drawing.Bitmap xboxlogo = Properties.Resources.Xbox;
        System.Drawing.Bitmap cod6logo = Properties.Resources.codbo6;
        System.Drawing.Bitmap codwarzonelogo = Properties.Resources.call_of_duty_warzone;
        System.Drawing.Bitmap battlenetlogo = Properties.Resources.battlenet;
        System.Drawing.Bitmap marvelrivalslogo = Properties.Resources.backmarvel;
        System.Drawing.Bitmap spotifylogo = Properties.Resources.Spotifyback;
        System.Drawing.Bitmap age4logo = Properties.Resources.age4back;
        System.Drawing.Bitmap coh2logo = Properties.Resources.coh2back;
        System.Drawing.Bitmap coh3logo = Properties.Resources.coh3back;
        System.Drawing.Bitmap darkanddarkerlogo = Properties.Resources.darkanddarkerback;
        System.Drawing.Bitmap destiny2logo = Properties.Resources.Destiny2back;
        System.Drawing.Bitmap helldiver2logo = Properties.Resources.helldivers2back;
        System.Drawing.Bitmap lostarklogo = Properties.Resources.lostarkback;
        System.Drawing.Bitmap steeldivision2logo = Properties.Resources.steeldivision2back;
        System.Drawing.Bitmap lotronlinelogo = Properties.Resources.lotronlineback;
        System.Drawing.Bitmap throneandlibertylogo = Properties.Resources.throneandlibertyback;
        System.Drawing.Bitmap threekingdomlogo = Properties.Resources.threekingdomback;
        System.Drawing.Bitmap warhammer3logo = Properties.Resources.twwarhammer3back;
        System.Drawing.Bitmap vrchatlogo = Properties.Resources.vrchatback;
        System.Drawing.Bitmap efootballlogo = Properties.Resources.efootballback;
        System.Drawing.Bitmap amonguslogo = Properties.Resources.amongus;
        System.Drawing.Bitmap deadbydaylight2logo = Properties.Resources.deadbydaylightback;
        System.Drawing.Bitmap deadlocklogo = Properties.Resources.deadlockback;
        System.Drawing.Bitmap insurgencysandstormlogo = Properties.Resources.insurgencysandstormback;
        System.Drawing.Bitmap warthunderlogo = Properties.Resources.warthunderback;
        System.Drawing.Bitmap paladinslogo = Properties.Resources.Paladinsback;
        System.Drawing.Bitmap readyornotlogo = Properties.Resources.readyornotback;
        System.Drawing.Bitmap mythofempireslogo = Properties.Resources.mythofempiresback;
        System.Drawing.Bitmap predecessorlogo = Properties.Resources.Predecessorback;
        System.Drawing.Bitmap unturnedlogo = Properties.Resources.unturnedback;
        System.Drawing.Bitmap rustlogo = Properties.Resources.rustback;
        System.Drawing.Bitmap truckersmplogo = Properties.Resources.truckersmpback;
        System.Drawing.Bitmap hellletlooselogo = Properties.Resources.hellletloose;
        System.Drawing.Bitmap pathofexile2logo = Properties.Resources.pathofexile2back;
        System.Drawing.Bitmap stateofdecay2logo = Properties.Resources.stateofdecay2back;
        System.Drawing.Bitmap phasmophobialogo = Properties.Resources.phasmophobiaback;
        System.Drawing.Bitmap fallguyslogo = Properties.Resources.fallguysback;

        public Games()
        {
            InitializeComponent();

            setting = new SETTINGS();

            about = new about();

            instance = this;

        }

        private void gameslibrarysound()
        {
            waveOut = new WaveOut();

            reader = new AudioFileReader(@"Games.mp3"); // Update the path to your MP3 file

            waveOut.Init(reader);

            waveOut.Play();
        }

        private void guna2GradientPanel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private IWavePlayer waveOut;

        private AudioFileReader reader;

        private void Games_Load(object sender, EventArgs e)
        {
            // Load the saved state of the checkbox

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void farmingsimulator2022_Click_1(object sender, EventArgs e)
        {
            if (farmingsimulator2022.Checked)
            {
                Main.instance.label16.Text = "Farming Simulator 2022";

                Main.instance.changedpanel.BackgroundImage = fs22logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void offthegrid_Click_1(object sender, EventArgs e)
        {
            if (offthegrid.Checked)
            {
                Main.instance.label16.Text = "Off The Grid";

                Main.instance.changedpanel.BackgroundImage = offthegridlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void victoria3_Click_1(object sender, EventArgs e)
        {
            if (victoria3.Checked)
            {
                Main.instance.label16.Text = "Victoria 3";

                Main.instance.changedpanel.BackgroundImage = victoria3logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void eu4_Click_1(object sender, EventArgs e)
        {
            if (eu4.Checked)
            {
                Main.instance.label16.Text = "Europa Universalis IV";

                Main.instance.changedpanel.BackgroundImage = eu4logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void hoi4_Click_1(object sender, EventArgs e)
        {
            if (hoi4.Checked)
            {
                Main.instance.label16.Text = "Hearts of Iron IV";

                Main.instance.changedpanel.BackgroundImage = hoi4logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void xdefiant_Click_1(object sender, EventArgs e)
        {
            if (xdefiant.Checked)
            {
                Main.instance.label16.Text = "Xdefiant";

                Main.instance.changedpanel.BackgroundImage = xdefiantlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void worldofwarcraft_Click_1(object sender, EventArgs e)
        {
            if (worldofwarcraft.Checked)
            {
                Main.instance.label16.Text = "World of Warcraft";

                Main.instance.changedpanel.BackgroundImage = wowlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void warframe_Click_1(object sender, EventArgs e)
        {
            if (warframe.Checked)
            {
                Main.instance.label16.Text = "Warframe";

                Main.instance.changedpanel.BackgroundImage = warframelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void valorant_Click_1(object sender, EventArgs e)
        {
            if (valorant.Checked)
            {
                Main.instance.label16.Text = "Valorant";

                Main.instance.changedpanel.BackgroundImage = valorantlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void xbox_Click_1(object sender, EventArgs e)
        {
            if (xbox.Checked)
            {
                Main.instance.label16.Text = "Xbox App";

                Main.instance.changedpanel.BackgroundImage = xboxlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void nvidia_Click(object sender, EventArgs e)
        {
            if (nvidia.Checked)
            {
                Main.instance.label16.Text = "Nvidia";

                Main.instance.changedpanel.BackgroundImage = nvidialogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void rage_Click_1(object sender, EventArgs e)
        {
            if (rage.Checked)
            {
                Main.instance.label16.Text = "Rage";

                Main.instance.changedpanel.BackgroundImage = ragelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void faceit_Click_1(object sender, EventArgs e)
        {
            if (faceit.Checked)
            {
                Main.instance.label16.Text = "FACEIT";

                Main.instance.changedpanel.BackgroundImage = faceitlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fivem_Click_1(object sender, EventArgs e)
        {
            if (fivem.Checked)
            {
                Main.instance.label16.Text = "Fivem";

                Main.instance.changedpanel.BackgroundImage = fivemlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void Ubisoft_Click_1(object sender, EventArgs e)
        {
            if (Ubisoft.Checked)
            {
                Main.instance.label16.Text = "Ubisoft";

                Main.instance.changedpanel.BackgroundImage = ubisoftlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void epicgames_Click(object sender, EventArgs e)
        {
            if (epicgames.Checked)
            {
                Main.instance.label16.Text = "Epic Games";

                Main.instance.changedpanel.BackgroundImage = epiclogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void eaapp_Click_1(object sender, EventArgs e)
        {
            if (eaapp.Checked)
            {
                Main.instance.label16.Text = "EA App";

                Main.instance.changedpanel.BackgroundImage = ealogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void discord_Click(object sender, EventArgs e)
        {
            if (discord.Checked)
            {
                Main.instance.label16.Text = "Discord";

                Main.instance.changedpanel.BackgroundImage = discordlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void thefinals_Click_1(object sender, EventArgs e)
        {
            if (thefinals.Checked)
            {
                Main.instance.label16.Text = "The Finals";

                Main.instance.changedpanel.BackgroundImage = thefinalslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void seaofthieves_Click_1(object sender, EventArgs e)
        {
            if (seaofthieves.Checked)
            {
                Main.instance.label16.Text = "Sea of Thieves";

                Main.instance.changedpanel.BackgroundImage = sealogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void starcitizen_Click_1(object sender, EventArgs e)
        {
            if (starcitizen.Checked)
            {
                Main.instance.label16.Text = "Star Citizen";

                Main.instance.changedpanel.BackgroundImage = starcitizenlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void squad_Click_1(object sender, EventArgs e)
        {
            if (squad.Checked)
            {
                Main.instance.label16.Text = "Squad";

                Main.instance.changedpanel.BackgroundImage = squadlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void spacemarine2_Click_1(object sender, EventArgs e)
        {
            if (spacemarine2.Checked)
            {
                Main.instance.label16.Text = "Space Marine 2";

                Main.instance.changedpanel.BackgroundImage = spacemarine2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void scum_Click_1(object sender, EventArgs e)
        {
            if (scum.Checked)
            {
                Main.instance.label16.Text = "Scum";

                Main.instance.changedpanel.BackgroundImage = scumlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void rocketleague_Click_1(object sender, EventArgs e)
        {
            if (rocketleague.Checked)
            {
                Main.instance.label16.Text = "Rocket League";

                Main.instance.changedpanel.BackgroundImage = rocketleaguelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void raidshadowlegends_Click_1(object sender, EventArgs e)
        {
            if (raidshadowlegends.Checked)
            {
                Main.instance.label16.Text = "Raid Shadow Legends";

                Main.instance.changedpanel.BackgroundImage = raidshadowlegendlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void reddeadredemption_Click_1(object sender, EventArgs e)
        {
            if (reddeadredemption.Checked)
            {
                Main.instance.label16.Text = "Read Dead Online";

                Main.instance.changedpanel.BackgroundImage = rdr2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void rainbowsixsiege_Click_1(object sender, EventArgs e)
        {
            if (rainbowsixsiege.Checked)
            {
                Main.instance.label16.Text = "Rainbow Six Siege";

                Main.instance.changedpanel.BackgroundImage = r6logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void pubgbattlegrounds_Click_1(object sender, EventArgs e)
        {
            if (pubgbattlegrounds.Checked)
            {
                Main.instance.label16.Text = "PUBG";

                Main.instance.changedpanel.BackgroundImage = pubglogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void overwatch2_Click_1(object sender, EventArgs e)
        {
            if (overwatch2.Checked)
            {
                Main.instance.label16.Text = "Overwatch 2";

                Main.instance.changedpanel.BackgroundImage = overwatch2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void oncehuman_Click_1(object sender, EventArgs e)
        {
            if (oncehuman.Checked)
            {
                Main.instance.label16.Text = "Once Human";

                Main.instance.changedpanel.BackgroundImage = oncehumanlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void newworld_Click_1(object sender, EventArgs e)
        {
            if (newworld.Checked)
            {
                Main.instance.label16.Text = "New World";

                Main.instance.changedpanel.BackgroundImage = newworldlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void narakabladepoint_Click_1(object sender, EventArgs e)
        {
            if (narakabladepoint.Checked)
            {
                Main.instance.label16.Text = "Naraka Bladepoint";

                Main.instance.changedpanel.BackgroundImage = narakalogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void multiversus_Click_1(object sender, EventArgs e)
        {
            if (multiversus.Checked)
            {
                Main.instance.label16.Text = "Multiversus";

                Main.instance.changedpanel.BackgroundImage = multiversuslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void leagueoflegends_Click_1(object sender, EventArgs e)
        {
            if (leagueoflegends.Checked)
            {
                Main.instance.label16.Text = "League of legends";

                Main.instance.changedpanel.BackgroundImage = lollogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void knightsofhonor_Click_1(object sender, EventArgs e)
        {
            if (knightsofhonor.Checked)
            {
                Main.instance.label16.Text = "Knights of Honor";

                Main.instance.changedpanel.BackgroundImage = koh2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void huntshowdown_Click_1(object sender, EventArgs e)
        {
            if (huntshowdown.Checked)
            {
                Main.instance.label16.Text = "Hunt Showdown";

                Main.instance.changedpanel.BackgroundImage = huntshowdownlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void genshinimpact_Click_1(object sender, EventArgs e)
        {
            if (genshinimpact.Checked)
            {
                Main.instance.label16.Text = "Genshin Impact";

                Main.instance.changedpanel.BackgroundImage = genshinlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void gtavgrandtheftautov_Click_1(object sender, EventArgs e)
        {
            if (gtavgrandtheftautov.Checked)
            {
                Main.instance.label16.Text = "Grand Theft Auto V";

                Main.instance.changedpanel.BackgroundImage = gtavlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fifa23_Click_1(object sender, EventArgs e)
        {
            if (fifa23.Checked)
            {
                Main.instance.label16.Text = "FIFA 23";

                Main.instance.changedpanel.BackgroundImage = fifa23logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fc25_Click_1(object sender, EventArgs e)
        {
            if (fc25.Checked)
            {
                Main.instance.label16.Text = "FC 25";

                Main.instance.changedpanel.BackgroundImage = fc25logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fc24_Click_1(object sender, EventArgs e)
        {
            if (fc24.Checked)
            {
                Main.instance.label16.Text = "FC 24";

                Main.instance.changedpanel.BackgroundImage = fc24logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void forhonor_Click_1(object sender, EventArgs e)
        {
            if (forhonor.Checked)
            {
                Main.instance.label16.Text = "For Honor";

                Main.instance.changedpanel.BackgroundImage = forhonorlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fortnite_Click_1(object sender, EventArgs e)
        {
            if (fortnite.Checked)
            {
                Main.instance.label16.Text = "Fortnite";

                Main.instance.changedpanel.BackgroundImage = fortnitelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void forzahorizen5_Click_1(object sender, EventArgs e)
        {
            if (forzahorizen5.Checked)
            {
                Main.instance.label16.Text = "Forza Horizen 5";

                Main.instance.changedpanel.BackgroundImage = forza5logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void elderscrollsonline_Click_1(object sender, EventArgs e)
        {
            if (elderscrollsonline.Checked)
            {
                Main.instance.label16.Text = "Elder Scrolls Online";

                Main.instance.changedpanel.BackgroundImage = esologo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void dota2_Click_1(object sender, EventArgs e)
        {
            if (dota2.Checked)
            {
                Main.instance.label16.Text = "Dota 2";

                Main.instance.changedpanel.BackgroundImage = dota2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void dayz_Click_1(object sender, EventArgs e)
        {
            if (dayz.Checked)
            {
                Main.instance.label16.Text = "Dayz";

                Main.instance.changedpanel.BackgroundImage = dayzlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void deltaforce_Click_1(object sender, EventArgs e)
        {
            if (deltaforce.Checked)
            {
                Main.instance.label16.Text = "Delta Force";

                Main.instance.changedpanel.BackgroundImage = deltaforcelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void crusaderkings3_Click_1(object sender, EventArgs e)
        {
            if (crusaderkings3.Checked)
            {
                Main.instance.label16.Text = "Crusader Kings 3";

                Main.instance.changedpanel.BackgroundImage = ck3logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void counterstrike2_Click_1(object sender, EventArgs e)
        {
            if (counterstrike2.Checked)
            {
                Main.instance.label16.Text = "Counter Strike 2";

                Main.instance.changedpanel.BackgroundImage = cs2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void conanexiles_Click_1(object sender, EventArgs e)
        {
            if (conanexiles.Checked)
            {
                Main.instance.label16.Text = "Conan Exiles";

                Main.instance.changedpanel.BackgroundImage = conanlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void chivalry2_Click_1(object sender, EventArgs e)
        {
            if (chivalry2.Checked)
            {
                Main.instance.label16.Text = "Chivalry 2";

                Main.instance.changedpanel.BackgroundImage = chiv2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void battlefield2042_Click_1(object sender, EventArgs e)
        {
            if (battlefield2042.Checked)
            {
                Main.instance.label16.Text = "Battlefield 2042";

                Main.instance.changedpanel.BackgroundImage = bf2042logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void battlefieldv_Click(object sender, EventArgs e)
        {
            if (battlefieldv.Checked)
            {
                Main.instance.label16.Text = "Battlefield V";

                Main.instance.changedpanel.BackgroundImage = bfvlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void battlefield1_Click_1(object sender, EventArgs e)
        {
            if (battlefield1.Checked)
            {
                Main.instance.label16.Text = "Battlefield 1";

                Main.instance.changedpanel.BackgroundImage = bf1logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void battlefield4_Click_1(object sender, EventArgs e)
        {
            if (battlefield4.Checked)
            {
                Main.instance.label16.Text = "Battlefield 4";

                Main.instance.changedpanel.BackgroundImage = bf4logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void battlefield3_Click_1(object sender, EventArgs e)
        {
            if (battlefield3.Checked)
            {
                Main.instance.label16.Text = "Battlefield 3";

                Main.instance.changedpanel.BackgroundImage = bf3logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void ageofmythology_Click_1(object sender, EventArgs e)
        {
            if (ageofmythology.Checked)
            {
                Main.instance.label16.Text = "Age of Mythology";

                Main.instance.changedpanel.BackgroundImage = ageofmythologylogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void apex_Click_1(object sender, EventArgs e)
        {
            if (apex.Checked)
            {
                Main.instance.label16.Text = "Apex";

                Main.instance.changedpanel.BackgroundImage = apexlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void arahistoryuntold_Click_1(object sender, EventArgs e)
        {
            if (arahistoryuntold.Checked)
            {
                Main.instance.label16.Text = "Ara History Untold";

                Main.instance.changedpanel.BackgroundImage = aralogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void arenabreakout_Click(object sender, EventArgs e)
        {
            if (arenabreakout.Checked)
            {
                Main.instance.label16.Text = "Arena Breakout";

                Main.instance.changedpanel.BackgroundImage = arenalogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void cod6_Click(object sender, EventArgs e)
        {
            if (cod6.Checked)
            {
                Main.instance.label16.Text = "Call of Duty Black Ops 6";

                Main.instance.changedpanel.BackgroundImage = cod6logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void battlenet_Click(object sender, EventArgs e)
        {
            if (battlenet.Checked)
            {
                Main.instance.label16.Text = "Battlenet";

                Main.instance.changedpanel.BackgroundImage = battlenetlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void codwarzone_Click(object sender, EventArgs e)
        {
            if (codwarzone.Checked)
            {
                Main.instance.label16.Text = "Call of Duty Warzone";

                Main.instance.changedpanel.BackgroundImage = codwarzonelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void marvelrivals_Click(object sender, EventArgs e)
        {
            if (marvelrivals.Checked)
            {
                Main.instance.label16.Text = "Marvel Rivals";

                Main.instance.changedpanel.BackgroundImage = marvelrivalslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void spotify_Click(object sender, EventArgs e)
        {
            if (spotify.Checked)
            {
                Main.instance.label16.Text = "Spotify";

                Main.instance.changedpanel.BackgroundImage = spotifylogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void ageofempires4_Click(object sender, EventArgs e)
        {
            if (ageofempires4.Checked)
            {
                Main.instance.label16.Text = "Age of Empires 4";

                Main.instance.changedpanel.BackgroundImage = age4logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void companyofheros2_Click(object sender, EventArgs e)
        {
            if (companyofheroes2.Checked)
            {
                Main.instance.label16.Text = "Company of Heroes 2";

                Main.instance.changedpanel.BackgroundImage = coh2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void companyofheroes3_Click(object sender, EventArgs e)
        {
            if (companyofheroes3.Checked)
            {
                Main.instance.label16.Text = "Company of Heroes 3";

                Main.instance.changedpanel.BackgroundImage = coh3logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void darkdanddarker_Click(object sender, EventArgs e)
        {
            if (darkdanddarker.Checked)
            {
                Main.instance.label16.Text = "Dark and Darker";

                Main.instance.changedpanel.BackgroundImage = darkanddarkerlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void destiny2_Click(object sender, EventArgs e)
        {
            if (destiny2.Checked)
            {
                Main.instance.label16.Text = "Destiny 2";

                Main.instance.changedpanel.BackgroundImage = destiny2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void helldiver2_Click(object sender, EventArgs e)
        {
            if (helldivers2.Checked)
            {
                Main.instance.label16.Text = "Helldivers 2";

                Main.instance.changedpanel.BackgroundImage = helldiver2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void lostark_Click(object sender, EventArgs e)
        {
            if (lostark.Checked)
            {
                Main.instance.label16.Text = "Lost Ark";

                Main.instance.changedpanel.BackgroundImage = lostarklogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void steeldivision2_Click(object sender, EventArgs e)
        {
            if (steeldivision2.Checked)
            {
                Main.instance.label16.Text = "Steel Division 2";

                Main.instance.changedpanel.BackgroundImage = steeldivision2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void lordoftheringsonline_Click(object sender, EventArgs e)
        {
            if (lordoftheringsonline.Checked)
            {
                Main.instance.label16.Text = "Lord of The Rings Online";

                Main.instance.changedpanel.BackgroundImage = lotronlinelogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void throneandliberty_Click(object sender, EventArgs e)
        {
            if (throneandliberty.Checked)
            {
                Main.instance.label16.Text = "Throne and Liberty";

                Main.instance.changedpanel.BackgroundImage = throneandlibertylogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void threekingdoms_Click(object sender, EventArgs e)
        {
            if (threekingdoms.Checked)
            {
                Main.instance.label16.Text = "Three Kingdoms";

                Main.instance.changedpanel.BackgroundImage = threekingdomlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void warhammer3_Click(object sender, EventArgs e)
        {
            if (warhammer3.Checked)
            {
                Main.instance.label16.Text = "Warhammer 3";

                Main.instance.changedpanel.BackgroundImage = warhammer3logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void vrchat_Click(object sender, EventArgs e)
        {
            if (vrchat.Checked)
            {
                Main.instance.label16.Text = "VR Chat";

                Main.instance.changedpanel.BackgroundImage = vrchatlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));

                gameslibrarysound();
            }
        }

        private void efootball_Click(object sender, EventArgs e)
        {
            if (efootball.Checked)
            {
                Main.instance.label16.Text = "eFootball";

                Main.instance.changedpanel.BackgroundImage = efootballlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (amongus.Checked)
            {
                Main.instance.label16.Text = "Among us";

                Main.instance.changedpanel.BackgroundImage = amonguslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void deadbydaylight2_Click(object sender, EventArgs e)
        {
            if (deadbydaylight2.Checked)
            {
                Main.instance.label16.Text = "Dead by Daylight 2";

                Main.instance.changedpanel.BackgroundImage = deadbydaylight2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void deadlock_Click(object sender, EventArgs e)
        {
            if (deadlock.Checked)
            {
                Main.instance.label16.Text = "Deadlock";

                Main.instance.changedpanel.BackgroundImage = deadlocklogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void insurgencysandstorm_Click(object sender, EventArgs e)
        {
            if (insurgencysandstorm.Checked)
            {
                Main.instance.label16.Text = "Insurgency Sandstorm";

                Main.instance.changedpanel.BackgroundImage = insurgencysandstormlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void warthunder_Click(object sender, EventArgs e)
        {
            if (warthunder.Checked)
            {
                Main.instance.label16.Text = "War Thunder";

                Main.instance.changedpanel.BackgroundImage = warthunderlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void paladins_Click(object sender, EventArgs e)
        {
            if (paladins.Checked)
            {
                Main.instance.label16.Text = "Paladins";

                Main.instance.changedpanel.BackgroundImage = paladinslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void readyornot_Click(object sender, EventArgs e)
        {
            if (readyornot.Checked)
            {
                Main.instance.label16.Text = "Ready or Not";

                Main.instance.changedpanel.BackgroundImage = readyornotlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void mythofempires_Click(object sender, EventArgs e)
        {
            if (mythofempires.Checked)
            {
                Main.instance.label16.Text = "Myth of Empires";

                Main.instance.changedpanel.BackgroundImage = mythofempireslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void predecessor_Click(object sender, EventArgs e)
        {
            if (predecessor.Checked)
            {
                Main.instance.label16.Text = "Predecessor";

                Main.instance.changedpanel.BackgroundImage = predecessorlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void unturned_Click(object sender, EventArgs e)
        {
            if (unturned.Checked)
            {
                Main.instance.label16.Text = "Unturned";

                Main.instance.changedpanel.BackgroundImage = unturnedlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void rust_Click(object sender, EventArgs e)
        {
            if (rust.Checked)
            {
                Main.instance.label16.Text = "Rust";

                Main.instance.changedpanel.BackgroundImage = rustlogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void truckersmp_Click(object sender, EventArgs e)
        {
            if (truckersmp.Checked)
            {
                Main.instance.label16.Text = "Truckers MP";

                Main.instance.changedpanel.BackgroundImage = truckersmplogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void hellletloose_Click(object sender, EventArgs e)
        {
            if (hellletloose.Checked)
            {
                Main.instance.label16.Text = "Hell Let Loose";

                Main.instance.changedpanel.BackgroundImage = hellletlooselogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void pathofexile2_Click(object sender, EventArgs e)
        {
            if (pathofexile2.Checked)
            {
                Main.instance.label16.Text = "Path of Exile 2";

                Main.instance.changedpanel.BackgroundImage = pathofexile2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void stateofdecay2_Click(object sender, EventArgs e)
        {
            if (stateofdecay2.Checked)
            {
                Main.instance.label16.Text = "State of Decay 2";

                Main.instance.changedpanel.BackgroundImage = stateofdecay2logo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void phasmophobia_Click(object sender, EventArgs e)
        {
            if (phasmophobia.Checked)
            {
                Main.instance.label16.Text = "Phasmophobia";

                Main.instance.changedpanel.BackgroundImage = phasmophobialogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }

        private void fallguys_Click(object sender, EventArgs e)
        {
            if (fallguys.Checked)
            {
                Main.instance.label16.Text = "Fall Guys";

                Main.instance.changedpanel.BackgroundImage = fallguyslogo;

                Invoke(new MethodInvoker(delegate
                {
                    Main.instance.guna2Panel1.FillColor = Color.Transparent;
                    Main.instance.searchgame.Visible = false;
                    Main.instance.mainpanel.Visible = true;
                    setting.Visible = false;
                    about.Visible = false;
                    this.Hide();
                    Main.instance.guna2Button3.Checked = true;
                }));
                gameslibrarysound();
            }
        }
    }
}
