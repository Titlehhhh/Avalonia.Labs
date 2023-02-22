﻿using System;
using Avalonia.Media;

namespace Avalonia.Labs.Controls
{
    public partial class AsyncImage
    {
        public static readonly StyledProperty<IImage> PlaceholderSourceProperty =
            AvaloniaProperty.Register<AsyncImage, IImage>(nameof(PlaceholderSource));

        public static readonly StyledProperty<Uri> SourceProperty =
            AvaloniaProperty.Register<AsyncImage, Uri>(nameof(Source));

        public static readonly StyledProperty<Stretch> StretchProperty =
            AvaloniaProperty.Register<AsyncImage, Stretch>(nameof(Stretch), Stretch.Uniform);

        public static readonly StyledProperty<Stretch> PlaceholderStretchProperty =
            AvaloniaProperty.Register<AsyncImage, Stretch>(nameof(PlaceholderStretch), Stretch.Uniform);

        public IImage PlaceholderSource
        {
            get => GetValue(PlaceholderSourceProperty);
            set => SetValue(PlaceholderSourceProperty, value);
        }

        public Uri Source
        {
            get => GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public Stretch Stretch
        {
            get { return GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public Stretch PlaceholderStretch
        {
            get { return GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }
    }
}
