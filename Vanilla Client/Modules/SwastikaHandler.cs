using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Vanilla.Wrappers;
using VRC.SDKBase;

namespace Vanilla.Modules
{
    internal class SwastikaHandler : VanillaModule
    {
        protected override string ModuleName => "SwastikaHandler";
        internal override void Update()
        {
            if (sovasticabool == true)
            {
                sovastica();
            }

        }
        public static bool sovasticabool;
        internal static VRC_Pickup[] array;
        internal static Vector3 Rotation;
        internal static Vector3 vec3poz;

        // Swatica Handler
        public static void sovastica()
        {
            if (!sovasticabool) return;

            int b = 0;
            var a = vec3poz;
            var io = array;

            try
            {

                io[0].transform.position = new Vector3(a.x, a.y, a.z);
                io[1].transform.position = new Vector3(a.x, a.y + 0.5f, a.z);
                io[2].transform.position = new Vector3(a.x, a.y + 1f, a.z);
                io[3].transform.position = new Vector3(a.x, a.y + 1.5f, a.z);
                io[4].transform.position = new Vector3(a.x, a.y + 2f, a.z);
                io[17].transform.position = new Vector3(a.x, a.y + 0.5f, a.z);
                io[18].transform.position = new Vector3(a.x, a.y + 1f, a.z);
                io[19].transform.position = new Vector3(a.x, a.y + 1.5f, a.z);
                io[20].transform.position = new Vector3(a.x, a.y, a.z);
                io[21].transform.position = new Vector3(a.x, a.y + 2.5f, a.z);
                io[22].transform.position = new Vector3(a.x, a.y + 3f, a.z);



                io[5].transform.position = new Vector3(a.x + 0.5f, a.y + 1.5f, a.z);
                io[6].transform.position = new Vector3(a.x + 1f, a.y + 1.5f, a.z);
                io[7].transform.position = new Vector3(a.x - 0.5f, a.y + 1.5f, a.z);
                io[8].transform.position = new Vector3(a.x - 1f, a.y + 1.5f, a.z);
                io[27].transform.position = new Vector3(a.x + 1.5f, a.y + 1.5f, a.z);
                io[28].transform.position = new Vector3(a.x - 1.5f, a.y + 1.5f, a.z);

                io[9].transform.position = new Vector3(a.x + 1.5f, a.y + 1.7f, a.z);
                io[10].transform.position = new Vector3(a.x + 1.5f, a.y + 1.9f, a.z);
                io[23].transform.position = new Vector3(a.x + 1.5f, a.y + 2.1f, a.z);

                io[11].transform.position = new Vector3(a.x - 1.5f, a.y + 1.3f, a.z);
                io[12].transform.position = new Vector3(a.x - 1.5f, a.y + 1.1f, a.z);
                io[24].transform.position = new Vector3(a.x - 1.5f, a.y + 1.3f, a.z);

                io[13].transform.position = new Vector3(a.x - 0.2f, a.y + 3f, a.z);
                io[14].transform.position = new Vector3(a.x - 0.4f, a.y + 3f, a.z);
                io[25].transform.position = new Vector3(a.x - 0.6f, a.y + 3f, a.z);

                io[15].transform.position = new Vector3(a.x + 0.2f, a.y, a.z);
                io[16].transform.position = new Vector3(a.x + 0.4f, a.y, a.z);
                io[26].transform.position = new Vector3(a.x + 0.6f, a.y, a.z);

            }
            catch { }


        }
    }
}
