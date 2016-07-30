using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGo_JSON_Editor
{

    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "JSON files|*.json";
            theDialog.InitialDirectory = Path.GetFullPath(Environment.CurrentDirectory);
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (theDialog.FileName.Trim() != string.Empty)
                    {
                        using (StreamReader r = new StreamReader(theDialog.FileName))
                        {
                            string json = r.ReadToEnd();
                            Userinfo items = JsonConvert.DeserializeObject<Userinfo>(json);
                            Auth_service.Items.Add(items.auth_service);
                            Username.Text = items.username;
                            Password.Text = items.password;
                            Location.Text = items.location;
                            Gmaps_key.Text = items.gmapkey;
                            Max_steps.Text = items.max_steps.ToString();
                            Mode.Text = items.mode;
                            Walk_speed.Text = items.walk;
                            if (items.debug == true)
                            {
                                Debug.SelectedIndex = 0;
                            }
                            else
                            {
                                Debug.SelectedIndex = 1;
                            }
                            if (items.test == true)
                            {
                                Test.SelectedIndex = 0;
                            }
                            else
                            {
                                Test.SelectedIndex = 1;
                            }
                            Initial_transfer.Text = items.initial_transfer.ToString();
                            if (items.location_cache == true)
                            {
                                Location_cache.SelectedIndex = 0;
                            }
                            else
                            {
                                Location_cache.SelectedIndex = 1;
                            }
                            Distance_unit.Items.Add(items.distance_unit);


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userinfo userinf = new Userinfo();
            List<Userinfo> _userinf = new List<Userinfo>();

            _userinf.Add(new Userinfo()
            {
                auth_service = "google",
                username = "" + Username.Text + "",
                password = "" + Password.Text + "",
                location = "" + Location.Text + "",
                gmapkey = "" + Gmaps_key.Text + "",
                max_steps = Int32.Parse(Max_steps.Text),
                mode = "" + Mode.Text + "",
                walk = Walk_speed.Text,
                debug = false,
                test = false,
                initial_transfer = Int32.Parse(Initial_transfer.Text),
                location_cache = true,
                distance_unit = "km",
                item_filter = "101,102,103,104",
                evolve_all = "NONE"

            });

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Path.GetFullPath(Environment.CurrentDirectory);
            saveFileDialog1.Filter = "JSON Image|*.json";
            saveFileDialog1.Title = "Save a JSON File";

            string json = JsonConvert.SerializeObject(_userinf.ToArray(), Formatting.Indented);
            if (json.Length > 2)
            {
                json = json.Substring(1, json.Length - 2);
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, json);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
