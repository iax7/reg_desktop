using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Media;

namespace Registration
{
    public partial class Form1 : Form
    {
        string url = Properties.Settings.Default.url;
        string user = Properties.Settings.Default.api_user;
        string password = Properties.Settings.Default.api_pass;
        Color Error   { get { return Color.FromArgb(139, 24, 32); } } // #881820
        Color Ok      { get { return ColorTranslator.FromHtml("#18bc9c"); } }
        Color Default { get { return SystemColors.Control; } }

        Color Friday   { get { return ColorTranslator.FromHtml("#5cb85c"); } }
        Color Saturday { get { return ColorTranslator.FromHtml("#5bc0de"); } }
        Color Sunday   { get { return ColorTranslator.FromHtml("#f0ad4e"); } }
        Color Monday   { get { return ColorTranslator.FromHtml("#d9534f"); } }
        Uri   BaseUrl  { get { return new Uri(url); } }
        Uri   Action   { get; set; }

        protected Logger Log;

        public Form1()
        {
            InitializeComponent();
            Log              = new Logger(this.GetType());
            FormLog.RegisterAsListener();            
            lblTitle.Text    = string.Empty;
            lblMsg.Text      = string.Empty;
            lblLastRead.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.Info("Loaded");
        }

        private void ErrorMesssage(string errorMessage)
        {
            Action act = () =>
            {
                lblMsg.Visible   = true;
                lblMsg.Text      = errorMessage;
                lblMsg.ForeColor = Color.White;
            };
            lblMsg.Invoke(act);

            Action act2 = () =>
            {
                pnlView.BackColor = Error;
            };
            pnlView.Invoke(act2);
        }

        private void DisableGUI()
        {
            imgSpinner.Visible = true;
            txtId.Enabled      = false;
            btnSend.Enabled    = false;
        }

