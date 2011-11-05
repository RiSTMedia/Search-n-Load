Public NotInheritable Class converter
    Implements IValueConverter

    Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        Dim source As Uri = New Uri(DirectCast(value, Google.GData.Extensions.ExtensionCollection(Of Google.GData.Extensions.MediaRss.MediaThumbnail))(0).Url)
        Return New BitmapImage(source)

    End Function

    Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        Throw New NotImplementedException
    End Function
End Class
