using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public enum ImageSearchConfigStatus
    {
        [Description("on")]
        On,
        
        [Description("off")]
        Off
    }

    public class ImageSearchConfigStatusWrapper : IImageSearchConfigStatus
    {
        public string JsonName { get; internal set; }
        public ImageSearchConfigStatus? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IImageSearchConfigStatus), "FindEnum")]
    public interface IImageSearchConfigStatus : IJsonName
    {
         public static IImageSearchConfigStatus On = new ImageSearchConfigStatusWrapper
             {Value = ImageSearchConfigStatus.On, JsonName = "on"}; 
         
         public static IImageSearchConfigStatus Off = new ImageSearchConfigStatusWrapper
             {Value = ImageSearchConfigStatus.Off, JsonName = "off"}; 

         ImageSearchConfigStatus? Value { get; }
        
         static IImageSearchConfigStatus[] Values()
         {
             return new[]
             {
                 On ,
                 Off 
             };
         }
         static IImageSearchConfigStatus FindEnum(string value)
         {
             return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ImageSearchConfigStatusWrapper() {JsonName = value};
         }
    }
}
