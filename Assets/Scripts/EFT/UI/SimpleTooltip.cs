using System;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200255B RID: 9563
	public class SimpleTooltip : Tooltip
	{

		// Token: 0x0400BF2F RID: 48943
		private readonly Vector2 vector2_1 = new Vector2(10f, 10f);

		// Token: 0x0400BF30 RID: 48944
		[FormerlySerializedAs("_text")]
		[SerializeField]
		private CustomTextMeshProUGUI _label;

		// Token: 0x0400BF31 RID: 48945
		private LayoutElement layoutElement_0;

		// Token: 0x0400BF32 RID: 48946
		private float float_0;
	}
}
