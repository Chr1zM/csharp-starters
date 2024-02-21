using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp;

partial class MainForm : Form
{
    readonly Model model;

    public MainForm(Model model)
    {
        ArgumentNullException.ThrowIfNull(model);
        this.model = model;
        this.model.DataChanged += this.Model_DataChanged;
        this.InitializeComponent();
    }

    public event EventHandler<ValueEventArgs> ValueChanged;

    void Model_DataChanged(object sender, EventArgs e)
    {
        this.NumericUpDown.Value = this.model.Value;
        this.Label.Text = this.model.Value.ToString(CultureInfo.CurrentCulture);
    }

    void NumericUpDown_ValueChanged(object sender, EventArgs e) => this.ValueChanged?.Invoke(this, new ValueEventArgs((int)this.NumericUpDown.Value));

    void RandomButton_Click(object sender, EventArgs e) => this.ValueChanged?.Invoke(this, new ValueEventArgs(new Random().Next(1000)));
}