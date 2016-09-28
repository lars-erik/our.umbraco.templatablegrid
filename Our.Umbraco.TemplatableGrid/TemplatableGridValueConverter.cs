using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.PropertyEditors.ValueConverters;

namespace Our.Umbraco.TemplatableGrid
{
    /// <summary>
    /// This ensures that the grid config is merged in with the front-end value
    /// </summary>
    [PropertyValueType(typeof(JToken))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class TemplatableGridValueConverter : GridValueConverter
    {
        public override bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.PropertyEditorAlias.InvariantEquals(TemplatableGridPropertyEditor.TemplatableGridAlias);
        }
    }
}
