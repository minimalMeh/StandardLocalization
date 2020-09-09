using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FastNotes.Resources
{
    /// <summary>
    /// Allow access to package resources according with current UI culture.
    /// </summary>
    public class ResourceProvider
    {
        /// <summary>
        /// Resource file name.
        /// </summary>
        private string resourceFileName;

        private ResourceManager resourceManager;

        public ResourceProvider(string resourceFileName)
        {
            this.resourceFileName = resourceFileName;
        }

        private ResourceManager ResourceManager
        {
            get
            {
                if (this.resourceManager == null)
                {
                    this.resourceManager = new ResourceManager(resourceFileName, typeof(ResourceProvider).Assembly);
                }

                return this.resourceManager;
            }
        }

        public CultureInfo SelectedCulture { get; set; }

        public string GetString(string key)
        {
            return resourceManager.GetString(key);
        }
    }
}
