﻿using Umbraco.Core.PropertyEditors;

namespace nuPickers.DataEditors.DotNetCheckBoxPicker
{
    internal class DotNetCheckBoxPickerConfiguration : ValueListConfiguration
    {
        [ConfigurationField("useLabel", "Include labels?", "boolean", Description = "")]
        public bool UseLabel { get; set; }

        [ConfigurationField("dataSource", "Data Source",
            EmbeddedResource.EmbeddedResource.ROOT_URL + "DotNetDataSource/DotNetDataSourceConfig.html", HideLabel =
                true)]
        public object DataSource { get; set; }


        [ConfigurationField("customLabel", "Label Macro",
            EmbeddedResource.EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("checkBoxPicker", "Checkbox Picker",
            EmbeddedResource.EmbeddedResource.ROOT_URL + "CheckBoxPicker/CheckBoxPickerConfig.html", HideLabel = true)]
        public object CheckBoxPicker { get; set; }

        [ConfigurationField("layoutDirection", "Layout Direction",
            EmbeddedResource.EmbeddedResource.ROOT_URL + "LayoutDirection/LayoutDirectionConfig.html")]
        public string LayoutDirection { get; set; }

        [ConfigurationField("saveFormat", "Save Format",
            EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public object SaveFormat { get; set; }
    }
}