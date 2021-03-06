﻿namespace NConfig.ValueProviders
{
    /// <summary>
    /// Represents an object that can provide a parameter's value.
    /// <remarks>
    /// For now, implemented by <see cref="TranslateFromStringValueProvider"/> and provides an extension point to enable providing values in different ways.
    /// </remarks>
    /// </summary>
    /// Also used as an extension point for providing values in different ways.
    /// </remarks>
    /// </summary>
    public interface IValueProvider : IHaveFilterConditions
    {
        /// <summary>
        /// Returns a configuration value.
        /// </summary>
        /// <returns>object</returns>
        object Get();
    }
}