        private void EnableGUI()
        {
            imgSpinner.Visible = false;
            txtId.Enabled      = true;
            btnSend.Enabled    = true;
            txtId.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Get Id
            string id = txtId.Text;
            if (id == string.Empty)
            {
                txtId.Focus();
                return;
            }

            txtId.Text = string.Empty;
            lblLastRead.Text = $"Id Leído: {id}";

            //Removes prevControl
            CleanPnlView();

            Uri selectedAction = (Uri)btnSend.Tag;
            Uri finalUrl = new Uri(selectedAction, id);

            string response;
            bool useThreads = true;
            if (useThreads)
            {
                DisableGUI();
                Task<string> task = Task.Factory.StartNew<string>(() => GetResponse(finalUrl));
                while (!task.IsCompleted)
                {
                    Application.DoEvents();
                }
                EnableGUI();
                response = task.Result;
            }
            else
                response = GetResponse(finalUrl);

            if (response == "error")
            {
                //string err = "Error, API no regresó ningun dato.";
                //Log.Error(err);
                //ErrorMesssage(err);
                return;
            }

            if (finalUrl.OriginalString.Contains("assist"))
            {
                Person data = null;

                pnlView.BackColor = Ok;
                data = JsonConvert.DeserializeObject<Person>(response);

                var reg                     = new RegistrationData();
                reg.Location                = new Point(0, 0);
                reg.Size                    = pnlView.Size;
                reg.Dock                    = DockStyle.Fill;
                reg.Width                   = pnlView.Width;
                reg.pnlTop.ForeColor        = Color.White;
                reg.pnlAllocation.ForeColor = Color.White;
                reg.pnlPay.ForeColor        = Color.White;
                //name
                reg.lblName.Text         = $"{data.name} {data.lastname}";
                reg.lblSubTitle.Text     = $"{data.church}, {data.city}";
                reg.grdGuests.DataSource = data.guests;
                //food
                List<Food> f = new List<Food>();
                data.food.created_at = "Adultos";
                f.Add(data.food);
                f.Add(new Food
                {
                    created_at = "Niños",
                    v3 = data.food.v3c,
                    s1 = data.food.s1c,
                    s2 = data.food.s2c,
                    s3 = data.food.s3c,
                    d1 = data.food.d1c,
                    d2 = data.food.d2c,
                    d3 = data.food.d3c,
                    l1 = data.food.l1c
                });
                reg.grdFood.DataSource = f;
                //allocation
                reg.pnlAllocation.Visible = data.allocation.option == 1;
                reg.lblN1.Text      = $"Adultos: {data.allocation.n1}";
                reg.lblN2.Text      = $"Niños: {data.allocation.n2}";
                reg.lblN3.Text      = $"Infantes: {data.allocation.n3}";
                //Pay
                var remaining       = data.total - data.amount_paid;
                reg.lblPay1.Text    = $"Gran Total: {data.total:C}";
                reg.lblPay2.Text    = $"Cantidad Pagada: {data.amount_paid:C}";
                reg.lblPay3.Text    = $"Total a Pagar {remaining:C}";
                reg.lblPay3.Visible = remaining > 0;

                pnlView.Controls.Add(reg);
            }
            else //FOOOOOOOOOOD --------------------------------
            {
                dynamic data = null;

                pnlView.BackColor = Ok;
                data = JsonConvert.DeserializeObject(response);

                var foodCtrl          = new FoodData();
                foodCtrl.Location     = new Point(0, 0);
                foodCtrl.Size         = pnlView.Size;
                foodCtrl.Dock         = DockStyle.Fill;
                foodCtrl.Width        = pnlView.Width;
                foodCtrl.ForeColor    = Color.White;
                foodCtrl.lblName.Text = "Comprados:";
                foodCtrl.lblTipo.Text = string.Empty;

                string name         = data["name"].ToString();
                string bought       = data["bought"].ToString();
                string bought_child = data["bought_child"].ToString();
                string used         = data["used"].ToString();
                string used_child   = data["used_child"].ToString();
                string available    = data["available"].ToString();
                string type         = data["foodtype"].ToString();
                string numin        = data["count_real"].ToString();
                string max          = data["max_people_time"].ToString();
                string status       = data["status"].ToString();

                foodCtrl.lblTotal.Text    = $"{bought}/{bought_child}";
                foodCtrl.lblConsumed.Text = $"{used}/{used_child}";
                foodCtrl.lblNumIn.Text    = $"{numin}/{max}";
                foodCtrl.lblNickname.Text = name;

                if (type == "Niño")
                    foodCtrl.lblTipo.Text = "   (Niño)";

                if (status == string.Empty)
                {
                    int pIn = Int32.Parse(numin);
                    int pMax = Int32.Parse(max);
                    if (pIn >= pMax && pIn < pMax + 10)
                    {
                        //Make Sound Alert
                        var sound = Registration.Properties.Resources.glass;
                        SoundPlayer simpleSound = new SoundPlayer(sound);
                        simpleSound.Play();

                        foodCtrl.imgWarning.Visible = true;
                    }
                    else
                    {
                        foodCtrl.imgWarning.Visible = false;
                    }
                }
                else
                {
                    pnlView.BackColor = Error;
                    foodCtrl.lblError.Text = status;
                    foodCtrl.lblName.Text = "Solicitados:";
                }

                pnlView.Controls.Add(foodCtrl);
            }
        }

        private string GetResponse(Uri uri, string restMethod = "PUT")
        {
            string method;
            if (restMethod == null || restMethod == string.Empty)
                method = "PUT";
            else
                method = restMethod;

            try
            {
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.Credentials = new NetworkCredential(user, password);
                request.Method = method;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    //if (response.StatusCode != HttpStatusCode.OK)
                    //    throw new Exception($"Server error (HTTP {response.StatusCode}: {response.StatusDescription}).");

                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    return reader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                if (e.Message.Contains("The remote name could not be resolved"))
                {
                    MessageBox.Show(e.Message);
                    return "error";
                }

                using (WebResponse response = e.Response)
                {
                    string result = string.Empty;
                    try
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        result = reader.ReadToEnd();
                    }
                    catch
                    {
                        result = e.Message;
                    }

                    ErrorMesssage($"Error: {result}");
                    return "error";
                }
            }
        }

