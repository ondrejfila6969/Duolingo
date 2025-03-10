using Duolingo.Languages;

namespace Duolingo.Forms;

public partial class Languages : UserControl
{
    private readonly BaseForm _parentForm;
    private DBDriver _dbDriver;
    
    
    public Languages(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void delete_language_textbox_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void back_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Navigation);
    }

    private void create_button_Click(object sender, EventArgs e)
    {
        if (create_language_textbox.Text != "")
        {
            CreateNewLanguage(create_language_textbox.Text);
            create_language_textbox.Text = "";
        }
        else
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid name";
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
            PopulateListView(languages);
        }
    }
    private void PopulateListView(List<LanguageTemplate> languagesList)
    {
        listView1.Items.Clear();
        foreach (var language in languagesList)
        {
            ListViewItem item = new ListViewItem();
            item.Text = language.Id.ToString();
            item.SubItems.Add(language.Name);
            item.SubItems.Add(language.DateCreated.ToString());
            item.SubItems.Add(language.DateModified.ToString());
            listView1.Items.Add(item);
        }
    }
    
    private void CreateNewLanguage(string name)
    {
        if (_dbDriver is null) return;

        LanguageTemplate newLanguage = new LanguageTemplate()
        {
            Name = name,
        };
        _dbDriver.InsertLanguage(newLanguage);
        LoadLanguages();
    }
    
    private void Login()
    {
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver("");
        }
    }
    
    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void error_label_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    
    private void create_user_textbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (create_language_textbox.Text == "") return;
            
            CreateNewLanguage(create_language_textbox.Text);
            create_language_textbox.Text = "";
        }
    }

    private void create_language_textbox_TextChanged(object sender, EventArgs e)
    {
        
    }
    
    private void DeleteLanguageWithId(string stringId)
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
        _dbDriver.DeleteLanguage(id);
        if (_dbDriver?.ThrownException is not null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            return;
        }
        LoadLanguages();
    }
    
    private void delete_button_Click(object sender, EventArgs e)
    {
        if (delete_language_textbox.Text != "")
        {
            DeleteLanguageWithId(delete_language_textbox.Text);
            delete_language_textbox.Text = "";
            
        }
        else
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid ID";
            delete_language_textbox.Text = "";
        }
    }
    
    private void delete_language_textbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            DeleteLanguageWithId(delete_language_textbox.Text);
            delete_language_textbox.Text = "";
        }
    }

    private void Languages_Load(object sender, EventArgs e)
    {
        Login();
        LoadLanguages();
    }
}