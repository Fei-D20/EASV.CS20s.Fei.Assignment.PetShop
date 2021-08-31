using EASV.CS20s.Fei.Assignment.PetShop.UI.Application;
using EASV.CS20s.Fei.Assignment.PetShop.UIService.IApplication;
using EASV.CS20s.Fei.Assignment.PetShop.UIService.UI;


namespace EASV.CS20s.Fei.Assignment.PetShop.UI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            IMenuApplication menuApplication = new MenuApplication();
            menuApplication.show(mainMenu);
        }
    }
}