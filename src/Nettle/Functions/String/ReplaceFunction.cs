﻿namespace Nettle.Functions.String
{
    using Nettle.Compiler;

    /// <summary>
    /// Represent a replace function implementation
    /// </summary>
    public sealed class ReplaceFunction : FunctionBase
    {
        /// <summary>
        /// Constructs the function by defining the parameters
        /// </summary>
        public ReplaceFunction() 
            : base()
        {
            DefineRequiredParameter
            (
                "Text",
                "The original text",
                typeof(string)
            );

            DefineRequiredParameter
            (
                "OldValue",
                "The old value",
                typeof(string)
            );

            DefineRequiredParameter
            (
                "NewValue",
                "The new value",
                typeof(string)
            );
        }

        /// <summary>
        /// Gets a description of the function
        /// </summary>
        public override string Description
        {
            get
            {
                return "Replaces text in a string with other text.";
            }
        }

        /// <summary>
        /// Replaces a value in some text with the value specified
        /// </summary>
        /// <param name="context">The template context</param>
        /// <param name="parameterValues">The parameter values</param>
        /// <returns>The updated text</returns>
        protected override object GenerateOutput
            (
                TemplateContext context,
                params object[] parameterValues
            )
        {
            Validate.IsNotNull(context);

            var text = GetParameterValue<string>
            (
                "Text",
                parameterValues
            );

            var oldValue = GetParameterValue<string>
            (
                "OldValue",
                parameterValues
            );

            var newValue = GetParameterValue<string>
            (
                "NewValue",
                parameterValues
            );

            return text.Replace
            (
                oldValue,
                newValue
            );
        }
    }
}
