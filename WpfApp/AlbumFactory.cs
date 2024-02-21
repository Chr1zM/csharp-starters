using System;

namespace WpfApp;

static class AlbumFactory
{
    public static AlbumModel GetAlbum() => new()
    {
        Artist = "Tate McRae",
        Title = "THINK LATER",
        Genre = "Trap-Pop",
        NumberOfTracks = 14,
        ReleaseDate = new DateTime(2023, 12, 8, 0, 0, 0, DateTimeKind.Utc)
    };
}