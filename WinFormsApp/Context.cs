using System.Windows.Forms;

namespace WinFormsApp;

class Context : ApplicationContext
{
    public Context()
    {
        var model = new Model();
        var controller = new Controller(model);

        var mainView = new MainForm(model);
        mainView.FormClosed += this.Form_FormClosed;
        mainView.ValueChanged += controller.ValueChanged;
        controller.AddView(mainView);
        mainView.Show();

        model.Value = 42;
    }

    void Form_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (Application.OpenForms.Count == 0)
            this.ExitThread();
    }
}