using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace SPT_Alt_Launcher
{
    public partial class CreateProfileForm : Form
    {
        List<string> editions;
        string baseProfileText = "{\"info\":{\"id\":\"\",\"scavId\":\"\",\"aid\":0,\"username\":\"\",\"password\":\"\",\"wipe\":true,\"edition\":\"\"},\"characters\":{\"pmc\":{},\"scav\":{}},\"vitality\":{\"health\":{\"Hydration\":0,\"Energy\":0,\"Temperature\":0,\"Head\":0,\"Chest\":0,\"Stomach\":0,\"LeftArm\":0,\"RightArm\":0,\"LeftLeg\":0,\"RightLeg\":0},\"effects\":{\"Head\":{},\"Chest\":{},\"Stomach\":{},\"LeftArm\":{},\"RightArm\":{},\"LeftLeg\":{},\"RightLeg\":{}}},\"inraid\":{\"location\":\"none\",\"character\":\"none\"},\"insurance\":[]}";

        public CreateProfileForm(Point location)
        {
            this.StartPosition = FormStartPosition.Manual;
            location.X += 250;
            location.Y += 5;
            this.Location = location;
            
            try
            {   
                //search in the editions json file all the possibles editions 
                using (StreamReader r = new StreamReader( Globals.gameFolder + "/SPT_Data/Server/database/templates/profiles.json" ))
                {
                    editions = JObject.Parse(r.ReadToEnd()).Properties().Select(p => p.Name).ToList(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error when loading default profiles : " + ex.Message);
            }

            InitializeComponent();
        }

        private void CreateProfileForm_Load(object sender, EventArgs e)
        {
            editions.ForEach(edition => { editionListBox.Items.Add(edition); });
            editionListBox.SelectedIndex = 0;

        }

        private void profileCreateButton_Click(object sender, EventArgs e)
        {

            string id = GenerateRandomID();
            JObject profileDATA = JObject.Parse( baseProfileText );

            profileDATA["info"]["aid"] = new Random().Next(1111111,9999999);
            profileDATA["info"]["id"] = id;
            profileDATA["info"]["scavId"] = GenerateRandomID();
            profileDATA["info"]["username"] = usernameTextBox.Text;
            profileDATA["info"]["edition"] = editionListBox.SelectedItem.ToString();

            try
            {
                using StreamWriter file = File.CreateText( Path.Combine(Globals.profilesFolder, id + ".json") );
                JsonSerializer serializer = new()
                {
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(file, profileDATA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Dispose();
            Application.Restart();
        }

        private void CreateProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
        }

        private string GenerateRandomID()
        {
            string res = "";
            Random R = new Random();
            for (int i = 0; i < 24;i++)
            {
                res += R.Next(0, 16).ToString("X").ToLower();
            }
            return res;
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }



    internal class Editions
    { 
        public Dictionary<string,object> Name { get; set; }


    }



}
