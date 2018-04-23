﻿using Omu.ValueInjecter;
using moduleModel = VirtoCommerce.Platform.Core.Settings;
using webModel = VirtoCommerce.Platform.Web.Model.Settings;

namespace VirtoCommerce.Platform.Web.Converters.Settings
{
    public static class ModuleDescriptorConverter
    {
        public static webModel.ModuleDescriptor ToWebModel(this moduleModel.ModuleDescriptor module)
        {
            var retVal = new webModel.ModuleDescriptor();
            retVal.InjectFrom(module);
            return retVal;
        }

        public static moduleModel.ModuleDescriptor ToModuleModel(this webModel.ModuleDescriptor module)
        {
            var retVal = new moduleModel.ModuleDescriptor();
            retVal.InjectFrom(module);
            return retVal;
        }
    }
}
