using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp;

class AlbumViewModel : INotifyPropertyChanged
{
    readonly AlbumModel model;

    public AlbumViewModel() : this(AlbumFactory.GetAlbum()) { }

    public AlbumViewModel(AlbumModel model) => this.model = model ?? throw new ArgumentNullException(nameof(model));

    public event PropertyChangedEventHandler PropertyChanged;

    public string Artist
    {
        get => this.model.Artist;
        set
        {
            if (this.model.Artist != value)
            {
                this.model.Artist = value;
                this.OnPropertyChanged(nameof(this.Artist));
            }
        }
    }

    public string Genre
    {
        get => this.model.Genre;
        set
        {
            if (this.model.Genre != value)
            {
                this.model.Genre = value;
                this.OnPropertyChanged(this.Genre);
            }
        }
    }

    public int NumberOfTracks
    {
        get => this.model.NumberOfTracks;
        set
        {
            if (this.model.NumberOfTracks != value)
            {
                this.model.NumberOfTracks = value;
                this.OnPropertyChanged(nameof(this.NumberOfTracks));
            }
        }
    }

    public DateTime ReleaseDate
    {
        get => this.model.ReleaseDate;
        set
        {
            if (this.model.ReleaseDate != value)
            {
                this.model.ReleaseDate = value;
                this.OnPropertyChanged(nameof(this.ReleaseDate));
            }
        }
    }

    public string Title
    {
        get => this.model.Title;
        set
        {
            if (this.model.Title != value)
            {
                this.model.Title = value;
                this.OnPropertyChanged(nameof(this.Title));
            }
        }
    }

    public ICommand Update => new AlbumCommand(this.UpdateExecute);

    void OnPropertyChanged(string propertyname) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));

    void UpdateExecute()
    {
        this.NumberOfTracks++;
        this.ReleaseDate = this.ReleaseDate.AddDays(-7);
    }
}