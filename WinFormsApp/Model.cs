using System;

namespace WinFormsApp;

class Model
{
    int value;

    public event EventHandler<EventArgs> DataChanged;

    public int Value
    {
        get => this.value;
        set
        {
            if (this.value != value)
            {
                this.value = value;
                this.DataChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}