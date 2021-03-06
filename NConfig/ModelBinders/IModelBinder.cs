﻿using System;
using System.Collections.Generic;

namespace NConfig.ModelBinders
{
    /// <summary>
    /// Binds configuration parameters values to a given section instance.
    /// </summary>
    public interface IModelBinder
    {
        /// <summary>
        /// Binds the given parameters values to the given <paramref name="modelType"/>
        /// </summary>
        /// <returns>An instance of the given <paramref name="modelType"/> type, populated with the given <paramref name="parametersInfo"/></returns>
        object Bind(Type modelType, IDictionary<string, object> parametersInfo);
    }
}
