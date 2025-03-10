using System.Diagnostics;
using Duolingo.Forms;

namespace Duolingo;

public partial class BaseForm : Form
{
    public DBDriver _dbDriver;
    private Duolingo.Forms.Languages _language;
    private Navigation _navigation;
    private Registrations _registration;
    private Users _users;
    private UserControl _currentView;
    public enum Forms
    {
        Language,
        Navigation,
        Registration,
        Users,
        Login,
    }
    public BaseForm()
    {
        InitializeComponent();
        _language = new Duolingo.Forms.Languages(this);
        _navigation = new Navigation(this);
        _registration = new Registrations(this);
        _users = new Users(this);
        SwitchForm(Forms.Navigation);
    }

    public void SwitchForm(Forms form)
    {
        Controls.Remove(_currentView);
        _currentView = form switch
        {
            Forms.Language => _language,
            Forms.Navigation => _navigation,
            Forms.Registration => _registration,
            Forms.Users => _users,
        };
        Controls.Add(_currentView);
    }
}