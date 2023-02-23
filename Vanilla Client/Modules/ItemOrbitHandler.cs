using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC;
using VRC.SDKBase;
using Object = UnityEngine.Object;

namespace Vanilla.Modules
{
    internal class ItemOrbitHandler
    {
        public static void ItemOrbit(Player player)
        {
            if (!ItemOrbitHandler.ItemOrbitToggle || VRCPlayer.field_Internal_Static_VRCPlayer_0 == null || player == null)
            {
                return;
            }
            if (ItemOrbitHandler.cached == null)
            {
                ItemOrbitHandler.Recache();
            }
            GameObject gameObject = new GameObject();
            Transform transform = gameObject.transform;
            transform.position = ((player != null) ? player.transform.position : VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position) + new Vector3(0f, (float)ItemOrbitHandler.ItemOrbitUpDown, 0f);
            gameObject.transform.Rotate(new Vector3(0f, 360f * Time.time * (float)ItemOrbitHandler.ItemOrbitSpeed, 0f));
            for (int i = 0; i < ItemOrbitHandler.cached.Length; i++)
            {
                VRC_Pickup vrc_Pickup = ItemOrbitHandler.cached[i];
                if (Networking.GetOwner(vrc_Pickup.gameObject) != Networking.LocalPlayer)
                {
                    Networking.SetOwner(Networking.LocalPlayer, vrc_Pickup.gameObject);
                }
                vrc_Pickup.transform.position = gameObject.transform.position + gameObject.transform.forward * (float)ItemOrbitHandler.ItemOrbitSize;
                gameObject.transform.Rotate(new Vector3(0f, (float)(360 / ItemOrbitHandler.cached.Length), 0f));
            }
            Object.Destroy(gameObject);
        }


        public static void Recache()
        {
            ItemOrbitHandler.cached = Object.FindObjectsOfType<VRC_Pickup>();
        }


        public static VRC_Pickup[] cached;


        public static bool ItemOrbitToggle;


        public static int ItemOrbitSpeed = 1;


        public static int ItemOrbitSize = 2;


        public static int ItemOrbitUpDown = 1;
    }
}
