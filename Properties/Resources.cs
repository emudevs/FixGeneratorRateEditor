using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication2.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (WindowsFormsApplication2.Properties.Resources.resourceMan == null)
          WindowsFormsApplication2.Properties.Resources.resourceMan = new ResourceManager("WindowsFormsApplication2.Properties.Resources", typeof (WindowsFormsApplication2.Properties.Resources).Assembly);
        return WindowsFormsApplication2.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return WindowsFormsApplication2.Properties.Resources.resourceCulture;
      }
      set
      {
        WindowsFormsApplication2.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
