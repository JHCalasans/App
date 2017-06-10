using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _QPedido.MarkupExtension
{
    [ContentProperty("ImgId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ImgId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ImgId))
                return null;
            return ImageSource.FromResource(ImgId);
        }
    }
}
