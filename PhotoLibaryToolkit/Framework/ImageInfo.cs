using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace PFP.Imaging
{
    using System.Globalization;
    using System.Linq;

    public class ImageInfo
    {
        Image image;
        public Dictionary<PropertyTagId, 
            KeyValuePair<PropertyTagType, Object>> imageProps = 
            new Dictionary<PropertyTagId,KeyValuePair<PropertyTagType,object>>();
        
        public ImageInfo(Image newImage)
        {
            image = newImage;
            BuildPropsHash();
        }

        public static DateTime? GetTakenDate(string filePath)
        {
            using (var imageAtPath = Image.FromFile(filePath))
            {
                int propertyToRead = 0;
                if (imageAtPath.PropertyIdList.Contains((int)PropertyTagId.ExifDTOrig))
                {
                    propertyToRead = (int)PropertyTagId.ExifDTOrig;
                }
                else if (imageAtPath.PropertyIdList.Contains((int)PropertyTagId.DateTime))
                {
                    propertyToRead = (int)PropertyTagId.DateTime;
                }

                if (propertyToRead <= 0)
                {
                    return null;
                }

                var dateProperty = imageAtPath.GetPropertyItem(propertyToRead);

                ASCIIEncoding encoding = new ASCIIEncoding();
                var propValue = encoding.GetString(
                    dateProperty.Value, 0, dateProperty.Len - 1);

                var takenDate = DateTime.ParseExact(propValue, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                return takenDate;
            }
        }

        private void BuildPropsHash()
        {
            foreach (PropertyItem property in image.PropertyItems)
            {
                Object propValue =  new Object();
                switch ((PropertyTagType)property.Type)
                {
                    case PropertyTagType.ASCII:
                        ASCIIEncoding encoding = new ASCIIEncoding();
                        propValue = encoding.GetString(
                            property.Value, 0, property.Len - 1);
                        break;
                    case PropertyTagType.Int16:
                        propValue = BitConverter.ToInt16(
                            property.Value, 0);
                        break;
                    case PropertyTagType.SLONG:
                    case PropertyTagType.Int32:
                        propValue = BitConverter.ToInt32(
                            property.Value, 0);
                        break;
                    case PropertyTagType.SRational:
                    case PropertyTagType.Rational:
                        UInt32 numberator =
                            BitConverter.ToUInt32(
                            property.Value, 0);
                        UInt32 denominator =
                            BitConverter.ToUInt32(
                            property.Value, 4);
                        try
                        {
                            propValue = ((double)numberator
                                / (double)denominator).ToString();

                            if (propValue.ToString() == "NaN")
                                propValue = "0";
                        }
                        catch (DivideByZeroException)
                        {
                            propValue = "0";
                        }
                        break;
                    case PropertyTagType.Undefined:
                        propValue = "Undefined Data";
                        break;
                }
                imageProps.Add(NumToEnum<PropertyTagId>(property.Id),
                    new KeyValuePair<PropertyTagType,object>(
                        NumToEnum<PropertyTagType>(property.Type),
                        propValue));
            }
        }

        public T NumToEnum<T>(int number)
        {
            return (T)Enum.ToObject(typeof(T), number);
        }
    }
}
