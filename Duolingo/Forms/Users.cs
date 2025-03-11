namespace Duolingo.Forms;

public partial class Users : UserControl
{
    private readonly BaseForm _parentForm;
    private DBDriver _dbDriver;

    public Users(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
    private void Users_Load(object sender, EventArgs e)
    {
        Login();
        LoadUsers();
    }

    private void navigate_back_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Navigation);
    }
    private void PopulateListView(List<User> users)
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
            PopulateListView(users);
        }
    }

    private void create_user_button_Click(object sender, EventArgs e)
    {
        if (create_user_textbox.Text != "")
        {
            CreateNewUser(create_user_textbox.Text);
            error_label.Text = "";
            create_user_textbox.Text = "";
        }
        else
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid name";
        }
    }
    
    private void Login()
    {
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver("");
        }
    }
    
    
    private void CreateNewUser(string username)
    {
        if (_dbDriver is null) return;

        User newUser = new User()
        {
            Username = username,
        };
        _dbDriver.InsertUser(newUser);
        LoadUsers();
    }

    private void listView1_UserListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        Console.WriteLine($"{e.Item.Text}: {e.Item.SubItems[1].Text}: {e.Item.SubItems[2].Text}");
    }

    private void error_label_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void create_user_textbox_TextChanged(object sender, EventArgs e)
    {
        
    }

    public void delete_user_textbox_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void create_user_textbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (create_user_textbox.Text == "") return;
            
            CreateNewUser(create_user_textbox.Text);
            create_user_textbox.Text = "";
        }
    }
    private void delete_user_textbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            DeleteUserWithId(delete_user_textbox.Text);
            delete_user_textbox.Text = "";
            error_label.Text = "";
        }
    }
    
    private void DeleteUserWithId(string stringId)
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
        _dbDriver.DeteteUser(id);
        error_label.Text = "";
        if (_dbDriver?.ThrownException is not null)
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            return;
        }
        LoadUsers();
    }

    private void delete_user_button_Click(object sender, EventArgs e)
    {
        if (delete_user_textbox.Text != "")
        {
            DeleteUserWithId(delete_user_textbox.Text);
            delete_user_textbox.Text = "";
            
        }
        else
        {
            error_label.ForeColor = Color.Red;
            error_label.Text = "Please enter a valid ID";
            delete_user_textbox.Text = "";
        }
    }
    
}