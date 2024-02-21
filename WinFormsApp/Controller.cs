using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp;

class Controller
{
    readonly List<Form> views = [];

    public Controller(Model model) => this.Model = model ?? throw new ArgumentNullException(nameof(model));

    public Model Model { get; }

    public void AddView(Form view) => this.views.Add(view);

    internal void ValueChanged(object sender, ValueEventArgs e) => this.Model.Value = e.Value;
}