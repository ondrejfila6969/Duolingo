using Duolingo.Languages;
using Duolingo.Registration;

namespace Duolingo.Forms;

public partial class Registrations : UserControl
{
    private readonly BaseForm _parentForm;
    private DBDriver _dbDriver;
    
    public Registrations(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void Registrations_Load(object sender, EventArgs e)
    {
        listView1.FullRowSelect = true;
        listView1.MultiSelect = false;

        listView2.FullRowSelect = true;
        listView2.MultiSelect = false;
        
        Login();
        LoadUsers();
        LoadLanguages();
        LoadRegistrations();
    }

    private void back_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Navigation);
    }
    
    private void PopulateListViewUsers(List<User> users)
    {
        listView1.Items.Clear();
        foreach (var user in users)
        {
            ListViewItem item = new ListViewItem();
            item.Text = user.Id.ToString();
            item.SubItems.Add(user.Username);
            item.SubItems.Add(user.DateCreated.ToString());
            item.SubItems.Add(user.DateModified.ToString());
            listView1.Items.Add(item);
        }
    }
    
    private void LoadUsers()
    {
        List<User> users = _dbDriver.GetUsers();
        if (_dbDriver.ThrownException is not null)
        {
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListViewUsers(users);
        }
    }
    
    private void PopulateListViewLanguages(List<LanguageTemplate> languagesList)
    {
        listView2.Items.Clear();
        foreach (var language in languagesList)
        {
            ListViewItem item = new ListViewItem();
            item.Text = language.Id.ToString();
            item.SubItems.Add(language.Name);
            item.SubItems.Add(language.DateCreated.ToString());
            item.SubItems.Add(language.DateModified.ToString());
            listView2.Items.Add(item);
        }
    }
    
    private void LoadLanguages()
    {
        List<LanguageTemplate> languages = _dbDriver.GetLanguages();
        if (_dbDriver.ThrownException is not null)
        {
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListViewLanguages(languages);
        }
    }
    
    private void PopulateListViewRegistrations(List<RegistrationTemplate> registrationsList)
    {
        listView3.Items.Clear();
        foreach (var registration in registrationsList)
        {
            ListViewItem item = new ListViewItem();
            item.Text = registration.Id.ToString();
            item.SubItems.Add(registration.UserId.ToString());
            item.SubItems.Add(registration.LanguageId.ToString());
            listView3.Items.Add(item);
        }
    }
    
    private void LoadRegistrations()
    {
        List<RegistrationTemplate> registrations = _dbDriver.GetRegistrations();
        if (_dbDriver.ThrownException is not null)
        {
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListViewRegistrations(registrations);
        }
    }
    private void Login()
    {
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver("");
        }
    }

    private string selectedUserId = null;
    private string selectedLanguageId = null;
    
    
    private void CreateNewRegistration(int userId, int languageId)
    {
        if (_dbDriver is null) return;

        RegistrationTemplate newRegistration = new RegistrationTemplate()
        {
            UserId = userId,
            LanguageId = languageId
        };
        _dbDriver.InsertRegistration(newRegistration);
        LoadRegistrations();
    }
    
    private void listView1_MouseClick(object sender, MouseEventArgs e)
    {
        ListViewHitTestInfo hit = listView1.HitTest(e.Location);
        if (hit.Item != null) 
        {
            selectedUserId = hit.Item.SubItems[0].Text; 
        }
    }
    
    private void listView2_MouseClick(object sender, MouseEventArgs e)
    {
        ListViewHitTestInfo hit = listView2.HitTest(e.Location);
        if (hit.Item != null)
        {
            selectedLanguageId = hit.Item.SubItems[0].Text;
        }
    }

    private void DeleteRegistrationWithId(string stringId)
    {
        if (_dbDriver is null) return;

        error_label.Text = "";
        int id;
        if (int.TryParse(stringId, out id) is false)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid ID";
            return;
        }
        _dbDriver.DeleteRegistration(id);
        if (_dbDriver?.ThrownException is not null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            return;
        }
        LoadRegistrations();
    }
    
    private void listView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void register_button_Click(object sender, EventArgs e)
    {
        if (selectedUserId != null && selectedLanguageId != null)
        {
            CreateNewRegistration( int.Parse(selectedUserId), int.Parse(selectedLanguageId));
            error_label.Text = "";
            selectedUserId = null;
            selectedLanguageId = null;
        }
        else if(selectedUserId != null && selectedLanguageId == null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please select language_id";
        } 
        else if(selectedUserId == null && selectedLanguageId != null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please select user_id";
        }
        else if(selectedUserId == null && selectedLanguageId == null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please select user_id and language_id";
        }
    }

    private void delete_button_Click(object sender, EventArgs e)
    {
        if (deleteRegistration_textbox.Text != "")
        {
            DeleteRegistrationWithId(deleteRegistration_textbox.Text);
            deleteRegistration_textbox.Text = "";
            
        }
        else
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid ID";
            deleteRegistration_textbox.Text = "";
        }
    }


    private void deleteRegistration_textbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            DeleteRegistrationWithId(deleteRegistration_textbox.Text);
            deleteRegistration_textbox.Text = "";
        }
    }
}