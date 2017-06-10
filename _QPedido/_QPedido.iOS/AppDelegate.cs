using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Prism.Unity;
using Microsoft.Practices.Unity;
using OpenGLES;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace _QPedido.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    // public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    [Register("AppDelegate")]
    public partial class AppDelegate : XFormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            //INICIANDO RESOLVER PARA PEGAR DETALHES DA TELA
            var resolverContainer = new SimpleContainer();
            resolverContainer.Register<IDevice>(t => AppleDevice.CurrentDevice);
            Resolver.SetResolver(resolverContainer.GetResolver());

            App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
            App.ScreenWHeight = (int)UIScreen.MainScreen.Bounds.Height;
            var teste =  (double)UIScreen.MainScreen.Scale;
            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }

    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }

}
