using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Wrappers;

namespace Vanilla.Modules
{
    internal class OrbitHandler : VanillaModule
    {
        protected override string ModuleName => "OrbitHandler";
        internal override void Update()
        {
            if (ItemOrbitHandler.ItemOrbitToggle)
            {
                ItemOrbitHandler.ItemOrbit(PlayerWrapper.SelectedUserid());
            }

        }
    }
}