        private void CleanPnlView()
        {
            var ctrl = from ctl in pnlView.Controls.OfType<RegistrationData>()
                       select ctl;
            ctrl.ToList().ForEach(c => pnlView.Controls.Remove(c));
           
            var ctrl2 = from ctl in pnlView.Controls.OfType<FoodData>()
                       select ctl;
            ctrl2.ToList().ForEach(c => pnlView.Controls.Remove(c));

            lblMsg.Visible     = false;
            imgSpinner.Visible = false;
            pnlView.BackColor  = Default;
            txtId.Focus();
        }

        #region MenuOptions
        private void commonMenuActions()
        {
            pnlBottom.Enabled = true;
            CleanPnlView();
        }

        private void registroAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            pnlTop.BackColor = Color.White;
            lblTitle.Text    = "Registro";
            btnSend.Tag      = new Uri(this.BaseUrl, "assist/");
            commonMenuActions();
        }

        private void desayunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Friday;
            lblTitle.Text    = "Desayuno Viernes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Friday1 );
            commonMenuActions();
        }

        private void comidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Friday;
            lblTitle.Text    = "Comida Viernes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Friday2);
            commonMenuActions();
        }

        private void cenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Friday;
            lblTitle.Text    = "Cena Viernes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Friday3);
            commonMenuActions();
        }

        private void desayunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Saturday;
            lblTitle.Text    = "Desayuno Sábado";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Saturday1);
            commonMenuActions();
        }

        private void comidaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Saturday;
            lblTitle.Text    = "Comida Sábado";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Saturday2);
            commonMenuActions();
        }

        private void cenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Saturday;
            lblTitle.Text    = "Cena Sábado";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Saturday3);
            commonMenuActions();
        }

        private void desayunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Sunday;
            lblTitle.Text    = "Desayuno Domingo";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Sunday1);
            commonMenuActions();
        }

        private void comidaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Sunday;
            lblTitle.Text    = "Comida Domingo";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Sunday2);
            commonMenuActions();
        }

        private void cenaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Sunday;
            lblTitle.Text    = "Cena Domingo";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Sunday3);
            commonMenuActions();
        }

        private void desayunoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Monday;
            lblTitle.Text    = "Desayuno Lunes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Monday1);
            commonMenuActions();
        }

        private void comidaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Monday;
            lblTitle.Text    = "Comida Lunes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Monday2);
            commonMenuActions();
        }

        private void cenaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Monday;
            lblTitle.Text    = "Cena Lunes";
            btnSend.Tag      = new Uri(this.BaseUrl, FoodTime.Monday3);
            commonMenuActions();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormNext(FormLog.Default, false);
            FormLog.Default.Show();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Color.White;
            lblTitle.Text = "Ping";
            Uri url = new Uri(this.BaseUrl, "ping");
            CleanPnlView();

            string response = ApiCall(url);
            MessageBox.Show($"{url}\nResponse: {response}");
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = Properties.Settings.Default.url;
            MessageBox.Show(url);
        }

        private void authToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTop.BackColor = Color.White;
            lblTitle.Text = "Auth";
            Uri url = new Uri(this.BaseUrl, "auth");
            CleanPnlView();

            string response = ApiCall(url);
            MessageBox.Show($"{url}\nResponse: {response}");
        }

        private string ApiCall(Uri url)
        {
            //string response = GetResponse(url, "GET");
            DisableGUI();
            Task<string> task = Task.Factory.StartNew<string>(() => GetResponse(url, "GET"));
            while (!task.IsCompleted)
            {
                Application.DoEvents();
            }
            EnableGUI();
            string response = task.Result;
            return response;
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
