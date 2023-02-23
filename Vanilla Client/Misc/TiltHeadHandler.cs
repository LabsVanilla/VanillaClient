using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Buttons.QM;
using Vanilla.Modules;
using Vanilla.QM.Menu;

namespace Vanilla.Misc
{
    internal class TiltHeadHandler : VanillaModule
    {
        protected override string ModuleName => "TiltHeadHandler";
        public static bool ms_update = false;
        public float m_lockedBodyRotation = 0f;
        public static bool ms_lockBodyRotation = false;
        public static bool _ignoreLimit;

        internal void OnUpdate()
        {
            if (ms_update)
            {

                if (_ignoreLimit == true)
                {
                    float l_angle = UnityEngine.Input.mouseScrollDelta.y;
                    if (l_angle != 0f)
                    {
                        var l_neckRotator = VRCPlayer.field_Internal_Static_VRCPlayer_0?.gameObject?.GetComponent<GamelikeInputController>()?.field_Protected_NeckMouseRotator_0;
                        if (l_neckRotator != null)
                        {
                            var l_quat = l_neckRotator.field_Private_Quaternion_0;
                            var l_vec = l_quat.eulerAngles;
                            l_vec.z += l_angle * 5f;
                            if (!_ignoreLimit)
                            {
                                float l_delta = UnityEngine.Mathf.DeltaAngle(l_vec.z, 0f);
                                if (UnityEngine.Mathf.Abs(l_delta) > 90f)
                                {
                                    l_vec.z += (UnityEngine.Mathf.Abs(l_delta) - 90f) * UnityEngine.Mathf.Sign(l_delta);
                                    l_vec.z = (l_vec.z + 360f) % 360f;
                                }
                            }
                            l_quat.eulerAngles = l_vec;
                            l_neckRotator.field_Private_Quaternion_0 = l_quat;
                        }
                    }
                }

                if (_ignoreLimit)
                {
                    if (!ms_lockBodyRotation)
                    {
                        var l_transform = VRCPlayer.field_Internal_Static_VRCPlayer_0?.prop_VRCAvatarManager_0?.gameObject?.transform;
                        if (l_transform != null)
                        {
                            m_lockedBodyRotation = l_transform.rotation.eulerAngles.y;
                            ms_lockBodyRotation = true;
                        }
                    }
                }
                if (_ignoreLimit == true || !UnityEngine.Application.isFocused)
                {
                    if (ms_lockBodyRotation)
                    {
                        var l_transformPlayer = VRCPlayer.field_Internal_Static_VRCPlayer_0?.gameObject?.transform;
                        var l_transformAvatar = VRCPlayer.field_Internal_Static_VRCPlayer_0?.prop_VRCAvatarManager_0?.gameObject?.transform;
                        if (l_transformAvatar != null && l_transformAvatar != null)
                        {
                            l_transformAvatar.rotation = l_transformPlayer.rotation;
                        }
                        ms_lockBodyRotation = false;
                    }
                }
                if (ms_lockBodyRotation)
                {
                    var l_playerTransform = VRCPlayer.field_Internal_Static_VRCPlayer_0?.gameObject?.transform;
                    var l_animatorTransform = VRCPlayer.field_Internal_Static_VRCPlayer_0?.prop_VRCAvatarManager_0?.gameObject?.transform;
                    if ((l_playerTransform != null) && (l_animatorTransform != null))
                    {
                        if (!_ignoreLimit)
                        {
                            float l_delta = UnityEngine.Mathf.DeltaAngle(m_lockedBodyRotation, l_playerTransform.eulerAngles.y);
                            if (UnityEngine.Mathf.Abs(l_delta) > 90f)
                            {
                                m_lockedBodyRotation += (UnityEngine.Mathf.Abs(l_delta) - 90f) * UnityEngine.Mathf.Sign(l_delta);
                                m_lockedBodyRotation = (m_lockedBodyRotation + 360f) % 360f;
                            }
                        }

                        var l_quat = l_animatorTransform.rotation;
                        var l_vec = l_quat.eulerAngles;
                        l_vec.y = m_lockedBodyRotation;
                        l_quat.eulerAngles = l_vec;
                        l_animatorTransform.rotation = l_quat;
                    }
                }
            }
        }

    }
}
