using CommunityToolkit.Maui.Converters;

var converter = new IsListNotNullOrEmptyConverter();
converter.ConvertFrom(Array.Empty<object>());
