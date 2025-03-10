namespace Duolingo.Forms;

public partial class Navigation : UserControl
{
    private readonly BaseForm _parentForm;
    public Navigation(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void Navigation_Load(object sender, EventArgs e)
    {
        
    }

    private void users_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Users);
    }

    private void languages_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Language);
    }

    private void registrations_button_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchForm(BaseForm.Forms.Registration);
    }
}