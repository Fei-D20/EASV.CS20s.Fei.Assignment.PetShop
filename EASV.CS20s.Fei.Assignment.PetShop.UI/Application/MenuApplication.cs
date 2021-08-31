using System;
using EASV.CS20s.Fei.Assignment.PetShop.UIService.IApplication;
using EASV.CS20s.Fei.Assignment.PetShop.UIService.UI;

namespace EASV.CS20s.Fei.Assignment.PetShop.UI.Application
{
    public class MenuApplication : IMenuApplication
    {
        public void show(MainMenu menu)
        {
            foreach (var VARIABLE in menu.MenuConstant)
            {
                Console.WriteLine(VARIABLE);
            }
            
        }

    }
}