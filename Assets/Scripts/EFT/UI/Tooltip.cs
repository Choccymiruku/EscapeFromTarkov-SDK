using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020025E2 RID: 9698
	public class Tooltip : UIElement
	{
		// Token: 0x0400C1A4 RID: 49572
		[SerializeField]
		private RectTransform _mainTransform;

		// Token: 0x0400C1A5 RID: 49573
		[SerializeField]
		private RectTransform _boundsTransform;

		// Token: 0x0400C1A6 RID: 49574
		private Coroutine coroutine_0;

		// Token: 0x0400C1A7 RID: 49575
		private Vector2 vector2_0;

		// Token: 0x0400C1A8 RID: 49576
		[CompilerGenerated]
		private bool bool_0;
	}
}
