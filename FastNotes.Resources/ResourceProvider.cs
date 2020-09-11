
using System.Globalization;
using System.Resources;
using System.Threading;

namespace FastNotes.Resources 
{

	public class InterfaceResources
	{
		private static ResourceManager resourceManager;

		private static CultureInfo resourceCulture;

		internal InterfaceResources()
		{
		}

		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceManager, null))
				{
					ResourceManager temp = new ResourceManager("FastNotes.Resources.Resources.Interface.Interface", typeof(InterfaceResources).Assembly);
					resourceManager = temp;
				}
				return resourceManager;
			}
		}

		public static CultureInfo Culture
		{
			get
			{
				if (resourceCulture == null)
				{
					resourceCulture = Thread.CurrentThread.CurrentCulture;
				}
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		public static string Label_Language_Eng
		{
			get
			{
				return ResourceManager.GetString("Label_Language_Eng", Culture);
			}
		}
		public static string Label_Language_Rus
		{
			get
			{
				return ResourceManager.GetString("Label_Language_Rus", Culture);
			}
		}
		public static string Label_Language_Ukr
		{
			get
			{
				return ResourceManager.GetString("Label_Language_Ukr", Culture);
			}
		}
	}
}